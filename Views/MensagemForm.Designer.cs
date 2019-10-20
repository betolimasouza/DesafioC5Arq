namespace DesafioC5Arq.Views
{
    partial class MensagemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSalvarMensagem = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblCodAplicacao = new System.Windows.Forms.Label();
            this.txtCodAplicacao = new System.Windows.Forms.TextBox();
            this.lblTextoMsg = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataIncl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarMensagem,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(285, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSalvarMensagem
            // 
            this.tsbSalvarMensagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalvarMensagem.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvarMensagem.Image")));
            this.tsbSalvarMensagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarMensagem.Name = "tsbSalvarMensagem";
            this.tsbSalvarMensagem.Size = new System.Drawing.Size(42, 22);
            this.tsbSalvarMensagem.Text = "Salvar";
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 22);
            this.tsbCancelar.Text = "Cancelar";
            // 
            // lblCodAplicacao
            // 
            this.lblCodAplicacao.Location = new System.Drawing.Point(1, 42);
            this.lblCodAplicacao.Name = "lblCodAplicacao";
            this.lblCodAplicacao.Size = new System.Drawing.Size(80, 13);
            this.lblCodAplicacao.TabIndex = 1;
            this.lblCodAplicacao.Text = "Aplicação";
            this.lblCodAplicacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodAplicacao
            // 
            this.txtCodAplicacao.Location = new System.Drawing.Point(85, 39);
            this.txtCodAplicacao.MaxLength = 12;
            this.txtCodAplicacao.Name = "txtCodAplicacao";
            this.txtCodAplicacao.Size = new System.Drawing.Size(182, 20);
            this.txtCodAplicacao.TabIndex = 2;
            // 
            // lblTextoMsg
            // 
            this.lblTextoMsg.Location = new System.Drawing.Point(1, 71);
            this.lblTextoMsg.Name = "lblTextoMsg";
            this.lblTextoMsg.Size = new System.Drawing.Size(80, 13);
            this.lblTextoMsg.TabIndex = 3;
            this.lblTextoMsg.Text = "Texto";
            this.lblTextoMsg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 70);
            this.textBox1.MaxLength = 4000;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 169);
            this.textBox1.TabIndex = 4;
            // 
            // lblDataInicial
            // 
            this.lblDataInicial.Location = new System.Drawing.Point(1, 252);
            this.lblDataInicial.Name = "lblDataInicial";
            this.lblDataInicial.Size = new System.Drawing.Size(80, 13);
            this.lblDataInicial.TabIndex = 5;
            this.lblDataInicial.Text = "Data Inicial";
            this.lblDataInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.CustomFormat = "{0:d}";
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(85, 248);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInicial.TabIndex = 6;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.CustomFormat = "{0:d}";
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(85, 275);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(95, 20);
            this.dtpDataFinal.TabIndex = 8;
            // 
            // lblDataFinal
            // 
            this.lblDataFinal.Location = new System.Drawing.Point(1, 278);
            this.lblDataFinal.Name = "lblDataFinal";
            this.lblDataFinal.Size = new System.Drawing.Size(80, 13);
            this.lblDataFinal.TabIndex = 7;
            this.lblDataFinal.Text = "Data Final";
            this.lblDataFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatus
            // 
            this.lblStatus.Location = new System.Drawing.Point(1, 301);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chbStatus
            // 
            this.chbStatus.AutoSize = true;
            this.chbStatus.Location = new System.Drawing.Point(85, 301);
            this.chbStatus.Name = "chbStatus";
            this.chbStatus.Size = new System.Drawing.Size(15, 14);
            this.chbStatus.TabIndex = 10;
            this.chbStatus.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "{0:d}";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(85, 321);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lblDataIncl
            // 
            this.lblDataIncl.Location = new System.Drawing.Point(1, 327);
            this.lblDataIncl.Name = "lblDataIncl";
            this.lblDataIncl.Size = new System.Drawing.Size(80, 13);
            this.lblDataIncl.TabIndex = 11;
            this.lblDataIncl.Text = "Data Inclusão";
            this.lblDataIncl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(85, 347);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(1, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Usuário";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MensagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 383);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDataIncl);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTextoMsg);
            this.Controls.Add(this.txtCodAplicacao);
            this.Controls.Add(this.lblCodAplicacao);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MensagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSalvarMensagem;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Label lblCodAplicacao;
        private System.Windows.Forms.TextBox txtCodAplicacao;
        private System.Windows.Forms.Label lblTextoMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataIncl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
    }
}