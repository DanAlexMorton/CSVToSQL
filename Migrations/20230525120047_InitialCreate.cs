using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csvtosql.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstname = table.Column<string>(name: "first_name", type: "TEXT", nullable: false),
                    lastname = table.Column<string>(name: "last_name", type: "TEXT", nullable: false),
                    jobtitle = table.Column<string>(name: "job_title", type: "TEXT", nullable: false),
                    emailaddress = table.Column<string>(name: "email_address", type: "TEXT", nullable: false),
                    department = table.Column<string>(type: "TEXT", nullable: false),
                    contractType = table.Column<string>(name: "contract_Type", type: "TEXT", nullable: false),
                    companyname = table.Column<string>(name: "company_name", type: "TEXT", nullable: false),
                    businessphone = table.Column<string>(name: "business_phone", type: "TEXT", nullable: false),
                    street = table.Column<string>(type: "TEXT", nullable: false),
                    street2 = table.Column<string>(type: "TEXT", nullable: false),
                    city = table.Column<string>(type: "TEXT", nullable: false),
                    postcode = table.Column<string>(type: "TEXT", nullable: false),
                    country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
