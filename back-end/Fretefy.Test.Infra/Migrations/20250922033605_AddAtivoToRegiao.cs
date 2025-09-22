using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Fretefy.Test.Infra.Migrations
{
    public partial class AddAtivoToRegiao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Regioes",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("be42c8b4-9400-4e59-8d46-8f844c95b9b8"), "Rio Branco", "AC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("82f2502b-1642-47c2-b83b-147dbe5e088b"), "Palmas", "TO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a4d87d4e-a2a4-48b3-9dc2-e2a2d41db6dd"), "Aracaju", "SE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("99fd1c90-9cdf-4feb-803e-5ae028f10e8e"), "São Paulo", "SP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("33b1ce95-b32e-407f-b84e-5beaf4dbf69f"), "Florianópolis", "SC" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bf0434cd-774f-4759-af7a-b3a4ec209287"), "Boa Vista", "RR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("51cfd7dd-b0a6-4c55-a92e-89c97599c7b6"), "Porto Velho", "RO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("00bc30c3-cd58-4ab1-850e-6d43d95535f2"), "Porto Alegre", "RS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("3bf08061-d547-48ef-a5f1-f36cbf9b5404"), "Natal", "RN" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("fc7d36cd-19fa-4544-8c23-7fe192577df3"), "Rio de Janeiro", "RJ" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("a5a3d959-69be-4681-a356-f49723e1e172"), "Teresina", "PI" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2425843a-230a-46ec-8405-2832547ffa8c"), "Recife", "PE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("196c68c9-cf4a-4292-8024-d4fd0e30cb1b"), "João Pessoa", "PB" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("44301e7d-612a-4bbf-9813-16500d762024"), "Curitiba", "PR" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("60c61097-740f-4afc-aa97-012429dfaa13"), "Belo Horizonte", "MG" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("165da3c3-1782-47a6-a472-bf06ddb8216f"), "Maceió", "AL" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("24743c90-c91f-46e4-b676-4ac136d5dfd9"), "Macapá", "AP" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("465e3f9a-4f33-4264-83c8-c971763a0dfd"), "Manaus", "AM" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("bb73a122-1c18-444c-ad87-d5bab7427277"), "Salvador", "BA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("9fb373a6-aa87-477f-8dfc-0e4037c17fd3"), "Belém", "PA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("0f0677a8-5615-4971-81be-5d7a84eb0e39"), "Brasília", "DF" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("e2590b64-22c8-45bf-ac3b-2dccf1e4e312"), "Fortaleza", " CE" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("2263e72c-8612-400b-b40d-a42a4c251dfd"), "Goiânia", "GO" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("f3137f3d-997c-4cab-bb07-836f0677ebe4"), "São Luís", "MA" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("8b5f64fb-236e-4374-b05f-bffb18c544dd"), "Cuiabá", "MT" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("11408749-0ac8-4b06-bd39-6ac2f9e879d0"), "Campo Grande", "MS" });

            migrationBuilder.InsertData(
                table: "Cidades",
                columns: new[] { "Id", "Nome", "UF" },
                values: new object[] { new Guid("5409d51a-3ce6-4310-bed6-6a6ec3b2e303"), "Vitória", "ES" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Ativo", "Nome" },
                values: new object[] { new Guid("56d605f6-ab88-453d-880b-782b70519c5a"), true, "Sudeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Ativo", "Nome" },
                values: new object[] { new Guid("85779a58-b2c5-425f-a06c-c5944290c4cc"), true, "Norte" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Ativo", "Nome" },
                values: new object[] { new Guid("170595e3-fefb-446d-9947-f7095868615b"), true, "Nordeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Ativo", "Nome" },
                values: new object[] { new Guid("33d71194-2266-499e-92ac-f94154b3f778"), true, "Centro-Oeste" });

            migrationBuilder.InsertData(
                table: "Regioes",
                columns: new[] { "Id", "Ativo", "Nome" },
                values: new object[] { new Guid("5cf33d7a-c171-46f3-b6b6-61a785d1b179"), true, "Sul" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("00bc30c3-cd58-4ab1-850e-6d43d95535f2"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("0f0677a8-5615-4971-81be-5d7a84eb0e39"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("11408749-0ac8-4b06-bd39-6ac2f9e879d0"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("165da3c3-1782-47a6-a472-bf06ddb8216f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("196c68c9-cf4a-4292-8024-d4fd0e30cb1b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2263e72c-8612-400b-b40d-a42a4c251dfd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("2425843a-230a-46ec-8405-2832547ffa8c"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("24743c90-c91f-46e4-b676-4ac136d5dfd9"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("33b1ce95-b32e-407f-b84e-5beaf4dbf69f"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("3bf08061-d547-48ef-a5f1-f36cbf9b5404"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("44301e7d-612a-4bbf-9813-16500d762024"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("465e3f9a-4f33-4264-83c8-c971763a0dfd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("51cfd7dd-b0a6-4c55-a92e-89c97599c7b6"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("5409d51a-3ce6-4310-bed6-6a6ec3b2e303"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("60c61097-740f-4afc-aa97-012429dfaa13"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("82f2502b-1642-47c2-b83b-147dbe5e088b"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("8b5f64fb-236e-4374-b05f-bffb18c544dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("99fd1c90-9cdf-4feb-803e-5ae028f10e8e"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("9fb373a6-aa87-477f-8dfc-0e4037c17fd3"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a4d87d4e-a2a4-48b3-9dc2-e2a2d41db6dd"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("a5a3d959-69be-4681-a356-f49723e1e172"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bb73a122-1c18-444c-ad87-d5bab7427277"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("be42c8b4-9400-4e59-8d46-8f844c95b9b8"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("bf0434cd-774f-4759-af7a-b3a4ec209287"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("e2590b64-22c8-45bf-ac3b-2dccf1e4e312"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("f3137f3d-997c-4cab-bb07-836f0677ebe4"));

            migrationBuilder.DeleteData(
                table: "Cidades",
                keyColumn: "Id",
                keyValue: new Guid("fc7d36cd-19fa-4544-8c23-7fe192577df3"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("170595e3-fefb-446d-9947-f7095868615b"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("33d71194-2266-499e-92ac-f94154b3f778"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("56d605f6-ab88-453d-880b-782b70519c5a"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("5cf33d7a-c171-46f3-b6b6-61a785d1b179"));

            migrationBuilder.DeleteData(
                table: "Regioes",
                keyColumn: "Id",
                keyValue: new Guid("85779a58-b2c5-425f-a06c-c5944290c4cc"));

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Regioes");

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
        }
    }
}
