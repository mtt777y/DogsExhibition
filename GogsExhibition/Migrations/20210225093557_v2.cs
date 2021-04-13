using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GogsExhibition.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "Breeds",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Dogs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Owners",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SexId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dogs",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BreedId",
                table: "Dogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Growth",
                table: "Dogs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Leght",
                table: "Dogs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Dogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SexId",
                table: "Dogs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Weight",
                table: "Dogs",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.CreateTable(
                name: "Breed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaxWeight = table.Column<float>(type: "real", nullable: false),
                    MaxGrowth = table.Column<float>(type: "real", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flag = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sex",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sex", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CountryId",
                table: "Owners",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_SexId",
                table: "Owners",
                column: "SexId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_SexId",
                table: "Dogs",
                column: "SexId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Breed_BreedId",
                table: "Dogs",
                column: "BreedId",
                principalTable: "Breed",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Sex_SexId",
                table: "Dogs",
                column: "SexId",
                principalTable: "Sex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Country_CountryId",
                table: "Owners",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Sex_SexId",
                table: "Owners",
                column: "SexId",
                principalTable: "Sex",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Breed_BreedId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Owners_OwnerId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Sex_SexId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Country_CountryId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Sex_SexId",
                table: "Owners");

            migrationBuilder.DropTable(
                name: "Breed");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "Sex");

            migrationBuilder.DropIndex(
                name: "IX_Owners_CountryId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Owners_SexId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_BreedId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_OwnerId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_SexId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "SexId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "BreedId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Growth",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Leght",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "SexId",
                table: "Dogs");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Dogs");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Owners",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AddColumn<string>(
                name: "Breeds",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
