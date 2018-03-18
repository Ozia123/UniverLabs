using System;
using System.Runtime.Serialization;

namespace lab2.Models {
    [DataContract]
    public class LecturerModel {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Pulpit { get; set; }
        [DataMember]
        public string LectureHall { get; set; }
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        [DataMember]
        public string PhoneNumber { get; set; }
    }
}