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
        
        BindingList<Mensagem> _mensagens;
        Mensagem _msgSelecionada;

        public MensagemController()
        {
            BindingList<Mensagem> msgs = new DataAccess().Conectar(100);
            _mensagens = msgs;
        }

        #region Load

        public void LoadView(IViewPadrao view, TipoProcesso tipoProcesso)
        {
            view.SetController(this);
            view.ShowView(_mensagens, tipoProcesso);
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
            view.SetDataBinding(_mensagens);
        }

        #endregion

        #region Processos

        #region Mensagem Selecionada na Listagem

        public void SelecionaMensagem(Mensagem selMsg)
        {
            _msgSelecionada = selMsg;
        }

        public int IndexMsgSelecionada()
        {
            return _mensagens.IndexOf(_msgSelecionada);
        }

        #endregion

        #region Insert
        public void NovaMensagem()
        {
            LoadForm(TipoProcesso.Inserir);
        }

        internal void InserirMensagem(Mensagem msg)
        {
            _mensagens.Add(msg);
        }

        #endregion

        public void EditarMensagem()
        {
            LoadForm(TipoProcesso.Editar);
        }

        internal void ExcluiMensagem()
        {
            if (_msgSelecionada != null)
            {
                DialogResult result = MessageBox.Show("Deseja excluir a mensagem selecionada?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                _mensagens.Remove(_msgSelecionada);
            }
        }

        internal bool ValidaMensagem(Mensagem msg)
        {

            return true;

            //var erros = msg.Validate(new ValidationContext(msg));
            //if (erros.Any())
            //{
            //    MessageBox.Show(string.Join("\n", erros.Select(a => a.ErrorMessage)));
            //    return false;
            //}

            //return true;
        }

        #endregion

    }
}
