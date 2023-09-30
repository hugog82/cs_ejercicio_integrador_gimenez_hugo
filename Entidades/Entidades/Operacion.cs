using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion PrimerOperando
        {
            get 
            { 
                return this.primerOperando; 
            }
            set 
            { 
                this.primerOperando = value; 
            }

        }
        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }

        public Numeracion Operar (char operador)
        {
            switch (operador)
            {
                case '+':
                    return PrimerOperando + SegundoOperando;
                case '-':
                    return PrimerOperando - SegundoOperando;
                case '*':
                    return PrimerOperando * SegundoOperando;
                case '/':
                    return PrimerOperando / SegundoOperando;
                default:
                    return PrimerOperando + SegundoOperando;
            }
        }
    }
    

}
