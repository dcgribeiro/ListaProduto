using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produtos
    {
        List<Produto> listaProdutos ;

        public List<Produto> ListaProdutos { get => listaProdutos; set => listaProdutos = value; }

        public Produtos()
        {
            this.ListaProdutos = new List<Produto>();
        }


        public void adicionar(Produto p)
        {
            this.ListaProdutos.Add(p);
        }

        public bool remover(Produto p)
        {
           Produto resultado =  this.pesquisar(p);
           if(resultado.Codigo < 0)
            {
                return false;
            }
            else
            {
                this.ListaProdutos.Remove(resultado);
                return true;
            }

        }

        public Produto pesquisar(Produto p)
        {
            foreach(Produto elemento in this.ListaProdutos)
            {
                if(elemento.Equals(p))
                {
                    return elemento;
                }
            }

            return new Produto();
            
        }

        public double custoTotal()
        {
            double custo = 0;

            foreach(Produto elemento in this.ListaProdutos)
            {
                custo += elemento.custo();
            }
            return custo;
        }
    }
}
