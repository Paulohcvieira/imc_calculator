using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC11_imc_pp
{
    public partial class Form1 : Form
    {

        string funcao_buttoncalcular = "c";




        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPESO_TextChanged(object sender, EventArgs e)
        {





        }

        private void buttonCALCULAR_Click(object sender, EventArgs e)
        {

            if (funcao_buttoncalcular == "c") 
            {
                double peso;
                double altura;
                double imc;



                if (textBoxPESO.Text != "" && textBoxPESO.Text != "")
                {



                    peso = Convert.ToDouble(textBoxPESO.Text.Replace(".", ","));
                    altura = Convert.ToDouble(textBoxALTURA.Text.Replace(".", ","));

                    imc = peso / (altura * altura);

                    string arredonda = imc.ToString("00.0");

                    labelRESULTADO.Text = Convert.ToString(arredonda);

                    buttonCALCULAR.ForeColor = Color.Green;


                    if (imc < 18.5)

                    {
                        labelIMC.Text = "Você está abaixo do peso";

                    }

                    else if (imc < 24.9)
                    {
                        labelIMC.Text = "Você está Normal";
                    }

                    else if (imc < 29.9)
                    {

                        labelIMC.Text = "Você está Sobrepeso";


                    }

                    else if (imc > 30)
                    {

                        labelIMC.Text = "Você é obeso";

                    }





                }

                else
                {
                    textBoxALTURA.Text = "Digite um número";
                    textBoxPESO.Text = "Digite um Número";
                }

                funcao_buttoncalcular = "l";
                buttonCALCULAR.Text = "limpar";
                textBoxALTURA.Enabled = false;
                textBoxPESO.Enabled = false;


            }

            else
            {
                textBoxALTURA.Text = string.Empty ;
                textBoxPESO.Text = string.Empty;
                labelRESULTADO.Text = "segundo clique";
                labelIMC.Text = "aaaa";


                funcao_buttoncalcular = "c";
                buttonCALCULAR.Text = "calcular";
                buttonCALCULAR.ForeColor = Color.Purple;
                textBoxALTURA.Enabled = true;
                textBoxPESO.Enabled = true;
            }

            
        }

        

        private void labelIMC_Click(object sender, EventArgs e)
        {





        }
    }
}
