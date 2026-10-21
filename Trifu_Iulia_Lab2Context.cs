using Microsoft.EntityFrameworkCore;

public class Trifu_Iulia_Lab2Context(DbContextOptions<Trifu_Iulia_Lab2Context> options) : DbContext(options)
{
    public DbSet<Trifu_Iulia_Lab2.Models.Book> Book { get; set; } = default!;
    public DbSet<Trifu_Iulia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    public DbSet<Trifu_Iulia_Lab2.Models.Author> Author { get; set; } = default!;
    public DbSet<Trifu_Iulia_Lab2.Models.Category> Category { get; set; } = default!;
}
