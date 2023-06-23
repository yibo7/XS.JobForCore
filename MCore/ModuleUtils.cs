using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using XS.Core2;
using XS.Core2.FSO;

namespace XS.JobForCore.MCore
{
    public class ModuleUtils
    {

        public static Dictionary<string, IModules> LoadModules()
        {
            Dictionary<string, IModules> dic = new Dictionary<string, IModules>();
            List<IModules> lst = getModuleList();
            foreach (var model in lst)
            {
                dic.Add(model.Title, model);
            }
            return dic;

        }
        private static List<IModules> getModuleList()
        {
            List<Assembly> assModule = new List<Assembly>();
            //try
            //{
            //    FileInfo[] moduleDlls = FObject.GetFileListByType(string.Concat(Application.StartupPath, "\\modules\\"), "dll"); //获取所有Dll
            //    foreach (FileInfo fileInfo in moduleDlls)
            //    {
            //        Assembly asm = Assembly.LoadFrom(fileInfo.FullName);
            //        assModule.Add(asm);
            //    }

            //}
            //catch (Exception ex)
            //{
            //    LogHelper.Error<ModuleUtils>($"扩展模块加载发生异常:【{ex.Message}】");
                
            //}
            List<Assembly> assAll = new List<Assembly>();
            try
            {
                Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
                assAll = assModule.Union(asms).ToList();//Concat保留重复项,Union去重

            }
            catch (Exception ex)
            {
                LogHelper.Error<ModuleUtils>($"默认模块加载发生异常:【{ex.Message}】");
            }

            return LoadInterface<IModules>(assAll);
        }

        private static List<T> LoadInterface<T>(List<Assembly> asms) where T : class
        {
            List<T> lstModules = new List<T>();
            foreach (var asm in asms)
            {
                try
                {
                    var tTypes = asm.GetTypes().Where(t => t.GetInterfaces().Contains(typeof(T))).ToArray();
                    foreach (var type in tTypes)
                    {
                        if (type.IsClass)
                        {
                            try
                            {
                                T md = Activator.CreateInstance(type) as T;
                                if (!Equals(md, null))
                                {
                                    lstModules.Add(md);
                                }
                            }
                            catch (Exception ex)
                            {
                                LogHelper.Error<ModuleUtils>($"模块类型转换发生异常:【{ex.Message}】");
                            }
                        }
                    }
                }
                catch (Exception)
                {
                     
                }
                
            }

            return lstModules;
        }
    }
}
