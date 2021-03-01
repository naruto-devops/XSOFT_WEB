using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Models.Migrations
{
    public partial class ajout_tableDimension_detailDimension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 26, 10, 41, 14, 31, DateTimeKind.Local).AddTicks(6063),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 25, 12, 32, 15, 367, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Libelle = table.Column<string>(maxLength: 35, nullable: true),
                    Description = table.Column<string>(maxLength: 60, nullable: true),
                    InfoLibre = table.Column<string>(maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DetailDimensions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Libelle = table.Column<string>(maxLength: 35, nullable: true),
                    InfoLibre = table.Column<string>(maxLength: 70, nullable: true),
                    DimensionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailDimensions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DetailDimensions_Dimensions_DimensionId",
                        column: x => x.DimensionId,
                        principalTable: "Dimensions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "DetailDimensions",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DetailDimensions_DimensionId",
                table: "DetailDimensions",
                column: "DimensionId");

            migrationBuilder.CreateIndex(
                name: "UnicityCode",
                table: "Dimensions",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailDimensions");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateCreation",
                table: "Tiers",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 12, 32, 15, 367, DateTimeKind.Local).AddTicks(1791),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 2, 26, 10, 41, 14, 31, DateTimeKind.Local).AddTicks(6063));
        }
    }
}
