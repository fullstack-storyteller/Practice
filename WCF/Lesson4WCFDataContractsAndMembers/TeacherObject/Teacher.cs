using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TeacherObject
{
    /*
 Using Serialization or serializable decorator will serialize all the private fields
 Using Datacontract decorator will provide much mode flexibility
 Remember, that we don't really have to give the decorator in the most recent versions of .net framework
 but giving the decorator allows you to supply, various customizations like require field,
 order, name.
     */

    [DataContract(Namespace = "https://manish.kumar.net/TeacherItem/03/01/2020")]
    //[KnownType(typeof(PartTimeTeacher))]
    //[KnownType(typeof(FullTimeTeacher))] 
    //the above known types can be added in web.config(which will be global too, just like using known types.)
    //or the serviceknown type attribute (which will be local only)
    //check the aap.config file for the way we do specify the knowntype in declaratively

    public class TeacherItem
    {
        [DataMember(Order = 1)]
        public int TeacherID { get; set; }
        [DataMember(Order = 2)]
        public string TeacherName { get; set; }
        [DataMember(Order = 5)]
        public string TeacherQualification { get; set; }
        [DataMember(Order = 4)]
        public Gender Gender { get; set; }
        //[DataMember(Order = 3)]
        //public int Salary { get; set; }

        [DataMember(Order = 6)]
        public DepartmentItem Department { get; set; }
        [DataMember(Order = 7)]
        public bool Success { get; set; }

        [DataMember(Order = 8)]
        public EmployeeType Type { get; set; }

    }

    [DataContract(Namespace = "https://manish.kumar.net/DepartmentItem/03/01/2020")]
    public class DepartmentItem
    {

        [DataMember]
        public int DeptID { get; set; }
        [DataMember]
        public string Name { get; set; }
    }

    public enum Gender
    {
        NotAvailable=-1,
        Male =1,
        Female=2,
        Others=3
        
    }

    public enum EmployeeType
    {
        NotProvided=-1,
        FullTimeTeacher =1,
        PartTimeTeacher =2
    }
}

