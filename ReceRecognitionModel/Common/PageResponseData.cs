using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecognitionModel
{
    [Serializable]
    public class PageResponseData<T>
    {
        public int Count { get; set; }
        public List<T> Data { get; set; }
    }
}
