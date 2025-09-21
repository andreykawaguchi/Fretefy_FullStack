using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class RefactorRegiaoToRegiaoCidadeRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cidades_Regioes_RegiaoId",
                table: "Cidades");

            migrationBuilder.DropIndex(
                name: "IX_Cidades_RegiaoId",
                table: "Cidades");

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("027c0a61-69a8-4aa4-b9bf-f40e01b6692f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("061645cc-b6ec-44f7-b2e2-22a126fb2627"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("080e5934-4686-439d-86ff-f628bf2e63b0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("096f1657-7198-4542-bb0f-13e7410ca3dc"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0ffd8bed-7722-4d5a-88ee-8606a4ed1cdd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2fa12cfe-a2cf-474a-bd39-9320f30c0d70"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("321c3444-dba7-429d-85fd-0011faf4ce61"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("323c41e0-31d4-452a-910b-2516286c2d38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("34842451-44aa-44e3-aada-28ccce1fb0c6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3d3e332e-e7a3-4de4-a628-870bed953f6a"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4ac037b3-5aee-4e01-987f-adcedd08b185"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5b8b148c-7d52-404b-a606-2ee6524d632d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("763dbb2c-e819-40ef-ad21-86af958407e3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7a5ed412-efe3-46c1-8fc6-cd4b73ed6a44"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("7e532cd8-2097-4cdf-844e-8616e6f57fc1"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9360c639-fb7f-4981-9015-8349025ce30d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("945be823-3e77-4dd1-86a0-34237e3f29ff"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a5e36d6a-6e30-4fba-be21-f88acaf50b43"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("aa0d1ca5-e974-4813-8b08-dfd0b6ae485d"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("af122c72-39bc-415d-93fb-4a2c7f0baf7f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bc2e96ba-d42e-4fb6-b81a-1424e09321a8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c29b56b8-8c4b-4c1c-a165-9cc1bf2563ab"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("dd4c9011-3d8c-428e-b2e4-80e53188b6e7"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e33a98a9-73a3-4c35-a6a5-46e45d9eab59"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e47139fc-ff7e-4e89-bf63-4627aa85185e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f6a4cf36-710d-4f0f-bf80-3608abe28ecf"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f8dcb5e4-78a8-4125-90f9-2d3161e1d4a6"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("1547df3e-da5b-4e2b-8b5d-1e4bc7b67c23"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("5cf6f306-70f2-4ee2-b347-f8739c35ee95"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("9f04a231-d130-4829-abf3-0d2cd172ccfc"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("e39cd8b6-ac2b-462f-b348-3462b334477f"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("e5f06eba-faf2-49b3-bcd4-d90ef3b1c752"));

            migrationBuilder.DropColumn(
                name: "RegiaoId",
                table: "Cidades");

            migrationBuilder.CreateTable(
                name: "RegiaoCidades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    RegiaoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CidadeId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegiaoCidades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegiaoCidades_Cidades_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegiaoCidades_Regioes_RegiaoId",
                        column: x => x.RegiaoId,
                        principalTable: "Regioes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cc229847-14b4-44c8-9252-a308111800c5"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2ccdc070-71e1-48ab-a33a-a9618f4cc505"), "Palmas", "TO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5da1966b-84d9-4d9a-8593-a198f5c05200"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a9a4beb1-4833-4fbe-a139-0d19cbe26824"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("ec71ecf7-c864-4931-b254-3e0256cb4b4c"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0aa6bba4-c912-4b63-8cde-bffb6171a12f"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("803d647c-3692-4f5e-892c-0ad180ee14f2"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("6a259e95-33ae-4dbe-b635-52a5b1a77c59"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("94e712df-86cb-4bbf-84e6-e911cc5d3848"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("d314c3b8-a648-4684-a522-57694bd737ac"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("351891a2-f6e6-4ede-a3fa-a2773d123501"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9573c60c-ba06-4910-b438-9f1f9d3f1827"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("07af457d-199a-4045-9533-4d2b0e357681"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("4f4d8f48-5037-4710-9cdf-749cfb42eb90"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("23af394f-2680-48d2-932d-5ac7b680fd38"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("c0744758-8d22-4215-9e00-c66f237c5503"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9c66d73f-b7ef-4f77-bfdb-4616abdeca83"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("cfdf22a5-c023-4de9-b548-7455ca01f3d3"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("1de92ab6-45fb-41ac-9e3b-eb74e8d04fc3"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("849efd2f-dabb-4d2d-9866-7ed35b58fa23"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("08906fbb-421e-4ae6-9670-56e6814a262c"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("b5874943-ee56-4663-87a0-77f847d77620"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5e176139-b363-4c4e-9cab-1a85ec76af95"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("73479c53-030c-48ee-bcd2-09c93559a93c"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fe394f1b-2706-4a4d-b370-e36077352178"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0969291f-626e-46f5-9bf4-6ebfcf384790"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("57a0f4ea-c572-4553-a31c-8d6deadf22b4"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("4cca1172-3e05-4930-b7b6-e9c21e78678c"), "Sudeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("e1d73569-aa71-4714-9e81-799eb8e7d6f7"), "Norte" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("546abf40-52fb-4b1a-9e76-b08770debe85"), "Nordeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("d9e62971-792f-489a-a4e0-5c20b399a55d"), "Centro-Oeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Nome" },
                values: new object[] { new Guid("77f50d80-699e-42c1-9cd0-5ab1b9bafded"), "Sul" });

            migrationBuilder.CreateIndex(
                name: "IX_Regioes_Nome",
                table: "Regioes",
                column: "Nome",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidades_CidadeId",
                table: "RegiaoCidades",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_RegiaoCidades_RegiaoId_CidadeId",
                table: "RegiaoCidades",
                columns: new[] { "RegiaoId", "CidadeId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegiaoCidades");

            migrationBuilder.DropIndex(
                name: "IX_Regioes_Nome",
                table: "Regioes");

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("07af457d-199a-4045-9533-4d2b0e357681"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("08906fbb-421e-4ae6-9670-56e6814a262c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0969291f-626e-46f5-9bf4-6ebfcf384790"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0aa6bba4-c912-4b63-8cde-bffb6171a12f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("1de92ab6-45fb-41ac-9e3b-eb74e8d04fc3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("23af394f-2680-48d2-932d-5ac7b680fd38"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2ccdc070-71e1-48ab-a33a-a9618f4cc505"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("351891a2-f6e6-4ede-a3fa-a2773d123501"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("4f4d8f48-5037-4710-9cdf-749cfb42eb90"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("57a0f4ea-c572-4553-a31c-8d6deadf22b4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5da1966b-84d9-4d9a-8593-a198f5c05200"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5e176139-b363-4c4e-9cab-1a85ec76af95"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("6a259e95-33ae-4dbe-b635-52a5b1a77c59"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("73479c53-030c-48ee-bcd2-09c93559a93c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("803d647c-3692-4f5e-892c-0ad180ee14f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("849efd2f-dabb-4d2d-9866-7ed35b58fa23"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("94e712df-86cb-4bbf-84e6-e911cc5d3848"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9573c60c-ba06-4910-b438-9f1f9d3f1827"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9c66d73f-b7ef-4f77-bfdb-4616abdeca83"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a9a4beb1-4833-4fbe-a139-0d19cbe26824"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("b5874943-ee56-4663-87a0-77f847d77620"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("c0744758-8d22-4215-9e00-c66f237c5503"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cc229847-14b4-44c8-9252-a308111800c5"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("cfdf22a5-c023-4de9-b548-7455ca01f3d3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("d314c3b8-a648-4684-a522-57694bd737ac"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("ec71ecf7-c864-4931-b254-3e0256cb4b4c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fe394f1b-2706-4a4d-b370-e36077352178"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("4cca1172-3e05-4930-b7b6-e9c21e78678c"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("546abf40-52fb-4b1a-9e76-b08770debe85"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("77f50d80-699e-42c1-9cd0-5ab1b9bafded"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("d9e62971-792f-489a-a4e0-5c20b399a55d"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("e1d73569-aa71-4714-9e81-799eb8e7d6f7"));

            migrationBuilder.AddColumn<Guid>(
                name: "RegiaoId",
                table: "Cidades",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Cidades_Regioes_RegiaoId",
                table: "Cidades",
                column: "RegiaoId",
                principalTable: "Regioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
