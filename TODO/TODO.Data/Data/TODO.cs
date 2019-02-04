namespace TODO.Data.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    public class TODO : DbContext
    {
        // Your context has been configured to use a 'TODO' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TODO.Data.Data.TODO' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TODO' 
        // connection string in the application configuration file.
        public TODO()
            : base("name=TODO.Model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<List> Lists { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}