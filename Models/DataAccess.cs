using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioC5Arq.Models
{
    public class DataAccess
    {
        //BindingList pra uso com o DataViewGrid da listagem principal (INotifyPropertyChanged)
        public BindingList<Mensagem> msgs = new BindingList<Mensagem>();

        public BindingList<Mensagem> Conectar(int NroItens)
        {
            if (NroItens > 0)
                InsereItensTeste(NroItens);
            return msgs;
        }

        private void InsereItensTeste(int NroItens)
        {
            int i;
            for (i = 1; i <= NroItens; i++)
            {
                msgs.Add(new Mensagem() { CodAplicacao = i.ToString(),
                                          DataInicial = DateTime.Now,
                                          DataFinal = DateTime.Now.AddDays(30 * i),
                                          DataInclusao = DateTime.Now,
                                          Status =  (i % 2 == 0),
                                          TextoMensagem = Path.GetRandomFileName(),
                                          UsuarioInclusao = Environment.UserName });
            }
        }
    }
}
