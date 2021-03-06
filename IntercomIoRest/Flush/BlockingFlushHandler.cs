using System.Collections.Generic;
using IntercomIoRest.Model;
using IntercomIoRest.Request;
using Segment.Model;

namespace IntercomIoRest.Flush
{
	internal class BlockingFlushHandler : IFlushHandler
	{
		/// <summary>
		/// Creates a series of actions into a batch that we can send to the server
		/// </summary>
		private readonly IBatchFactory _batchFactory;
		/// <summary>
		/// Performs the actual HTTP request to our server
		/// </summary>
		private readonly IRequestHandler _requestHandler;

		
		internal BlockingFlushHandler(IBatchFactory batchFactory, 
		                         IRequestHandler requestHandler)
		{

			_batchFactory = batchFactory;
			_requestHandler = requestHandler;
		}
		
		public void Process(BaseAction action)
		{
			var batch = _batchFactory.Create(new List<BaseAction>() { action });
			_requestHandler.MakeRequest(batch);
		}
		
		/// <summary>
		/// Returns immediately since the blocking flush handler does not queue
		/// </summary>
		public void Flush() 
		{
			// do nothing
		}
		
		/// <summary>
		/// Does nothing, as nothing needs to be disposed here
		/// </summary>
		public void Dispose() 
		{
			// do nothing
		}
		
	}
}

