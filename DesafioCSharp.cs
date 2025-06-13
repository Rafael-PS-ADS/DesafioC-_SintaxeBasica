using System;

public class DesafioCSharp
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o valor bruto do salário: ");
        double valorSalario = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor adicional dos benefícios: ");
        double valorBeneficios = double.Parse(Console.ReadLine());

        double valorImposto = 0;
        if (valorSalario >= 0 && valorSalario <= 1100)
        {
            valorImposto = 0.05 * valorSalario;
        }
        else if (valorSalario > 1100 && valorSalario <= 2500)
        {
            valorImposto = 0.10 * valorSalario;
        }
        else
        {
            valorImposto = 0.15 * valorSalario;
        }
        
        double saida = valorSalario - valorImposto + valorBeneficios;

        Console.WriteLine($"O valor a ser transferido é: {saida.ToString("0.00")}");
    }
}