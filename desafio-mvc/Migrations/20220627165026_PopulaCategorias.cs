using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao, Status) VALUES ('Doces','Doces fitness low carbs',1)");
            migrationBuilder.Sql("INSERT INTO Categorias(Nome, Descricao, Status) VALUES ('Salgados','Salgados fitness low carbs',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categorias");
        }
    }
}
