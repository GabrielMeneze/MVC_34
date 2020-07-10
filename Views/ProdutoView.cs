using System;
using System.Collections.Generic;
using MVC_34.Models;

namespace MVC_34.Views
{
    public class ProdutoView
    {
        public void MostrarnoConsole(List<Produto> lista){
            foreach(Produto item in lista)
            {
                Console.WriteLine($" {item.Nome} - {item.Preco} ");
            }
        }
    }


}