using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelExportImport
{
    public partial class FNoteblock : Form
    {
        ProcessStartInfo psi = new ProcessStartInfo("notepad.exe");
        Process p;
        public FNoteblock()
        {
            InitializeComponent();
        }

        private void btnBlocNote_Click(object sender, EventArgs e)
        {
            p = Process.Start(psi);

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

            try
            {
                p.Kill();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnOpenText_Click(object sender, EventArgs e)
        {
            var temp = Path.GetTempFileName();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var ruta = Path.ChangeExtension(temp, Path.GetExtension(openFile.FileName));
                File.Copy(openFile.FileName, ruta);

                StreamReader sr = new StreamReader(ruta);
                
                txtTexto.Text = sr.ReadToEnd();
                if (!chkGetFirstLine.Checked)
                {

                    txtTexto.Text = txtTexto.Text.Remove(0, txtTexto.Text.Split("\n")[0].Length);
                    txtTexto.Text = txtTexto.Text.Replace("\n", " ");
                }
                sr.Close();
                File.Delete(ruta);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(openFile.FileName))
                {
                    sw.WriteLine(txtTexto.Text);
                    sw.Close();
                }
                MessageBox.Show("has bean saved sucessful");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    var file = File.CreateText(saveFile.FileName);
                    file.Write(txtTexto.Text);
                    file.Close();
                    MessageBox.Show("has been saved successful");
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
