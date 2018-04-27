/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Worker 
{

    /// <summary>
    /// FetchWorkerStatisticsOptions
    /// </summary>
    public class FetchWorkerStatisticsOptions : IOptions<WorkerStatisticsResource> 
    {
        /// <summary>
        /// The workspace_sid
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The worker_sid
        /// </summary>
        public string PathWorkerSid { get; }
        /// <summary>
        /// Filter cumulative statistics by up to ‘x’ minutes in the past.
        /// </summary>
        public int? Minutes { get; set; }
        /// <summary>
        /// Filter cumulative statistics by a start date.
        /// </summary>
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Filter cumulative statistics by a end date.
        /// </summary>
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// Filter cumulative statistics by TaskChannel.
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new FetchWorkerStatisticsOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathWorkerSid"> The worker_sid </param>
        public FetchWorkerStatisticsOptions(string pathWorkspaceSid, string pathWorkerSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathWorkerSid = pathWorkerSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Minutes != null)
            {
                p.Add(new KeyValuePair<string, string>("Minutes", Minutes.Value.ToString()));
            }

            if (StartDate != null)
            {
                p.Add(new KeyValuePair<string, string>("StartDate", Serializers.DateTimeIso8601(StartDate)));
            }

            if (EndDate != null)
            {
                p.Add(new KeyValuePair<string, string>("EndDate", Serializers.DateTimeIso8601(EndDate)));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

}