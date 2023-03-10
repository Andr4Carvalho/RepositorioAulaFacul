using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Noite
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }

        public int GetId()
        {
            return Id;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCpf() {
            return Cpf;
        }
    }
}
