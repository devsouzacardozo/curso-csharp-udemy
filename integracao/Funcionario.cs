using System;
using System.Globalization;

namespace integracao {
    class Funcionario {
        public long Matricula;
        public string Nome;
        public double Salario;
        public double Irrf;
        public double Inss;


        public double CalculoInss() {
            Previdencia p = new Previdencia();
            
             p.previdenciaFaixa(Inss);           
            
            return Inss;        
        }

        public double SalarioLiquido() {
            return Salario - (Irrf + CalculoInss());

        }
        public void AumentarSalario(double porcentual) {
            double vPorcentagem = porcentual / 100;
            Salario = Salario * vPorcentagem;
        }

        public override string ToString() {
            return " Matricula: "
                   + Matricula
                   + " Nome: "
                   + Nome
                   + " Salário Liquido R$ "
                   + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
