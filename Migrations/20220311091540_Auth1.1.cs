using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantAuthentication.Migrations
{
    public partial class Auth11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TenantId",
                table: "Logins",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tenant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenant", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_TenantId",
                table: "Logins",
                column: "TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Tenant_TenantId",
                table: "Logins",
                column: "TenantId",
                principalTable: "Tenant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Tenant_TenantId",
                table: "Logins");

            migrationBuilder.DropTable(
                name: "Tenant");

            migrationBuilder.DropIndex(
                name: "IX_Logins_TenantId",
                table: "Logins");

            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "Logins");
        }
    }
}
