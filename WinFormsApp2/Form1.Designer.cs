
using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp2
{
    partial class Form1
    {
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        TextBox txt1 = new TextBox();
        TextBox txt2 = new TextBox();
        TextBox txt3 = new TextBox();
        Button btn1 = new Button();
        Button btn2 = new Button();
        Button btn3 = new Button();
        Button btn4 = new Button();
        Button btn5 = new Button();
        private void InitializeComponent()
        {
           // label
            label1.Location = new Point(60,20);
            label1.Text = "number 1";
            label1.Size = new Size(80,50);
            label1.ForeColor = Color.Red;
            label2.Location = new Point(260, 20);
            label2.Text = "number 2";
            label2.Size = new Size(80, 50);
            label2.ForeColor = Color.Red;
            label3.Location = new Point(460, 20);
            label3.Text = "Result";
            label3.Size = new Size(80, 50);
            label3.ForeColor = Color.Red;
            // textbox
            txt1.Location = new Point(140, 20);
            txt2.Location = new Point(340, 20);
            txt3.Location = new Point(540, 20);
            // button 
            btn1.Location = new Point(60, 80);
            btn1.Text = "Add";
            btn1.Width = 80;
            btn1.Click += new System.EventHandler(Add);
            btn2.Location = new Point(160, 80);
            btn2.Text = "Substract";
            btn2.Width = 80;
            btn2.Click += new System.EventHandler(sub);
            btn3.Location = new Point(260, 80);
            btn3.Text = "Multiply";
            btn3.Width = 80;
            btn3.Click += new System.EventHandler(multi);
            btn4.Location = new Point(360, 80);
            btn4.Text = "Divid";
            btn4.Width = 80;
            btn4.Click += new System.EventHandler(divid);
            btn5.Location = new Point(460, 80);
            btn5.Text = "Models";
            btn5.Width = 80;
            btn5.Click += new System.EventHandler(model);
            //form
            this.Text = "Menu Demo";
            this.ClientSize = new System.Drawing.Size(800, 450);
            //Controls
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
        }
    }
}

