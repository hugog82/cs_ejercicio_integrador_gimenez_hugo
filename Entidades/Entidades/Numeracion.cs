namespace Entidades
{
    public enum ESistema
    {
        Decimal,Binario
    }
    public class Numeracion
    {
        //ATRIBUTOS
        private ESistema sistema;
        private double valorNumerico;

        //PROPIEDADES
        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }
        public double Valor
        {
            get
            {
                return this.valorNumerico;
            }
        }
        //CONSTRUCTORES
        public Numeracion(ESistema sistema, double valorNumerico)
        {
            this.sistema = sistema;
            InicializarValores(valorNumerico.ToString(), sistema);
        }
        public Numeracion(ESistema sistema, string valorNumerico)
        {
            this.sistema = sistema;
            InicializarValores(valorNumerico, sistema);
        }

        //METODOS
        private void InicializarValores(string valor, ESistema sistema)
        {
            if (sistema == ESistema.Binario && EsBinario(valor))
            {
                valorNumerico = BinarioADecimal(valor);
            }
            else if (int.TryParse(valor, out int valorDecimal))
            {
                valorNumerico = valorDecimal;
            }
            else
            {
                valorNumerico = double.MinValue;
            }
        }
        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Decimal)
            {
                return valorNumerico.ToString();
            }
            else
            {
                return DecimalABinario((int)valorNumerico);
            }
        }
        private bool EsBinario(string valor)//comprobar que no se use ||
        {
            foreach (var caracter in valor)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }
        private double BinarioADecimal(string valor)
        {
            double retorno = 0;
            int cantCaracteres = valor.Length;

            if (EsBinario(valor))
            {
                foreach (var caracter in valor)
                {
                    cantCaracteres--;
                    if (caracter == '1')
                    {
                        retorno += (int)Math.Pow(2, cantCaracteres);
                    }
                }
            }
            return retorno;
        }
        private string DecimalABinario(int valor)
        {
            string valorBinario = string.Empty;
            int numeroEntero = (int)valor;
            int resto;

            if (valor >= 0)
            {
                do
                {
                    resto = numeroEntero % 2;
                    numeroEntero = numeroEntero / 2;
                    valorBinario = resto + valorBinario;

                } while (numeroEntero > 0);

                return valorBinario.ToString();
            }
            return "Numero Invalido";
        }
        private string DecimalABinario(string valor)
        {
            string valorBinario = string.Empty;
            int resto;

            if (int.TryParse(valor, out int numeroEntero) && numeroEntero >= 0)
            {
                do
                {
                    resto = numeroEntero % 2;
                    numeroEntero = numeroEntero / 2;
                    valorBinario = resto + valorBinario;

                } while (numeroEntero > 0);

                return valorBinario.ToString();
            }
            return "Numero Invalido";
        }
        //SOBRECARGA DE COMPARACION, SUMA, RESTA, MULTIPLICACION Y DIVISION

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico == n2.valorNumerico && n1.sistema == n2.sistema;
        }
        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return n1.valorNumerico != n2.valorNumerico || n1.sistema != n2.sistema;
        }
        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            if (n1.sistema == ESistema.Decimal && n2.sistema  == ESistema.Decimal)
            {
                double resultado = n1.valorNumerico + n2.valorNumerico;
                return new Numeracion ((ESistema)resultado, (double)ESistema.Decimal);
            }
            else
            {
                return new Numeracion(0, (double)ESistema.Decimal);
            }
        }
        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            if (n1.sistema == ESistema.Decimal && n2.sistema == ESistema.Decimal)
            {
                double resultado = n1.valorNumerico - n2.valorNumerico;
                return new Numeracion((ESistema)resultado, (double)ESistema.Decimal);
            }
            else
            {
                return new Numeracion(0, (double)ESistema.Decimal);
            }
        }
        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            if (n1.sistema == ESistema.Decimal && n2.sistema == ESistema.Decimal)
            {
                double resultado = n1.valorNumerico * n2.valorNumerico;
                return new Numeracion((ESistema)resultado, (double)ESistema.Decimal);
            }
            else
            {
                return new Numeracion(0, (double)ESistema.Decimal);
            }
        }
        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n1.sistema == ESistema.Decimal && n2.sistema == ESistema.Decimal)
            {
                if(n2.valorNumerico >0)
                {
                    double resultado = n1.valorNumerico / n2.valorNumerico;
                    return new Numeracion((ESistema)resultado, (double)ESistema.Decimal);
                }
                else
                {
                    return new Numeracion(0, (double)ESistema.Decimal);
                }
            }
            else
            {
                return new Numeracion(0, (double)ESistema.Decimal);
            }
        }
        //public override bool Equals(object obj)
        //{
        //    if (obj is Numeracion other)
        //    {
        //        return sistema == other.sistema && valorNumerico == other.valorNumerico;
        //    }
        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(sistema, valorNumerico);
        //}





    }
}