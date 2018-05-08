namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNamesToMembershipTypes : DbMigration
    {
        public override void Up()
        {
            //Sql("UPDATE MEMBERSHIPTYPES SET NAME='Pay as You Go' WHERE ID=1");
            //Sql("UPDATE MEMBERSHIPTYPES SET NAME='Monthly' WHERE ID=2");
            //Sql("UPDATE MEMBERSHIPTYPES SET NAME='Haly Yearly' WHERE ID=3");
        }
        
        public override void Down()
        {
        }
    }
}
