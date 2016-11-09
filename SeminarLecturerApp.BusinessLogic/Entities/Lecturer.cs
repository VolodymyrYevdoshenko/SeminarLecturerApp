using System.Collections.Generic;

namespace SeminarLecturerApp.BusinessLogic.Entities
{
    public class Lecturer
    {
        public int LecturerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int WorkExperience { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Seminar> Seminars { get; set; } = new List<Seminar>();
    }
}
