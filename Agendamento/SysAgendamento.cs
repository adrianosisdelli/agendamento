using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendamento
{
    public class SysAgendamento
    {
        public Controladora controladora { get; private set; }

        public SysAgendamento()
        {
            this.controladora = new Controladora();
        }
    }
}
