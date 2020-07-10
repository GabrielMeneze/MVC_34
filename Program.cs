using System;
using MVC_34.Controllers;
using MVC_34.Models;

namespace MVC_34
{

    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.buscar("55");
        }
    }
}
