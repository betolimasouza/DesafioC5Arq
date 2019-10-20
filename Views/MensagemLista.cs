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

        int vnItensPagina = 25;
        int vnPaginaAtual = 1;
        int vnTotalPaginas;

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
            bSource.DataSource = ((BindingList<Mensagem>)mensagens).Skip(vnItensPagina * (vnPaginaAtual - 1) ).Take(vnItensPagina);
            
            //Calcula numero total de páginas
            vnTotalPaginas = (int)Math.Ceiling((double)(mensagens.Count / vnItensPagina));
            tslPaginaTotal.Text = "de " + vnTotalPaginas;

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
            vnPaginaAtual = pagina;
            tstPaginaAtual.Text = pagina.ToString();
            msgController.RefreshView(this);
        }


        private void TsbPrimeiraPagina_Click(object sender, EventArgs e)
        {
            Paginar(1);
        }

        private void TsbPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (vnPaginaAtual > 0) Paginar(vnPaginaAtual - 1);
        }

        private void TsbProximaPagina_Click(object sender, EventArgs e)
        {
            if (vnPaginaAtual  < vnTotalPaginas) Paginar(vnPaginaAtual + 1);
        }

        private void TsbUltimaPagina_Click(object sender, EventArgs e)
        {
            Paginar(vnTotalPaginas);
        }

        #endregion
    }
}
