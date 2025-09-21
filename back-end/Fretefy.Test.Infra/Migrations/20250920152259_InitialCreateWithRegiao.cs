using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class InitialCreateWithRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regioes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regioes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                    UF = table.Column<string>(type: "TEXT", maxLength: 2, nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cidades_Regioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regioes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e47139fc-ff7e-4e89-bf63-4627aa85185e"), "Rio Branco", null, "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f6a4cf36-710d-4f0f-bf80-3608abe28ecf"), "Palmas", null, "TO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("0ffd8bed-7722-4d5a-88ee-8606a4ed1cdd"), "Aracaju", null, "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("bc2e96ba-d42e-4fb6-b81a-1424e09321a8"), "São Paulo", null, "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("f8dcb5e4-78a8-4125-90f9-2d3161e1d4a6"), "Florianópolis", null, "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("7a5ed412-efe3-46c1-8fc6-cd4b73ed6a44"), "Boa Vista", null, "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("a5e36d6a-6e30-4fba-be21-f88acaf50b43"), "Porto Velho", null, "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("323c41e0-31d4-452a-910b-2516286c2d38"), "Porto Alegre", null, "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("af122c72-39bc-415d-93fb-4a2c7f0baf7f"), "Natal", null, "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("7e532cd8-2097-4cdf-844e-8616e6f57fc1"), "Rio de Janeiro", null, "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("945be823-3e77-4dd1-86a0-34237e3f29ff"), "Teresina", null, "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("4ac037b3-5aee-4e01-987f-adcedd08b185"), "Recife", null, "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("c29b56b8-8c4b-4c1c-a165-9cc1bf2563ab"), "João Pessoa", null, "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("e33a98a9-73a3-4c35-a6a5-46e45d9eab59"), "Curitiba", null, "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("2fa12cfe-a2cf-474a-bd39-9320f30c0d70"), "Belo Horizonte", null, "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("9360c639-fb7f-4981-9015-8349025ce30d"), "Maceió", null, "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("061645cc-b6ec-44f7-b2e2-22a126fb2627"), "Macapá", null, "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("096f1657-7198-4542-bb0f-13e7410ca3dc"), "Manaus", null, "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("aa0d1ca5-e974-4813-8b08-dfd0b6ae485d"), "Salvador", null, "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("027c0a61-69a8-4aa4-b9bf-f40e01b6692f"), "Belém", null, "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("321c3444-dba7-429d-85fd-0011faf4ce61"), "Brasília", null, "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("34842451-44aa-44e3-aada-28ccce1fb0c6"), "Fortaleza", null, " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("3d3e332e-e7a3-4de4-a628-870bed953f6a"), "Goiânia", null, "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("080e5934-4686-439d-86ff-f628bf2e63b0"), "São Luís", null, "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("763dbb2c-e819-40ef-ad21-86af958407e3"), "Cuiabá", null, "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("5b8b148c-7d52-404b-a606-2ee6524d632d"), "Campo Grande", null, "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "RegiaoId", "UF" },
                values: new object[] { new Guid("dd4c9011-3d8c-428e-b2e4-80e53188b6e7"), "Vitória", null, "ES" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e5f06eba-faf2-49b3-bcd4-d90ef3b1c752"), "Sudeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("5cf6f306-70f2-4ee2-b347-f8739c35ee95"), "Norte" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e39cd8b6-ac2b-462f-b348-3462b334477f"), "Nordeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("1547df3e-da5b-4e2b-8b5d-1e4bc7b67c23"), "Centro-Oeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("9f04a231-d130-4829-abf3-0d2cd172ccfc"), "Sul" });

            migrationBuilder.CreateIndex(
                name: "IX_Cidades_RegiaoId",
                table: "Cidades",
                column: "RegiaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Regioes");
        }
    }
}
