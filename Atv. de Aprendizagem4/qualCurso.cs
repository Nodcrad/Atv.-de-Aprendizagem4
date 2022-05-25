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
