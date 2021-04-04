using System;

namespace integracao {
    class Calculadora {
        public double Pi = 3.14;
        public double Circungerencia(double r) {
            return 2.0 * Pi * r;
        }
        public double Volume(double r) {
            return 4.0 / 3 * Pi * Math.Pow(r, 3.0); // r * r * r ou Math.Paw(r, 3.0)
        }
    }
}
