using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaWorld.Storage.Migrations
{
    public partial class updateuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("654c3a49-2b5d-48b3-9e04-b899c2d48921"));

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("7028b55a-02ec-4429-9298-ec7c100bdf3e"));

            migrationBuilder.DeleteData(
                table: "Crust",
                keyColumn: "EntityId",
                keyValue: new Guid("ece05d2a-383a-47c7-aa2f-763203b9a058"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("a5ce67b5-7990-4042-a3f4-9db5dfb3eb4b"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("bebff9da-4cf0-47f2-bb03-fc55a85e0b19"));

            migrationBuilder.DeleteData(
                table: "Size",
                keyColumn: "EntityId",
                keyValue: new Guid("bfb8491d-9e8c-4a62-9b96-d83ff3436ff4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("db9d19d4-83f8-44e4-bda0-cfbf297dac5e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "EntityId",
                keyValue: new Guid("e34c7963-100b-4d66-9ac3-0d2fdd8dbabd"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("15fe1345-fe4a-44d5-b10f-43931d4fca07"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("296a5806-54ad-484b-95b2-14c3880f2c4a"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("64bb23cb-61d0-4e2d-8da7-80455d29b62c"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("6b3480c3-75ac-4b4d-86b5-7d9e7d704adb"));

            migrationBuilder.DeleteData(
                table: "Toppings",
                keyColumn: "EntityId",
                keyValue: new Guid("e809c245-d894-41ef-95ad-2b97ed99b01f"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
