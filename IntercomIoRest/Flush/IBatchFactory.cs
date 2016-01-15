using System.Collections.Generic;
using IntercomIoRest.Model;
using Segment.Model;

namespace IntercomIoRest.Flush
{
	internal interface IBatchFactory
	{
		Batch Create(List<BaseAction> actions);
	}
}

