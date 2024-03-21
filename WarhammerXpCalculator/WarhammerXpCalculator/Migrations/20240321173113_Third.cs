using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkill_Characters_CharacterId",
                table: "AdvancedSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkill_Characteristic_SkillCharacteristicId",
                table: "BasicSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_BasicSkill_Characters_CharacterId",
                table: "BasicSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Characteristic_Characters_CharacterId",
                table: "Characteristic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characteristic",
                table: "Characteristic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicSkill",
                table: "BasicSkill");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvancedSkill",
                table: "AdvancedSkill");

            migrationBuilder.RenameTable(
                name: "Characteristic",
                newName: "Characteristics");

            migrationBuilder.RenameTable(
                name: "BasicSkill",
                newName: "BasicSkills");

            migrationBuilder.RenameTable(
                name: "AdvancedSkill",
                newName: "AdvancedSkills");

            migrationBuilder.RenameIndex(
                name: "IX_Characteristic_CharacterId",
                table: "Characteristics",
                newName: "IX_Characteristics_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicSkill_SkillCharacteristicId",
                table: "BasicSkills",
                newName: "IX_BasicSkills_SkillCharacteristicId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicSkill_CharacterId",
                table: "BasicSkills",
                newName: "IX_BasicSkills_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedSkill_SkillCharacteristicId",
                table: "AdvancedSkills",
                newName: "IX_AdvancedSkills_SkillCharacteristicId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedSkill_CharacterId",
                table: "AdvancedSkills",
                newName: "IX_AdvancedSkills_CharacterId");

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkills",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characteristics",
                table: "Characteristics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicSkills",
                table: "BasicSkills",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvancedSkills",
                table: "AdvancedSkills",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId",
                principalTable: "Characteristics",
                principalColumn: "Id");

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
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkills_Characters_CharacterId",
                table: "BasicSkills",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristics_Characters_CharacterId",
                table: "Characteristics",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Characteristics_Characters_CharacterId",
                table: "Characteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characteristics",
                table: "Characteristics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasicSkills",
                table: "BasicSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdvancedSkills",
                table: "AdvancedSkills");

            migrationBuilder.RenameTable(
                name: "Characteristics",
                newName: "Characteristic");

            migrationBuilder.RenameTable(
                name: "BasicSkills",
                newName: "BasicSkill");

            migrationBuilder.RenameTable(
                name: "AdvancedSkills",
                newName: "AdvancedSkill");

            migrationBuilder.RenameIndex(
                name: "IX_Characteristics_CharacterId",
                table: "Characteristic",
                newName: "IX_Characteristic_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicSkills_SkillCharacteristicId",
                table: "BasicSkill",
                newName: "IX_BasicSkill_SkillCharacteristicId");

            migrationBuilder.RenameIndex(
                name: "IX_BasicSkills_CharacterId",
                table: "BasicSkill",
                newName: "IX_BasicSkill_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedSkills_SkillCharacteristicId",
                table: "AdvancedSkill",
                newName: "IX_AdvancedSkill_SkillCharacteristicId");

            migrationBuilder.RenameIndex(
                name: "IX_AdvancedSkills_CharacterId",
                table: "AdvancedSkill",
                newName: "IX_AdvancedSkill_CharacterId");

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkill",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characteristic",
                table: "Characteristic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasicSkill",
                table: "BasicSkill",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdvancedSkill",
                table: "AdvancedSkill",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill",
                column: "SkillCharacteristicId",
                principalTable: "Characteristic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkill_Characters_CharacterId",
                table: "AdvancedSkill",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkill_Characteristic_SkillCharacteristicId",
                table: "BasicSkill",
                column: "SkillCharacteristicId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasicSkill_Characters_CharacterId",
                table: "BasicSkill",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristic_Characters_CharacterId",
                table: "Characteristic",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");
        }
    }
}
