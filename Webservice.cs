using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web;
using System.Xml.Linq;

namespace RaptorTest.Web
{




    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, IncludeExceptionDetailInFaults = true)]
    public class Webservice : IWebservice
    {
        public Webservice()
        {

        }
        public TimeSpan test()
        {
           return new TimeSpan(0, 21, 0, 0);
        }

    }
}