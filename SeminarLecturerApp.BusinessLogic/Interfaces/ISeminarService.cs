using SeminarLecturerApp.BusinessLogic.Entities;
using System.Collections.Generic;

namespace SeminarLecturerApp.BusinessLogic.Interfaces
{
    public interface ISeminarService
    {
        List<Seminar> GetSeminars();
        List<Lecturer> GetLecturers(int seminarId);
        void RemoveSeminar(int id);
        void RemoveLecturer(int seminarId, int lecturerId);
        void RemoveLecturers(int seminarId);
    }
}
