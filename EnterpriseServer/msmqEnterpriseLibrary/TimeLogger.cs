using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace msmqEnterpriseLibrary
{
    public class TimeLogger
    {
        public void ReportTimeNow()
        {
            Debug.WriteLine(string.Format("The time is now {0}", DateTime.Now.ToString("hh:mm:ss")));
        }
    }
}
