using Microsoft.EntityFrameworkCore.Migrations;

namespace WilbertVaultCompany.api.Migrations
{
    public partial class modifyFuneralHome : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_Deceased_DeceasedId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Delivery_VaultOrder_VaultOrderId",
                table: "Delivery");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Plant_PlantId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHome_Plant_PlantId",
                table: "FuneralHome");

            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomeContact_FuneralHome_FuneralHomeId",
                table: "FuneralHomeContact");

            migrationBuilder.DropForeignKey(
                name: "FK_Interaction_FuneralHome_FuneralHomeId",
                table: "Interaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Employee_EmployeeId",
                table: "Phone");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_FuneralHome_FuneralHomeId",
                table: "Phone");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_FuneralHomeContact_FuneralHomeContactId",
                table: "Phone");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Plant_PlantId",
                table: "Phone");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_FuneralHome_FuneralHomeId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Truck_TruckId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Truck_Employee_DriverEmployeeId",
                table: "Truck");

            migrationBuilder.DropForeignKey(
                name: "FK_Truck_Plant_PlantId",
                table: "Truck");

            migrationBuilder.DropForeignKey(
                name: "FK_Vault_AllowedToSelect_AllowedToSelectId",
                table: "Vault");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Cemetary_CemetaryId",
                table: "VaultOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Deceased_DeceasedId",
                table: "VaultOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Plant_PlantId",
                table: "VaultOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrder_Vault_VaultId",
                table: "VaultOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaultOrder",
                table: "VaultOrder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vault",
                table: "Vault");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Truck",
                table: "Truck");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plant",
                table: "Plant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photo",
                table: "Photo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phone",
                table: "Phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interaction",
                table: "Interaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuneralHomeContact",
                table: "FuneralHomeContact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuneralHome",
                table: "FuneralHome");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deceased",
                table: "Deceased");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cemetary",
                table: "Cemetary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllowedToSelect",
                table: "AllowedToSelect");

            migrationBuilder.RenameTable(
                name: "VaultOrder",
                newName: "VaultOrders");

            migrationBuilder.RenameTable(
                name: "Vault",
                newName: "Vaults");

            migrationBuilder.RenameTable(
                name: "Truck",
                newName: "Trucks");

            migrationBuilder.RenameTable(
                name: "Plant",
                newName: "Plants");

            migrationBuilder.RenameTable(
                name: "Photo",
                newName: "Photos");

            migrationBuilder.RenameTable(
                name: "Phone",
                newName: "Phones");

            migrationBuilder.RenameTable(
                name: "Interaction",
                newName: "Interactions");

            migrationBuilder.RenameTable(
                name: "FuneralHomeContact",
                newName: "FuneralHomeContacts");

            migrationBuilder.RenameTable(
                name: "FuneralHome",
                newName: "FuneralHomes");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameTable(
                name: "Delivery",
                newName: "Deliveries");

            migrationBuilder.RenameTable(
                name: "Deceased",
                newName: "Deceaseds");

            migrationBuilder.RenameTable(
                name: "Cemetary",
                newName: "Cemetaries");

            migrationBuilder.RenameTable(
                name: "AllowedToSelect",
                newName: "AllowedToSelects");

            migrationBuilder.RenameColumn(
                name: "newFuneralHome",
                table: "VaultOrders",
                newName: "NewFuneralHome");

            migrationBuilder.RenameColumn(
                name: "newFuneralDirector",
                table: "VaultOrders",
                newName: "NewFuneralDirector");

            migrationBuilder.RenameColumn(
                name: "funeralHome",
                table: "VaultOrders",
                newName: "FuneralHome");

            migrationBuilder.RenameColumn(
                name: "funeralDirector",
                table: "VaultOrders",
                newName: "FuneralDirector");

            migrationBuilder.RenameColumn(
                name: "category",
                table: "VaultOrders",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "FDRequest",
                table: "VaultOrders",
                newName: "Fdrequest");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_VaultId",
                table: "VaultOrders",
                newName: "IX_VaultOrders_VaultId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_PlantId",
                table: "VaultOrders",
                newName: "IX_VaultOrders_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_DeceasedId",
                table: "VaultOrders",
                newName: "IX_VaultOrders_DeceasedId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrder_CemetaryId",
                table: "VaultOrders",
                newName: "IX_VaultOrders_CemetaryId");

            migrationBuilder.RenameIndex(
                name: "IX_Vault_AllowedToSelectId",
                table: "Vaults",
                newName: "IX_Vaults_AllowedToSelectId");

            migrationBuilder.RenameColumn(
                name: "VIN",
                table: "Trucks",
                newName: "Vin");

            migrationBuilder.RenameIndex(
                name: "IX_Truck_PlantId",
                table: "Trucks",
                newName: "IX_Trucks_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Truck_DriverEmployeeId",
                table: "Trucks",
                newName: "IX_Trucks_DriverEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_TruckId",
                table: "Photos",
                newName: "IX_Photos_TruckId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_FuneralHomeId",
                table: "Photos",
                newName: "IX_Photos_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_PlantId",
                table: "Phones",
                newName: "IX_Phones_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_FuneralHomeId",
                table: "Phones",
                newName: "IX_Phones_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_FuneralHomeContactId",
                table: "Phones",
                newName: "IX_Phones_FuneralHomeContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_EmployeeId",
                table: "Phones",
                newName: "IX_Phones_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interaction_FuneralHomeId",
                table: "Interactions",
                newName: "IX_Interactions_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_FuneralHomeContact_FuneralHomeId",
                table: "FuneralHomeContacts",
                newName: "IX_FuneralHomeContacts_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_FuneralHome_PlantId",
                table: "FuneralHomes",
                newName: "IX_FuneralHomes_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Employee_PlantId",
                table: "Employees",
                newName: "IX_Employees_PlantId");

            migrationBuilder.RenameColumn(
                name: "FDCommentsAndRemarks",
                table: "Deliveries",
                newName: "FdcommentsAndRemarks");

            migrationBuilder.RenameColumn(
                name: "FDArrivalTime",
                table: "Deliveries",
                newName: "FdarrivalTime");

            migrationBuilder.RenameColumn(
                name: "TimeIn_Plant",
                table: "Deliveries",
                newName: "TimeInPlant");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_VaultOrderId",
                table: "Deliveries",
                newName: "IX_Deliveries_VaultOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Delivery_DeceasedId",
                table: "Deliveries",
                newName: "IX_Deliveries_DeceasedId");

            migrationBuilder.RenameColumn(
                name: "suffix",
                table: "Deceaseds",
                newName: "Suffix");

            migrationBuilder.AddColumn<string>(
                name: "Phone1",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType1",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneType2",
                table: "FuneralHomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaultOrders",
                table: "VaultOrders",
                column: "VaultOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vaults",
                table: "Vaults",
                column: "VaultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trucks",
                table: "Trucks",
                column: "TruckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plants",
                table: "Plants",
                column: "PlantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photos",
                table: "Photos",
                column: "PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interactions",
                table: "Interactions",
                column: "InteractionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuneralHomeContacts",
                table: "FuneralHomeContacts",
                column: "FuneralHomeContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuneralHomes",
                table: "FuneralHomes",
                column: "FuneralHomeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries",
                column: "DeliveryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deceaseds",
                table: "Deceaseds",
                column: "DeceasedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cemetaries",
                table: "Cemetaries",
                column: "CemetaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllowedToSelects",
                table: "AllowedToSelects",
                column: "AllowedToSelectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_Deceaseds_DeceasedId",
                table: "Deliveries",
                column: "DeceasedId",
                principalTable: "Deceaseds",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Deliveries_VaultOrders_VaultOrderId",
                table: "Deliveries",
                column: "VaultOrderId",
                principalTable: "VaultOrders",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Plants_PlantId",
                table: "Employees",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomeContacts_FuneralHomes_FuneralHomeId",
                table: "FuneralHomeContacts",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomes_Plants_PlantId",
                table: "FuneralHomes",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Interactions_FuneralHomes_FuneralHomeId",
                table: "Interactions",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Employees_EmployeeId",
                table: "Phones",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_FuneralHomeContacts_FuneralHomeContactId",
                table: "Phones",
                column: "FuneralHomeContactId",
                principalTable: "FuneralHomeContacts",
                principalColumn: "FuneralHomeContactId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_FuneralHomes_FuneralHomeId",
                table: "Phones",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Plants_PlantId",
                table: "Phones",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_FuneralHomes_FuneralHomeId",
                table: "Photos",
                column: "FuneralHomeId",
                principalTable: "FuneralHomes",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Trucks_TruckId",
                table: "Photos",
                column: "TruckId",
                principalTable: "Trucks",
                principalColumn: "TruckId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Employees_DriverEmployeeId",
                table: "Trucks",
                column: "DriverEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Plants_PlantId",
                table: "Trucks",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrders_Cemetaries_CemetaryId",
                table: "VaultOrders",
                column: "CemetaryId",
                principalTable: "Cemetaries",
                principalColumn: "CemetaryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrders_Deceaseds_DeceasedId",
                table: "VaultOrders",
                column: "DeceasedId",
                principalTable: "Deceaseds",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrders_Plants_PlantId",
                table: "VaultOrders",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrders_Vaults_VaultId",
                table: "VaultOrders",
                column: "VaultId",
                principalTable: "Vaults",
                principalColumn: "VaultId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaults_AllowedToSelects_AllowedToSelectId",
                table: "Vaults",
                column: "AllowedToSelectId",
                principalTable: "AllowedToSelects",
                principalColumn: "AllowedToSelectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_Deceaseds_DeceasedId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Deliveries_VaultOrders_VaultOrderId",
                table: "Deliveries");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Plants_PlantId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomeContacts_FuneralHomes_FuneralHomeId",
                table: "FuneralHomeContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_FuneralHomes_Plants_PlantId",
                table: "FuneralHomes");

            migrationBuilder.DropForeignKey(
                name: "FK_Interactions_FuneralHomes_FuneralHomeId",
                table: "Interactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Employees_EmployeeId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_FuneralHomeContacts_FuneralHomeContactId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_FuneralHomes_FuneralHomeId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Plants_PlantId",
                table: "Phones");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_FuneralHomes_FuneralHomeId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Trucks_TruckId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Employees_DriverEmployeeId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Plants_PlantId",
                table: "Trucks");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrders_Cemetaries_CemetaryId",
                table: "VaultOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrders_Deceaseds_DeceasedId",
                table: "VaultOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrders_Plants_PlantId",
                table: "VaultOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_VaultOrders_Vaults_VaultId",
                table: "VaultOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaults_AllowedToSelects_AllowedToSelectId",
                table: "Vaults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vaults",
                table: "Vaults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VaultOrders",
                table: "VaultOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trucks",
                table: "Trucks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plants",
                table: "Plants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Photos",
                table: "Photos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interactions",
                table: "Interactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuneralHomes",
                table: "FuneralHomes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FuneralHomeContacts",
                table: "FuneralHomeContacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deliveries",
                table: "Deliveries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deceaseds",
                table: "Deceaseds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cemetaries",
                table: "Cemetaries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AllowedToSelects",
                table: "AllowedToSelects");

            migrationBuilder.DropColumn(
                name: "Phone1",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "PhoneType1",
                table: "FuneralHomes");

            migrationBuilder.DropColumn(
                name: "PhoneType2",
                table: "FuneralHomes");

            migrationBuilder.RenameTable(
                name: "Vaults",
                newName: "Vault");

            migrationBuilder.RenameTable(
                name: "VaultOrders",
                newName: "VaultOrder");

            migrationBuilder.RenameTable(
                name: "Trucks",
                newName: "Truck");

            migrationBuilder.RenameTable(
                name: "Plants",
                newName: "Plant");

            migrationBuilder.RenameTable(
                name: "Photos",
                newName: "Photo");

            migrationBuilder.RenameTable(
                name: "Phones",
                newName: "Phone");

            migrationBuilder.RenameTable(
                name: "Interactions",
                newName: "Interaction");

            migrationBuilder.RenameTable(
                name: "FuneralHomes",
                newName: "FuneralHome");

            migrationBuilder.RenameTable(
                name: "FuneralHomeContacts",
                newName: "FuneralHomeContact");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameTable(
                name: "Deliveries",
                newName: "Delivery");

            migrationBuilder.RenameTable(
                name: "Deceaseds",
                newName: "Deceased");

            migrationBuilder.RenameTable(
                name: "Cemetaries",
                newName: "Cemetary");

            migrationBuilder.RenameTable(
                name: "AllowedToSelects",
                newName: "AllowedToSelect");

            migrationBuilder.RenameIndex(
                name: "IX_Vaults_AllowedToSelectId",
                table: "Vault",
                newName: "IX_Vault_AllowedToSelectId");

            migrationBuilder.RenameColumn(
                name: "NewFuneralHome",
                table: "VaultOrder",
                newName: "newFuneralHome");

            migrationBuilder.RenameColumn(
                name: "NewFuneralDirector",
                table: "VaultOrder",
                newName: "newFuneralDirector");

            migrationBuilder.RenameColumn(
                name: "FuneralHome",
                table: "VaultOrder",
                newName: "funeralHome");

            migrationBuilder.RenameColumn(
                name: "FuneralDirector",
                table: "VaultOrder",
                newName: "funeralDirector");

            migrationBuilder.RenameColumn(
                name: "Fdrequest",
                table: "VaultOrder",
                newName: "FDRequest");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "VaultOrder",
                newName: "category");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrders_VaultId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_VaultId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrders_PlantId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrders_DeceasedId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_DeceasedId");

            migrationBuilder.RenameIndex(
                name: "IX_VaultOrders_CemetaryId",
                table: "VaultOrder",
                newName: "IX_VaultOrder_CemetaryId");

            migrationBuilder.RenameColumn(
                name: "Vin",
                table: "Truck",
                newName: "VIN");

            migrationBuilder.RenameIndex(
                name: "IX_Trucks_PlantId",
                table: "Truck",
                newName: "IX_Truck_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Trucks_DriverEmployeeId",
                table: "Truck",
                newName: "IX_Truck_DriverEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_TruckId",
                table: "Photo",
                newName: "IX_Photo_TruckId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_FuneralHomeId",
                table: "Photo",
                newName: "IX_Photo_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_PlantId",
                table: "Phone",
                newName: "IX_Phone_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_FuneralHomeId",
                table: "Phone",
                newName: "IX_Phone_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_FuneralHomeContactId",
                table: "Phone",
                newName: "IX_Phone_FuneralHomeContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_EmployeeId",
                table: "Phone",
                newName: "IX_Phone_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_Interactions_FuneralHomeId",
                table: "Interaction",
                newName: "IX_Interaction_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_FuneralHomes_PlantId",
                table: "FuneralHome",
                newName: "IX_FuneralHome_PlantId");

            migrationBuilder.RenameIndex(
                name: "IX_FuneralHomeContacts_FuneralHomeId",
                table: "FuneralHomeContact",
                newName: "IX_FuneralHomeContact_FuneralHomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PlantId",
                table: "Employee",
                newName: "IX_Employee_PlantId");

            migrationBuilder.RenameColumn(
                name: "FdcommentsAndRemarks",
                table: "Delivery",
                newName: "FDCommentsAndRemarks");

            migrationBuilder.RenameColumn(
                name: "FdarrivalTime",
                table: "Delivery",
                newName: "FDArrivalTime");

            migrationBuilder.RenameColumn(
                name: "TimeInPlant",
                table: "Delivery",
                newName: "TimeIn_Plant");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_VaultOrderId",
                table: "Delivery",
                newName: "IX_Delivery_VaultOrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Deliveries_DeceasedId",
                table: "Delivery",
                newName: "IX_Delivery_DeceasedId");

            migrationBuilder.RenameColumn(
                name: "Suffix",
                table: "Deceased",
                newName: "suffix");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vault",
                table: "Vault",
                column: "VaultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VaultOrder",
                table: "VaultOrder",
                column: "VaultOrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Truck",
                table: "Truck",
                column: "TruckId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plant",
                table: "Plant",
                column: "PlantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Photo",
                table: "Photo",
                column: "PhotoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phone",
                table: "Phone",
                column: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interaction",
                table: "Interaction",
                column: "InteractionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuneralHome",
                table: "FuneralHome",
                column: "FuneralHomeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuneralHomeContact",
                table: "FuneralHomeContact",
                column: "FuneralHomeContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Delivery",
                table: "Delivery",
                column: "DeliveryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deceased",
                table: "Deceased",
                column: "DeceasedId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cemetary",
                table: "Cemetary",
                column: "CemetaryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AllowedToSelect",
                table: "AllowedToSelect",
                column: "AllowedToSelectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_Deceased_DeceasedId",
                table: "Delivery",
                column: "DeceasedId",
                principalTable: "Deceased",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Delivery_VaultOrder_VaultOrderId",
                table: "Delivery",
                column: "VaultOrderId",
                principalTable: "VaultOrder",
                principalColumn: "VaultOrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Plant_PlantId",
                table: "Employee",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHome_Plant_PlantId",
                table: "FuneralHome",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuneralHomeContact_FuneralHome_FuneralHomeId",
                table: "FuneralHomeContact",
                column: "FuneralHomeId",
                principalTable: "FuneralHome",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interaction_FuneralHome_FuneralHomeId",
                table: "Interaction",
                column: "FuneralHomeId",
                principalTable: "FuneralHome",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Employee_EmployeeId",
                table: "Phone",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_FuneralHome_FuneralHomeId",
                table: "Phone",
                column: "FuneralHomeId",
                principalTable: "FuneralHome",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_FuneralHomeContact_FuneralHomeContactId",
                table: "Phone",
                column: "FuneralHomeContactId",
                principalTable: "FuneralHomeContact",
                principalColumn: "FuneralHomeContactId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Plant_PlantId",
                table: "Phone",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_FuneralHome_FuneralHomeId",
                table: "Photo",
                column: "FuneralHomeId",
                principalTable: "FuneralHome",
                principalColumn: "FuneralHomeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Truck_TruckId",
                table: "Photo",
                column: "TruckId",
                principalTable: "Truck",
                principalColumn: "TruckId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Truck_Employee_DriverEmployeeId",
                table: "Truck",
                column: "DriverEmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Truck_Plant_PlantId",
                table: "Truck",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vault_AllowedToSelect_AllowedToSelectId",
                table: "Vault",
                column: "AllowedToSelectId",
                principalTable: "AllowedToSelect",
                principalColumn: "AllowedToSelectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Cemetary_CemetaryId",
                table: "VaultOrder",
                column: "CemetaryId",
                principalTable: "Cemetary",
                principalColumn: "CemetaryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Deceased_DeceasedId",
                table: "VaultOrder",
                column: "DeceasedId",
                principalTable: "Deceased",
                principalColumn: "DeceasedId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Plant_PlantId",
                table: "VaultOrder",
                column: "PlantId",
                principalTable: "Plant",
                principalColumn: "PlantId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VaultOrder_Vault_VaultId",
                table: "VaultOrder",
                column: "VaultId",
                principalTable: "Vault",
                principalColumn: "VaultId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
