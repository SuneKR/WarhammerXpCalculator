using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characteristic",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Initial = table.Column<int>(type: "int", nullable: false),
                    Advances = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortTermPartyAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongTermPartyAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyAwardedXP = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Career = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CareerTier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hair = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eyes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarSign = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cWSId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cBSId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cSId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cTId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cIId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cAgId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cDexId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cIntId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cWPId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    cFelId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FatePoints = table.Column<int>(type: "int", nullable: false),
                    FortunePoints = table.Column<int>(type: "int", nullable: false),
                    ResiliencePoints = table.Column<int>(type: "int", nullable: false),
                    ResolvePoints = table.Column<int>(type: "int", nullable: false),
                    Motivation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongTermAmbition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementMove = table.Column<int>(type: "int", nullable: false),
                    MovementWalk = table.Column<int>(type: "int", nullable: false),
                    MovementRun = table.Column<int>(type: "int", nullable: false),
                    ExperienceGainIndividually = table.Column<int>(type: "int", nullable: false),
                    ExperienceSpent = table.Column<int>(type: "int", nullable: false),
                    Wounds = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cAgId",
                        column: x => x.cAgId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cBSId",
                        column: x => x.cBSId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cDexId",
                        column: x => x.cDexId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cFelId",
                        column: x => x.cFelId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cIId",
                        column: x => x.cIId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cIntId",
                        column: x => x.cIntId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cSId",
                        column: x => x.cSId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cTId",
                        column: x => x.cTId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cWPId",
                        column: x => x.cWPId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Characteristic_cWSId",
                        column: x => x.cWSId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Characters_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedSkill",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCharacteristicId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Advances = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedSkill_Characteristic_SkillCharacteristicId",
                        column: x => x.SkillCharacteristicId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AdvancedSkill_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasicSkill",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCharacteristicId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Advances = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicSkill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicSkill_Characteristic_SkillCharacteristicId",
                        column: x => x.SkillCharacteristicId,
                        principalTable: "Characteristic",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BasicSkill_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ExperienceLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    XpSpent = table.Column<int>(type: "int", nullable: false),
                    InCareerDiscount = table.Column<bool>(type: "bit", nullable: false),
                    XpBought = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExperienceLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExperienceLogs_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimesTaken = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Talents_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkill_CharacterId",
                table: "AdvancedSkill",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkill_SkillCharacteristicId",
                table: "AdvancedSkill",
                column: "SkillCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkill_CharacterId",
                table: "BasicSkill",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkill_SkillCharacteristicId",
                table: "BasicSkill",
                column: "SkillCharacteristicId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PartyId",
                table: "Characters",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExperienceLogs_CharacterId",
                table: "ExperienceLogs",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_Talents_CharacterId",
                table: "Talents",
                column: "CharacterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancedSkill");

            migrationBuilder.DropTable(
                name: "BasicSkill");

            migrationBuilder.DropTable(
                name: "ExperienceLogs");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Characteristic");

            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
