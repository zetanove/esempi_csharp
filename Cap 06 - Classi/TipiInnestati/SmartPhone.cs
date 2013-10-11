using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipiInnestati
{
    public class SmartPhone
    {
        private string modello;
        private class Battery
        {
            private SmartPhone phone;
            internal Battery(SmartPhone phone)
            {
                this.phone = phone;
                
            }

            public string Modello
            {
                get
                {
                    return "Batteria per modello " + phone.modello;
                }
            }
            private double percentualeCarica;
            public enum LivelloBatteria { zero, basso, medio, alto, totale }
        }
    }

}
