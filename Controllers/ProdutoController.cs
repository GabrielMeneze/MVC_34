using System.Collections.Generic;
using MVC_34.Models;
using MVC_34.Views;

namespace MVC_34.Controllers
{
    public class ProdutoController
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void Listar()
        {
            produtoView.MostrarnoConsole(produtoModel.Ler());
        }
        public void buscar(string Preco){
           
            List<Produto> busca = produtoModel.Ler().FindAll(x => x.Preco == float.Parse(Preco));
            produtoView.MostrarnoConsole(busca);
        }

    }
}