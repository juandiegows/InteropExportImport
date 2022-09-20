using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelExportImport
{
    public partial class FH : Form
    {
        public FH()
        {
            InitializeComponent();
        }

        private void btnBlocNote_Click(object sender, EventArgs e)
        {
            new FNoteblock().ShowDialog();
        }
    }
}
