using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace magicSquare
{
    public partial class square : UserControl
    {
        public square()
        {
            InitializeComponent();
        }

        Form1 f;
        public string val = " ";
        public void setLabelText(string s)
        {
            label1.Text = s;
            val = label1.Text;
        }

        private void square_Load(object sender, EventArgs e)
        {
            try
            {
                f = (Form1)ParentForm;
            }
            catch { }
            
        }

        private void square_MouseClick(object sender, MouseEventArgs e)
        {
            f.Text = this.label1.Text ;
            f.Text = this.Name;
            f.Text += " ";
            f.Text += val;
            string s = val;
            f.zerois = s;
            this.label1.Text = " ";
            f.zerosquare.setLabelText(s);
            f.zerosquare = this;

        }

    }
}
