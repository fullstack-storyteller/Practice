using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.UI.WebControls;
using TeacherObject;

namespace Lesson4WCFDataContractsAndMembers
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        int InsertNewEmployee(TeacherItem teacher);

        [OperationContract]
        TeacherItem ShowTeacherByID(int ID);

        [OperationContract]
        List<ListItem> ShowAllDepartments();
    }
}
