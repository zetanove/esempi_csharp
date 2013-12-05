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
    }
}
