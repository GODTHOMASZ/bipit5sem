using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataTable GetData();

        [OperationContract]
        DataTable GetComboValue();

        [OperationContract]
        void NewRec(string cname, string service, string count, string date);
    }
}
