using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeifenLuo.WinFormsUI.Docking;

namespace XS.JobForCore.MCore
{
    public class XsDockContent: DockContent
    {
        /// <summary>
        /// 修复，打开标签后再关闭会出错实例被释放的BUG
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if(!Equals(this.Parent, null))
                    this.Hide();
            }
            catch (Exception)
            {
               base.Dispose(disposing);
            }
        }
    }
}
