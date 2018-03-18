using System.Runtime.Serialization;

namespace lab2.Models {
    [DataContract]
    public class SubjectModel {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Term { get; set; }
        [DataMember]
        public int Course { get; set; }
        [DataMember]
        public string Specialty { get; set; }
        [DataMember]
        public int NumberOfLections { get; set; }
        [DataMember]
        public int NumberOfLabs { get; set; }
        [DataMember]
        public int NumberOfStudents { get; set; }
        [DataMember]
        public LecturerModel Lecturer { get; set; }
    }
}