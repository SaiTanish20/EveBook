namespace EveBook.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserNameAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbl_user", "UserName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbl_user", "UserName");
        }
    }
}
