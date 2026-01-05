using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.Migrations
{
    /// <inheritdoc />
    public partial class CompleteRelationShips : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "employeeId",
                table: "Payrolls",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmployeeAttendance",
                columns: table => new
                {
                    attendanceid = table.Column<int>(type: "int", nullable: false),
                    employeesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeAttendance", x => new { x.attendanceid, x.employeesid });
                    table.ForeignKey(
                        name: "FK_EmployeeAttendance_Attendances_attendanceid",
                        column: x => x.attendanceid,
                        principalTable: "Attendances",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeAttendance_Employees_employeesid",
                        column: x => x.employeesid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeaves",
                columns: table => new
                {
                    employeesid = table.Column<int>(type: "int", nullable: false),
                    leavesid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeaves", x => new { x.employeesid, x.leavesid });
                    table.ForeignKey(
                        name: "FK_EmployeeLeaves_Employees_employeesid",
                        column: x => x.employeesid,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLeaves_Leaves_leavesid",
                        column: x => x.leavesid,
                        principalTable: "Leaves",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payrolls_employeeId",
                table: "Payrolls",
                column: "employeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttendance_employeesid",
                table: "EmployeeAttendance",
                column: "employeesid");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLeaves_leavesid",
                table: "EmployeeLeaves",
                column: "leavesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Payrolls_Employees_employeeId",
                table: "Payrolls",
                column: "employeeId",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payrolls_Employees_employeeId",
                table: "Payrolls");

            migrationBuilder.DropTable(
                name: "EmployeeAttendance");

            migrationBuilder.DropTable(
                name: "EmployeeLeaves");

            migrationBuilder.DropIndex(
                name: "IX_Payrolls_employeeId",
                table: "Payrolls");

            migrationBuilder.DropColumn(
                name: "employeeId",
                table: "Payrolls");
        }
    }
}
