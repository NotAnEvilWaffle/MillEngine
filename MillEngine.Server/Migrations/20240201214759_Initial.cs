using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MillEngine.API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LibraryCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryDecks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryDecks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    ScryfallId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SetId = table.Column<Guid>(type: "TEXT", nullable: false),
                    CollectionId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckCommanderId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckMainId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckMaybeId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckPartnerId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckSideId = table.Column<int>(type: "INTEGER", nullable: true),
                    DeckWishId = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryCollections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "LibraryCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckCommanderId",
                        column: x => x.DeckCommanderId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckMainId",
                        column: x => x.DeckMainId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckMaybeId",
                        column: x => x.DeckMaybeId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckPartnerId",
                        column: x => x.DeckPartnerId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckSideId",
                        column: x => x.DeckSideId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryCards_LibraryDecks_DeckWishId",
                        column: x => x.DeckWishId,
                        principalTable: "LibraryDecks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_CollectionId",
                table: "LibraryCards",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckCommanderId",
                table: "LibraryCards",
                column: "DeckCommanderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckMainId",
                table: "LibraryCards",
                column: "DeckMainId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckMaybeId",
                table: "LibraryCards",
                column: "DeckMaybeId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckPartnerId",
                table: "LibraryCards",
                column: "DeckPartnerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckSideId",
                table: "LibraryCards",
                column: "DeckSideId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryCards_DeckWishId",
                table: "LibraryCards",
                column: "DeckWishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryCards");

            migrationBuilder.DropTable(
                name: "LibraryCollections");

            migrationBuilder.DropTable(
                name: "LibraryDecks");
        }
    }
}
