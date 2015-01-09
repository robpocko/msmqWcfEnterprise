using System.ServiceModel;

namespace msmqEnterpriseContract
{
    [ServiceContract]
    public interface ImsmqEnterpriseContract
    {
        [OperationContract(IsOneWay = true)]
        void TellTheTime();
    }
}
