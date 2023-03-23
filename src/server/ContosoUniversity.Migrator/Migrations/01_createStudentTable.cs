using FluentMigrator;

namespace ContosoUniversity.Migrator.Migrations
{
    [Migration(1, "CreateStudentTable")]
    public class CreateStudentTable : Migration
    {
        public override void Up()
        {
            Create.Table("student")
                .WithColumn("id").AsInt32().PrimaryKey().Identity()
                .WithColumn("firstMidName").AsString().NotNullable()
                .WithColumn("lastName").AsString().NotNullable()
                .WithColumn("enrollmentDate").AsDateTime2().NotNullable();
        }

        public override void Down()
        {
            Delete.Table("Student");
        }
    }
}
