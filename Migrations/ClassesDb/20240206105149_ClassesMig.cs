using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolApplicationCrud.Migrations.ClassesDb
{
    public partial class ClassesMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Class_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Class_Section = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Class_Name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
