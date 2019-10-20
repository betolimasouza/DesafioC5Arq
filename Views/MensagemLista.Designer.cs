namespace DesafioC5Arq.Views
{
    partial class MensagemLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensagemLista));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.dgvMensagens = new System.Windows.Forms.DataGridView();
            this.bNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.TsbNovaMensagem = new System.Windows.Forms.ToolStripButton();
            this.TspEditarMensagem = new System.Windows.Forms.ToolStripButton();
            this.tsbExcluiMensagem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrimeiraPagina = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPaginaAnterior = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tstPaginaAtual = new System.Windows.Forms.ToolStripTextBox();
            this.tslPaginaTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbProximaPagina = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUltimaPagina = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).BeginInit();
            this.bNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvMensagens
            // 
            this.dgvMensagens.AllowUserToAddRows = false;
            this.dgvMensagens.AllowUserToDeleteRows = false;
            this.dgvMensagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMensagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMensagens.Location = new System.Drawing.Point(0, 28);
            this.dgvMensagens.MultiSelect = false;
            this.dgvMensagens.Name = "dgvMensagens";
            this.dgvMensagens.ReadOnly = true;
            this.dgvMensagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMensagens.Size = new System.Drawing.Size(800, 420);
            this.dgvMensagens.TabIndex = 0;
            this.dgvMensagens.SelectionChanged += new System.EventHandler(this.DgvMensagens_SelectionChanged);
            this.dgvMensagens.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvMensagens_MouseDoubleClick);
            // 
            // bNavigator
            // 
            this.bNavigator.AddNewItem = null;
            this.bNavigator.CountItem = null;
            this.bNavigator.DeleteItem = null;
            this.bNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNovaMensagem,
            this.TspEditarMensagem,
            this.tsbExcluiMensagem,
            this.bindingNavigatorSeparator2,
            this.tsbPrimeiraPagina,
            this.toolStripSeparator2,
            this.tsbPaginaAnterior,
            this.toolStripSeparator4,
            this.tstPaginaAtual,
            this.tslPaginaTotal,
            this.toolStripSeparator3,
            this.tsbProximaPagina,
            this.bindingNavigatorSeparator,
            this.tsbUltimaPagina,
            this.toolStripSeparator1});
            this.bNavigator.Location = new System.Drawing.Point(0, 0);
            this.bNavigator.MoveFirstItem = null;
            this.bNavigator.MoveLastItem = null;
            this.bNavigator.MoveNextItem = null;
            this.bNavigator.MovePreviousItem = null;
            this.bNavigator.Name = "bNavigator";
            this.bNavigator.PositionItem = null;
            this.bNavigator.Size = new System.Drawing.Size(800, 25);
            this.bNavigator.TabIndex = 2;
            this.bNavigator.Text = "bindingNavigator1";
            // 
            // TsbNovaMensagem
            // 
            this.TsbNovaMensagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsbNovaMensagem.Image = ((System.Drawing.Image)(resources.GetObject("TsbNovaMensagem.Image")));
            this.TsbNovaMensagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNovaMensagem.Name = "TsbNovaMensagem";
            this.TsbNovaMensagem.Size = new System.Drawing.Size(101, 22);
            this.TsbNovaMensagem.Text = "Nova Mensagem";
            this.TsbNovaMensagem.Click += new System.EventHandler(this.TsbNovaMensagem_Click);
            // 
            // TspEditarMensagem
            // 
            this.TspEditarMensagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TspEditarMensagem.Image = ((System.Drawing.Image)(resources.GetObject("TspEditarMensagem.Image")));
            this.TspEditarMensagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TspEditarMensagem.Name = "TspEditarMensagem";
            this.TspEditarMensagem.Size = new System.Drawing.Size(103, 22);
            this.TspEditarMensagem.Text = "Editar Mensagem";
            this.TspEditarMensagem.Click += new System.EventHandler(this.TspEditarMensagem_Click);
            // 
            // tsbExcluiMensagem
            // 
            this.tsbExcluiMensagem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbExcluiMensagem.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcluiMensagem.Image")));
            this.tsbExcluiMensagem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExcluiMensagem.Name = "tsbExcluiMensagem";
            this.tsbExcluiMensagem.Size = new System.Drawing.Size(108, 22);
            this.tsbExcluiMensagem.Text = "Excluir Mensagem";
            this.tsbExcluiMensagem.Click += new System.EventHandler(this.TsbExcluiMensagem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPrimeiraPagina
            // 
            this.tsbPrimeiraPagina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimeiraPagina.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrimeiraPagina.Image")));
            this.tsbPrimeiraPagina.Name = "tsbPrimeiraPagina";
            this.tsbPrimeiraPagina.RightToLeftAutoMirrorImage = true;
            this.tsbPrimeiraPagina.Size = new System.Drawing.Size(23, 22);
            this.tsbPrimeiraPagina.Text = "Move first";
            this.tsbPrimeiraPagina.Click += new System.EventHandler(this.TsbPrimeiraPagina_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbPaginaAnterior
            // 
            this.tsbPaginaAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaginaAnterior.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaginaAnterior.Image")));
            this.tsbPaginaAnterior.Name = "tsbPaginaAnterior";
            this.tsbPaginaAnterior.RightToLeftAutoMirrorImage = true;
            this.tsbPaginaAnterior.Size = new System.Drawing.Size(23, 22);
            this.tsbPaginaAnterior.Text = "Move previous";
            this.tsbPaginaAnterior.Click += new System.EventHandler(this.TsbPaginaAnterior_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tstPaginaAtual
            // 
            this.tstPaginaAtual.AccessibleName = "Position";
            this.tstPaginaAtual.AutoSize = false;
            this.tstPaginaAtual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstPaginaAtual.Name = "tstPaginaAtual";
            this.tstPaginaAtual.Size = new System.Drawing.Size(50, 23);
            this.tstPaginaAtual.Text = "1";
            this.tstPaginaAtual.ToolTipText = "Atual";
            // 
            // tslPaginaTotal
            // 
            this.tslPaginaTotal.Name = "tslPaginaTotal";
            this.tslPaginaTotal.Size = new System.Drawing.Size(37, 22);
            this.tslPaginaTotal.Text = "de {0}";
            this.tslPaginaTotal.ToolTipText = "Total number of items";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbProximaPagina
            // 
            this.tsbProximaPagina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProximaPagina.Image = ((System.Drawing.Image)(resources.GetObject("tsbProximaPagina.Image")));
            this.tsbProximaPagina.Name = "tsbProximaPagina";
            this.tsbProximaPagina.RightToLeftAutoMirrorImage = true;
            this.tsbProximaPagina.Size = new System.Drawing.Size(23, 22);
            this.tsbProximaPagina.Text = "Move next";
            this.tsbProximaPagina.Click += new System.EventHandler(this.TsbProximaPagina_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbUltimaPagina
            // 
            this.tsbUltimaPagina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUltimaPagina.Image = ((System.Drawing.Image)(resources.GetObject("tsbUltimaPagina.Image")));
            this.tsbUltimaPagina.Name = "tsbUltimaPagina";
            this.tsbUltimaPagina.RightToLeftAutoMirrorImage = true;
            this.tsbUltimaPagina.Size = new System.Drawing.Size(23, 22);
            this.tsbUltimaPagina.Text = "Move last";
            this.tsbUltimaPagina.Click += new System.EventHandler(this.TsbUltimaPagina_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // MensagemLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNavigator);
            this.Controls.Add(this.dgvMensagens);
            this.Name = "MensagemLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagens";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvMensagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNavigator)).EndInit();
            this.bNavigator.ResumeLayout(false);
            this.bNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.DataGridView dgvMensagens;
        private System.Windows.Forms.BindingNavigator bNavigator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bSource;
        private System.Windows.Forms.ToolStripButton TsbNovaMensagem;
        private System.Windows.Forms.ToolStripButton TspEditarMensagem;
        private System.Windows.Forms.ToolStripButton tsbExcluiMensagem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPrimeiraPagina;
        private System.Windows.Forms.ToolStripButton tsbPaginaAnterior;
        private System.Windows.Forms.ToolStripTextBox tstPaginaAtual;
        private System.Windows.Forms.ToolStripLabel tslPaginaTotal;
        private System.Windows.Forms.ToolStripButton tsbProximaPagina;
        private System.Windows.Forms.ToolStripButton tsbUltimaPagina;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}