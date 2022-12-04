public class BackgroundWorkerService : BackgroundService
{
    private readonly FilaService _fila;

    public BackgroundWorkerService(FilaService fila)
    {
        _fila = fila;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (true)
        {
            await Task.Delay(100);
            _fila.ChecaItensVencidos();
            Console.WriteLine($"Itens na fila: {_fila.Fila.Count}");
        }
    }
}