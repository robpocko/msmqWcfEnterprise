using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using msmqEnterpriseContract;
using msmqEnterpriseLibrary;

namespace msmqEnterpriseService
{
    public class msmqEnterpriseService : ImsmqEnterpriseContract
    {
        [OperationBehavior(TransactionScopeRequired = true)] 
        public void TellTheTime()
        {
            TimeLogger reporter = new TimeLogger();
            reporter.ReportTimeNow();
        }
    }
}
