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
using DevExpress.XtraRichEdit;

namespace Windows.Main.UserControls
{
    public partial class TextDocumentUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        
        
        public TextDocumentUserControl1()
        {
            InitializeComponent();
        }
        public RichEditControl TextBoxControl
        {
            get { return this.richEditControl1; }
        }
    }
}
