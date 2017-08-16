namespace VidlyGeoApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemebershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypeS SET Name= 'Pay as You Go' WHERE Id=1");
            Sql("UPDATE MembershipTypeS SET Name= 'Monthly' WHERE Id=2");
            Sql("UPDATE MembershipTypeS SET Name= 'Quarterly' WHERE Id=3");
            Sql("UPDATE MembershipTypeS SET Name= 'Annual' WHERE Id=4");
        }
        
        public override void Down()
        {
        }
    }
}
