using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication6.Migrations
{
    /// <inheritdoc />
    public partial class Initi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isDone",
                table: "TaskLists",
                newName: "IsDone");

            migrationBuilder.AddColumn<DateTime>(
                name: "datetime",
                table: "TaskLists",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "datetime",
                table: "TaskLists");

            migrationBuilder.RenameColumn(
                name: "IsDone",
                table: "TaskLists",
                newName: "isDone");
        }
    }
}
