using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agendamento.Interfaces;

namespace Agendamento
{
    public class LCDDisplay: IDisplay
    {
        string valorAtual;

        public void receberDados(string dados)
        {
            this.valorAtual = dados;
        }
    }
}
