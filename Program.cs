using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesafioC5Arq.Views;
using DesafioC5Arq.Controllers;
using System.ComponentModel;
using DesafioC5Arq.Models;

namespace DesafioC5Arq
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MensagemLista());

            MensagemLista view = new MensagemLista();
            view.Visible = false;

            //Inicia coleção vazia
            //BindingList para o DataGridView enxergar as mudanças na coleção (INotifyPropertyChanged)
            BindingList<Mensagem> msgs = new BindingList<Mensagem>();

            //Inicia o controller
            MensagemListController controller = new MensagemListController(view, msgs);

            //Dados de teste
            controller.InsereItensTeste();
            
            controller.LoadView();
            view.ShowDialog();


        }
    }
}
