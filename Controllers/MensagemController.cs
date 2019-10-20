using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioC5Arq.Models;

namespace DesafioC5Arq.Controllers
{
    public class MensagemListController : IControllerPadrao
    {
        IViewPadrao _view;
        BindingList<Mensagem> _mensagens;
        Mensagem _msgSelecionada;


        public MensagemListController(IViewPadrao view, BindingList<Mensagem> msgs)
        {
            _view = view;
            _mensagens = msgs;
            view.SetController(this);
        }

        public void LoadView()
        {
            _view.SetDataBinding(_mensagens);
        }

        public void SelecionaMensagem(Mensagem selMsg)
        {
            _msgSelecionada = selMsg;
        }

        public void NovaMensagem(Mensagem newMsg)
        {
            
        }

        private void AbreMensagemForm(Mensagem msg)
        {
            
        }

        public void InsereItensTeste()
        {
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
            _mensagens.Add(new Mensagem() { CodAplicacao = "001", DataInicial = DateTime.Now, DataFinal = DateTime.Now.AddDays(30), DataInclusao = DateTime.Now, StatusMSG = Mensagem.TipoStatus.Ativo, TextoMensagem = "TST", UsuarioInclusao = Environment.UserName });
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
    }
}
