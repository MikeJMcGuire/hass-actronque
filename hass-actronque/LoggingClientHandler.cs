using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HMX.HASSActronQue
{
	public class LoggingClientHandler : DelegatingHandler
	{
		public LoggingClientHandler(HttpMessageHandler innerHandler) : base(innerHandler) { }

		protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			HttpResponseMessage response = await base.SendAsync(request, cancellationToken); 
			
			Logging.WriteDebugLog("Request: {0}", request.ToString());
			Logging.WriteDebugLog("Response: {0}", response.ToString());

			return response;
		}
	}
}