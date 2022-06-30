using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class PopulaIngredientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Flocos de milho sem açúcar',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Flocos de arroz',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Aveia flocos grossos',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Semente de Abóbora',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Semente de Girassol',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Linhaça',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Gergelim',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Chia',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Nozes e castanha de caju quebradas',4,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Uvas-passas',4,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Óleo de coco',9,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Mel',9,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Purê de abóbora',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Polvilho Azedo',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Azeite',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Sal',6,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Água',3,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Banana maçãs',5,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Ovos',5,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Farinha de amêndoas',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Whey sabor cacau',7,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Semente de girassol',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Noz-Pecan',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Frutas Vermelhas',8,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Farinha de amêndoas',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Amêndoas laminadas',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Leite de amêndoas',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Amaranto',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Psyllium',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Açucar demerara',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Fermento em pó',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Óleo de coco',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Essência de baunilha',9,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Leite',4,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Farinha de trigo',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Presunto',10,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Queijo Ralado',11,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Legumes',12,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Tomate picado',5,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Azeitona picada',5,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Coentro',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Sal',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Óregano',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Pimenta do reino',8,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Leite',2,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Queijo branco',10,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Manjericão',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Cream cheese',8,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Salsinha picada',8,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Queijo coalho',10,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Tapioca granulada',10,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Leite fervente',13,1)");

            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Tapioca',3,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Sal rosa',16,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Azeite de oliva',15,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Queijo mussarela',14,1)");
            migrationBuilder.Sql("INSERT INTO Ingredientes(Nome, UnidadeDeMedidaMedidaId, Status) VALUES ('Tomate picadinho',3,1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Ingredientes");
        }
    }
}
