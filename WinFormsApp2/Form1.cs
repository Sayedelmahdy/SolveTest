using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Add (object sender , EventArgs e)
        {
            txt3.Text = Convert.ToString(Convert.ToInt32(txt1.Text) + Convert.ToInt32(txt2.Text));
            this.Refresh();
        }
        private void sub(object sender, EventArgs e)
        {
            txt3.Text = Convert.ToString(Convert.ToInt32(txt1.Text) - Convert.ToInt32(txt2.Text));
            this.Refresh();
        }
        private void multi(object sender, EventArgs e)
        {
            txt3.Text = Convert.ToString(Convert.ToInt32(txt1.Text) * Convert.ToInt32(txt2.Text));
            this.Refresh();
        }
        private void divid(object sender, EventArgs e)
        {
            txt3.Text = Convert.ToString(Convert.ToInt32(txt1.Text) / Convert.ToInt32(txt2.Text));
            this.Refresh();
        }
        private void model(object sender, EventArgs e)
        {
            txt3.Text = Convert.ToString(Convert.ToInt32(txt1.Text) % Convert.ToInt32(txt2.Text));
            this.Refresh();
        }
    }
}
