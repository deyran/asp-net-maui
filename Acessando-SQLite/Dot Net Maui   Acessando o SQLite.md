# .NET MAUI :  Acessando o SQLite

## Pacotes a serem instalados

1. sqlite-net-pcl						1.8.116
2. SQLitePCLRaw.bundle_green			2.1.6
3. SQLitePCLRaw.core					2.1.6
4. SQLitePCLRaw.provider.dynamic_cdecl	2.1.6
5. CommunityToolkit.Mvvm				8.2.1

## Atributos da biblioteca SQLite.Net

1. [Table]
2. [Column]
3. [PrimaryKey]
4. [NotNull]
5. [ForeignKey]
6. [Unique]
7. [AutoIncrement]

## Tipos de dados no SQLite

1. Integer
2. Real
3. Text
4. Blog	

## DB Browser for SQLite

Permite criar, pesquisar e editar banco de dados SQLite

## Criar classes modelo de domínio e mapeamento

1. No diretório MVVM/Models

```
using SQLite;

[Table("Contato")]
public class Contato
{
	[PrimaryKey, AutoIncrement]
	public int Id { get; set; }

	[MaxLength(100), NotNull]
	public string Nome { get; set; }

	[MaxLength(200), NotNull]
	public string Email { get; set; }
}
```

2. No diretório Services -> IAgendaService

```
public interface IAgendaService
{
	Task InitializeAsync();
	Task<List<Contato>> GetContato();
	Task<int> AddContato(Contato contato);
	Task<int> UpdateContato(Contato contato);
	Task<int> DeleteContato(Contato contato);
}
```

3. AgendaService

```
public class AgendaService : IAgendaService
{
	private SQLiteAsyncConnection _dbConnection;
	public async Task InitializeAsync()
	{
		await SetUpDb();
	}

	private async Task SetUpDb()
	{
		if(_dbConnection == null)
		{
			string dbPath = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				"Agenda.db3"
			);

			_dbConnection = new SQliteAsyncConnection(dbPath);

			await _dbConnection.CreateTableAsync<Contato>();
		}
	}

	public async Task<int> AddContato(Contato contato)
	{
		return await _dbConnection.InsertAsync(Contato);
	}	

	public async Task<int> DeleteContato(Contato contato)
	{
		return await _dbConnection.DeleteAsync(contato);
	}

	public async Task<int> UpdateContato(Contato contato)
	{
		return await _dbConnection.UpdateAsync(contato);
	}

	public async Task<Contato> GetContato()
	{
		return await _dbConnection.Table<Contato>().ToListAsync();
	}

	public async Task<Contato> GetContato(int id)
	{
		return await _dbConnection.Table<Contato>().FirstOrDefaultAsync(x => x.Id == id);
	}
}
```

## Implementar Serviços