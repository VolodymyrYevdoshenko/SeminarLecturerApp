using SeminarLecturerApp.BusinessLogic.Entities;
using System.Collections.Generic;

namespace SeminarLecturerApp.BusinessLogic.Storage
{
    internal class Seminars
    {
        public List<Seminar> SeminarList { get; set; } = new List<Seminar>();

        public Seminars() 
        {
            Init();
        }

        private void Init()
        {
            var math = new Seminar
            {
                SeminarId = 1,
                Name = "Math"
            };

            var physics = new Seminar
            {
                SeminarId = 2,
                Name = "Physics"
            };

            var chemistry = new Seminar
            {
                SeminarId = 3,
                Name = "Chemistry"
            };

            SeminarList.AddRange(new List<Seminar>{ math, physics, chemistry });
        }

    }
}
