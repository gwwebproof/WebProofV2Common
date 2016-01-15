using Segment.Model;

namespace IntercomIoRest.Request
{
	internal interface IRequestHandler
	{
		void MakeRequest(Batch batch); 
	}
}
