namespace VehicleDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateVehicleMakeDb : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Bayerische Motoren Werke', 'BMW')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Ford Motor Company', 'Ford')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Alfa Romeo', 'Alfa Romeo')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Renault', 'Renault')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Audi AG', 'Audi')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Citroen', 'Citroen')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Ferrari', 'Ferrari')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Jaguar Land Rover', 'Jaguar')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Honda Motor Company', 'Honda')");
            Sql("INSERT INTO VehicleMakes (Name, Abrv) VALUES ('Toyota Motor Corporation', 'Toyota')");
        }
        
        public override void Down()
        {
        }
    }
}
