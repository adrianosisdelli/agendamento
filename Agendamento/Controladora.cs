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
        private string nome;
        private int qtdeSolicitacoes = 0;
        private IController controladora;

        public Controladora(string vNome)
        {
            this.nome = vNome;
        }

        public string getNome()
        {
            this.qtdeSolicitacoes++;

            return this.nome;
        }

    }
}
