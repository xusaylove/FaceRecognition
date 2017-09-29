using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Model
{
    /// <summary>
    /// 课程表
    /// </summary>
    [Table("eleven_courseinfo")]
    public class CourseInfo
    {
        /// <summary>
        /// 课程编号
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string CourseName { get; set; }
        /// <summary>
        /// 课程开始时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 课程结束时间
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
