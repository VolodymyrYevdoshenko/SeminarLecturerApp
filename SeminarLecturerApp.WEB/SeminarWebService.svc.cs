using System;
using SeminarLecturerApp.WEB.Interfaces;

namespace SeminarLecturerApp.WEB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SeminarWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SeminarWebService.svc or SeminarWebService.svc.cs at the Solution Explorer and start debugging.
    public class SeminarWebService : ISeminarSoapService, ISeminarRestService
    {
        public void DoWork()
        {
        }

        void ISeminarRestService.DoWorkRest()
        {
        }
    }
}
