
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace WcfNewtonsoftJsonSerializer
{
    public class NewtonsoftJsonBehavior : WebHttpBehavior
    {
        protected override IDispatchMessageFormatter GetRequestDispatchFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint)
        {
            return new NewtonsoftJsonDispatchFormatter(operationDescription, true);
        }

        protected override IDispatchMessageFormatter GetReplyDispatchFormatter(OperationDescription operationDescription, ServiceEndpoint endpoint)
        {
            return new NewtonsoftJsonDispatchFormatter(operationDescription, false);
        }
    }
}