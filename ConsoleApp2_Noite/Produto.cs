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

        public decimal getValor()
        {
            return Valor;
        }

        public int getId()
        {
            return Id;
        }
    }
}
