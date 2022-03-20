using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hdogs.api.Migrations
{
    public partial class firstV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admin_auth_data_AuthDataId",
                table: "admin");

            migrationBuilder.DropForeignKey(
                name: "FK_client_auth_data_AuthDataId",
                table: "client");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_admin_PersonId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_auth_data_AuthDataId",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_pet_client_ClientId",
                table: "pet");

            migrationBuilder.DropForeignKey(
                name: "FK_service_client_ClientId",
                table: "service");

            migrationBuilder.DropForeignKey(
                name: "FK_service_Monitors_MonitorId",
                table: "service");

            migrationBuilder.DropForeignKey(
                name: "FK_service_pet_PetId",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_ClientId",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_MonitorId",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_PetId",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_pet_ClientId",
                table: "pet");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_AuthDataId",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_client_AuthDataId",
                table: "client");

            migrationBuilder.DropIndex(
                name: "IX_admin_AuthDataId",
                table: "admin");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "service",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "PetId",
                table: "service",
                newName: "pet_id");

            migrationBuilder.RenameColumn(
                name: "MonitorId",
                table: "service",
                newName: "monitor_id");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "service",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "service",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "pet",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "pet",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "pet",
                newName: "client_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Monitors",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Monitors",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "AuthDataId",
                table: "Monitors",
                newName: "auth_data_id");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Monitors",
                newName: "auth_data_id1");

            migrationBuilder.RenameIndex(
                name: "IX_Monitors_PersonId",
                table: "Monitors",
                newName: "IX_Monitors_auth_data_id1");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "document",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "document",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "client",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "client",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "AuthDataId",
                table: "client",
                newName: "auth_data_id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "auth_data",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "auth_data",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "admin",
                newName: "updated_date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "admin",
                newName: "created_date");

            migrationBuilder.RenameColumn(
                name: "AuthDataId",
                table: "admin",
                newName: "auth_data_id");

            migrationBuilder.AddColumn<long>(
                name: "client_id1",
                table: "service",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "monitor_id1",
                table: "service",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "pet_id1",
                table: "service",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "client_id1",
                table: "pet",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "admin_id",
                table: "Monitors",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "auth_data_id1",
                table: "client",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "auth_data_id1",
                table: "admin",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_service_client_id1",
                table: "service",
                column: "client_id1");

            migrationBuilder.CreateIndex(
                name: "IX_service_monitor_id1",
                table: "service",
                column: "monitor_id1");

            migrationBuilder.CreateIndex(
                name: "IX_service_pet_id1",
                table: "service",
                column: "pet_id1");

            migrationBuilder.CreateIndex(
                name: "IX_pet_client_id1",
                table: "pet",
                column: "client_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_admin_id",
                table: "Monitors",
                column: "admin_id");

            migrationBuilder.CreateIndex(
                name: "IX_client_auth_data_id1",
                table: "client",
                column: "auth_data_id1");

            migrationBuilder.CreateIndex(
                name: "IX_admin_auth_data_id1",
                table: "admin",
                column: "auth_data_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_admin_auth_data_auth_data_id1",
                table: "admin",
                column: "auth_data_id1",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_client_auth_data_auth_data_id1",
                table: "client",
                column: "auth_data_id1",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_admin_admin_id",
                table: "Monitors",
                column: "admin_id",
                principalTable: "admin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_auth_data_auth_data_id1",
                table: "Monitors",
                column: "auth_data_id1",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pet_client_client_id1",
                table: "pet",
                column: "client_id1",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_client_client_id1",
                table: "service",
                column: "client_id1",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_Monitors_monitor_id1",
                table: "service",
                column: "monitor_id1",
                principalTable: "Monitors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_pet_pet_id1",
                table: "service",
                column: "pet_id1",
                principalTable: "pet",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_admin_auth_data_auth_data_id1",
                table: "admin");

            migrationBuilder.DropForeignKey(
                name: "FK_client_auth_data_auth_data_id1",
                table: "client");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_admin_admin_id",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_Monitors_auth_data_auth_data_id1",
                table: "Monitors");

            migrationBuilder.DropForeignKey(
                name: "FK_pet_client_client_id1",
                table: "pet");

            migrationBuilder.DropForeignKey(
                name: "FK_service_client_client_id1",
                table: "service");

            migrationBuilder.DropForeignKey(
                name: "FK_service_Monitors_monitor_id1",
                table: "service");

            migrationBuilder.DropForeignKey(
                name: "FK_service_pet_pet_id1",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_client_id1",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_monitor_id1",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_service_pet_id1",
                table: "service");

            migrationBuilder.DropIndex(
                name: "IX_pet_client_id1",
                table: "pet");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_admin_id",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_client_auth_data_id1",
                table: "client");

            migrationBuilder.DropIndex(
                name: "IX_admin_auth_data_id1",
                table: "admin");

            migrationBuilder.DropColumn(
                name: "client_id1",
                table: "service");

            migrationBuilder.DropColumn(
                name: "monitor_id1",
                table: "service");

            migrationBuilder.DropColumn(
                name: "pet_id1",
                table: "service");

            migrationBuilder.DropColumn(
                name: "client_id1",
                table: "pet");

            migrationBuilder.DropColumn(
                name: "admin_id",
                table: "Monitors");

            migrationBuilder.DropColumn(
                name: "auth_data_id1",
                table: "client");

            migrationBuilder.DropColumn(
                name: "auth_data_id1",
                table: "admin");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "service",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "pet_id",
                table: "service",
                newName: "PetId");

            migrationBuilder.RenameColumn(
                name: "monitor_id",
                table: "service",
                newName: "MonitorId");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "service",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "service",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "pet",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "pet",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "pet",
                newName: "ClientId");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "Monitors",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "Monitors",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "auth_data_id",
                table: "Monitors",
                newName: "AuthDataId");

            migrationBuilder.RenameColumn(
                name: "auth_data_id1",
                table: "Monitors",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_Monitors_auth_data_id1",
                table: "Monitors",
                newName: "IX_Monitors_PersonId");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "document",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "document",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "client",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "client",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "auth_data_id",
                table: "client",
                newName: "AuthDataId");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "auth_data",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "auth_data",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "updated_date",
                table: "admin",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "created_date",
                table: "admin",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "auth_data_id",
                table: "admin",
                newName: "AuthDataId");

            migrationBuilder.CreateIndex(
                name: "IX_service_ClientId",
                table: "service",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_service_MonitorId",
                table: "service",
                column: "MonitorId");

            migrationBuilder.CreateIndex(
                name: "IX_service_PetId",
                table: "service",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_pet_ClientId",
                table: "pet",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_AuthDataId",
                table: "Monitors",
                column: "AuthDataId");

            migrationBuilder.CreateIndex(
                name: "IX_client_AuthDataId",
                table: "client",
                column: "AuthDataId");

            migrationBuilder.CreateIndex(
                name: "IX_admin_AuthDataId",
                table: "admin",
                column: "AuthDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_admin_auth_data_AuthDataId",
                table: "admin",
                column: "AuthDataId",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_client_auth_data_AuthDataId",
                table: "client",
                column: "AuthDataId",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_admin_PersonId",
                table: "Monitors",
                column: "PersonId",
                principalTable: "admin",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monitors_auth_data_AuthDataId",
                table: "Monitors",
                column: "AuthDataId",
                principalTable: "auth_data",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_pet_client_ClientId",
                table: "pet",
                column: "ClientId",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_client_ClientId",
                table: "service",
                column: "ClientId",
                principalTable: "client",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_Monitors_MonitorId",
                table: "service",
                column: "MonitorId",
                principalTable: "Monitors",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_service_pet_PetId",
                table: "service",
                column: "PetId",
                principalTable: "pet",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
