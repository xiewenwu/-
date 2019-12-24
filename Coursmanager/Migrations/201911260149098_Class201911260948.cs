namespace Coursmanager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Class201911260948 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(nullable: false, maxLength: 10, fixedLength: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "Name", c => c.String(maxLength: 10, fixedLength: true));
        }
    }
}
