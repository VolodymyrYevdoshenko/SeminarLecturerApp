using System.Collections.Generic;
using System.ServiceModel;
using SeminarLecturerApp.WEB.Contracts;

namespace SeminarLecturerApp.WEB.Interfaces
{
    [ServiceContract]
    public interface ILecturerSoapService
    {
        [OperationContract]
        void Add(LecturerContract lecturer);

        [OperationContract]
        void Update(int id, LecturerContract lecturer);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        LecturerContract GetLecturer(int id);

        [OperationContract]
        List<LecturerContract> GetLecturers();

    }
}
