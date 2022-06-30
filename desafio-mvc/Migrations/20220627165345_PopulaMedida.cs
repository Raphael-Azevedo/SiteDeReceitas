using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class PopulaMedida : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Litros','L',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Xícara de chá','Xícara de chá',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Colher de Sopa','Colher(es) de sopa',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Xícara','Xícara',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Unidade','Unidade(s)',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Colher de Sopa rasa','Colher(es) rasa',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Scoop','Scoop',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('A gosto','a gosto',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Colher de chá','Colher(es) de chá',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Grama','g',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Pacote','Pacote',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Lata','Lata',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('MiliLitro','ml',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Fatia','Fatia',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Fio','Fio',1)");
            migrationBuilder.Sql("INSERT INTO Medidas(Nome, Simbolo, Status) VALUES ('Pitada','Pitada',1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Medidas");
        }
    }
}
