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
          
            //Inicia o controller
            MensagemController controller = new MensagemController();

            //Inicia listagem
            controller.LoadLista();
        }
    }
}
