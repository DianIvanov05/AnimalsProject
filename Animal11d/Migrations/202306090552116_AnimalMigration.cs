namespace Animal11d.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnimalMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Animals", "RegisterOn");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Animals", "RegisterOn", c => c.DateTime(nullable: false));
        }
    }
}
