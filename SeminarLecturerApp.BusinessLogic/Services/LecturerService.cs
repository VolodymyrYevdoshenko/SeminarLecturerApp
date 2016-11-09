using System.Collections.Generic;
using System.Linq;
using SeminarLecturerApp.BusinessLogic.Entities;
using SeminarLecturerApp.BusinessLogic.Interfaces;
using SeminarLecturerApp.BusinessLogic.Storage;

namespace SeminarLecturerApp.BusinessLogic.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly Lecturers _lecturers;

        public LecturerService()
        {
            _lecturers = new Lecturers();
        }

        public List<Lecturer> GetLecturers()
        {
            return _lecturers.LecturerList;
        }

        public Lecturer GetLecturer(int id)
        {
            return _lecturers.LecturerList.First(lecturer => lecturer.LecturerId == id);
        }

        public void AddLecturer(Lecturer lecturer)
        {
            _lecturers.LecturerList.Add(lecturer);
        }

        public void EditLecturer(int id, Lecturer lecturer)
        {
            var index = _lecturers.LecturerList.FindIndex(_ => _.LecturerId == id);

            _lecturers.LecturerList.RemoveAt(index);
            _lecturers.LecturerList.Insert(index,lecturer);
        }

        public void RemoveLecturer(int id)
        {
            _lecturers.LecturerList.Remove(_lecturers.LecturerList.First(lecturer => lecturer.LecturerId == id));
        }
    }
}
