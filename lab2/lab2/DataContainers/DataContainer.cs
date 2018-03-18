using lab2.Models;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;

namespace lab2.DataContainers {
    public static class DataContainer {
        private static readonly DataContractJsonSerializer jsonFormatterForSubjects;
        private static readonly DataContractJsonSerializer jsonFormatterForLecturers;

        public static LecturerModel LecturerModel { get; set; }
        public static List<LecturerModel> Lecturers { get; set; }
        public static List<SubjectModel> Subjects { get; set; }

        static DataContainer() {
            jsonFormatterForSubjects = new DataContractJsonSerializer(typeof(List<SubjectModel>));
            jsonFormatterForLecturers = new DataContractJsonSerializer(typeof(List<LecturerModel>));
            LecturerModel = null;
            GetLecturersFromJsonFile();
            GetSubjectsFromJsonFile();
        }

        private static void ClearFileContent(string path) {
            if (File.Exists(path)) {
                File.WriteAllText(path, string.Empty);
            }
        }

        private static void GetLecturersFromJsonFile() {
            Lecturers = new List<LecturerModel>();
            if (File.Exists("lecturers.json")) {
                using(FileStream fs = new FileStream("lecturers.json", FileMode.Open)) {
                    Lecturers = (List<LecturerModel>)jsonFormatterForLecturers.ReadObject(fs);
                }
            }
        }

        private static void GetSubjectsFromJsonFile() {
            Subjects = new List<SubjectModel>();
            if (File.Exists("subjects.json")) {
                using (FileStream fs = new FileStream("subjects.json", FileMode.Open)) {
                   Subjects = (List<SubjectModel>)jsonFormatterForSubjects.ReadObject(fs);
                }
            }
        }

        public static void SerializeLecturers() {
            ClearFileContent("lecturers.json");
            using (FileStream fs = new FileStream("lecturers.json", FileMode.OpenOrCreate)) {
                jsonFormatterForLecturers.WriteObject(fs, Lecturers);
            }
        }

        public static void SerializeSubjects() {
            ClearFileContent("subjects.json");
            using (FileStream fs = new FileStream("subjects.json", FileMode.OpenOrCreate)) {
                jsonFormatterForSubjects.WriteObject(fs, Subjects);
            }
        }
    }
}