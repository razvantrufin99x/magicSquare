using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace magicSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string zerois = "16";
        public square zerosquare = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.square1.setLabelText("1");
            this.square2.setLabelText("2");
            this.square3.setLabelText("3");
            this.square4.setLabelText("4");

            this.square5.setLabelText("5");
            this.square6.setLabelText("6");
            this.square7.setLabelText("7");
            this.square8.setLabelText("8");

            this.square9.setLabelText("9");
            this.square10.setLabelText("10");
            this.square11.setLabelText("11");
            this.square12.setLabelText("12");

            this.square13.setLabelText("13");
            this.square14.setLabelText("14");
            this.square15.setLabelText("15");
            this.square16.setLabelText(" ");
            zerosquare = square16;

        }
    }
}
