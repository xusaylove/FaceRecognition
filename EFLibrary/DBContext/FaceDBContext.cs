using EFLibrary.Model;
using MySql.Data.Entity;
using System.Data.Entity;

namespace EFLibrary.DBContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FaceDBContext : DbContext
    {
        public FaceDBContext():base("FaceDM")
        {
            
        }

        public virtual DbSet<StudentInfo> StudentInfo { get; set; }
        public virtual DbSet<CourseInfo> CourseInfo { get; set; }
        public virtual DbSet<FaceInfo> FaceInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FaceInfo>().ToTable("eleven_faceinfo");
            modelBuilder.Entity<CourseInfo>().ToTable("eleven_courseinfo");
            modelBuilder.Entity<StudentInfo>().ToTable("eleven_studentinfo");
            base.OnModelCreating(modelBuilder);
        }
    }
}
