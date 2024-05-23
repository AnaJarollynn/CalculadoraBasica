
namespace CalculadoraBasica
{
    public class Calculadora
    {
        public List<int> OpcoesMenu;
        public double Resultado;

        public int LerNumeroMenu()
        {
            OpcoesMenu = [0, 1, 2, 3, 4, 5, 6];


            while (true)
            {
                string numeroMenuSemTratamento = Console.ReadLine();

                if (int.TryParse(numeroMenuSemTratamento, out int numeroMenu)
                    && numeroMenu >= 0 && OpcoesMenu.Contains(numeroMenu))
                    return numeroMenu;
                else
                    Console.Write("Número inválido, por favor, digite novamente: ");
            }
        }

        public double VerificarNumeroMenu(int numeroMenu)
        {
            switch (numeroMenu)
            {
                case 1:
                    return Resultado = Soma();
                case 2:
                    return Resultado = Subtracao();
                case 3:
                    return Resultado = Multiplicacao();
                case 4:
                    return Resultado = Divisao();
                case 5:
                    return Resultado = RestoDivisao();
                case 6:
                    return Resultado = Potenciacao();
                default:
                    return Resultado = 0;
            }
        }

        public double LerNumero()
        {
            while (true)
            {
                string numero = Console.ReadLine();
                if (double.TryParse(numero, out double numeroTratado))
                    return numeroTratado;
                else
                    Console.Write("Número inválido, por favor, digite novamente: ");
            }
        }

        public double Soma()
        {
            Console.WriteLine();
            Console.Write("Escreva um número: ");
            double primeiraParcela = LerNumero();
            Console.Write("Escreva outro número: ");
            double segundaParcela = LerNumero();

            return primeiraParcela + segundaParcela;
        }

        public double Subtracao()
        {
            Console.WriteLine();
            Console.Write("Escreva um número: ");
            double minuendo = LerNumero();
            Console.Write("Escreva outro número: ");
            double subtraendo = LerNumero();

            return minuendo - subtraendo;
        }

        public double Multiplicacao()
        {
            Console.WriteLine();
            Console.Write("Escreva um número: ");
            double multiplicando = LerNumero();
            Console.Write("Escreva outro número: ");
            double multiplicador = LerNumero();

            return multiplicando * multiplicador;
        }

        public double Divisao()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Escreva um número: ");
                double dividendo = LerNumero();
                Console.Write("Escreva outro número: ");
                double divisor = LerNumero();

                if (divisor != 0)
                    return dividendo / divisor;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Impossível Dívidir, digite novamente.");
                }
            }
        }

        public double RestoDivisao()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Escreva um número: ");
                double dividendo = LerNumero();
                Console.Write("Escreva outro número: ");
                double divisor = LerNumero();

                if (divisor != 0)
                    return dividendo % divisor;
                else
                {
                    Console.Clear();
                    Console.WriteLine("Impossível Dívidir, digite novamente.");
                }
            }
        }

        public double Potenciacao()
        {
            while (true)
            {
                Console.WriteLine();
                Console.Write("Escreva um número: ");
                double basePotenciacao = LerNumero();
                Console.Write("Escreva outro número: ");
                double expoente = LerNumero();

                return Math.Pow(basePotenciacao, expoente);
            }
        }
    }
}
