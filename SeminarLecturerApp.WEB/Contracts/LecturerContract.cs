using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SeminarLecturerApp.WEB.Contracts
{
    [DataContract]
    public class LecturerContract
    {
        [DataMember]
        public int LecturerId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int WorkExperience { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
        [DataMember]
        public List<SeminarContract> Seminars { get; set; } = new List<SeminarContract>();
    }
}