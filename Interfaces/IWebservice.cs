
using System;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RaptorTest.Web
{
    [ServiceContract]
    public interface IWebservice
    {


        [OperationContract]
        [WebGet(UriTemplate = "/test", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        TimeSpan test();

    }
}