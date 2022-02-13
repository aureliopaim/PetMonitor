using System;
using System.Drawing;
using System.Windows.Forms;

namespace PetMonitor
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void Distancia()
        {
            double LatTutor, LongTutor, LatPet, LongPet, distancia;

            if(latTutor.Text=="")
            {
                MessageBox.Show("Informe a latitude do Tutor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                latTutor.Focus();
            }
            else
            {
                if (longTutor.Text == "")
                {
                    MessageBox.Show("Informe a longitude do Tutor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    longTutor.Focus();
                }
                else
                {
                    if (latPet.Text == "")
                    {
                        MessageBox.Show("Informe a latitude do Pet", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        latPet.Focus();
                    }
                    else
                    {
                        if (longPet.Text == "")
                        {
                            MessageBox.Show("Informe a longitude do Pet", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            longPet.Focus();
                        }
                        else
                        {
                            LatTutor = Convert.ToDouble(latTutor.Text);
                            LongTutor = Convert.ToDouble(longTutor.Text);
                            LatPet = Convert.ToDouble(latPet.Text);
                            LongPet = Convert.ToDouble(longPet.Text);

                            var d1 = LatTutor * (Math.PI / 180.0);
                            var num1 = LongTutor * (Math.PI / 180.0);
                            var d2 = LatPet * (Math.PI / 180.0);
                            var num2 = LongPet * (Math.PI / 180.0) - num1;
                            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

                            distancia = 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));

                            labelDistancia.Text = distancia.ToString("N0")+" "+"Metros";
                            
                            if(distancia>20)
                            {
                                msgResultado.ForeColor = Color.Red;
                                msgResultado.Text = "Perigo! O Pet se distanciou.";
                            }
                            else
                            {
                                msgResultado.ForeColor = Color.Black;
                                msgResultado.Text = "Seu Pet está próximo. Tudo certo!";
                            }
                        }
                    }

                    }

                }

            }
     
        private void botaoCalcular_Click(object sender, EventArgs e)
        {
            Distancia();
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            latTutor.Text = "";
            longTutor.Text = "";
            latPet.Text = "";
            longPet.Text = "";
            labelDistancia.Text = "";
            msgResultado.Text = "";
            latTutor.Focus();
        }

        private void latTutor_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (latTutor.Text.Contains(",") || (latTutor.Text.Contains("-")))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back) && !(e.KeyChar == ('-')))
            {
                e.Handled = true;
            }*/
        }
    }
}
