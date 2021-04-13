using Microsoft.EntityFrameworkCore.Migrations;

namespace GogsExhibition.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorsOfDogs_TypeShows_ColorId",
                table: "ColorsOfDogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TypesOfShows_TypeShow_TypeId",
                table: "TypesOfShows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeShows",
                table: "TypeShows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeShow",
                table: "TypeShow");

            migrationBuilder.RenameTable(
                name: "TypeShows",
                newName: "Colors");

            migrationBuilder.RenameTable(
                name: "TypeShow",
                newName: "TypesShow");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colors",
                table: "Colors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypesShow",
                table: "TypesShow",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorsOfDogs_Colors_ColorId",
                table: "ColorsOfDogs",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesOfShows_TypesShow_TypeId",
                table: "TypesOfShows",
                column: "TypeId",
                principalTable: "TypesShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorsOfDogs_Colors_ColorId",
                table: "ColorsOfDogs");

            migrationBuilder.DropForeignKey(
                name: "FK_TypesOfShows_TypesShow_TypeId",
                table: "TypesOfShows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypesShow",
                table: "TypesShow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colors",
                table: "Colors");

            migrationBuilder.RenameTable(
                name: "TypesShow",
                newName: "TypeShow");

            migrationBuilder.RenameTable(
                name: "Colors",
                newName: "TypeShows");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeShow",
                table: "TypeShow",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeShows",
                table: "TypeShows",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorsOfDogs_TypeShows_ColorId",
                table: "ColorsOfDogs",
                column: "ColorId",
                principalTable: "TypeShows",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesOfShows_TypeShow_TypeId",
                table: "TypesOfShows",
                column: "TypeId",
                principalTable: "TypeShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
