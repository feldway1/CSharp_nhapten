using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_nhapten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CancelButton = btnthoat;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbllaptrinh.Text=txtnhapten.Text;
        }

        private void rdbRed_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = (RadioButton)sender;
            switch (r.Name)
            {
                case "rdbRed":
                    lbllaptrinh.ForeColor= Color.Red;
                    txtnhapten.ForeColor= Color.Red;
                    break;
                case "rdbGreen":
                    lbllaptrinh.ForeColor = Color.Green;
                    txtnhapten.ForeColor= Color.Green;
                    break;
                case "rdbBlue":
                    lbllaptrinh.ForeColor =Color.Blue;
                    txtnhapten.ForeColor = Color.Blue;
                    break;
                case "rdbBlack":
                    lbllaptrinh.ForeColor = Color.Black;
                    txtnhapten.ForeColor =(Color)Color.Black;
                    break;
            } 
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox r=(CheckBox)sender;
            switch(r.Name)
            {
                case "ckbBold":
                    lbllaptrinh.Font=new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size,lbllaptrinh.Font.Style^FontStyle.Bold);
                    break;
                case "ckbItalic":
                    lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Italic);
                    break;
                case "ckbUnderLine":
                    lbllaptrinh.Font = new Font(lbllaptrinh.Font.Name, lbllaptrinh.Font.Size, lbllaptrinh.Font.Style ^ FontStyle.Underline);
                    break;
            }
        }

        private void grbcolor_Enter(object sender, EventArgs e)
        {
             
        }

        private void grbfont_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
