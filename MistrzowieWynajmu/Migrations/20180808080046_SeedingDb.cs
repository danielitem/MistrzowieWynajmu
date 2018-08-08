using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace MistrzowieWynajmu.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Daniel', 'Dybek', '123456789')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Weronika', 'Gwiazda-Dybek', '923456789')");
            migrationBuilder.Sql("INSERT INTO Owners (Name, Surname, Phone) VALUES ('Perła', 'Dybek', '173456789')");

            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Niemcewicza', 'Kraków')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Myślenicka', 'Kraków')");
            migrationBuilder.Sql("INSERT INTO Addresses (Street, City) VALUES ('Cechowa', 'Kraków')");

            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0, 'Opis1', 7, 170, 1, 1, 1, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (0, 'Opis2', 5, 120, 1, 1, 0, 2, 2)");
            migrationBuilder.Sql("INSERT INTO Properties (Type, Description, Rooms, Area, Washer, Refrigerator, Iron, AddressId, OwnerId) VALUES (1, 'Opis3', 2, 70, 1, 0, 1, 3, 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
