using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class RebuildThird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characters_CharacterId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characters_CharacterId",
                table: "BasicSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Talents_Characters_CharacterId",
                table: "Talents");

            migrationBuilder.DropIndex(
                name: "IX_BasicSkills_SkillCharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropIndex(
                name: "IX_AdvancedSkills_SkillCharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropColumn(
                name: "SkillCharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropColumn(
                name: "SkillCharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Talents",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdvancedSkillIds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BasicSkillIds",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "BasicSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "BasicSkills",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "AdvancedSkills",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicId",
                table: "AdvancedSkills",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkills_CharacteristicId",
                table: "BasicSkills",
                column: "CharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkills_CharacteristicId",
                table: "AdvancedSkills",
                column: "CharacteristicId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characteristics_CharacteristicId",
                table: "AdvancedSkills",
                column: "CharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characters_CharacterId",
                table: "AdvancedSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characteristics_CharacteristicId",
                table: "BasicSkills",
                column: "CharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characters_CharacterId",
                table: "BasicSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Talents_Characters_CharacterId",
                table: "Talents",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characteristics_CharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkills_Characters_CharacterId",
                table: "AdvancedSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characteristics_CharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkills_Characters_CharacterId",
                table: "BasicSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_Talents_Characters_CharacterId",
                table: "Talents");

            migrationBuilder.DropIndex(
                name: "IX_BasicSkills_CharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropIndex(
                name: "IX_AdvancedSkills_CharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.DropColumn(
                name: "AdvancedSkillIds",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BasicSkillIds",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "BasicSkills");

            migrationBuilder.DropColumn(
                name: "CharacteristicId",
                table: "AdvancedSkills");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "Talents",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "BasicSkills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SkillCharacteristicId",
                table: "BasicSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "CharacterId",
                table: "AdvancedSkills",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkills_SkillCharacteristicId",
                table: "BasicSkills",
                column: "SkillCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkills_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characters_CharacterId",
                table: "AdvancedSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                table: "BasicSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characters_CharacterId",
                table: "BasicSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Talents_Characters_CharacterId",
                table: "Talents",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
