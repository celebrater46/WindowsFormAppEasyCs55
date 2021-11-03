using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs55
{
    public partial class Form1 : Form
    {
        public void Display()
        {
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "サンプル";
            this.Width = 400;
            this.Height = 200;
            this.BackgroundImage = Image.FromFile("C:\\Users\\Enin\\RiderProjects\\WindowsFormsAppEasyCs55\\WindowsFormsAppEasyCs55\\img\\sunSymbol3.png");
        }
    }
}