creation du script de creeation de la base dans migration
l'assembly doit être compilé avec les entites pour pouvoir generer le code



dotnet tool install --global 
dotnet-ef dotnet add package Microsoft.EntityFrameworkCore.Design 
dotnet ef migrations add InitialCreate

dotnet ef database update