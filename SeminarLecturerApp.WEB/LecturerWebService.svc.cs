using System.Collections.Generic;
using System.Net;
using SeminarLecturerApp.BusinessLogic.Interfaces;
using SeminarLecturerApp.BusinessLogic.Services;
using SeminarLecturerApp.WEB.Contracts;
using SeminarLecturerApp.WEB.Interfaces;

namespace SeminarLecturerApp.WEB
{
    public class LecturerWebService : ILecturerSoapService, ILecturerRestService
    {
        private readonly ILecturerService _lecturerService = new LecturerService();

        public void Add(LecturerContract lecturer)
        {
            _lecturerService.AddLecturer(lecturer.ToEntity());
        }

        public void Update(int id, LecturerContract lecturer)
        {
            _lecturerService.EditLecturer(id, lecturer.ToEntity());
        }

        public void Delete(int id)
        {
            _lecturerService.RemoveLecturer(id);
        }

        public LecturerContract GetLecturer(int id)
        {
            return _lecturerService.GetLecturer(id).ToDataContract();
        }

        public List<LecturerContract> GetLecturers()
        {
            return _lecturerService.GetLecturers().ToDataContract();
        }

        public List<LecturerContract> GetLecturerList()
        {
            return _lecturerService.GetLecturers().ToDataContract();
        }

        public string GetTest()
        {
            using (var client = new WebClient())
            {
                return client.DownloadString("https://www.google.com.ua/");
            }
        }

        public LecturerContract Get(string id)
        {
            return _lecturerService.GetLecturer(int.Parse(id)).ToDataContract();
        }

        public void AddLecturer(LecturerContract lecturer)
        {
            _lecturerService.AddLecturer(lecturer.ToEntity());
        }

        public void UpdateLecturer(string id, LecturerContract lecturer)
        {
            _lecturerService.EditLecturer(int.Parse(id), lecturer.ToEntity());
        }

        public void RemoveLecturer(string id)
        {
            _lecturerService.RemoveLecturer(int.Parse(id));
        }
    }
}
