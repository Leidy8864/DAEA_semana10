namespace University.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.InstructorCourses", new[] { "Course_CourseId" });
            CreateIndex("dbo.InstructorCourses", "Course_CourseID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.InstructorCourses", new[] { "Course_CourseID" });
            CreateIndex("dbo.InstructorCourses", "Course_CourseId");
        }
    }
}
