using System; 
using WeifenLuo.WinFormsUI.Docking;
using XS.JobForCore.MCore;

namespace XS.JobForCore
{
    public partial class ModuleList : DockContent
    {
        private Main _main;
        public ModuleList(Main main)
        {
            InitializeComponent();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            _main = main;
            BindTools();

        }
        private void BindTools()
        {
            ImgListItemBll ilib = new ImgListItemBll(this.lvTools);
            ilib.OnMouseDoubleClick += OnBindToolMouseDoubleClick;
            //获取模块
            var modules = ModuleUtils.LoadModules();
            foreach (var md in modules)
            {                
                DockContent mDockContent = md.Value as DockContent;
                ilib.Add(md.Key, md.Value.Ico, mDockContent);
            }
            ilib.Bind();
        }
        private void OnBindToolMouseDoubleClick(ImgListItem item)
        {
            _main.ShowContent(item.Name, item.DockContentObj);
        }
    }
}
