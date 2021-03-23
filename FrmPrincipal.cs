using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcIMC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.ActiveControl = Txt_peso;
            Txt_peso.Focus();
        }

        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            Double peso, altura, resultado;
            peso = Convert.ToDouble(Txt_peso.Text);
            altura = Convert.ToDouble(Txt_altura.Text);
            resultado = (peso / (altura * altura));
            Lbl_mostar.Text = resultado.ToString("F");
            Txt_altura.Text = "";
            Txt_peso.Text = "";
            if(resultado < 18.5){
                MessageBox.Show("Magreza", "IMC", MessageBoxButtons.OK);
            }else if(resultado <= 24.9){
                MessageBox.Show("Normal", "IMC", MessageBoxButtons.OK);
            }else if(resultado <= 29.9){
                MessageBox.Show("Sobrepeso", "IMC", MessageBoxButtons.OK);
            }else if(resultado <= 39.9){
                MessageBox.Show("Obesidade", "IMC", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Obeseidade Grave", "IMC", MessageBoxButtons.OK);
            }

        }
    }
}
