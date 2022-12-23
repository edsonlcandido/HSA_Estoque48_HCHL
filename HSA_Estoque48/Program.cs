﻿using HSA_Estoque.Model;
using HSA_Estoque.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSA_Estoque
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var todosUsuarios = new Presenter.Usuario().showAll;


            Application.Run(new FormViewProdutos(new Presenter.Produto()));
            //Application.Run(new View.FormSaidaProduto());
        }
    }
}
