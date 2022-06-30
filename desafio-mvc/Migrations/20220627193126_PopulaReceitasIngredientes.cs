using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class PopulaReceitasIngredientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (1,1,1.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (2,1,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (3,1,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (4,1,0.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (5,1,0.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (6,1,0.25)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (7,1,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (8,1,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (9,1,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (10,1,0.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (11,1,0.25)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (12,1,0.5)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (13,2,1.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (14,2,1.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (15,2,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (8,2,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (16,2,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (17,2,2)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (18,3,4)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (19,3,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (20,3,4)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (21,3,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (22,3,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (23,3,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (24,3,0)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (19,4,3)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (25,4,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (26,4,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (27,4,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (28,4,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (29,4,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (30,4,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (31,4,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (32,4,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (33,4,1)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (19,5,6)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (34,5,0.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (35,5,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (36,5,200)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (37,5,0.5)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (38,5,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (39,5,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (40,5,10)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (41,5,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (42,5,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (43,5,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (44,5,0)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (19,6,3)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (45,6,0.25)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (42,6,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (15,6,0.25)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (39,6,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (46,6,100)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (47,6,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (48,6,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (49,6,0)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (50,7,250)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (21,7,250)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (52,7,500)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (42,7,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (44,7,0)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (43,7,0)");

            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (19,8,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (53,8,2)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (54,8,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (55,8,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (56,8,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (57,8,1)");
            migrationBuilder.Sql("INSERT INTO ReceitaIngredientes(IngredienteId, ReceitaId, QuantidadeDeIngrediente) VALUES (43,8,0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from ReceitaIngredientes");
        }
    }
}
