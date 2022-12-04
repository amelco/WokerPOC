namespace WokerPOC.Repositories
{
    public class CasosRepository
    {
        private List<Caso> Casos { get; set; }

        public CasosRepository()
        {
            Casos = new();
            Casos.Add(new Caso { Id = 1, Nome = "Primeiro caso", Previa = DateTime.Now.AddSeconds(10), Status = Status.Aberto });
            Casos.Add(new Caso { Id = 2, Nome = "Segundo caso", Previa = DateTime.Now.AddSeconds(25), Status = Status.Aberto });
            Casos.Add(new Caso { Id = 3, Nome = "Terceiro caso", Previa = DateTime.Now.AddSeconds(6), Status = Status.Aberto });
        }

        public IEnumerable<Caso> Listar()
        {
            return Casos;
        }

        public void Adicionar(Caso caso)
        {
            Casos.Add(caso);
            // Disparar contador regressivo
        }
    }
}
