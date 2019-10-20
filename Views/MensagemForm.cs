using DesafioC5Arq.Controllers;
using DesafioC5Arq.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DesafioC5Arq.ClassePadrao;

namespace DesafioC5Arq.Views
{
    public partial class MensagemForm : Form, IViewPadrao
    {
        MensagemController _msgController;
        TipoProcesso _tipoProcesso;

        public MensagemForm()
        {
            InitializeComponent();
        }

        #region Interface

        public void SetController(IControllerPadrao controller)
        {
            _msgController = (MensagemController)controller;
        }

        public void SetDataBinding(IBindingList mensagens)
        {
            if (_tipoProcesso == TipoProcesso.Editar)
            {
                //Seta o binding source para a coleção completa, para uso com o Navigator
                bsForm.DataSource = mensagens;
                bsForm.Position = _msgController.IndexMsgSelecionada();
                //Seta o navigator
                bnForm.BindingSource = bsForm;
            }
            else
            {
                bsForm.DataSource = new Mensagem().NovaMensagem();
            }


            //Seta os bindings do formulário
            txtCodAplicacao.DataBindings.Add(new Binding("Text", bsForm, "CodAplicacao"));
            txtTextoMensagem.DataBindings.Add(new Binding("Text", bsForm, "TextoMensagem"));
            dtpDataInicial.DataBindings.Add(new Binding("Value", bsForm, "DataInicial"));
            dtpDataFinal.DataBindings.Add(new Binding("Value", bsForm, "DataFinal"));
            dtpDataInclusao.DataBindings.Add(new Binding("Value", bsForm, "DataInclusao"));
            txtUsuarioInclusao.DataBindings.Add(new Binding("Text", bsForm, "UsuarioInclusao"));
            chbStatus.DataBindings.Add(new Binding("Checked", bsForm, "Status"));
        }

        public void ShowView(IBindingList mensagens, TipoProcesso tipoProcesso)
        {
            _tipoProcesso = tipoProcesso;
            SetDataBinding(mensagens);
            ShowDialog();
        }

        #endregion

        #region Eventos Controles
        private void TsbCancelar_Click(object sender, EventArgs e)
        {
            bsForm.CancelEdit();
            Close();
        }

        private void TsbSalvarMensagem_Click(object sender, EventArgs e)
        {
            if (_msgController.ValidaMensagem((Mensagem)bsForm.Current))
            {
                if (_tipoProcesso == TipoProcesso.Inserir)
                    _msgController.InserirMensagem((Mensagem)bsForm.Current);

                bsForm.EndEdit();
                Close();
            }
        }
        
        #endregion

    }
}
