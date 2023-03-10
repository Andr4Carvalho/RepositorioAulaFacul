using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Noite
{
    public class Produto
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public string? Descricao { get; set; }

        public Produto(int id, decimal valor, string? descricao)
        {
            Id = id;
            Valor = valor;
            Descricao = descricao;
        }

        public string getDescricao()
        {
            return Descricao;
        }
        public void setDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public decimal getValor()
        {
            return Valor;
        }

        public void setValor(decimal valor)
        {
            Valor = valor;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }
    }
}
