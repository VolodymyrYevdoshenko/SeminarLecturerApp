using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SeminarLecturerApp.WEB.Contracts
{
    [DataContract]
    public class SeminarContract
    {
        [DataMember]
        public int SeminarId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<LecturerContract> Lecturers { get; set; } = new List<LecturerContract>();
    }
}