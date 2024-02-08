using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppVendasWeb.Migrations
{
    /// <inheritdoc />
    public partial class Nova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "CadastroAtivo",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "DataCadastro",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "ClienteNome",
                table: "Produto",
                newName: "ProdutoDescricao");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Produto",
                newName: "CategoriaId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Produto",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<decimal>(
                name: "PrecoProduto",
                table: "Produto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "ProdutoId");

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteNome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CadastroAtivo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "CategoriaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "PrecoProduto",
                table: "Produto");

            migrationBuilder.RenameColumn(
                name: "ProdutoDescricao",
                table: "Produto",
                newName: "ClienteNome");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Produto",
                newName: "ClienteId");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Produto",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "CadastroAtivo",
                table: "Produto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Produto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataCadastro",
                table: "Produto",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "DataNascimento",
                table: "Produto",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Produto",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "ClienteId");
        }
    }
}
