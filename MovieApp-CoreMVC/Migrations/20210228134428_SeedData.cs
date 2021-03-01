using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp_CoreMVC.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Student");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Student",
                newName: "MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "MovieId");

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "MovieId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Set in a dystopian future where humanity is struggling to survive, the film follows a group of astronauts who travel through a wormhole near Saturn in search of a new home for mankind.", "Interstellar_film_poster.jpg", "Interstellar" },
                    { 2, "It depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, created by intelligent machines to distract humans while using their bodies as an energy source", "matrix.jpg", "Matrix" },
                    { 3, "The ending of “Shutter Island” reveals that DiCaprio's character is a patient himself, committed to the Shutter Island facility after murdering his wife (Michelle Williams) because she went insane and killed their children.", "shutterisland.jpg", "Shutter Island" },
                    { 4, "The Godfather is a 1972 American crime film directed by Francis Ford Coppola, who co-wrote the screenplay with Mario Puzo, based on Puzo's best-selling 1969 novel of the same name. ", "godfather.jpg", "God Father" },
                    { 5, "Ace Ventura is a fictional character created by Canadian screenwriter Jack Bernstein. Ace was performed by Jim Carrey in the films Ace Ventura: Pet Detective, released in 1994, and Ace Ventura: When Nature Calls, released in 1995, and was voiced by Michael Daingerfield in the Ace Ventura: Pet Detective television series.", "aceventura.jpg", "Aceventura" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "MovieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "MovieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "MovieId",
                keyValue: 5);

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Movies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Movies",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
