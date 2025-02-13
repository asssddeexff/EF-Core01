using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core01.Migrations
{
    /// <inheritdoc />
    public partial class IntialCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 22, 35, 49, 990, DateTimeKind.Local).AddTicks(4629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 22, 28, 23, 451, DateTimeKind.Local).AddTicks(810));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfCreation",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 13, 22, 28, 23, 451, DateTimeKind.Local).AddTicks(810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 13, 22, 35, 49, 990, DateTimeKind.Local).AddTicks(4629));
        }
    }
}
