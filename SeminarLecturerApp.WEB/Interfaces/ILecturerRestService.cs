using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using SeminarLecturerApp.WEB.Contracts;

namespace SeminarLecturerApp.WEB.Interfaces
{
    [ServiceContract]
    public interface ILecturerRestService
    {
        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "lecturers")]
        List<LecturerContract> GetLecturerList();

        [OperationContract]
        [WebInvoke(
            Method = "GET",
             RequestFormat = WebMessageFormat.Json,
             ResponseFormat = WebMessageFormat.Json,
             UriTemplate = "/test")]
        string GetTest();

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "lecturers/{id}")]
        LecturerContract Get(string id);

        [OperationContract]
        [WebInvoke(
            Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "lecturers/add")]
        void AddLecturer(LecturerContract lecturer);

        [OperationContract]
        [WebInvoke(
            Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "lecturers/update/{id}")]
        void UpdateLecturer(string id, LecturerContract lecturer);

        [OperationContract]
        [WebInvoke(
            Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "lecturers/delete/{id}")]
        void RemoveLecturer(string id);
    }
}
