using HSA_Estoque.Model;
using HSA_Estoque.View;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
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

            var adminUser = todosUsuarios.Find(u => u.nome.ToUpper().Equals(Environment.UserName.ToUpper()));

            if (adminUser == null)
            {
                MessageBox.Show("Seu usuário não tem permissão para consultar o estoque de consumiveis.\n" +
                                "Solicite acesso com o almoxarifado.\n"+
                                $"Usuário: {Environment.UserName.ToUpper()}", 
                                "USUÁRIO NÃO PERMITIDO", 
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
                Application.Exit();
            }

            if (adminUser.isAdmin)
            {
                Application.Run(new FormMain(new Presenter.Produto()));
            }
            else
            {
                Application.Run(new FormViewProdutos(new Presenter.Produto()));
            }
            //Application.Run(new View.FormSaidaProduto());
        }
    }
}
