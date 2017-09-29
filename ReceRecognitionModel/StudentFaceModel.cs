using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    public class StudentFaceModel
    {
        /// <summary>
        /// 课程ID
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// 学员ID
        /// </summary>
        public int StudentID { get; set; }
        /// <summary>
        /// 记录时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 表情状态
        /// </summary>
        public FaceTypeEnum FaceType { get; set; }
    }
}
