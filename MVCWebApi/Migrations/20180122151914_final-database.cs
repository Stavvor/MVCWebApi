using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MVCWebApi.Migrations
{
    public partial class finaldatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Client_ClientId1",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Client_ClientId1",
                table: "Contact");

            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookOrders");

            migrationBuilder.DropTable(
                name: "BooksGenres");

            migrationBuilder.DropIndex(
                name: "IX_Contact_ClientId1",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Adress_ClientId1",
                table: "Adress");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "AdressId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Adress");

            migrationBuilder.AlterColumn<string>(
                name: "SubmitDate",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "RealizationDate",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "PublishDate",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Birthday",
                table: "Author",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientId",
                table: "Contact",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_GenreId",
                table: "Book",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_PublisherId",
                table: "Book",
                column: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_Adress_ClientId",
                table: "Adress",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Client_ClientId",
                table: "Adress",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Book_BookId",
                table: "Order",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Client_ClientId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Genre_GenreId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book");

            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Client_ClientId",
                table: "Contact");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Book_BookId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_BookId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Contact_ClientId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_GenreId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Adress_ClientId",
                table: "Adress");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "Book");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SubmitDate",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RealizationDate",
                table: "Order",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "Contact",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdressId",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Book",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Birthday",
                table: "Author",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "Adress",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.AuthorId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false),
                    BookId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookOrders", x => new { x.OrderId, x.BookId });
                    table.ForeignKey(
                        name: "FK_BookOrders_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookOrders_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksGenres",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BooksGenres_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksGenres_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ClientId1",
                table: "Contact",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_Adress_ClientId1",
                table: "Adress",
                column: "ClientId1");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_BookId",
                table: "BookAuthors",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookOrders_BookId",
                table: "BookOrders",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksGenres_GenreId",
                table: "BooksGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Client_ClientId1",
                table: "Adress",
                column: "ClientId1",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Client_ClientId1",
                table: "Contact",
                column: "ClientId1",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
