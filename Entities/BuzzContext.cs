using Microsoft.EntityFrameworkCore;

namespace SimpleBuzzer.Entities;

public class BuzzContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = System.IO.Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "simplebuzzer.db");
        optionsBuilder.UseSqlite($"DataSource={path}");
    }
}

public class Player
{
    public int PlayerId { get; set; }
    public string PlayerName { get; set; }
    public DateTime RegisteredAt { get; set; }
}