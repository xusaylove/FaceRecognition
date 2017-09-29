using EFLibrary.DBContext;
using EFLibrary.Model;
using RecognitionModel;
using System;

namespace RecognitionBLL
{
    public class FaceInfoService
    {
        public FaceInfoService()
        {
        }
        public bool AddFaceInfo(StudentFaceModel model)
        {
            try
            {
                FaceDBContext _db = new FaceDBContext();
                FaceInfo info = new FaceInfo();
                _db.FaceInfo.Add(info);
                int i = _db.SaveChanges();
                return i > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
