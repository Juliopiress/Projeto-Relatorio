
namespace Relatório_de_Funcionarios_
{
    partial class Frm_Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Relatorio));
            this.chekSsair = new System.Windows.Forms.CheckBox();
            this.Chekatraso = new System.Windows.Forms.CheckBox();
            this.ChekFalta = new System.Windows.Forms.CheckBox();
            this.RadioPadaria = new System.Windows.Forms.RadioButton();
            this.RadioAçogue = new System.Windows.Forms.RadioButton();
            this.RadioCaixa = new System.Windows.Forms.RadioButton();
            this.RadioHortifruti = new System.Windows.Forms.RadioButton();
            this.TxtCpf = new System.Windows.Forms.TextBox();
            this.Txtnome = new System.Windows.Forms.TextBox();
            this.Txthoratrabalhar = new System.Windows.Forms.TextBox();
            this.TxtRelatorio = new System.Windows.Forms.TextBox();
            this.CmbCargos = new System.Windows.Forms.ComboBox();
            this.CombSituacoes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCargos = new System.Windows.Forms.Label();
            this.LblCpf = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.BtnApagar = new System.Windows.Forms.Button();
            this.LblSituacoes = new System.Windows.Forms.Label();
            this.LblSetordesc = new System.Windows.Forms.Label();
            this.LblInfor = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesSobreSetoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarFonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.BtnApagar2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chekSsair
            // 
            this.chekSsair.AutoSize = true;
            this.chekSsair.Enabled = false;
            this.chekSsair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chekSsair.ForeColor = System.Drawing.Color.Green;
            this.chekSsair.Location = new System.Drawing.Point(12, 349);
            this.chekSsair.Name = "chekSsair";
            this.chekSsair.Size = new System.Drawing.Size(160, 24);
            this.chekSsair.TabIndex = 0;
            this.chekSsair.Text = "Saiu mais cedo";
            this.chekSsair.UseVisualStyleBackColor = true;
            this.chekSsair.CheckedChanged += new System.EventHandler(this.chekSsair_CheckedChanged);
            // 
            // Chekatraso
            // 
            this.Chekatraso.AutoSize = true;
            this.Chekatraso.Enabled = false;
            this.Chekatraso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chekatraso.ForeColor = System.Drawing.Color.DarkOrchid;
            this.Chekatraso.Location = new System.Drawing.Point(6, 537);
            this.Chekatraso.Name = "Chekatraso";
            this.Chekatraso.Size = new System.Drawing.Size(96, 24);
            this.Chekatraso.TabIndex = 1;
            this.Chekatraso.Text = "Atrasos";
            this.Chekatraso.UseVisualStyleBackColor = true;
            this.Chekatraso.CheckedChanged += new System.EventHandler(this.Chekatraso_CheckedChanged);
            // 
            // ChekFalta
            // 
            this.ChekFalta.AutoSize = true;
            this.ChekFalta.Enabled = false;
            this.ChekFalta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChekFalta.ForeColor = System.Drawing.Color.Red;
            this.ChekFalta.Location = new System.Drawing.Point(6, 440);
            this.ChekFalta.Name = "ChekFalta";
            this.ChekFalta.Size = new System.Drawing.Size(73, 24);
            this.ChekFalta.TabIndex = 2;
            this.ChekFalta.Text = "Falta";
            this.ChekFalta.UseVisualStyleBackColor = true;
            this.ChekFalta.CheckedChanged += new System.EventHandler(this.ChekFalta_CheckedChanged);
            // 
            // RadioPadaria
            // 
            this.RadioPadaria.AutoSize = true;
            this.RadioPadaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioPadaria.Location = new System.Drawing.Point(10, 87);
            this.RadioPadaria.Name = "RadioPadaria";
            this.RadioPadaria.Size = new System.Drawing.Size(94, 24);
            this.RadioPadaria.TabIndex = 3;
            this.RadioPadaria.Text = "Padaria";
            this.RadioPadaria.UseVisualStyleBackColor = true;
            this.RadioPadaria.CheckedChanged += new System.EventHandler(this.RadioPadaria_CheckedChanged);
            // 
            // RadioAçogue
            // 
            this.RadioAçogue.AutoSize = true;
            this.RadioAçogue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioAçogue.Location = new System.Drawing.Point(8, 244);
            this.RadioAçogue.Name = "RadioAçogue";
            this.RadioAçogue.Size = new System.Drawing.Size(92, 24);
            this.RadioAçogue.TabIndex = 4;
            this.RadioAçogue.Text = "Açogue";
            this.RadioAçogue.UseVisualStyleBackColor = true;
            this.RadioAçogue.CheckedChanged += new System.EventHandler(this.RadioAçogue_CheckedChanged);
            // 
            // RadioCaixa
            // 
            this.RadioCaixa.AutoSize = true;
            this.RadioCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioCaixa.Location = new System.Drawing.Point(10, 185);
            this.RadioCaixa.Name = "RadioCaixa";
            this.RadioCaixa.Size = new System.Drawing.Size(77, 24);
            this.RadioCaixa.TabIndex = 5;
            this.RadioCaixa.Text = "Caixa";
            this.RadioCaixa.UseVisualStyleBackColor = true;
            this.RadioCaixa.CheckedChanged += new System.EventHandler(this.RadioCaixa_CheckedChanged);
            // 
            // RadioHortifruti
            // 
            this.RadioHortifruti.AutoSize = true;
            this.RadioHortifruti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioHortifruti.Location = new System.Drawing.Point(8, 139);
            this.RadioHortifruti.Name = "RadioHortifruti";
            this.RadioHortifruti.Size = new System.Drawing.Size(96, 24);
            this.RadioHortifruti.TabIndex = 6;
            this.RadioHortifruti.Text = "Hortfrut";
            this.RadioHortifruti.UseVisualStyleBackColor = true;
            this.RadioHortifruti.CheckedChanged += new System.EventHandler(this.RadioHortifruti_CheckedChanged);
            // 
            // TxtCpf
            // 
            this.TxtCpf.Enabled = false;
            this.TxtCpf.Location = new System.Drawing.Point(578, 176);
            this.TxtCpf.Multiline = true;
            this.TxtCpf.Name = "TxtCpf";
            this.TxtCpf.Size = new System.Drawing.Size(270, 28);
            this.TxtCpf.TabIndex = 7;
            // 
            // Txtnome
            // 
            this.Txtnome.Enabled = false;
            this.Txtnome.Location = new System.Drawing.Point(578, 110);
            this.Txtnome.Multiline = true;
            this.Txtnome.Name = "Txtnome";
            this.Txtnome.Size = new System.Drawing.Size(244, 28);
            this.Txtnome.TabIndex = 8;
            // 
            // Txthoratrabalhar
            // 
            this.Txthoratrabalhar.Enabled = false;
            this.Txthoratrabalhar.Location = new System.Drawing.Point(762, 244);
            this.Txthoratrabalhar.Multiline = true;
            this.Txthoratrabalhar.Name = "Txthoratrabalhar";
            this.Txthoratrabalhar.ReadOnly = true;
            this.Txthoratrabalhar.Size = new System.Drawing.Size(201, 22);
            this.Txthoratrabalhar.TabIndex = 9;
            // 
            // TxtRelatorio
            // 
            this.TxtRelatorio.Enabled = false;
            this.TxtRelatorio.Location = new System.Drawing.Point(430, 332);
            this.TxtRelatorio.Multiline = true;
            this.TxtRelatorio.Name = "TxtRelatorio";
            this.TxtRelatorio.Size = new System.Drawing.Size(549, 275);
            this.TxtRelatorio.TabIndex = 10;
            // 
            // CmbCargos
            // 
            this.CmbCargos.Enabled = false;
            this.CmbCargos.FormattingEnabled = true;
            this.CmbCargos.Items.AddRange(new object[] {
            "Aprendiz",
            "Ajudante Geral",
            "Encarregado",
            "Gerente"});
            this.CmbCargos.Location = new System.Drawing.Point(422, 245);
            this.CmbCargos.Name = "CmbCargos";
            this.CmbCargos.Size = new System.Drawing.Size(164, 24);
            this.CmbCargos.TabIndex = 11;
            this.CmbCargos.SelectedIndexChanged += new System.EventHandler(this.CmbCargos_SelectedIndexChanged);
            // 
            // CombSituacoes
            // 
            this.CombSituacoes.FormattingEnabled = true;
            this.CombSituacoes.Location = new System.Drawing.Point(220, 332);
            this.CombSituacoes.Name = "CombSituacoes";
            this.CombSituacoes.Size = new System.Drawing.Size(204, 24);
            this.CombSituacoes.TabIndex = 12;
            this.CombSituacoes.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Horas Trabalhadas";
            // 
            // LblCargos
            // 
            this.LblCargos.AutoSize = true;
            this.LblCargos.Enabled = false;
            this.LblCargos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargos.Location = new System.Drawing.Point(338, 252);
            this.LblCargos.Name = "LblCargos";
            this.LblCargos.Size = new System.Drawing.Size(63, 18);
            this.LblCargos.TabIndex = 14;
            this.LblCargos.Text = "Cargos";
            // 
            // LblCpf
            // 
            this.LblCpf.AutoSize = true;
            this.LblCpf.Enabled = false;
            this.LblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpf.Location = new System.Drawing.Point(531, 185);
            this.LblCpf.Name = "LblCpf";
            this.LblCpf.Size = new System.Drawing.Size(41, 18);
            this.LblCpf.TabIndex = 15;
            this.LblCpf.Text = "CPF";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Enabled = false;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(521, 116);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(53, 18);
            this.LblNome.TabIndex = 16;
            this.LblNome.Text = "Nome";
            // 
            // BtnApagar
            // 
            this.BtnApagar.Enabled = false;
            this.BtnApagar.Location = new System.Drawing.Point(888, 104);
            this.BtnApagar.Name = "BtnApagar";
            this.BtnApagar.Size = new System.Drawing.Size(75, 33);
            this.BtnApagar.TabIndex = 17;
            this.BtnApagar.Text = "Apagar";
            this.BtnApagar.UseVisualStyleBackColor = true;
            this.BtnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // LblSituacoes
            // 
            this.LblSituacoes.AutoSize = true;
            this.LblSituacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSituacoes.Location = new System.Drawing.Point(217, 312);
            this.LblSituacoes.Name = "LblSituacoes";
            this.LblSituacoes.Size = new System.Drawing.Size(0, 17);
            this.LblSituacoes.TabIndex = 18;
            this.LblSituacoes.Visible = false;
            // 
            // LblSetordesc
            // 
            this.LblSetordesc.AutoSize = true;
            this.LblSetordesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSetordesc.Location = new System.Drawing.Point(609, 284);
            this.LblSetordesc.Name = "LblSetordesc";
            this.LblSetordesc.Size = new System.Drawing.Size(0, 18);
            this.LblSetordesc.TabIndex = 19;
            // 
            // LblInfor
            // 
            this.LblInfor.AutoSize = true;
            this.LblInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfor.Location = new System.Drawing.Point(446, 312);
            this.LblInfor.Name = "LblInfor";
            this.LblInfor.Size = new System.Drawing.Size(517, 17);
            this.LblInfor.TabIndex = 20;
            this.LblInfor.Text = "As informações abaixo devem ser colodas respeitando ponto e virgula";
            this.LblInfor.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.editarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informaçõesSobreSetoresToolStripMenuItem,
            this.salvarComoToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // informaçõesSobreSetoresToolStripMenuItem
            // 
            this.informaçõesSobreSetoresToolStripMenuItem.Name = "informaçõesSobreSetoresToolStripMenuItem";
            this.informaçõesSobreSetoresToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.informaçõesSobreSetoresToolStripMenuItem.Text = "Informações sobre setores";
            this.informaçõesSobreSetoresToolStripMenuItem.Click += new System.EventHandler(this.informaçõesSobreSetoresToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.salvarComoToolStripMenuItem.Text = "Salvar como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarFonteToolStripMenuItem,
            this.fonteToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // apagarFonteToolStripMenuItem
            // 
            this.apagarFonteToolStripMenuItem.Name = "apagarFonteToolStripMenuItem";
            this.apagarFonteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.apagarFonteToolStripMenuItem.Text = " Apagar tudo";
            this.apagarFonteToolStripMenuItem.Click += new System.EventHandler(this.apagarFonteToolStripMenuItem_Click);
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.fonteToolStripMenuItem.Text = "Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(268, 28);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(488, 44);
            this.LblTitulo.TabIndex = 22;
            this.LblTitulo.Text = "Relatorio do dia";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnApagar2
            // 
            this.BtnApagar2.Enabled = false;
            this.BtnApagar2.Location = new System.Drawing.Point(888, 176);
            this.BtnApagar2.Name = "BtnApagar2";
            this.BtnApagar2.Size = new System.Drawing.Size(75, 33);
            this.BtnApagar2.TabIndex = 23;
            this.BtnApagar2.Text = "Apagar";
            this.BtnApagar2.UseVisualStyleBackColor = true;
            this.BtnApagar2.Click += new System.EventHandler(this.BtnApagar2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SalvarOk);
            // 
            // Frm_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.BtnApagar2);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.LblInfor);
            this.Controls.Add(this.LblSetordesc);
            this.Controls.Add(this.LblSituacoes);
            this.Controls.Add(this.BtnApagar);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblCpf);
            this.Controls.Add(this.LblCargos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CombSituacoes);
            this.Controls.Add(this.CmbCargos);
            this.Controls.Add(this.TxtRelatorio);
            this.Controls.Add(this.Txthoratrabalhar);
            this.Controls.Add(this.Txtnome);
            this.Controls.Add(this.TxtCpf);
            this.Controls.Add(this.RadioHortifruti);
            this.Controls.Add(this.RadioCaixa);
            this.Controls.Add(this.RadioAçogue);
            this.Controls.Add(this.RadioPadaria);
            this.Controls.Add(this.ChekFalta);
            this.Controls.Add(this.Chekatraso);
            this.Controls.Add(this.chekSsair);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Relatorio";
            this.Text = "Relatorio do Dia";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chekSsair;
        private System.Windows.Forms.CheckBox Chekatraso;
        private System.Windows.Forms.CheckBox ChekFalta;
        private System.Windows.Forms.RadioButton RadioPadaria;
        private System.Windows.Forms.RadioButton RadioAçogue;
        private System.Windows.Forms.RadioButton RadioCaixa;
        private System.Windows.Forms.RadioButton RadioHortifruti;
        private System.Windows.Forms.TextBox TxtCpf;
        private System.Windows.Forms.TextBox Txtnome;
        private System.Windows.Forms.TextBox Txthoratrabalhar;
        private System.Windows.Forms.TextBox TxtRelatorio;
        private System.Windows.Forms.ComboBox CmbCargos;
        private System.Windows.Forms.ComboBox CombSituacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCargos;
        private System.Windows.Forms.Label LblCpf;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button BtnApagar;
        private System.Windows.Forms.Label LblSituacoes;
        private System.Windows.Forms.Label LblSetordesc;
        private System.Windows.Forms.Label LblInfor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informaçõesSobreSetoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apagarFonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Button BtnApagar2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

