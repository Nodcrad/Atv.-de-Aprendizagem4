using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Atv.de_Aprendizagem4
{
    public partial class qualCurso : Form
    {
        public qualCurso()
        {
            InitializeComponent();
        }

        double Valor = 0;

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            String mensagem = "";
            double comDesconto = Valor;


            if (cmbCurso.Text == "Técnico em Informática")
                comDesconto = Valor - (Valor * 0.10);
            else
            {
                if (cmbCurso.Text == "Superior de Sistemas de Informação")
                    comDesconto = Valor - (Valor * 0.085);
            }

            if (txtNome.Text != "") { mensagem += "Aluno: " + txtNome.Text + "\n"; }

            mensagem += Cursaras();
            mensagem += "\nCusto original " + lblValorTotal.Text + 
                "\nCusto após aplicado o desconto para alunos do Curso " + cmbCurso.Text + ": " + comDesconto.ToString("N2") + " R$";
            mensagem += "\nQue será pago usando " + Pagamento();

            MessageBox.Show(mensagem);
        }

        private String Pagamento()
        {
            String modoDePagamento;
            if (rdCartao.Checked == true)
            {
                modoDePagamento = rdCartao.Text;
            }
            else
            {
                if (rdPix.Checked == true)
                {
                    modoDePagamento = rdPix.Text;
                }else
                    modoDePagamento = rdCartao.Text;
                
            }
            return modoDePagamento;
        }
        private String Cursaras()
        {
            String CursosChecados = "Cursos escolhidos:\n";
            if (chkCurso1.Checked == true)
            {
                CursosChecados += chkCurso1.Text +"\n";
            }
            if (chkCurso2.Checked == true)
            {
                CursosChecados += chkCurso2.Text + "\n";
            }
            if (chkCurso3.Checked == true)
            {
                CursosChecados += chkCurso3.Text + "\n";
            }
            if (chkCurso4.Checked == true)
            {
                CursosChecados += chkCurso4.Text + "\n";
            }
            return CursosChecados;
        }

        private void chkCurso1_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCurso1.Checked == true)
            {
                btnConfirmar.Enabled = true;
                Valor += 258.50 ;
            }
            else
            {
                Valor -= 258.50;
                if (chkCurso2.Checked == false & chkCurso3.Checked == false & chkCurso4.Checked == false)
                {
                    btnConfirmar.Enabled = false;
                    Valor = 0;
                }
            }
            lblValorTotal.Text = Valor.ToString("N2") + " R$";
        }

        private void chkCurso2_CheckedChanged(object sender, EventArgs e)
        {

            if (chkCurso2.Checked == true)
            {
                btnConfirmar.Enabled = true;
                Valor += 260.00;
            }
            else
            {
                Valor -= 260.00;
                if (chkCurso1.Checked == false & chkCurso3.Checked == false & chkCurso4.Checked == false)
                {
                    btnConfirmar.Enabled = false;
                    Valor = 0;
                }
            }
            lblValorTotal.Text = Valor.ToString("N2") + " R$";
        }

        private void chkCurso3_CheckedChanged(object sender, EventArgs e)
        { 
            if (chkCurso3.Checked == true)
            {
                btnConfirmar.Enabled = true;
                Valor += 215.45;
            }
            else
            {
                Valor -= 215.45;
                if (chkCurso1.Checked == false & chkCurso2.Checked == false & chkCurso4.Checked == false)
                {
                    btnConfirmar.Enabled = false;
                    Valor = 0;
                }
            }
            lblValorTotal.Text = Valor.ToString("N2") + " R$";
        }

        private void chkCurso4_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCurso4.Checked == true)
            {
                btnConfirmar.Enabled = true;
                Valor += 280.50;
            }
            else
            {
                Valor -= 280.50;
                if (chkCurso1.Checked == false & chkCurso2.Checked == false & chkCurso3.Checked == false)
                {
                    btnConfirmar.Enabled = false;
                    Valor = 0.00;
                }
            }
            lblValorTotal.Text = Valor.ToString("N2") + " R$";
        }
    }
}
/*
                2  4   8   14
                 
                1   4   =   5
                1   8   =   9
                1   14  =   15
                
                4   8   =   12
                4   14  =   18

                8   14  =   22

                 
                1   4   8   =   13
                1   4   14  =   19
                1   8   14  =   23

                4   8   14  =   26

                
                1   4   8   14  =   27
                 */