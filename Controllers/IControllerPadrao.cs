using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesafioC5Arq.ClassePadrao;

namespace DesafioC5Arq.Controllers
{
    public interface IControllerPadrao
    {
        void LoadView(IViewPadrao view, TipoProcesso tipoProcesso);

    }
}
