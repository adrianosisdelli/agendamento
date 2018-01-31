using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agendamento.Interfaces;

namespace Agendamento
{
    public class PTextbox : IDisplay
    {
        private string leituraAtual;

        public void receberDados(string dados)
        {
            this.leituraAtual = dados;
        }
    }
}
