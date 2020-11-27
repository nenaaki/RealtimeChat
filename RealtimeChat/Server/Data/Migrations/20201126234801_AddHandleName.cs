using Microsoft.EntityFrameworkCore.Migrations;

namespace RealtimeChat.Server.Data.Migrations
{
    public partial class AddHandleName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HandleName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HandleName",
                table: "AspNetUsers");
        }
    }
}
