using System.Net;
using System.Threading;
using Segment.Model;

namespace IntercomIoRest.Request
{
    internal class BatchState
    {
        internal HttpWebRequest Request { get; set; }
        internal Batch Batch { get; set; }
        internal ManualResetEvent Event { get; set; }

        internal BatchState(HttpWebRequest request, Batch batch)
        {
            Request = request;
            Batch = batch;

            Event = new ManualResetEvent(false);
        }
    }
}
