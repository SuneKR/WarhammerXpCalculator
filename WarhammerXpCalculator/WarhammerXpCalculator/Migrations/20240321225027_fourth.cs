using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Characteristics",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "SkillCharacteristicId",
                table: "BasicSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Characteristics",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "BasicSkills",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkills",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id");
        }
    }
}
