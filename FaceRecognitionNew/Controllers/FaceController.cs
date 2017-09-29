using RecognitionBLL;
using RecognitionModel;
using System;
using System.Web.Http;

namespace FaceRecognitionNew.Controllers
{
    public class FaceController : ApiController
    {
        public bool AddFaceInfo(StudentFaceModel model)
        {
            bool flag = false;
            try
            {
                FaceInfoService _service = new FaceInfoService();
                flag = _service.AddFaceInfo(model);
                return flag;
            }
            catch (Exception ex)
            {
                return flag;
            }
        }
    }
}
