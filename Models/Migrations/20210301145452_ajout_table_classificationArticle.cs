using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajout_table_classificationArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 15, 54, 52, 285, DateTimeKind.Local).AddTicks(7761),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 1, 12, 37, 45, 130, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.CreateTable(
                name: "ClassificationArticles",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 19, nullable: true),
                    Libelle = table.Column<string>(maxLength: 50, nullable: true),
                    Niveau = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassificationArticles", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "ClassificationArticles",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassificationArticles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 1, 12, 37, 45, 130, DateTimeKind.Local).AddTicks(263),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 3, 1, 15, 54, 52, 285, DateTimeKind.Local).AddTicks(7761));
        }
    }
}
