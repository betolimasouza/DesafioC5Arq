using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioC5Arq.Models;
using DesafioC5Arq.Views;
using static DesafioC5Arq.ClassePadrao;

namespace DesafioC5Arq.Controllers
{
    public class MensagemController : IControllerPadrao
    {
        
        BindingList<Mensagem> mensagens;
        Mensagem msgSelecionada;

        public MensagemController()
        {
            BindingList<Mensagem> msgs = new DataAccess().Conectar(100);
            mensagens = msgs;
        }

        #region Load

        public void LoadView(IViewPadrao view, TipoProcesso tipoProcesso)
        {
            view.SetController(this);
            view.ShowView(mensagens, tipoProcesso);
        }

        public void LoadLista()
        {
            var lista = new MensagemLista();
            LoadView(lista, TipoProcesso.Listagem);
        }

        public void LoadForm(TipoProcesso tipoProcesso)
        {
            var form = new MensagemForm();
            LoadView(form, tipoProcesso);
        }

        public void RefreshView(IViewPadrao view)
        {
            view.SetDataBinding(mensagens);
        }

        #endregion

        #region Processos

        #region Mensagem Selecionada na Listagem

        public void SelecionaMensagem(Mensagem selMsg)
        {
            msgSelecionada = selMsg;
        }

        public int IndexMsgSelecionada()
        {
            return mensagens.IndexOf(msgSelecionada);
        }

        #endregion

        #region Insert
        public void NovaMensagem()
        {
            LoadForm(TipoProcesso.Inserir);
        }

        internal void InserirMensagem(Mensagem msg)
        {
            mensagens.Add(msg);
        }

        #endregion

        public void EditarMensagem()
        {
            LoadForm(TipoProcesso.Editar);
        }

        internal void ExcluiMensagem()
        {
            if (msgSelecionada != null)
            {
                DialogResult result = MessageBox.Show("Deseja excluir a mensagem selecionada?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                mensagens.Remove(msgSelecionada);
            }
        }

        internal bool ValidaMensagem(Mensagem msg)
        {

            var erros = msg.Validate(new ValidationContext(msg));
            if (erros.Any())
            {
                MessageBox.Show(string.Join("\n", erros.Select(a => a.ErrorMessage)));
                return false;
            }

            return true;
        }

        #endregion

    }
}
