using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class RebuildSecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteristics_Characters_CharacterId",
                table: "Characteristics");

            migrationBuilder.DropIndex(
                name: "IX_Characteristics_CharacterId",
                table: "Characteristics");

            migrationBuilder.AddColumn<string>(
                name: "CharacteristicIds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CharacteristicIds",
                table: "Characters");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_CharacterId",
                table: "Characteristics",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Characters_CharacterId",
                table: "Characteristics",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
