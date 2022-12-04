using System.Reflection;

public class BackgroundWorkerService : BackgroundService
{
    private readonly FilaService _fila;
    private DateTime _startTime;

    public BackgroundWorkerService(FilaService fila)
    {
        _fila = fila;
        _startTime = DateTime.Now;
        Console.WriteLine("Construtor BackgroundService");
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        // Carrega todos os casos que estão abertos
        _fila.Inicia();
        while (true)
        {
            await Task.Delay(1000);
            Console.Write($"\n[Tempo: {(int)(DateTime.Now.Subtract(_startTime)).TotalSeconds} s] "); 
        }
    }
}