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