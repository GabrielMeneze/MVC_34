using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_34.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome  { get; set; }
        public float Preco { get; set; }

        public const string PATH = "Database/produto.csv";


        public List<Produto> Ler()
        {
            List<Produto> prod = new List<Produto>();
            

            string[] linhas = File.ReadAllLines(PATH);
            
            foreach(string linha in linhas)
            {
                string[] dado = linha.Split(';');
                Produto produto = new Produto();
                
                produto.Codigo = Int32.Parse(separar(dado[0]));
                produto.Nome = (separar(dado[1]));
                produto.Preco = Int32.Parse(separar(dado[2]));

                prod.Add(produto);
            }
            return prod;
        }
        public string separar(string dado)
        {
            return dado.Split('=')[1];
        }


    }
}