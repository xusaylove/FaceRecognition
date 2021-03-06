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
    /// 学员表
    /// </summary>
    [Table("eleven_studentinfo")]
    public class StudentInfo
    {
        /// <summary>
        /// 学员编号
        /// </summary>
        [Key]
        public int ID { get; set; }
        /// <summary>
        /// 中文姓名
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public int Sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime Birthday { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
