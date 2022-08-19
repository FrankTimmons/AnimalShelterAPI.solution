using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Breed", "Gender", "Name" },
                values: new object[] { 1, "Tuxedo", "Female", "Cuddles" });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Breed", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, "Labradoodle", "Male", "Marvin" },
                    { 2, "Boston Terrier", "Male", "Reggie" },
                    { 3, "Rat Terrier", "Female", "Sushi" },
                    { 4, "Greyhound", "Female", "Eva" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);
        }
    }
}
