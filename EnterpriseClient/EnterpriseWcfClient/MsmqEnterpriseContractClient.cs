using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using msmqEnterpriseContract;

namespace EnterpriseWcfClient
{
    class MsmqEnterpriseContractClient : ClientBase<ImsmqEnterpriseContract>, ImsmqEnterpriseContract
    {
        public MsmqEnterpriseContractClient(string endpoint)
            : base(endpoint)
        { }

        #region IMsmqEnterpriseContract Members

        public void TellTheTime()
        {
            Channel.TellTheTime();
        }

        #endregion
    }
}
