﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLibrary.Model
{
    /// <summary>
    /// 表情信息表
    /// </summary>
    [Table("eleven_faceinfo")]
    public class FaceInfo
    {
        [Key]
        public int ID { get; set; }
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
        public int FaceType { get; set; }
    }
}
