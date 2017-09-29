using RecognitionBLL;
using System;
using System.Web.Http;
using RecognitionModel;
namespace FaceRecognitionNew.Controllers
{
    public class FaceController : ApiController
    {
        [HttpPost]
        public QueryResponse<bool> AddFaceInfo(StudentFaceModel model)
        {
            bool flag = false;
            try
            {
                FaceInfoService _service = new FaceInfoService();
                flag = _service.AddFaceInfo(model);
                return QueryHelper.SetResponse<bool>(flag);
            }
            catch (Exception ex)
            {
                return ExceptionQuery.SetException<bool>(ex);
            }
        }
    }
}
