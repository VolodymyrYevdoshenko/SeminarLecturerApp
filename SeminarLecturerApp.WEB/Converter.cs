using System.Collections.Generic;
using System.Linq;
using SeminarLecturerApp.BusinessLogic.Entities;
using SeminarLecturerApp.WEB.Contracts;

namespace SeminarLecturerApp.WEB
{
    public static class Converter
    {
        public static SeminarContract ToDataContract(this Seminar seminar)
        {
            return new SeminarContract
            {
                SeminarId = seminar.SeminarId,
                Name = seminar.Name,
                Description = seminar.Description,
                Lecturers = seminar.Lecturers.ConvertAll(ToDataContract)
            };
        }

        public static List<SeminarContract> ToDataContract(this List<Seminar> seminars)
        {
            return seminars.Select(seminar => seminar.ToDataContract()).ToList();
        }

        public static Seminar ToEntity(this SeminarContract contract)
        {
            return  new Seminar
            {
                SeminarId = contract.SeminarId,
                Name = contract.Name,
                Description = contract.Description,
                Lecturers = contract.Lecturers.ConvertAll(ToEntity)
            };
        }

        public static LecturerContract ToDataContract(this Lecturer lecturer)
        {
            return new LecturerContract
            {
                LecturerId = lecturer.LecturerId,
                Name = lecturer.Name,
                Surname = lecturer.Surname,
                Title = lecturer.Title,
                Address = lecturer.Address,
                PhoneNumber = lecturer.PhoneNumber,
                Age = lecturer.Age,
                WorkExperience = lecturer.WorkExperience,
                Seminars = lecturer.Seminars.ConvertAll(ToDataContract)
            };
        }

        public static List<LecturerContract> ToDataContract(this List<Lecturer> lecturers)
        {
            return lecturers.Select(lecturer => lecturer.ToDataContract()).ToList();
        }

        public static Lecturer ToEntity(this LecturerContract contract)
        {
            return new Lecturer
            {
                LecturerId = contract.LecturerId,
                Name = contract.Name,
                Surname = contract.Surname,
                Address = contract.Address,
                PhoneNumber = contract.PhoneNumber,
                Age = contract.Age,
                WorkExperience = contract.WorkExperience,
                Title = contract.Title,
                Seminars = contract.Seminars.ConvertAll(ToEntity)
            };
        }   
    }
}
