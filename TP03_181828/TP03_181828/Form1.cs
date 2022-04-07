using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP03_181828
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        #region Calcular
        private void calcular_Click(object sender, EventArgs e)
        {
            double desloc, veloc, acel, espacoi, velocidadei, tempop;
            try
            {
                acel = double.Parse(aceleracao.Text);
                espacoi = double.Parse(espacoinicial.Text);
                velocidadei = double.Parse(velocidadeinicial.Text);
                tempop = double.Parse(tempo.Text);

                if (acel < 0)
                {
                    MessageBox.Show("ERRO NA ACELERAÇÃO");
                    acel = 0;
                    aceleracao.Clear();
                    aceleracao.Focus();
                }
                else
                {
                    if (espacoi < 0)
                    {
                        MessageBox.Show("ERRO NO ESPAÇO INICIAL");
                        espacoi = 0;
                        espacoinicial.Clear();
                        espacoinicial.Focus();
                    }

                    else
                    {
                        if (velocidadei < 0)
                        {
                            MessageBox.Show("ERRO NA VELOCIDADE INICIAL");
                            velocidadei = 0;
                            velocidadeinicial.Clear();
                            velocidadeinicial.Focus();
                        }

                        else
                        {
                            if (tempop < 0)
                            {
                                MessageBox.Show("ERRO NO TEMPO");
                                tempop = 0;
                                tempo.Clear();
                                tempo.Focus();
                            }


                            else
                            {
                                if (acel == 0)
                                {
                                    veloc = velocidadei;
                                    desloc = espacoi + (velocidadei * tempop);
                                }

                                else
                                {
                                    veloc = velocidadei + (acel * tempop);
                                    desloc = espacoi + (velocidadei * tempop) + ((acel * tempop * tempop) / 2);
                                }

                                velocidade.Text = Convert.ToString(veloc);
                                deslocamento.Text = Convert.ToString(desloc);
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERRO NO CÁLCULO");
                return;
            }
         
        }
        #endregion

        #region Limpar
        private void LIMPAR_Click(object sender, EventArgs e)
        {
            string pergunta = "Deseja limpar o programa?";
            string sair = "LIMPAR O PROGRAMA";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes) {           
                aceleracao.Clear();
                espacoinicial.Clear();
                velocidadeinicial.Clear();
                tempo.Clear();
                deslocamento.Clear();
                velocidade.Clear();
            }


        }
        #endregion

        #region Sair
        private void Sair_Click(object sender, EventArgs e)
        {
            string pergunta = "Deseja sair do programa?";
            string sair = "SAIR DO PROGRAMA";
            MessageBoxButtons botao = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            MessageBoxDefaultButton Default = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(pergunta, sair, botao, icon, Default) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region Lixo
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void espacoinicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void deslocamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void aceleracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void velocidade_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString();
        }
        #endregion


    }
}
