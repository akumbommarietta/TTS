using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace Windows.Main.UserControls
{
    public partial class CommandsUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public EventHandler CommandsViewKeyPressed;
        public EventHandler AddTextFileKeyPressed;
        public EventHandler AddPdfFileKeyPressed;
        public EventHandler OpenTextEditorKeyPressed;

        public CommandsUserControl1()
        {
            InitializeComponent();
        }

        //properties

        public PopupMenu PopUpMenu
        {
            get { return this.popupMenu_Commands; }
        }

        // Events

        private void barButtonItem_controlCommands_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CommandsViewKeyPressed(this, new EventArgs());
        }

        private void barButtonItem_addTextFile_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTextFileKeyPressed += AddTextFileKeyPressed;
        }

        private void barButtonItem_addPdfFile_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_openTextEditor_ItemPress(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem_addTextFile_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
