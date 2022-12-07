using HSA_Estoque.Model;
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
            
            Presenter.Produto produto= new Presenter.Produto();
            produto.id = 603061285;
            produto.descricao = "PA QUADRADA CABO Y P/ CONSTRUCAO HORTA ENTULHO REFORCADO";
            produto.tipo = "FERRAMENTAS";
            produto.unidade = "PÇ";
            produto.quantidadeTotal = 1;
            produto.localizacao = "ALMOXARIFADO";
            Console.WriteLine(produto.add());

            Console.ReadLine();
            //Application.Run(new FormMain());
        }
    }
}
