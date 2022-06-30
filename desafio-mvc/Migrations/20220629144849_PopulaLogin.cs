using Microsoft.EntityFrameworkCore.Migrations;

namespace desafio_mvc.Migrations
{
    public partial class PopulaLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetusers` (`Id`,`UserName`,`NormalizedUserName`,`Email`,`NormalizedEmail`,`EmailConfirmed`,`PasswordHash`,`SecurityStamp`,`ConcurrencyStamp`,`PhoneNumber`,`PhoneNumberConfirmed`,`TwoFactorEnabled`,`LockoutEnd`,`LockoutEnabled`,`AccessFailedCount`) VALUES ('2fc41cdf-5852-4817-8968-89543e4fc23b','admin@gft.com','ADMIN@GFT.COM','admin@gft.com','ADMIN@GFT.COM',1,'AQAAAAEAACcQAAAAEHZrGQMpbAdDmeNHIWtaRzoyX4msxAyADdTpT5NWZE/9Rg671fzHRUgz0UhntHKYZg==','5AODIAWFLK2BMB54OENLLHPQDBTNRI4G','225631c2-d6b8-4f43-b142-84b61eb8e2f5',NULL,0,0,NULL,1,0);");
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetusers` (`Id`,`UserName`,`NormalizedUserName`,`Email`,`NormalizedEmail`,`EmailConfirmed`,`PasswordHash`,`SecurityStamp`,`ConcurrencyStamp`,`PhoneNumber`,`PhoneNumberConfirmed`,`TwoFactorEnabled`,`LockoutEnd`,`LockoutEnabled`,`AccessFailedCount`) VALUES ('a1cf9047-8e65-4808-a651-d15c059019c6','usuario@gft.com','USUARIO@GFT.COM','usuario@gft.com','USUARIO@GFT.COM',1,'AQAAAAEAACcQAAAAEMI10dZ7KKE+gPT/ITRlTtUXZwKXu8EQ/NvD7NsgbLQxNzW2523tmiLM5XW9VSiPQQ==','GO4KH6573HPWSEESE5ODDCFL3DKGMXXS','a4547d3b-ef1c-4059-a883-d4e35745bf29',NULL,0,0,NULL,1,0);");
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetuserclaims` (`UserId`, `ClaimType`, `ClaimValue`) VALUES ('2fc41cdf-5852-4817-8968-89543e4fc23b', 'Acesso', 'Admin');");
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetuserclaims` (`UserId`, `ClaimType`, `ClaimValue`) VALUES ('2fc41cdf-5852-4817-8968-89543e4fc23b', 'FullName', 'Administrador');");
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetuserclaims` (`UserId`, `ClaimType`, `ClaimValue`) VALUES ('a1cf9047-8e65-4808-a651-d15c059019c6', 'Acesso', 'usuario');");
            migrationBuilder.Sql("INSERT INTO `receitadb`.`aspnetuserclaims` (`UserId`, `ClaimType`, `ClaimValue`) VALUES ('a1cf9047-8e65-4808-a651-d15c059019c6', 'FullName', 'Usuario');");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
