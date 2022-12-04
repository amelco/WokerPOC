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
        while (true)
        {
            // Apenas teste. Necessita event sourcing.
            await Task.Delay(1000);
            _fila.Atualiza();
            Console.Write($"[Tempo: {(int)(DateTime.Now.Subtract(_startTime)).TotalSeconds} s] ");
            Console.WriteLine($"Itens no temporizador: {_fila.TotalDeTemporizadores()}");
        }
    }
}