using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class ContextAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Crust",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crust", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SelectedStoreEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Users_Stores_SelectedStoreEntityId",
                        column: x => x.SelectedStoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Order_Stores_StoreEntityId",
                        column: x => x.StoreEntityId,
                        principalTable: "Stores",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Users_UserEntityId",
                        column: x => x.UserEntityId,
                        principalTable: "Users",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "APizzaModel",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CrustEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SizeEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OrderEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizzaModel", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_APizzaModel_Crust_CrustEntityId",
                        column: x => x.CrustEntityId,
                        principalTable: "Crust",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_APizzaModel_Order_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "Order",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_APizzaModel_Size_SizeEntityId",
                        column: x => x.SizeEntityId,
                        principalTable: "Size",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    APizzaModelEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Toppings_APizzaModel_APizzaModelEntityId",
                        column: x => x.APizzaModelEntityId,
                        principalTable: "APizzaModel",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Crust",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("ece05d2a-383a-47c7-aa2f-763203b9a058"), "Brooklyn", 2m },
                    { new Guid("654c3a49-2b5d-48b3-9e04-b899c2d48921"), "Deep Dish", 3m },
                    { new Guid("7028b55a-02ec-4429-9298-ec7c100bdf3e"), "Hand Tossed", 1m }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "EntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("bebff9da-4cf0-47f2-bb03-fc55a85e0b19"), "Large", 15m },
                    { new Guid("bfb8491d-9e8c-4a62-9b96-d83ff3436ff4"), "Medium", 12m },
                    { new Guid("a5ce67b5-7990-4042-a3f4-9db5dfb3eb4b"), "Small", 9m }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "EntityId", "Name" },
                values: new object[,]
                {
                    { new Guid("e34c7963-100b-4d66-9ac3-0d2fdd8dbabd"), "Home Slice" },
                    { new Guid("db9d19d4-83f8-44e4-bda0-cfbf297dac5e"), "Pinthouse Pizza Co" }
                });

            migrationBuilder.InsertData(
                table: "Toppings",
                columns: new[] { "EntityId", "APizzaModelEntityId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6b3480c3-75ac-4b4d-86b5-7d9e7d704adb"), null, "Cheese", 0m },
                    { new Guid("15fe1345-fe4a-44d5-b10f-43931d4fca07"), null, "Pepperoni", 1m },
                    { new Guid("64bb23cb-61d0-4e2d-8da7-80455d29b62c"), null, "Pineapple", 1m },
                    { new Guid("296a5806-54ad-484b-95b2-14c3880f2c4a"), null, "Bell Pepper", 1m },
                    { new Guid("e809c245-d894-41ef-95ad-2b97ed99b01f"), null, "Bacon", 2m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizzaModel_CrustEntityId",
                table: "APizzaModel",
                column: "CrustEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_APizzaModel_OrderEntityId",
                table: "APizzaModel",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_APizzaModel_SizeEntityId",
                table: "APizzaModel",
                column: "SizeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreEntityId",
                table: "Order",
                column: "StoreEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserEntityId",
                table: "Order",
                column: "UserEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Toppings_APizzaModelEntityId",
                table: "Toppings",
                column: "APizzaModelEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_SelectedStoreEntityId",
                table: "Users",
                column: "SelectedStoreEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "APizzaModel");

            migrationBuilder.DropTable(
                name: "Crust");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
