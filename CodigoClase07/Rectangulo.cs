using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase07
{
    public class Rectangulo
    {



        #region Propieades
       
        //Propiedades de Navegación (Propiedades de tipo objeto)
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }
        public Punto Punto4 { get; set; }
        #endregion

        #region Métodos Privados
        double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        double CalcularBase()
        {
            double base1 = CalcularDistancia(Punto1.X, Punto1.Y, Punto2.X, Punto2.Y);
            return base1;
        }
        double CalcularAltura()
        {
            double altura = CalcularDistancia(Punto2.X, Punto2.Y, Punto3.X, Punto3.Y);
            return altura;
        }
        #endregion

        #region  Métodos Públicos
        public double CalcularArea()
        {
            double base1= CalcularBase();
            double altura= CalcularAltura();
            return base1*altura;
        }

        public double CalcularPerimetro()
        {
            double base1 = CalcularBase();
            double altura = CalcularAltura();
            return 2*(base1+altura);
        }
        #endregion
    }
}
