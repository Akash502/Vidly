namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes SET MembershipType_Name = 'Pay as You Go' WHERE ID=1");
            Sql("Update MembershipTypes SET MembershipType_Name = 'Weakly' WHERE ID=2");
            Sql("Update MembershipTypes SET MembershipType_Name = 'Monthly' WHERE ID=3");
            Sql("Update MembershipTypes SET MembershipType_Name = 'Quaterly' WHERE ID=4");
        }
        
        public override void Down()
        {
        }
    }
}
