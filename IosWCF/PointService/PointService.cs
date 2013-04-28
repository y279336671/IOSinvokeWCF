using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;

namespace PointService
{
    public class PointService : IPointService
    {
        public void GetPerson(string point)
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "text/plain";

            if (point != null)
                Console.WriteLine(point);
        }
    }
}
