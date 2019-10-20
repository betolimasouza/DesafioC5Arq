using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioC5Arq.Controllers;
using DesafioC5Arq.Models;
using static DesafioC5Arq.ClassePadrao;

namespace DesafioC5Arq.Views
{
    public partial class MensagemLista : Form, IViewPadrao
    {

        MensagemController msgController;

        int itensPagina = 25;
        int paginaAtual = 1;
        int totalPaginas;

        public MensagemLista()
        {
            InitializeComponent();
        }

        #region Interface
        public void SetController(IControllerPadrao controller)
        {
            msgController = (MensagemController)controller;
        }

        public void SetDataBinding(IBindingList mensagens)
        {
            int.TryParse(tstItensPagina.Text, out itensPagina);

            bSource.DataSource = ((BindingList<Mensagem>)mensagens).Skip(itensPagina * (paginaAtual - 1)).Take(itensPagina);

            //Calcula numero total de páginas
            totalPaginas = ((mensagens.Count - 1) / itensPagina + 1);
            tslPaginaTotal.Text = "de " + totalPaginas;

            dgvMensagens.DataSource =  bSource;
        }

        public void ShowView(IBindingList mensagens, TipoProcesso tipoProcesso)
        {
            SetDataBinding(mensagens);
            ShowDialog();
        }
        
        #endregion

        #region Eventos Controles

        private void TsbNovaMensagem_Click(object sender, EventArgs e)
        {
            msgController.NovaMensagem();
            msgController.RefreshView(this);
        }

        private void DgvMensagens_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMensagens.SelectedRows.Count > 0)
            {
                msgController.SelecionaMensagem((Mensagem)dgvMensagens.SelectedRows[0].DataBoundItem);
            }
        }

        private void TsbExcluiMensagem_Click(object sender, EventArgs e)
        {
            msgController.ExcluiMensagem();
        }

        private void DgvMensagens_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void TspEditarMensagem_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            msgController.EditarMensagem();
            msgController.RefreshView(this);
        }
        
        #endregion

        #region Paginação


        private void Paginar(int pagina)
        {
            paginaAtual = pagina;
            tstPaginaAtual.Text = pagina.ToString();
            msgController.RefreshView(this);
        }


        private void TsbPrimeiraPagina_Click(object sender, EventArgs e)
        {
            Paginar(1);
        }

        private void TsbPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (paginaAtual > 0) Paginar(paginaAtual - 1);
        }

        private void TsbProximaPagina_Click(object sender, EventArgs e)
        {
            if (paginaAtual  < totalPaginas) Paginar(paginaAtual + 1);
        }

        private void TsbUltimaPagina_Click(object sender, EventArgs e)
        {
            Paginar(totalPaginas);
        }

        private void TstItensPagina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TsbReload_Click(object sender, EventArgs e)
        {
            Paginar(1);
        }

        private void TstItensPagina_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstItensPagina.Text)) tstItensPagina.Text = "25";
        }

        #endregion

        private void TsbBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
