using System;
using System.Globalization;

namespace integracao {
    class Program {

        static void Main(string[] args) {
            //areaTriangulo();
            //cadastroProduto();
            //calculoRetangulo();
            //calculoSalario();
            //calculoNotaAluno();
            //Triangulo();
            //ContaBancaria();
            point();
        }
        public static void areaTriangulo() {
            Triangulo X, Y;

            X = new Triangulo();
            Y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X: ");
            X.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com as medidas do triangulo X: ");
            Y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = X.Area();
            double areaY = Y.Area();

            Console.WriteLine("ÁREA de X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA de Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("A área de X é maior!!");
            } else {
                Console.WriteLine("A área de Y é maior!!");
            }

        }

        public static void cadastroProduto() {
            

            Console.WriteLine("Entre com os dados do prodto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do produdo: " + p);

            Console.WriteLine();//Quebra de linha
            Console.Write("Digite o número de produtos a ser adicionada ao usuário: ");

            int qte = int.Parse(Console.ReadLine());

            p.AdicioneProdutos(qte);

            Console.WriteLine(); //Quebra de linha
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();//Quebra de linha
            Console.Write("Digite o número de produtos a ser removido pelo usuário: ");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);

            Console.WriteLine(); //Quebra de linha
            Console.WriteLine("Dados atualizados: " + p);

        }

        public static void calculoRetangulo() {
            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura ealtura do retângulo: ");
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = r.Area();
            double perimetro = r.Perimetro();
            double diagonal = r.Diagonal();

            Console.WriteLine(); //Quebra de linha
            Console.WriteLine("Dados atualizados: " + r);

            
        }
        public static void calculoSalario() {
            Funcionario f = new Funcionario();
            Previdencia p = new Previdencia();

            Console.WriteLine("Informe os dados do Funcionario: ");
            Console.Write(" Matricula: ");
            f.Matricula = long.Parse(Console.ReadLine());

            Console.Write(" Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write(" Salário: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write(" IRRF: ");
            f.Irrf = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
     
            Console.Write(" INSS: ");
            f.Inss = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valor = f.Salario;

            p.previdenciaFaixa(valor);

            Console.WriteLine(" Inss: " + f.CalculoInss());


            Console.WriteLine("Funcionario: " + f);
        }

        public static void calculoNotaAluno() {
            Aluno aluno = new Aluno();

            Console.WriteLine("Informe os dados do Aluno: ");
            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();
            ;

            Console.Write("Nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final: " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.NotaFinal() > 60.00) {
                Console.WriteLine("APROVADO");
            } else {
                Console.WriteLine("REPROVADO");
                double valor = 60.00 - aluno.NotaFinal();
                Console.WriteLine("FALTAM " + (valor.ToString("F2", CultureInfo.InvariantCulture)) + " PONTOS ");
                ;
            }
        }
        public static void Triangulo() {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Entre com valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calc.Circungerencia(raio);

            double volume = calc.Volume(raio);
            Console.WriteLine("Circunfência: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor PI: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));


        }

        public static void ContaBancaria() {
            ContaBancaria conta;

            Console.Write("Entre o número da Conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S') {
                Console.Write("Entre o valor de depósito inicial");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depositoInicial);
            } else {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito R$ ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta Atualizado!!");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque R$ ");
             quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(quantia);

            Console.WriteLine("Dados da conta Atualizado!!");
            Console.WriteLine(conta);



        }

        public static void point() {
            
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);
        }


    }
}

