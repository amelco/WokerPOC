namespace WokerPOC.Entities
{
    public class Caso
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Previa { get; set; }
        public string Nome { get; set; } = "";
    }

    public enum Status
    {
        Aberto,
        Fechado
    }
}
