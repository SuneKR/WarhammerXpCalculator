using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WarhammerXpCalculator.Migrations
{
    /// <inheritdoc />
    public partial class Rebuild : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.CreateTable(
                name: "Characteristics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Initial = table.Column<int>(type: "int", nullable: false),
                    Advances = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characteristics_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Talents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "AdvancedSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCharacteristicId = table.Column<int>(type: "int", nullable: false),
                    Advances = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedSkills_Characteristics_SkillCharacteristicId",
                        column: x => x.SkillCharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BasicSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SkillCharacteristicId = table.Column<int>(type: "int", nullable: false),
                    Advances = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasicSkills_Characteristics_SkillCharacteristicId",
                        column: x => x.SkillCharacteristicId,
                        principalTable: "Characteristics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasicSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkills_CharacterId",
                table: "AdvancedSkills",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedSkills_SkillCharacteristicId",
                table: "AdvancedSkills",
                column: "SkillCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkills_CharacterId",
                table: "BasicSkills",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_BasicSkills_SkillCharacteristicId",
                table: "BasicSkills",
                column: "SkillCharacteristicId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteristics_CharacterId",
                table: "Characteristics",
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
                name: "AdvancedSkills");

            migrationBuilder.DropTable(
                name: "BasicSkills");

            migrationBuilder.DropTable(
                name: "ExperienceLogs");

            migrationBuilder.DropTable(
                name: "Talents");

            migrationBuilder.DropTable(
                name: "Characteristics");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Parties");
        }
    }
}
