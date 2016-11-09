using SeminarLecturerApp.BusinessLogic.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarLecturerApp.BusinessLogic.Storage
{
    internal class Lecturers
    {
        public List<Lecturer> LecturerList { get; set; } = new List<Lecturer>();

        public Lecturers()
        {
            Init();
        }

        private void Init()
        {
            var johnDoe = new Lecturer
            {
                LecturerId = 1,
                Name = "John",
                Surname = "Doe",
                Age = 45,
                WorkExperience = 20,
                Seminars = new List<Seminar> { new Seminar { SeminarId = 2 } }
            };

            var stephSmith = new Lecturer
            {
                LecturerId = 2,
                Name = "Stephen",
                Surname = "Smith",
                Age = 27,
                WorkExperience = 5
            };

            var donaldClinton = new Lecturer
            {
                LecturerId = 3,
                Name = "Donald",
                Surname = "Clinton",
                Age = 87,
                WorkExperience = 2
            };

            LecturerList.AddRange(new List<Lecturer> { johnDoe, stephSmith, donaldClinton }.OrderBy(_=>_.LecturerId));
        }
    }
}
