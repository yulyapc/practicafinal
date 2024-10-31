using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hackaton.api.Migrations
{
    /// <inheritdoc />
    public partial class updaterelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Mentors_MentorId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Projects_ProjectId",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Teams_TeamId",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Rewards_Hackatons_HackatonId",
                table: "Rewards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Hackatons_HackatonId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "HackatonId",
                table: "Teams",
                newName: "HackatonID");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_HackatonId",
                table: "Teams",
                newName: "IX_Teams_HackatonID");

            migrationBuilder.RenameColumn(
                name: "HackatonId",
                table: "Rewards",
                newName: "HackatonID");

            migrationBuilder.RenameIndex(
                name: "IX_Rewards_HackatonId",
                table: "Rewards",
                newName: "IX_Rewards_HackatonID");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Projects",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                newName: "IX_Projects_TeamID");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Participants",
                newName: "TeamID");

            migrationBuilder.RenameIndex(
                name: "IX_Participants_TeamId",
                table: "Participants",
                newName: "IX_Participants_TeamID");

            migrationBuilder.RenameColumn(
                name: "ProjectId",
                table: "Evaluations",
                newName: "ProjectID");

            migrationBuilder.RenameColumn(
                name: "MentorId",
                table: "Evaluations",
                newName: "MentorID");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_ProjectId",
                table: "Evaluations",
                newName: "IX_Evaluations_ProjectID");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_MentorId",
                table: "Evaluations",
                newName: "IX_Evaluations_MentorID");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonID",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HackatonID",
                table: "Rewards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamID",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectID",
                table: "Evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MentorID",
                table: "Evaluations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Mentors_MentorID",
                table: "Evaluations",
                column: "MentorID",
                principalTable: "Mentors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Projects_ProjectID",
                table: "Evaluations",
                column: "ProjectID",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Teams_TeamID",
                table: "Participants",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamID",
                table: "Projects",
                column: "TeamID",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rewards_Hackatons_HackatonID",
                table: "Rewards",
                column: "HackatonID",
                principalTable: "Hackatons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Hackatons_HackatonID",
                table: "Teams",
                column: "HackatonID",
                principalTable: "Hackatons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Mentors_MentorID",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Evaluations_Projects_ProjectID",
                table: "Evaluations");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Teams_TeamID",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Rewards_Hackatons_HackatonID",
                table: "Rewards");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Hackatons_HackatonID",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "HackatonID",
                table: "Teams",
                newName: "HackatonId");

            migrationBuilder.RenameIndex(
                name: "IX_Teams_HackatonID",
                table: "Teams",
                newName: "IX_Teams_HackatonId");

            migrationBuilder.RenameColumn(
                name: "HackatonID",
                table: "Rewards",
                newName: "HackatonId");

            migrationBuilder.RenameIndex(
                name: "IX_Rewards_HackatonID",
                table: "Rewards",
                newName: "IX_Rewards_HackatonId");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Projects",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_TeamID",
                table: "Projects",
                newName: "IX_Projects_TeamId");

            migrationBuilder.RenameColumn(
                name: "TeamID",
                table: "Participants",
                newName: "TeamId");

            migrationBuilder.RenameIndex(
                name: "IX_Participants_TeamID",
                table: "Participants",
                newName: "IX_Participants_TeamId");

            migrationBuilder.RenameColumn(
                name: "ProjectID",
                table: "Evaluations",
                newName: "ProjectId");

            migrationBuilder.RenameColumn(
                name: "MentorID",
                table: "Evaluations",
                newName: "MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_ProjectID",
                table: "Evaluations",
                newName: "IX_Evaluations_ProjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Evaluations_MentorID",
                table: "Evaluations",
                newName: "IX_Evaluations_MentorId");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HackatonId",
                table: "Rewards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Projects",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Participants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "Evaluations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MentorId",
                table: "Evaluations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Mentors_MentorId",
                table: "Evaluations",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Evaluations_Projects_ProjectId",
                table: "Evaluations",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Teams_TeamId",
                table: "Participants",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rewards_Hackatons_HackatonId",
                table: "Rewards",
                column: "HackatonId",
                principalTable: "Hackatons",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Hackatons_HackatonId",
                table: "Teams",
                column: "HackatonId",
                principalTable: "Hackatons",
                principalColumn: "Id");
        }
    }
}
