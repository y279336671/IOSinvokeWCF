using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Drawing;


namespace Contracts
{
    [ServiceContract(Name = "SignatureContracts")]
    public interface ISignatureContracts

    {
        [OperationContract]
        void setPoint(float x, float y);

        [OperationContract]
        PointF getPoint();
    }
}
