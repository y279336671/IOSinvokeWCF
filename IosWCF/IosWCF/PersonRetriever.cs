using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;

namespace PointService
{
    public class PersonRetriever : IPersonRetriever
    {
        public Person GetPerson(string name)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/plain";
            return new Person { Name = name, Age = 22, Birthday = DateTime.Now };
        }
    }
}
