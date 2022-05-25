
namespace Atv.de_Aprendizagem4
{
    partial class qualCurso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblSelecioneCurso = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkCurso1 = new System.Windows.Forms.CheckBox();
            this.chkCurso2 = new System.Windows.Forms.CheckBox();
            this.chkCurso3 = new System.Windows.Forms.CheckBox();
            this.chkCurso4 = new System.Windows.Forms.CheckBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rdCartao = new System.Windows.Forms.RadioButton();
            this.rdPix = new System.Windows.Forms.RadioButton();
            this.rdDinheiro = new System.Windows.Forms.RadioButton();
            this.grpFormasDePagar = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.grpFormasDePagar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(205, 36);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Aluno";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(12, 79);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(86, 36);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso";
            // 
            // lblSelecioneCurso
            // 
            this.lblSelecioneCurso.AutoSize = true;
            this.lblSelecioneCurso.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecioneCurso.Location = new System.Drawing.Point(12, 126);
            this.lblSelecioneCurso.Name = "lblSelecioneCurso";
            this.lblSelecioneCurso.Size = new System.Drawing.Size(407, 36);
            this.lblSelecioneCurso.TabIndex = 2;
            this.lblSelecioneCurso.Text = "Selecione o(s) curso(s) que deseja:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 423);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(182, 36);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total a Pagar: ";
            // 
            // chkCurso1
            // 
            this.chkCurso1.AutoSize = true;
            this.chkCurso1.Location = new System.Drawing.Point(17, 165);
            this.chkCurso1.Name = "chkCurso1";
            this.chkCurso1.Size = new System.Drawing.Size(311, 30);
            this.chkCurso1.TabIndex = 4;
            this.chkCurso1.Text = "Aprendendo Orientação a Objetos";
            this.chkCurso1.UseVisualStyleBackColor = true;
            this.chkCurso1.CheckedChanged += new System.EventHandler(this.chkCurso1_CheckedChanged);
            // 
            // chkCurso2
            // 
            this.chkCurso2.AutoSize = true;
            this.chkCurso2.Location = new System.Drawing.Point(17, 201);
            this.chkCurso2.Name = "chkCurso2";
            this.chkCurso2.Size = new System.Drawing.Size(302, 30);
            this.chkCurso2.TabIndex = 5;
            this.chkCurso2.Text = "Banco de Dados: Teoria e Prática";
            this.chkCurso2.UseVisualStyleBackColor = true;
            this.chkCurso2.CheckedChanged += new System.EventHandler(this.chkCurso2_CheckedChanged);
            // 
            // chkCurso3
            // 
            this.chkCurso3.AutoSize = true;
            this.chkCurso3.Location = new System.Drawing.Point(17, 237);
            this.chkCurso3.Name = "chkCurso3";
            this.chkCurso3.Size = new System.Drawing.Size(267, 30);
            this.chkCurso3.TabIndex = 6;
            this.chkCurso3.Text = "Orientação a Objetos com C#";
            this.chkCurso3.UseVisualStyleBackColor = true;
            this.chkCurso3.CheckedChanged += new System.EventHandler(this.chkCurso3_CheckedChanged);
            // 
            // chkCurso4
            // 
            this.chkCurso4.AutoSize = true;
            this.chkCurso4.Location = new System.Drawing.Point(17, 273);
            this.chkCurso4.Name = "chkCurso4";
            this.chkCurso4.Size = new System.Drawing.Size(236, 30);
            this.chkCurso4.TabIndex = 7;
            this.chkCurso4.Text = "HTML / CSS / JavaScript";
            this.chkCurso4.UseVisualStyleBackColor = true;
            this.chkCurso4.CheckedChanged += new System.EventHandler(this.chkCurso4_CheckedChanged);
            // 
            // cmbCurso
            // 
            this.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurso.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Items.AddRange(new object[] {
            "Técnico em Informática",
            "Superior de Sistemas de Informação"});
            this.cmbCurso.Location = new System.Drawing.Point(102, 79);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(233, 40);
            this.cmbCurso.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(219, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(338, 40);
            this.txtNome.TabIndex = 9;
            // 
            // rdCartao
            // 
            this.rdCartao.AutoSize = true;
            this.rdCartao.Checked = true;
            this.rdCartao.Location = new System.Drawing.Point(6, 32);
            this.rdCartao.Name = "rdCartao";
            this.rdCartao.Size = new System.Drawing.Size(83, 30);
            this.rdCartao.TabIndex = 10;
            this.rdCartao.TabStop = true;
            this.rdCartao.Text = "Cartão";
            this.rdCartao.UseVisualStyleBackColor = true;
            // 
            // rdPix
            // 
            this.rdPix.AutoSize = true;
            this.rdPix.Location = new System.Drawing.Point(95, 32);
            this.rdPix.Name = "rdPix";
            this.rdPix.Size = new System.Drawing.Size(57, 30);
            this.rdPix.TabIndex = 11;
            this.rdPix.TabStop = true;
            this.rdPix.Text = "Pix";
            this.rdPix.UseVisualStyleBackColor = true;
            // 
            // rdDinheiro
            // 
            this.rdDinheiro.AutoSize = true;
            this.rdDinheiro.Location = new System.Drawing.Point(158, 32);
            this.rdDinheiro.Name = "rdDinheiro";
            this.rdDinheiro.Size = new System.Drawing.Size(103, 30);
            this.rdDinheiro.TabIndex = 12;
            this.rdDinheiro.TabStop = true;
            this.rdDinheiro.Text = "Dinheiro";
            this.rdDinheiro.UseVisualStyleBackColor = true;
            // 
            // grpFormasDePagar
            // 
            this.grpFormasDePagar.Controls.Add(this.rdPix);
            this.grpFormasDePagar.Controls.Add(this.rdCartao);
            this.grpFormasDePagar.Controls.Add(this.rdDinheiro);
            this.grpFormasDePagar.Location = new System.Drawing.Point(17, 309);
            this.grpFormasDePagar.Name = "grpFormasDePagar";
            this.grpFormasDePagar.Size = new System.Drawing.Size(290, 85);
            this.grpFormasDePagar.TabIndex = 13;
            this.grpFormasDePagar.TabStop = false;
            this.grpFormasDePagar.Text = "Forma de Pagamento";
            
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(220, 517);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(199, 39);
            this.btnConfirmar.TabIndex = 14;
            this.btnConfirmar.Text = "Confirmar inscrição";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(198, 423);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(39, 32);
            this.lblValorTotal.TabIndex = 15;
            this.lblValorTotal.Text = "....";
            // 
            // qualCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 616);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.grpFormasDePagar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.chkCurso4);
            this.Controls.Add(this.chkCurso3);
            this.Controls.Add(this.chkCurso2);
            this.Controls.Add(this.chkCurso1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSelecioneCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "qualCurso";
            this.Text = "Escola de Programação";
            this.grpFormasDePagar.ResumeLayout(false);
            this.grpFormasDePagar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblSelecioneCurso;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkCurso1;
        private System.Windows.Forms.CheckBox chkCurso2;
        private System.Windows.Forms.CheckBox chkCurso3;
        private System.Windows.Forms.CheckBox chkCurso4;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rdCartao;
        private System.Windows.Forms.RadioButton rdPix;
        private System.Windows.Forms.RadioButton rdDinheiro;
        private System.Windows.Forms.GroupBox grpFormasDePagar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblValorTotal;
    }
}

