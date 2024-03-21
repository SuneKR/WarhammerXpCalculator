using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cAgId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cBSId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cDexId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cFelId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cIId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cIntId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cSId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cTId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cWPId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Characteristic_cWSId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Parties_PartyId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cAgId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cBSId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cDexId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cFelId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cIId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cIntId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cSId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cTId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cWPId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_cWSId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cAgId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cBSId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cDexId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cFelId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cIId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cIntId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cSId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cTId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cWPId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "cWSId",
                table: "Characters");

            migrationBuilder.AlterColumn<int>(
                name: "PartyId",
                table: "Characters",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CharacterId",
                table: "Characteristic",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkill",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Characteristic_CharacterId",
                table: "Characteristic",
                column: "CharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill",
                column: "SkillCharacteristicId",
                principalTable: "Characteristic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Characteristic_Characters_CharacterId",
                table: "Characteristic",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Parties_PartyId",
                table: "Characters",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_Characteristic_Characters_CharacterId",
                table: "Characteristic");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Parties_PartyId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characteristic_CharacterId",
                table: "Characteristic");

            migrationBuilder.DropColumn(
                name: "CharacterId",
                table: "Characteristic");

            migrationBuilder.AlterColumn<int>(
                name: "PartyId",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cAgId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cBSId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cDexId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cFelId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cIId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cIntId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cSId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cTId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cWPId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cWSId",
                table: "Characters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkillCharacteristicId",
                table: "AdvancedSkill",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cAgId",
                table: "Characters",
                column: "cAgId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cBSId",
                table: "Characters",
                column: "cBSId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cDexId",
                table: "Characters",
                column: "cDexId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cFelId",
                table: "Characters",
                column: "cFelId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cIId",
                table: "Characters",
                column: "cIId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cIntId",
                table: "Characters",
                column: "cIntId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cSId",
                table: "Characters",
                column: "cSId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cTId",
                table: "Characters",
                column: "cTId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cWPId",
                table: "Characters",
                column: "cWPId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_cWSId",
                table: "Characters",
                column: "cWSId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                table: "AdvancedSkill",
                column: "SkillCharacteristicId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cAgId",
                table: "Characters",
                column: "cAgId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cBSId",
                table: "Characters",
                column: "cBSId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cDexId",
                table: "Characters",
                column: "cDexId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cFelId",
                table: "Characters",
                column: "cFelId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cIId",
                table: "Characters",
                column: "cIId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cIntId",
                table: "Characters",
                column: "cIntId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cSId",
                table: "Characters",
                column: "cSId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cTId",
                table: "Characters",
                column: "cTId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cWPId",
                table: "Characters",
                column: "cWPId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Characteristic_cWSId",
                table: "Characters",
                column: "cWSId",
                principalTable: "Characteristic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Parties_PartyId",
                table: "Characters",
                column: "PartyId",
                principalTable: "Parties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
