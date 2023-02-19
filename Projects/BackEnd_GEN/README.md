creation du script de creation de la base dans migration
l'assembly doit être compilé avec les entites pour pouvoir generer le code

Installation des outils pour la generation de code ef
dotnet tool install --global dotnet-ef

Ajout des librairies 
dotnet add package Microsoft.EntityFrameworkCore.Design

Creation du script de creation de la base
dotnet ef migrations add InitialCreate

Suppression du code de création de la base
dotnet ef migrations remove

Creation ou mise a jour de la base a partir de l'assembly
dotnet ef database update


TEST du PROJETS
dotnet run
test : http://localhost:5279/healthz
url : http://localhost:5279/swagger/index.html
