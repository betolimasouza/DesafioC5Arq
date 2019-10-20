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


namespace DesafioC5Arq.Views
{
    public partial class MensagemLista : Form, IViewPadrao
    {

        MensagemListController msgController;

        int vnItensPagina = 15;
        int vnPaginaAtual = 1;
        int vnTotalPaginas;
    

        public MensagemLista()
        {
            InitializeComponent();

            
        }

        public void ClearGrid()
        {
            dgvMensagens.Rows.Clear();
        }


        #region Interface
        public void SetController(IControllerPadrao controller)
        {
            msgController = (MensagemListController)controller;
        }

        public void SetDataBinding(IBindingList mensagens)
        {
            bSource.DataSource = ((BindingList<Mensagem>)mensagens);
            vnTotalPaginas = mensagens.Count / vnItensPagina;
            dgvMensagens.DataSource =  bSource;
        }

        private void LoadList()
        {
            
        }





        #endregion

        private void TsbNovaMensagem_Click(object sender, EventArgs e)
        {
            msgController.NovaMensagem(new Mensagem());
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

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }
    }
}
