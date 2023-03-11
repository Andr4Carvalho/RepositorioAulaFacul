using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Noite
{
    public class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(string rua, string numero, string bairro, string cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
            Estado = estado;
        }

        public void setRua(string rua) { Rua = rua; }
        public void setNumero(string numero) {  Numero = numero; }
        public void setBairro(string bairro) { Bairro = bairro;  }
        public void setCep(string cep) {  Cep = cep; }
        public void setCidade(string cidade) { Cidade = cidade; }
        public void setEstado(string estado) { Estado = estado; }

        public string getRua() { return Rua; }
        public string getNumero() {  return Numero; }
        public string getBairro() {  return Bairro; }
        public string getCep() { return Cep; }
        public string getCidade() {  return Cidade; }
        public string getEstado() {  return Estado; }
    }
}
