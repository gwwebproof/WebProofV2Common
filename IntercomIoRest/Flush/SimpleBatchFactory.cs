using System.Collections.Generic;
using IntercomIoRest.Model;
using Segment.Model;

namespace IntercomIoRest.Flush
{
	internal class SimpleBatchFactory : IBatchFactory
	{
		private readonly string _writeKey;

		internal SimpleBatchFactory (string writeKey)
		{
			this._writeKey = writeKey;
		}

		public Batch Create(List<BaseAction> actions) 
		{
			return new Batch(_writeKey, actions);
		}
	}
}

