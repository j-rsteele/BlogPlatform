using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class updatedBlogData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Technology");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Photography");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Travel");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "Tom B.", "Innovative technologies offer more immersive experiences like AR and VR. Virtual Reality immerses the user in a simulated environment, Augmented Reality is an overlay of technology in the real world. CISCO forecasts that globally, AR-VR traffic will increase 12-fold by 2022 in all fields of entertainment.", "Software technologies" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "John T.", "When most people think of fine art photography, their mind flashes to still lifes. Still lifes come in many forms, from the mundane art school bowl of fruit to the visually interesting digital creations you see online today. Still lifes can fall into any genre or class of photography, and it's a fundamental skill that all shutterbugs should try to master.", "Photography styles" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Body", "PublishDate", "Title" },
                values: new object[] { "Joe S.", "India, Morocco and Vietnam were ranked the top 3 best places to travel in 2021...", new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Best places to travel to this year" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Personal");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Technology");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Music");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "Tom", "...", "My Personal Blog" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "Body", "Title" },
                values: new object[] { "John", "...", "New in Tech" });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "Body", "PublishDate", "Title" },
                values: new object[] { "Joe", "...", new DateTime(2018, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "New Artists" });
        }
    }
}
