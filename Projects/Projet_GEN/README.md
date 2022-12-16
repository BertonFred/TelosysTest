creation du script de creeation de la base dans migration
l'assembly doit être compilé avec les entites pour pouvoir generer le code



dotnet tool install --global 
dotnet-ef dotnet add package Microsoft.EntityFrameworkCore.Design 
dotnet ef migrations add InitialCreate

dotnet ef database update

Recreation
del .\Migrations\*.cs
Drop-Database
Add-Migration InitialCreate
Update-Database


        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // initialisation des données 
            modelBuilder.Entity<Post>().HasData(new { oid = 1L, Title ="Title 1",Description="Description 1"});
            modelBuilder.Entity<Post>().HasData(new { oid = 2L, Title = "Title 2", Description = "Description 2" });
            modelBuilder.Entity<Post>().HasData(new { oid = 3L, Title = "Title 3", Description = "Description 3" });
            modelBuilder.Entity<Post>().HasData(new { oid = 4L, Title = "Title 4", Description = "Description 4" });
        }
