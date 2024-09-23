using System;
using System.Collections.Generic;

class Program
{
    static void Exercicio()
    {
        
        Dictionary<string, double> faturamento = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        
        double faturamentoTotal = 0;
        foreach (var valor in faturamento.Values)
        {
            faturamentoTotal += valor;
        }

        
        foreach (var estado in faturamento)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
