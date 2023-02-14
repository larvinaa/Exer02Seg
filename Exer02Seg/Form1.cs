using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer02Seg
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

        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (this.cboGraus.SelectedIndex == 0)
            {
                float graus = 0;
                if (float.TryParse(txtGrauspconverter.Text, out graus))
                {
                    float fahreinheit = (float)(graus * 9 / 5) + 32;
                    txtGrausconvertidos.Text = $"{fahreinheit:N2}";
                }
                else
                {
                    MessageBox.Show("Valor Inválido");
                    txtGrausconvertidos.Text = "";
                }
            }
            else if (this.cboGraus.SelectedIndex == 1)
            {
                {
                    float fahreinheit = 0;
                    if (float.TryParse(txtGrauspconverter.Text, out fahreinheit))
                    {
                        float graus = (float)(fahreinheit - 32) * 5 / 9;
                        txtGrausconvertidos.Text = $"{graus:N2}";
                    }
                    else
                    {
                        MessageBox.Show("Valor invalido");
                        txtGrausconvertidos.Text = "";
                    }



                }
                



            }
            
        }

        private void lblgrausconvertidos_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtGrausconvertidos.Text = "";
            txtGrauspconverter.Text = "";
            cboGraus.Text = "";
            
        }
    }
}
