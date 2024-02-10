using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace filmesApi.Migrations
{
    public partial class SessaoeFilme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmeId",
                table: "Sessoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Sessoes_FilmeId",
                table: "Sessoes",
                column: "FilmeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes",
                column: "FilmeId",
                principalTable: "Filmes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sessoes_Filmes_FilmeId",
                table: "Sessoes");

            migrationBuilder.DropIndex(
                name: "IX_Sessoes_FilmeId",
                table: "Sessoes");

            migrationBuilder.DropColumn(
                name: "FilmeId",
                table: "Sessoes");
        }
    }
}
