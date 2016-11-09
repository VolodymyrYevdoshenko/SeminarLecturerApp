using System.ServiceModel;

namespace SeminarLecturerApp.WEB.Interfaces
{
    [ServiceContract]
    public interface ISeminarRestService
    {
        [OperationContract]
        void DoWorkRest();
    }
}
