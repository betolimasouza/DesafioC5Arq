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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemForm));
            this.lblCodAplicacao = new System.Windows.Forms.Label();
            this.txtCodAplicacao = new System.Windows.Forms.TextBox();
            this.lblTextoMsg = new System.Windows.Forms.Label();
            this.txtTextoMensagem = new System.Windows.Forms.TextBox();
            this.lblDataInicial = new System.Windows.Forms.Label();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.lblDataFinal = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chbStatus = new System.Windows.Forms.CheckBox();
            this.dtpDataInclusao = new System.Windows.Forms.DateTimePicker();
            this.lblDataIncl = new System.Windows.Forms.Label();
            this.txtUsuarioInclusao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsForm = new System.Windows.Forms.BindingSource(this.components);
            this.bnForm = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalvarMensagem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnForm)).BeginInit();
            this.bnForm.SuspendLayout();
            this.SuspendLayout();
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
            // txtTextoMensagem
            // 
            this.txtTextoMensagem.Location = new System.Drawing.Point(85, 70);
            this.txtTextoMensagem.MaxLength = 4000;
            this.txtTextoMensagem.Multiline = true;
            this.txtTextoMensagem.Name = "txtTextoMensagem";
            this.txtTextoMensagem.Size = new System.Drawing.Size(181, 169);
            this.txtTextoMensagem.TabIndex = 4;
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
            this.dtpDataFinal.Checked = false;
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
            // dtpDataInclusao
            // 
            this.dtpDataInclusao.CustomFormat = "{0:d}";
            this.dtpDataInclusao.Enabled = false;
            this.dtpDataInclusao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInclusao.Location = new System.Drawing.Point(85, 321);
            this.dtpDataInclusao.Name = "dtpDataInclusao";
            this.dtpDataInclusao.Size = new System.Drawing.Size(95, 20);
            this.dtpDataInclusao.TabIndex = 12;
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
            // txtUsuarioInclusao
            // 
            this.txtUsuarioInclusao.Enabled = false;
            this.txtUsuarioInclusao.Location = new System.Drawing.Point(85, 347);
            this.txtUsuarioInclusao.MaxLength = 12;
            this.txtUsuarioInclusao.Name = "txtUsuarioInclusao";
            this.txtUsuarioInclusao.Size = new System.Drawing.Size(181, 20);
            this.txtUsuarioInclusao.TabIndex = 14;
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
            // bnForm
            // 
            this.bnForm.AddNewItem = null;
            this.bnForm.CountItem = this.bindingNavigatorCountItem;
            this.bnForm.DeleteItem = null;
            this.bnForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalvarMensagem,
            this.tsbCancelar,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnForm.Location = new System.Drawing.Point(0, 0);
            this.bnForm.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnForm.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnForm.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnForm.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnForm.Name = "bnForm";
            this.bnForm.PositionItem = this.bindingNavigatorPositionItem;
            this.bnForm.Size = new System.Drawing.Size(362, 25);
            this.bnForm.TabIndex = 15;
            this.bnForm.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(57, 22);
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.Click += new System.EventHandler(this.TsbCancelar_Click);
            // 
            // tsbSalvarMensagem
            // 
            this.tsbSalvarMensagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSalvarMensagem.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalvarMensagem.Image")));
            this.tsbSalvarMensagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalvarMensagem.Name = "tsbSalvarMensagem";
            this.tsbSalvarMensagem.Size = new System.Drawing.Size(42, 22);
            this.tsbSalvarMensagem.Text = "Salvar";
            this.tsbSalvarMensagem.Click += new System.EventHandler(this.TsbSalvarMensagem_Click);
            // 
            // MensagemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 383);
            this.Controls.Add(this.bnForm);
            this.Controls.Add(this.txtUsuarioInclusao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataInclusao);
            this.Controls.Add(this.lblDataIncl);
            this.Controls.Add(this.chbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.lblDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.lblDataInicial);
            this.Controls.Add(this.txtTextoMensagem);
            this.Controls.Add(this.lblTextoMsg);
            this.Controls.Add(this.txtCodAplicacao);
            this.Controls.Add(this.lblCodAplicacao);
            this.Name = "MensagemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagem";
            ((System.ComponentModel.ISupportInitialize)(this.bsForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnForm)).EndInit();
            this.bnForm.ResumeLayout(false);
            this.bnForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodAplicacao;
        private System.Windows.Forms.TextBox txtCodAplicacao;
        private System.Windows.Forms.Label lblTextoMsg;
        private System.Windows.Forms.TextBox txtTextoMensagem;
        private System.Windows.Forms.Label lblDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Label lblDataFinal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chbStatus;
        private System.Windows.Forms.DateTimePicker dtpDataInclusao;
        private System.Windows.Forms.Label lblDataIncl;
        private System.Windows.Forms.TextBox txtUsuarioInclusao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsForm;
        private System.Windows.Forms.BindingNavigator bnForm;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton tsbSalvarMensagem;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}