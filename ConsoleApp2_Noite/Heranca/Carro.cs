using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_Noite.Heranca
{
    public class Carro : Veiculo
    {
        public bool cintoSeguranca;

        public string ExibirDados()
        {
            return "Tem cinto: " + (cintoSeguranca ? "SIM" : "NÃO") + " Assentos: " + numAssentos + " Portas: " + numPortas + " Motor: " + (temMotor ? "SIM" : "NÃO");
        }
    }
}
