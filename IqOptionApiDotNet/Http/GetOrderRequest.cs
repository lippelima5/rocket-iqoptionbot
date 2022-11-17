using RestSharp;

namespace IqOptionApiDotNet.Http
{
    class GetOrderRequest : IqOptionRequest
    {
        public GetOrderRequest(long order_id) : base("sendMessage", Method.GET)
        {
            AddParameter("get-order", order_id, ParameterType.QueryString);
        }
    }
}
