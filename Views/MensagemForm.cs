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
        MensagemController msgController;
        TipoProcesso tipoProcesso;

        public MensagemForm()
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
            if (tipoProcesso == TipoProcesso.Editar)
            {
                //Seta o binding source para a coleção completa, para uso com o Navigator
                bsForm.DataSource = mensagens;
                bsForm.Position = msgController.IndexMsgSelecionada();
              
                //Seta o navigator
                bnForm.BindingSource = bsForm;
            }
            else
            {
                bsForm.DataSource = new Mensagem().NovaMensagem();
            }


            //Seta os bindings do formulário
            txtCodAplicacao.DataBindings.Add(new Binding("Text", bsForm, "CodAplicacao", false, DataSourceUpdateMode.OnPropertyChanged));
            txtTextoMensagem.DataBindings.Add(new Binding("Text", bsForm, "TextoMensagem", false, DataSourceUpdateMode.OnPropertyChanged));
            dtpDataInicial.DataBindings.Add(new Binding("Value", bsForm, "DataInicial", false, DataSourceUpdateMode.OnPropertyChanged));
            dtpDataFinal.DataBindings.Add(new Binding("Value", bsForm, "DataFinal", false, DataSourceUpdateMode.OnPropertyChanged));
            dtpDataInclusao.DataBindings.Add(new Binding("Value", bsForm, "DataInclusao", false, DataSourceUpdateMode.OnPropertyChanged));
            txtUsuarioInclusao.DataBindings.Add(new Binding("Text", bsForm, "UsuarioInclusao", false, DataSourceUpdateMode.OnPropertyChanged));
            chbStatus.DataBindings.Add(new Binding("Checked", bsForm, "Status", false, DataSourceUpdateMode.OnPropertyChanged));

            
        }

        public void ShowView(IBindingList mensagens, TipoProcesso tipoProcesso)
        {
            this.tipoProcesso = tipoProcesso;
            SetDataBinding(mensagens);
            ShowDialog();
        }

        #endregion

        #region Eventos Controles
       
        private void TsbSalvarMensagem_Click(object sender, EventArgs e)
        {
            if (msgController.ValidaMensagem((Mensagem)bsForm.Current))
            {
                if (tipoProcesso == TipoProcesso.Inserir)
                    msgController.InserirMensagem((Mensagem)bsForm.Current);

                bsForm.EndEdit();
                Close();
            }
        }
        
        #endregion

    }
}
