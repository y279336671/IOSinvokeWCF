using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PointService
{
    [ServiceContract]
    public interface IPersonRetriever
    {
        [OperationContract]
        [WebGet(UriTemplate = "Persons/{name}", ResponseFormat = WebMessageFormat.Json)]
        Person GetPerson(string name);
    }

    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public DateTime Birthday { get; set; }
    }
}
