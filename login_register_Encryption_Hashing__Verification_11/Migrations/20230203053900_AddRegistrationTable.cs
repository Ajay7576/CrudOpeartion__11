using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace login_register_Encryption_Hashing__Verification_11.Migrations
{
    public partial class AddRegistrationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailSendTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsEmailVerified = table.Column<bool>(type: "bit", nullable: false),
                    OtpSendTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registrations");
        }
    }
}
