using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesafioC5Arq.ClassePadrao;

namespace DesafioC5Arq.Controllers
{
    public interface IViewPadrao
    {
        void SetController(IControllerPadrao controller);

        void ShowView(IBindingList mensagens, TipoProcesso tipoProcesso);

        void SetDataBinding(IBindingList mensagens);

    }
}
