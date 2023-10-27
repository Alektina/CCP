using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVCDog.Migrations
{
    /// <inheritdoc />
    public partial class AddingTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breeders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    KennelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reg_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryID = table.Column<int>(type: "int", nullable: true),
                    Birth_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hairlayers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TitleId = table.Column<int>(type: "int", nullable: true),
                    DogId_Mother = table.Column<int>(type: "int", nullable: true),
                    DogId_Father = table.Column<int>(type: "int", nullable: true),
                    Death_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Other_info = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    File_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DogId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BreederDog",
                columns: table => new
                {
                    BreedersId = table.Column<int>(type: "int", nullable: false),
                    DogsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreederDog", x => new { x.BreedersId, x.DogsId });
                    table.ForeignKey(
                        name: "FK_BreederDog_Breeders_BreedersId",
                        column: x => x.BreedersId,
                        principalTable: "Breeders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreederDog_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Country_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Kennels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreederId = table.Column<int>(type: "int", nullable: true),
                    ContactId = table.Column<int>(type: "int", nullable: true),
                    DogId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kennels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kennels_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Litters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Birth_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false),
                    MotherId = table.Column<int>(type: "int", nullable: false),
                    FatherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Litters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Litters_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Merits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Merit_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Merit_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Best_in_show = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    National_BISS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Winner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Top = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merits_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Title_Dogs_DogId",
                        column: x => x.DogId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DogGallery",
                columns: table => new
                {
                    DogsId = table.Column<int>(type: "int", nullable: false),
                    GalleriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogGallery", x => new { x.DogsId, x.GalleriesId });
                    table.ForeignKey(
                        name: "FK_DogGallery_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogGallery_Galleries_GalleriesId",
                        column: x => x.GalleriesId,
                        principalTable: "Galleries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DogOwner",
                columns: table => new
                {
                    DogsId = table.Column<int>(type: "int", nullable: false),
                    OwnersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogOwner", x => new { x.DogsId, x.OwnersId });
                    table.ForeignKey(
                        name: "FK_DogOwner_Dogs_DogsId",
                        column: x => x.DogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogOwner_Owners_OwnersId",
                        column: x => x.OwnersId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BreederKennel",
                columns: table => new
                {
                    BredeersId = table.Column<int>(type: "int", nullable: false),
                    KennelsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreederKennel", x => new { x.BredeersId, x.KennelsId });
                    table.ForeignKey(
                        name: "FK_BreederKennel_Breeders_BredeersId",
                        column: x => x.BredeersId,
                        principalTable: "Breeders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BreederKennel_Kennels_KennelsId",
                        column: x => x.KennelsId,
                        principalTable: "Kennels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_nr = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Social_media = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Added_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    About_us = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BreederId = table.Column<int>(type: "int", nullable: true),
                    KennelId = table.Column<int>(type: "int", nullable: true),
                    OwnerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_Breeders_BreederId",
                        column: x => x.BreederId,
                        principalTable: "Breeders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contacts_Kennels_KennelId",
                        column: x => x.KennelId,
                        principalTable: "Kennels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contacts_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Breeders",
                columns: new[] { "Id", "ContactId", "DogId", "KennelId", "Name" },
                values: new object[] { 1, 1, 1, 0, "Elin Gunnarsson" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "About_us", "Added_date", "Address", "BreederId", "Country", "Email", "KennelId", "OwnerId", "Phone_nr", "Social_media", "Url" },
                values: new object[] { 1, "Sirocco was founded by Elin & Birgitta Gunnarsson in 2005, owners of Chinese Crested Dogs since 1999.\nSince 2017 Elin is the sole owner of the Sirocco prefix.", null, "Torpavägen 60, 461 77 Sjuntorp", null, "Sweden", "kennelsirocco@gmail.com", null, null, 703022152, "https://www.facebook.com/elin.sirocco", "https://kennelsirocco.com/" });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "Id", "Birth_date", "Color", "CountryID", "Death_date", "DogId_Father", "DogId_Mother", "Hairlayers", "Height", "Name", "Nickname", "Other_info", "Reg_number", "Sex", "TitleId", "Weight" },
                values: new object[,]
                {
                    { 1, null, "Blue with white markings", null, null, 2, 3, "Hailless", "32 cm", "Sirocco Lunatic Toc Tamarine", "Morgan", null, "SE23916/2016", null, null, "5 kg" },
                    { 2, null, "Spotted", null, null, null, null, "Hailless", "33 cm", "Hooki z Teramonu", "Hooki", null, "SE59047/2012", null, null, "5 kg" },
                    { 3, null, "Spotted", null, null, null, null, "Hailless", "33 cm", "Sirocco Endless Locks Of Eventide", "Viska", null, "SE29122/2013", null, null, "5 kg" }
                });

            migrationBuilder.InsertData(
                table: "Kennels",
                columns: new[] { "Id", "BreederId", "ContactId", "DogId", "Name" },
                values: new object[] { 1, 1, 1, null, "Sirocco" });

            migrationBuilder.CreateIndex(
                name: "IX_BreederDog_DogsId",
                table: "BreederDog",
                column: "DogsId");

            migrationBuilder.CreateIndex(
                name: "IX_BreederKennel_KennelsId",
                table: "BreederKennel",
                column: "KennelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_BreederId",
                table: "Contacts",
                column: "BreederId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_KennelId",
                table: "Contacts",
                column: "KennelId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_OwnerId",
                table: "Contacts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Country_DogId",
                table: "Country",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_DogGallery_GalleriesId",
                table: "DogGallery",
                column: "GalleriesId");

            migrationBuilder.CreateIndex(
                name: "IX_DogOwner_OwnersId",
                table: "DogOwner",
                column: "OwnersId");

            migrationBuilder.CreateIndex(
                name: "IX_Kennels_DogId",
                table: "Kennels",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Litters_DogId",
                table: "Litters",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Merits_DogId",
                table: "Merits",
                column: "DogId");

            migrationBuilder.CreateIndex(
                name: "IX_Title_DogId",
                table: "Title",
                column: "DogId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreederDog");

            migrationBuilder.DropTable(
                name: "BreederKennel");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "DogGallery");

            migrationBuilder.DropTable(
                name: "DogOwner");

            migrationBuilder.DropTable(
                name: "Litters");

            migrationBuilder.DropTable(
                name: "Merits");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Breeders");

            migrationBuilder.DropTable(
                name: "Kennels");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
