using SeminarLecturerApp.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarLecturerApp.BusinessLogic.Interfaces
{
    public interface ILecturerService
    {
        List<Lecturer> GetLecturers();
        Lecturer GetLecturer(int id);
        void AddLecturer(Lecturer lecturer);
        void EditLecturer(int id, Lecturer lecturer);
        void RemoveLecturer(int id);
    }
}
