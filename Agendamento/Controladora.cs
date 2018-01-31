using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agendamento.Interfaces;

namespace Agendamento
{
    public class Controladora
    {
        private int qtdeSolicitacoes = 0;
        public IDisplay display { get; private set; }
        private IController controladora;

        private void notificar() { }
    }
}
