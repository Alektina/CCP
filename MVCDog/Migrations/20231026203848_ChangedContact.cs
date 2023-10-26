using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCDog.Migrations
{
    /// <inheritdoc />
    public partial class ChangedContact : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fil_name",
                table: "Galleries",
                newName: "File_name");

            migrationBuilder.RenameColumn(
                name: "Telefon_nr",
                table: "Contacts",
                newName: "Phone_nr");

            migrationBuilder.AlterColumn<string>(
                name: "Social_media",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Added_date",
                table: "Contacts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added_date",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "File_name",
                table: "Galleries",
                newName: "Fil_name");

            migrationBuilder.RenameColumn(
                name: "Phone_nr",
                table: "Contacts",
                newName: "Telefon_nr");

            migrationBuilder.AlterColumn<string>(
                name: "Social_media",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Added_date",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Added_date",
                value: "2022-03-09");
        }
    }
}
