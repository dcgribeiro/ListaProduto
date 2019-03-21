using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private int qtde;
        private double preco;

        public Produto()
        {
            this.codigo = -1;
            this.descricao = "";
            this.qtde = 0;
            this.preco = 0;
        }

        public Produto(int codigo,string descricao,int qtde,double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Qtde = qtde;
            this.Preco = preco;
        }

        public int Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }

        public int Qtde
        {
            get { return this.qtde; }
            set { this.qtde = value; }
        }

        public double Preco
        {
            get { return this.preco; }
            set { this.preco = value; }
        }

        public double custo()
        {
            return this.preco * this.qtde;
        }
        public override bool Equals(object obj)
        {
            return this.codigo == ((Produto)obj).codigo;
        }
    }
}
