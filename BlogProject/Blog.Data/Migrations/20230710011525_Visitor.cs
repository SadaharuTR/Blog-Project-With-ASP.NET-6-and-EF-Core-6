using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Visitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("177fe677-6b6c-402f-9e44-bc68a4a97141"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("78a08f85-972a-4f76-a2ed-96c794c63fc8"));

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IpAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserAgent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleVisitors",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleVisitors", x => new { x.ArticleId, x.VisitorId });
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleVisitors_Visitors_VisitorId",
                        column: x => x.VisitorId,
                        principalTable: "Visitors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3c47c40e-a91d-4b12-a535-53064eecf69d"), new Guid("764f8a12-b9c3-411b-9c65-b1cf1e15d595"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec faucibus elit, quis egestas massa. Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.", "Admin Test", new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(228), null, null, new Guid("ad7476c8-dafa-4379-a3c3-376f6212abc5"), false, null, null, ".NET Deneme Makalesi - 1", new Guid("f34456b2-2def-4b91-805e-24fb21544602"), 15 },
                    { new Guid("e0a7f373-b837-4008-b237-2c9ed8985858"), new Guid("d913fb49-6d85-488f-9ee2-42bfdba43b2e"), "Visual Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.", "Admin Test", new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(243), null, null, new Guid("fe0d98eb-3cad-4836-ad2a-51b9a41b1ade"), false, null, null, "Visual Studio Deneme Makalesi - 1", new Guid("b1fb55df-2930-4211-a479-dfe0d5297675"), 25 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0cdbebc9-1913-41bd-a0f3-83ab8a7fdf4d"),
                column: "ConcurrencyStamp",
                value: "bfd8e494-0eed-40a7-be8c-e7a3d44d93e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("14054160-3e27-4936-a8e2-e17494d45225"),
                column: "ConcurrencyStamp",
                value: "fda59aed-41b5-45ba-a9bf-0120fb83b256");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("64d9ecbd-5026-42a1-8518-a1482ad67684"),
                column: "ConcurrencyStamp",
                value: "947aa807-77dd-41e4-8d49-3e4fdf02ef33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fb55df-2930-4211-a479-dfe0d5297675"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19296c71-89c0-406c-9e55-d53dda901479", "AQAAAAEAACcQAAAAEH0123GLmyiNYIz6tWQEdOLcKBuCue25CDrFSxQZBRPT7a6m/X646HKAneJlgt2gww==", "a6e27c8a-66e2-4d3e-b626-2f058851bb27" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f34456b2-2def-4b91-805e-24fb21544602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7c21b11-7d11-4f77-b02c-6835ef54788a", "AQAAAAEAACcQAAAAEE24LR27W1sH5Q5RGE908hvI3T2HljmMZkv2cZcKOrcp3DUg3zc/g33xBL2MrEh1Cg==", "17da5fc1-4f26-4ef8-88da-a78e55c13da3" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("764f8a12-b9c3-411b-9c65-b1cf1e15d595"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d913fb49-6d85-488f-9ee2-42bfdba43b2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ad7476c8-dafa-4379-a3c3-376f6212abc5"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fe0d98eb-3cad-4836-ad2a-51b9a41b1ade"),
                column: "CreatedDate",
                value: new DateTime(2023, 7, 10, 4, 15, 25, 340, DateTimeKind.Local).AddTicks(3100));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleVisitors_VisitorId",
                table: "ArticleVisitors",
                column: "VisitorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleVisitors");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3c47c40e-a91d-4b12-a535-53064eecf69d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e0a7f373-b837-4008-b237-2c9ed8985858"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("177fe677-6b6c-402f-9e44-bc68a4a97141"), new Guid("d913fb49-6d85-488f-9ee2-42bfdba43b2e"), "Visual Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.", "Admin Test", new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(71), null, null, new Guid("fe0d98eb-3cad-4836-ad2a-51b9a41b1ade"), false, null, null, "Visual Studio Deneme Makalesi - 1", new Guid("b1fb55df-2930-4211-a479-dfe0d5297675"), 25 },
                    { new Guid("78a08f85-972a-4f76-a2ed-96c794c63fc8"), new Guid("764f8a12-b9c3-411b-9c65-b1cf1e15d595"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec faucibus elit, quis egestas massa. Ut nec viverra enim. Donec sed laoreet risus. Aenean egestas auctor turpis at laoreet. Sed tincidunt risus vitae lorem semper, et finibus neque porta. Morbi laoreet efficitur nunc, sed sagittis mi. Praesent semper posuere quam a porta. Aliquam efficitur imperdiet arcu et posuere. Quisque non ornare turpis, non ultrices massa. Donec urna tortor, interdum ultrices tincidunt et, tincidunt et ex.", "Admin Test", new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(62), null, null, new Guid("ad7476c8-dafa-4379-a3c3-376f6212abc5"), false, null, null, ".NET Deneme Makalesi - 1", new Guid("f34456b2-2def-4b91-805e-24fb21544602"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0cdbebc9-1913-41bd-a0f3-83ab8a7fdf4d"),
                column: "ConcurrencyStamp",
                value: "bbc074cd-857d-4525-8bff-b676b9ffdbbd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("14054160-3e27-4936-a8e2-e17494d45225"),
                column: "ConcurrencyStamp",
                value: "8845775c-c499-4b1f-9309-0a074f5c6f3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("64d9ecbd-5026-42a1-8518-a1482ad67684"),
                column: "ConcurrencyStamp",
                value: "a58552e9-9579-4612-b53e-b2024daf4fe9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1fb55df-2930-4211-a479-dfe0d5297675"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7287f565-3820-49fc-9aea-f3ae265df8f2", "AQAAAAEAACcQAAAAEOH+D7qQolM0nZB8EOGumAA3BW/dInKSo2/1rDHlgCWeNG2am9uN3XLdZG2LkxdamA==", "bb8d3952-65d8-47f8-96b5-bdb8157022fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f34456b2-2def-4b91-805e-24fb21544602"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9db7935b-aadc-42f4-ae8e-e058486116bc", "AQAAAAEAACcQAAAAEHMM4O3qWiUD1KyHcsjynvsuCWyPDXgflAdTPCfSrahbXj5i023FRHm0e7AvRNJmdw==", "28faf8c7-190a-4cc0-81db-9a62134f6212" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("764f8a12-b9c3-411b-9c65-b1cf1e15d595"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d913fb49-6d85-488f-9ee2-42bfdba43b2e"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ad7476c8-dafa-4379-a3c3-376f6212abc5"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("fe0d98eb-3cad-4836-ad2a-51b9a41b1ade"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 22, 6, 2, 30, 289, DateTimeKind.Local).AddTicks(415));
        }
    }
}
