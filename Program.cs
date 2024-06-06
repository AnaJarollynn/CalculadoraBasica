using CalculadoraBasica;

int numero;

do
{
    Calculadora novaCalculadora = new Calculadora();

    Console.WriteLine("Escreva o Menu que deseja entrar:");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Resto da Divisão");
    Console.WriteLine("6 - Potenciação");
    Console.WriteLine("0 - Sair");

    numero = novaCalculadora.LerNumeroMenu();
    if (numero == 0)
        break;

    double resultado = novaCalculadora.VerificarNumeroMenu(numero);

    Console.WriteLine($"Resultado: {resultado}");
    Console.WriteLine();
    Console.Write("Pressione Enter para continuar: ");
    Console.ReadLine();
    Console.Clear();
}
while (numero != 0);