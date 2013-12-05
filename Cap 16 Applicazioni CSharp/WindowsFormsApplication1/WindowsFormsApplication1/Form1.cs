using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Hello Windows";
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hai cliccato il pulsante");
        }

        private void btShowChild_Click(object sender, EventArgs e)
        {
            Form f2 = new Form();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("continuare?", "scegli", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result== System.Windows.Forms.DialogResult.OK)
            {
                label1.Text = "Hai cliccato OK";
            }
            else label1.Text = "Hai cliccato annulla";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "File di test (*.txt)|*.txt|Tutti i file (*.*)|*.*";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                string filename = ofd.FileName;
                MessageBox.Show("Hai selezionato il file "+filename);
            }
        }
    }
}
