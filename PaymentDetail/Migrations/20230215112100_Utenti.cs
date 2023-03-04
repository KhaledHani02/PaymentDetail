using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentDetail.Migrations
{
    public partial class Utenti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Utenti",
               columns: table => new
               {
                   IdUtente = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   NomeUtente = table.Column<string>(nullable: false),
                   Password = table.Column<string>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Utenti", x => x.IdUtente);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Utenti");
        }
    }
}
