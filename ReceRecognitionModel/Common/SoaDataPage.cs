using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    [Serializable]
    public class SoaDataPage
    {
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderBy { get; set; }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        /// <summary>
        /// 0、asc 1、desc
        /// </summary>
        public int SortCol { get; set; }
    }

    [Serializable]
    public class SoaDataPage<Tmodel>:SoaDataPage{
        public Tmodel Where { get; set; }
    }
}
