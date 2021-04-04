using System;
using System.Globalization;

namespace integracao {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
            
        }
        public double Perimetro() {
            return (Largura + Altura) * 2.0;
        }
        public double Diagonal() {            
            return Math.Sqrt(Largura * Largura + Altura * Altura);
            
        }

        public override string ToString() {
            return "\n Área do retângulo: " 
                + Area().ToString("F2", CultureInfo.InvariantCulture) 
                + " \n Perímetro do Retangulo: "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "\n Diagonal do retangulo: "
                + Diagonal().ToString("F2", CultureInfo.InvariantCulture) + "" ;
        }
    }
}
