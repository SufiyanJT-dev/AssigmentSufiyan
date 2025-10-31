using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingSystem.Migrations
{
    /// <inheritdoc />
    public partial class testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_sReview_Customers_CustomerId",
                table: "sReview");

            migrationBuilder.DropForeignKey(
                name: "FK_sReview_Hotels_HotelId",
                table: "sReview");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sReview",
                table: "sReview");

            migrationBuilder.RenameTable(
                name: "sReview",
                newName: "Review");

            migrationBuilder.RenameIndex(
                name: "IX_sReview_HotelId",
                table: "Review",
                newName: "IX_Review_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_sReview_CustomerId",
                table: "Review",
                newName: "IX_Review_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Customers_CustomerId",
                table: "Review",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Hotels_HotelId",
                table: "Review",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Customers_CustomerId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Hotels_HotelId",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "sReview");

            migrationBuilder.RenameIndex(
                name: "IX_Review_HotelId",
                table: "sReview",
                newName: "IX_sReview_HotelId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CustomerId",
                table: "sReview",
                newName: "IX_sReview_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sReview",
                table: "sReview",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_sReview_Customers_CustomerId",
                table: "sReview",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sReview_Hotels_HotelId",
                table: "sReview",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
