namespace AtivarKeysWeb
{
    partial class FormWeb
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
            this.components = new System.ComponentModel.Container();
            this.lblAtivados = new System.Windows.Forms.Label();
            this.lblNOK = new System.Windows.Forms.Label();
            this.lblQtdKeys = new System.Windows.Forms.Label();
            this.START = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.BTN_START_KEYS = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_STOP_KEYS = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAtivados
            // 
            this.lblAtivados.AutoSize = true;
            this.lblAtivados.Location = new System.Drawing.Point(95, 149);
            this.lblAtivados.Name = "lblAtivados";
            this.lblAtivados.Size = new System.Drawing.Size(60, 13);
            this.lblAtivados.TabIndex = 1;
            this.lblAtivados.Text = "Ativados: 0";
            // 
            // lblNOK
            // 
            this.lblNOK.AutoSize = true;
            this.lblNOK.Location = new System.Drawing.Point(95, 173);
            this.lblNOK.Name = "lblNOK";
            this.lblNOK.Size = new System.Drawing.Size(78, 13);
            this.lblNOK.TabIndex = 2;
            this.lblNOK.Text = "Não Ativado: 0";
            // 
            // lblQtdKeys
            // 
            this.lblQtdKeys.AutoSize = true;
            this.lblQtdKeys.Location = new System.Drawing.Point(95, 195);
            this.lblQtdKeys.Name = "lblQtdKeys";
            this.lblQtdKeys.Size = new System.Drawing.Size(47, 13);
            this.lblQtdKeys.TabIndex = 3;
            this.lblQtdKeys.Text = "KEYS: 0";
            // 
            // START
            // 
            this.START.Location = new System.Drawing.Point(67, 243);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(51, 25);
            this.START.TabIndex = 4;
            this.START.Text = "LOGIN";
            this.START.UseVisualStyleBackColor = true;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TEMPO:";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(65, 287);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(34, 13);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "30:00";
            // 
            // BTN_START_KEYS
            // 
            this.BTN_START_KEYS.Location = new System.Drawing.Point(147, 243);
            this.BTN_START_KEYS.Name = "BTN_START_KEYS";
            this.BTN_START_KEYS.Size = new System.Drawing.Size(51, 25);
            this.BTN_START_KEYS.TabIndex = 7;
            this.BTN_START_KEYS.Text = "START";
            this.BTN_START_KEYS.UseVisualStyleBackColor = true;
            this.BTN_START_KEYS.Click += new System.EventHandler(this.BTN_START_KEYS_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(98, 30);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(98, 66);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // BTN_STOP_KEYS
            // 
            this.BTN_STOP_KEYS.Location = new System.Drawing.Point(147, 243);
            this.BTN_STOP_KEYS.Name = "BTN_STOP_KEYS";
            this.BTN_STOP_KEYS.Size = new System.Drawing.Size(51, 25);
            this.BTN_STOP_KEYS.TabIndex = 12;
            this.BTN_STOP_KEYS.Text = "STOP";
            this.BTN_STOP_KEYS.UseVisualStyleBackColor = true;
            this.BTN_STOP_KEYS.Visible = false;
            this.BTN_STOP_KEYS.Click += new System.EventHandler(this.BTN_STOP_KEYS_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "STEAMGUARD";
            // 
            // txtGuard
            // 
            this.txtGuard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuard.Location = new System.Drawing.Point(98, 103);
            this.txtGuard.MaxLength = 5;
            this.txtGuard.Name = "txtGuard";
            this.txtGuard.Size = new System.Drawing.Size(100, 20);
            this.txtGuard.TabIndex = 13;
            // 
            // FormWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGuard);
            this.Controls.Add(this.BTN_STOP_KEYS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.BTN_START_KEYS);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.START);
            this.Controls.Add(this.lblQtdKeys);
            this.Controls.Add(this.lblNOK);
            this.Controls.Add(this.lblAtivados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormWeb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamActivationBulk";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWeb_FormClosing);
            this.Load += new System.EventHandler(this.FormWeb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAtivados;
        private System.Windows.Forms.Label lblNOK;
        private System.Windows.Forms.Label lblQtdKeys;
        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button BTN_START_KEYS;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_STOP_KEYS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuard;
    }
}

