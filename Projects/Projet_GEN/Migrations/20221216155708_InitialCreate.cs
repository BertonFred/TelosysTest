using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace wsRestTest.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    oid = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.oid);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    oid = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    comment = table.Column<string>(type: "TEXT", nullable: false),
                    Postoid = table.Column<long>(name: "Post_oid", type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.oid);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_Post_oid",
                        column: x => x.Postoid,
                        principalTable: "Posts",
                        principalColumn: "oid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "oid", "Description", "Title" },
                values: new object[,]
                {
                    { 1L, "Description 1", "Title 1" },
                    { 2L, "Description 2", "Title 2" },
                    { 3L, "Description 3", "Title 3" },
                    { 4L, "Description 4", "Title 4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Post_oid",
                table: "Comments",
                column: "Post_oid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
