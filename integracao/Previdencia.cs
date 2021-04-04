using System;


namespace integracao {
    class Previdencia {
        public double Faixa1;
        public double Faixa2;
        public double Faixa3;
        public double Percentual1;
        public double Percentual2;
        public double Percentual3;

        public void previdenciaFaixa(double valor) {
            Faixa1 = 1000.00;
            Faixa2 = 4000.00;
            Faixa3 = 6000.00;

            if (Faixa1 <= valor) {
                 Percentual1 = 7.5 / 100;
            } else if (valor > Faixa1 && Faixa2 <= valor) {
                 Percentual2 = 8.00 / 100;
            } else {
                 Percentual3 = 11.00 / 100;
            }
        }

    }
}
