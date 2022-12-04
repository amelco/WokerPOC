public class FilaService
{
    public List<string> Fila { get; set; } = new();
    public List<DateTime> Vencimento { get; set; } = new();

    public void AdicionaItem()
    {
        Random random = new Random();
        Fila.Add($"Item {Fila.Count + 1}");
        Vencimento.Add(DateTime.Now.AddSeconds(random.Next(2,100)));
    }

    public void ChecaItensVencidos()
    {
        for (var i=0; i < Vencimento.Count; i++)
        {
            if (DateTime.Now > Vencimento[i])
            {
                Console.WriteLine($"\nItem {i} venceu.\n");
                Fila.RemoveAt(i);
                Vencimento.RemoveAt(i);
            }
        }
    }
}