using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GogsExhibition.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Breed_BreedId",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sex",
                table: "Sex");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breed",
                table: "Breed");

            migrationBuilder.RenameTable(
                name: "Sex",
                newName: "Sexs");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "Breed",
                newName: "Breeds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sexs",
                table: "Sexs",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breeds",
                table: "Breeds",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Shows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOf = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shows_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Specifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeShow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeShow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeShows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpecificalionsOfBreeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreedId = table.Column<int>(type: "int", nullable: true),
                    SpecificationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificalionsOfBreeds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificalionsOfBreeds_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SpecificalionsOfBreeds_Specifications_SpecificationId",
                        column: x => x.SpecificationId,
                        principalTable: "Specifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypesOfShows",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShowId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesOfShows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypesOfShows_Shows_ShowId",
                        column: x => x.ShowId,
                        principalTable: "Shows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TypesOfShows_TypeShow_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TypeShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ColorsOfDogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogId = table.Column<int>(type: "int", nullable: true),
                    ColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorsOfDogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorsOfDogs_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ColorsOfDogs_TypeShows_ColorId",
                        column: x => x.ColorId,
                        principalTable: "TypeShows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ColorsOfDogs_ColorId",
                table: "ColorsOfDogs",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorsOfDogs_DogId",
                table: "ColorsOfDogs",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Shows_CountryId",
                table: "Shows",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificalionsOfBreeds_BreedId",
                table: "SpecificalionsOfBreeds",
                column: "BreedId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificalionsOfBreeds_SpecificationId",
                table: "SpecificalionsOfBreeds",
                column: "SpecificationId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfShows_ShowId",
                table: "TypesOfShows",
                column: "ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesOfShows_TypeId",
                table: "TypesOfShows",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Breeds_BreedId",
                table: "Dogs",
                column: "BreedId",
                principalTable: "Breeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Sexs_SexId",
                table: "Dogs",
                column: "SexId",
                principalTable: "Sexs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Sexs_SexId",
                table: "Owners",
                column: "SexId",
                principalTable: "Sexs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Breeds_BreedId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Sexs_SexId",
                table: "Dogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Countries_CountryId",
                table: "Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Sexs_SexId",
                table: "Owners");

            migrationBuilder.DropTable(
                name: "ColorsOfDogs");

            migrationBuilder.DropTable(
                name: "SpecificalionsOfBreeds");

            migrationBuilder.DropTable(
                name: "TypesOfShows");

            migrationBuilder.DropTable(
                name: "TypeShows");

            migrationBuilder.DropTable(
                name: "Specifications");

            migrationBuilder.DropTable(
                name: "Shows");

            migrationBuilder.DropTable(
                name: "TypeShow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sexs",
                table: "Sexs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breeds",
                table: "Breeds");

            migrationBuilder.RenameTable(
                name: "Sexs",
                newName: "Sex");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Breeds",
                newName: "Breed");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sex",
                table: "Sex",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breed",
                table: "Breed",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Breed_BreedId",
                table: "Dogs",
                column: "BreedId",
                principalTable: "Breed",
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
    }
}
