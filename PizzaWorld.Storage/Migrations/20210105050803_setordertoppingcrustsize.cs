using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class setordertoppingcrustsize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Crust_CrustEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Size_SizeEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Users_UserEntityId",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Size",
                table: "Size");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crust",
                table: "Crust");

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("07e04c45-b87c-4999-b764-18435ef3e32e"));

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("2471c503-01bf-4c26-8ea4-89351fba9d73"));

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("d5ea8184-2bb7-4e21-84ac-0c6524ac6fe3"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("5da2279b-00b7-4203-af9b-2f3cdf3eaa95"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("871f9043-2c13-423b-ae33-8c5ebd39dc96"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("91418252-112e-4b0e-9a6b-1f224aac4bc0"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("8cb4f5b2-fd1b-4be1-818c-dd4c6e7bb550"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("9183b298-a336-4fd6-a507-9599256e885d"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("2361c73f-9c5e-4439-9337-56b3f1e02c8a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("51c0397a-3342-4f69-935c-cb2ebfc462bb"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("70b63315-ab14-4592-a5a9-afe873e1a79a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("a3d08d54-7afa-4228-b63a-547e9e352169"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("ac9fc7ab-d18d-4c76-bc00-816efdfbad22"));

            migrationBuilder.RenameTable(
                name: "Size",
                newName: "Sizes");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Crust",
                newName: "Crusts");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserEntityId",
                table: "Orders",
                newName: "IX_Orders_UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_StoreEntityId",
                table: "Orders",
                newName: "IX_Orders_StoreEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts",
                column: "EntityId");

            migrationBuilder.InsertData(
                table: "Crusts",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("ed4beb48-c69a-42d5-a4db-806f910bc0c9"), "Brooklyn", 2m },
                    { new Guid("b9b40d2b-1478-4337-b20e-a0018fe56e8b"), "Deep Dish", 3m },
                    { new Guid("dc13f602-38d0-4ecd-a223-8e22fd3b7b9f"), "Hand Tossed", 1m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("62582259-5239-4037-b33f-17e7b373a71a"), "Large", 15m },
                    { new Guid("00e502b6-23dd-495f-aea7-39b145339fa2"), "Medium", 12m },
                    { new Guid("d544eb31-8d2a-42db-877a-6dbed1bbebb9"), "Small", 9m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { new Guid("71b4cba6-cd12-429c-b0e9-085c6711f258"), "Home Slice" },
                    { new Guid("a5713a92-fe9c-4874-b6d8-a0e618fecdd7"), "Pinthouse Pizza Co" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "APizzaModelEntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6fd80b32-084b-463e-a595-3a0e7a124df8"), null, "Cheese", 0m },
                    { new Guid("8e94d8d3-dbd9-4a26-9434-4dc9b71010d4"), null, "Pepperoni", 1m },
                    { new Guid("619b994d-2a2f-4464-b6db-a6c41b0f03b3"), null, "Pineapple", 1m },
                    { new Guid("519311e3-6934-4d13-b9c7-1236ad973f7e"), null, "Bell Pepper", 1m },
                    { new Guid("f3a20af7-4d0a-4d33-a391-a0d614aa7f32"), null, "Bacon", 2m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Crusts_CrustEntityId",
                table: "APizzaModel",
                column: "CrustEntityId",
                principalTable: "Crusts",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Orders_OrderEntityId",
                table: "APizzaModel",
                column: "OrderEntityId",
                principalTable: "Orders",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Sizes_SizeEntityId",
                table: "APizzaModel",
                column: "SizeEntityId",
                principalTable: "Sizes",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserEntityId",
                table: "Orders",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Crusts_CrustEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Orders_OrderEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_APizzaModel_Sizes_SizeEntityId",
                table: "APizzaModel");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Stores_StoreEntityId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserEntityId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sizes",
                table: "Sizes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Crusts",
                table: "Crusts");

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: new Guid("b9b40d2b-1478-4337-b20e-a0018fe56e8b"));

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: new Guid("dc13f602-38d0-4ecd-a223-8e22fd3b7b9f"));

            migrationBuilder.DeleteData(
                table: "Crusts",
                keyColumn: "EntityId",
                keyValue: new Guid("ed4beb48-c69a-42d5-a4db-806f910bc0c9"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: new Guid("00e502b6-23dd-495f-aea7-39b145339fa2"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: new Guid("62582259-5239-4037-b33f-17e7b373a71a"));

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "EntityId",
                keyValue: new Guid("d544eb31-8d2a-42db-877a-6dbed1bbebb9"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("71b4cba6-cd12-429c-b0e9-085c6711f258"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("a5713a92-fe9c-4874-b6d8-a0e618fecdd7"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("519311e3-6934-4d13-b9c7-1236ad973f7e"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("619b994d-2a2f-4464-b6db-a6c41b0f03b3"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("6fd80b32-084b-463e-a595-3a0e7a124df8"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("8e94d8d3-dbd9-4a26-9434-4dc9b71010d4"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("f3a20af7-4d0a-4d33-a391-a0d614aa7f32"));

            migrationBuilder.RenameTable(
                name: "Sizes",
                newName: "Size");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Crusts",
                newName: "Crust");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserEntityId",
                table: "Order",
                newName: "IX_Order_UserEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_StoreEntityId",
                table: "Order",
                newName: "IX_Order_StoreEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Size",
                table: "Size",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "EntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Crust",
                table: "Crust",
                column: "EntityId");

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("07e04c45-b87c-4999-b764-18435ef3e32e"), "Brooklyn", 2m },
                    { new Guid("2471c503-01bf-4c26-8ea4-89351fba9d73"), "Deep Dish", 3m },
                    { new Guid("d5ea8184-2bb7-4e21-84ac-0c6524ac6fe3"), "Hand Tossed", 1m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("91418252-112e-4b0e-9a6b-1f224aac4bc0"), "Large", 15m },
                    { new Guid("5da2279b-00b7-4203-af9b-2f3cdf3eaa95"), "Medium", 12m },
                    { new Guid("871f9043-2c13-423b-ae33-8c5ebd39dc96"), "Small", 9m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { new Guid("9183b298-a336-4fd6-a507-9599256e885d"), "Home Slice" },
                    { new Guid("8cb4f5b2-fd1b-4be1-818c-dd4c6e7bb550"), "Pinthouse Pizza Co" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "APizzaModelEntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a3d08d54-7afa-4228-b63a-547e9e352169"), null, "Cheese", 0m },
                    { new Guid("51c0397a-3342-4f69-935c-cb2ebfc462bb"), null, "Pepperoni", 1m },
                    { new Guid("2361c73f-9c5e-4439-9337-56b3f1e02c8a"), null, "Pineapple", 1m },
                    { new Guid("70b63315-ab14-4592-a5a9-afe873e1a79a"), null, "Bell Pepper", 1m },
                    { new Guid("ac9fc7ab-d18d-4c76-bc00-816efdfbad22"), null, "Bacon", 2m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Crust_CrustEntityId",
                table: "APizzaModel",
                column: "CrustEntityId",
                principalTable: "Crust",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Order_OrderEntityId",
                table: "APizzaModel",
                column: "OrderEntityId",
                principalTable: "Order",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_APizzaModel_Size_SizeEntityId",
                table: "APizzaModel",
                column: "SizeEntityId",
                principalTable: "Size",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Stores_StoreEntityId",
                table: "Order",
                column: "StoreEntityId",
                principalTable: "Stores",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Users_UserEntityId",
                table: "Order",
                column: "UserEntityId",
                principalTable: "Users",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
