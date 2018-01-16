using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MVCWebApi.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Client_ClientId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Publisher_PublisherId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_PublisherId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Adress_ClientId",
                table: "Adress");

            migrationBuilder.AddColumn<int>(
                name: "ClientId1",
                table: "Adress",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adress_ClientId1",
                table: "Adress",
                column: "ClientId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Client_ClientId1",
                table: "Adress",
                column: "ClientId1",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Client_ClientId1",
                table: "Adress");

            migrationBuilder.DropIndex(
                name: "IX_Adress_ClientId1",
                table: "Adress");

            migrationBuilder.DropColumn(
                name: "ClientId1",
                table: "Adress");

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
                name: "FK_Book_Publisher_PublisherId",
                table: "Book",
                column: "PublisherId",
                principalTable: "Publisher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
