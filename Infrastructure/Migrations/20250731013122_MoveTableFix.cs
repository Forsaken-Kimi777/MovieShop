using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MoveTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Review_MovieId",
                table: "Review",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Movie_MovieId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_MovieId",
                table: "Review");
        }
    }
}
