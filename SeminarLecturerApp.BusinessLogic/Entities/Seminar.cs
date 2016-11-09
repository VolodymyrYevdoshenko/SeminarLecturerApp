using System.Collections.Generic;

namespace SeminarLecturerApp.BusinessLogic.Entities
{
    public class Seminar
    {
        public int SeminarId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Lecturer> Lecturers { get; set; } = new List<Lecturer>();
    }
}
