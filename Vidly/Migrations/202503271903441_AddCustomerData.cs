namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class AddCustomerData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Customers(Name,IsSubscibedtoNewsLetter,MembershipType_Id) Values('Akash',2,1)");
            Sql("Insert Into Customers(Name,IsSubscibedtoNewsLetter,MembershipType_Id) Values('Adarsh',3,1)");
        }
        
        public override void Down()
        {
        }
    }
}
