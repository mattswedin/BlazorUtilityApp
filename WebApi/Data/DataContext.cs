using Microsoft.EntityFrameworkCore;
{
    public class DataContext : DbContext //built-in class in EFCore that provides the functionality to query and save data.
    {
        public DataContext(DbContextOptions<DataContext> options : base(options) { } )  // The constructor takes DbContextOptions, which contain configuration details (connection string, etc), and passes them to the base DbContext class so that EFCore knows how to configure and connect to the database.

        public DbSet<User> Users { get; set; } //defines a property that allows you to interact with the Users table in your database using EFCore. You can query, add, update, or delete User entities from your database using this property.
    }
}
