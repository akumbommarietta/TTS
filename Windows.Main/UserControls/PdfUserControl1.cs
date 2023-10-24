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
using Windows.Main.View;
using DevExpress.XtraPdfViewer;

namespace Windows.Main.UserControls
{
    public partial class PdfUserControl1 : DevExpress.XtraEditors.XtraUserControl
    {
        public PdfUserControl1()
        {
            InitializeComponent();
        }

        public PdfViewer PdfViewer
        {
            get { return this.pdfViewer; }
        }
    }
}
