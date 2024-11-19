using System;

namespace CalculoTempoVida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de tempo de vida perdido pelo fumo");    

            // Solicita os dados ao usuário
            Console.Write("Digite a quantidade de cigarros fumados por dia: ");
            int cigarrosPorDia = int.Parse(Console.ReadLine());

            Console.Write("Há quantos anos você fuma? ");
            int anosFumando = int.Parse(Console.ReadLine());

            // Tempo de vida perdido por cigarro (em minutos) - valor estimado
            const int tempoPerdidoPorCigarro = 11;

            // Cálculos
            int cigarrosPorAno = cigarrosPorDia * 365;
            int totalCigarros = cigarrosPorAno * anosFumando;
            int minutosPerdidos = totalCigarros * tempoPerdidoPorCigarro;

            // Convertendo minutos para horas, dias e anos (aproximado)
            int horasPerdidas = minutosPerdidos / 60;
            int diasPerdidos = horasPerdidas / 24;
            int anosPerdidos = diasPerdidos / 365;

            // Exibindo o resultado
            Console.WriteLine($"Você perdeu aproximadamente {anosPerdidos} anos de vida por causa do cigarro.");
            Console.WriteLine($"Isso equivale a cerca de {diasPerdidos} dias ou {horasPerdidas} horas.");
        }
    }
}