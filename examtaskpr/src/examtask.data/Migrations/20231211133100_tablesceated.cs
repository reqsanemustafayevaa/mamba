using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examtask.data.Migrations
{
    public partial class tablesceated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imageurl",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imageurl",
                table: "Teams");
        }
    }
}
