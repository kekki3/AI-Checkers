using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AICheckers
{
    public partial class FormEnd : Form
    {
        string str;
        public FormEnd(string str)
        {
            InitializeComponent();
            this.str = str;
            textBox1.Text = str;
        }

        private void FormEnd_Load(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
