public interface IAgendaService
{
    Task InitializeAsync();
    Task<List<Contato>> GetContato();
    Task<int> AddContato(Contato contato);
    Task<int> UpdateContato(Contato contato);
    Task<int> DeleteContato(Contato contato);
}