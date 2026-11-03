using SmartHome___Sistema_de_Climatização;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== CENTRAL DE CONTROLO SMARTHOME===\n");
        
// Instanciação recorrendo ao Construtor (Bloco 2 e Bloco5)
    
ArCondicionado meuAc = new ArCondicionado("Daikin Premium");

// Subscrição do Evento de Segurança (Bloco 9)meuAc.AlertaLimiteAtingido += NotificarCentralSeguranca;

        // 1. Testar comportamento com aparelho desligado(Encapsulamento bloqueia)
    
meuAc.TemperaturaAlvo = 20;

        Console.WriteLine();

        // 2. Ativar o equipamento (Invocação de método - Bloco 4)
        meuAc.Ligar();

        Console.WriteLine();

        // 3. Testar alteração de dados válida (Uso do Set - Bloco7)

meuAc.TemperaturaAlvo = 24;

        Console.WriteLine();

        // 4. Testar tentativa de corrupção/erro de dados(Validação rejeita)
    
meuAc.TemperaturaAlvo = 12;

        Console.WriteLine();

        // 5. Testar limite crítico para ver o Evento a dispararsozinho
    
Console.WriteLine("A configurar para potência máxima derefrigeração...");

meuAc.TemperaturaAlvo = 16;

        Console.ReadKey();
    }

    // O Manipulador do Evento (Handler - Bloco 9)
    static void NotificarCentralSeguranca(object sender, EventArgs
    e)
    {
        // Converter o sender de volta para o tipo ArCondicionadopara ler os seus dados de forma dinâmica
    
ArCondicionado ac = (ArCondicionado)sender;

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"\n[NOTIFICAÇÃO CENTRAL]: O ArCondicionado({ ac.Marca}) atingiu o limite crítico de funcionamentooperativo({ ac.TemperaturaAlvo}°C). Monitorizando picos deenergia...");
    
Console.ResetColor();
    }
}