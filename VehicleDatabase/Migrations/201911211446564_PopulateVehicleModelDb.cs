namespace VehicleDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleModelDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('1series', '120i', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('1series', '135i', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('3series', '320d', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('3series', '330xd', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('5series', '530i', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('5series', '520d', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('X5', 'xDrive30i', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('X5', 'xDrive40i', 1 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Fiesta', 'Fiesta', 2 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Mondeo', 'Mondeo', 2 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Escort', 'Escort', 2 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Mustang', 'Mustang', 2 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Giulia', 'Giulia', 3 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Stelvio', 'Stelvio', 3 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('4C Spider', 'Spider', 3 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Clio', 'Clio', 4 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Megane', 'Megane', 4 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Espace', 'Espace', 4 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('A3', 'A3', 5 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('A4', 'A4', 5 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('A5', 'A5', 5 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('A6', 'A6', 5 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('A7', 'A7', 5 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Berlingo', 'Berlingo', 6 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('C1', 'C1', 6 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('C2', 'C2', 6 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Modena', 'Modena', 7 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('F40', 'F40', 7 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Enzo', 'Enzo', 7 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('XE', 'XE', 8 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('XF', 'XF', 8 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('XJ', 'XJ', 8 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Civic', 'Civic', 9 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Prelude', 'Prelude', 9 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Accord', 'Accord', 9 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Yaris', 'Yaris', 10 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Avensis', 'Avensis', 10 )");
            Sql("INSERT INTO VehicleModels (Name, Abrv, VehicleMakeId) VALUES ('Corolla', 'Corolla', 10 )");
        }      
        public override void Down()
        {
        }
    }
}
