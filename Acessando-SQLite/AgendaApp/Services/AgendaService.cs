using SQLite;

public class AgendaService : IAgendaService
{
    private SQLiteAsyncConnection _dbConnection;

    public Task InitializeAsync()
    {
        throw new NotImplementedException();
    }

    private async Task SetUpDb()
    {
        if (_dbConnection == null)
        {
            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "Agenda.db3"
            );

            _dbConnection = new SQLiteAsyncConnection(dbPath);
            
            await _dbConnection.CreateTableAsync<Contato>();
        }
    }


    public Task<int> AddContato(Contato contato)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteContato(Contato contato)
    {
        throw new NotImplementedException();
    }

    public Task<List<Contato>> GetContato()
    {
        throw new NotImplementedException();
    }
    

    public Task<int> UpdateContato(Contato contato)
    {
        throw new NotImplementedException();
    }
}