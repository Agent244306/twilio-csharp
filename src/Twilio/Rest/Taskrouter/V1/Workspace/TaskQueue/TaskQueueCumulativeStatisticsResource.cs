/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// TaskQueueCumulativeStatisticsResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.TaskQueue 
{

    public class TaskQueueCumulativeStatisticsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchTaskQueueCumulativeStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/TaskQueues/" + options.PathTaskQueueSid + "/CumulativeStatistics",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueCumulativeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueCumulativeStatistics </returns> 
        public static TaskQueueCumulativeStatisticsResource Fetch(FetchTaskQueueCumulativeStatisticsOptions options, 
                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch TaskQueueCumulativeStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueCumulativeStatistics </returns> 
        public static async System.Threading.Tasks.Task<TaskQueueCumulativeStatisticsResource> FetchAsync(FetchTaskQueueCumulativeStatisticsOptions options, 
                                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        /// <param name="endDate"> Filter cumulative statistics by an end date. </param>
        /// <param name="minutes"> Filter cumulative statistics by up to ‘x’ minutes in the past. </param>
        /// <param name="startDate"> Filter cumulative statistics by a start date. </param>
        /// <param name="taskChannel"> Filter real-time and cumulative statistics by TaskChannel. </param>
        /// <param name="splitByWaitTime"> A comma separated values for viewing splits of tasks canceled and accepted above the
        ///                       given threshold in seconds. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of TaskQueueCumulativeStatistics </returns> 
        public static TaskQueueCumulativeStatisticsResource Fetch(string pathWorkspaceSid, 
                                                                  string pathTaskQueueSid, 
                                                                  DateTime? endDate = null, 
                                                                  int? minutes = null, 
                                                                  DateTime? startDate = null, 
                                                                  string taskChannel = null, 
                                                                  string splitByWaitTime = null, 
                                                                  ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueCumulativeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathWorkspaceSid"> The workspace_sid </param>
        /// <param name="pathTaskQueueSid"> The task_queue_sid </param>
        /// <param name="endDate"> Filter cumulative statistics by an end date. </param>
        /// <param name="minutes"> Filter cumulative statistics by up to ‘x’ minutes in the past. </param>
        /// <param name="startDate"> Filter cumulative statistics by a start date. </param>
        /// <param name="taskChannel"> Filter real-time and cumulative statistics by TaskChannel. </param>
        /// <param name="splitByWaitTime"> A comma separated values for viewing splits of tasks canceled and accepted above the
        ///                       given threshold in seconds. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of TaskQueueCumulativeStatistics </returns> 
        public static async System.Threading.Tasks.Task<TaskQueueCumulativeStatisticsResource> FetchAsync(string pathWorkspaceSid, 
                                                                                                          string pathTaskQueueSid, 
                                                                                                          DateTime? endDate = null, 
                                                                                                          int? minutes = null, 
                                                                                                          DateTime? startDate = null, 
                                                                                                          string taskChannel = null, 
                                                                                                          string splitByWaitTime = null, 
                                                                                                          ITwilioRestClient client = null)
        {
            var options = new FetchTaskQueueCumulativeStatisticsOptions(pathWorkspaceSid, pathTaskQueueSid){EndDate = endDate, Minutes = minutes, StartDate = startDate, TaskChannel = taskChannel, SplitByWaitTime = splitByWaitTime};
            return await FetchAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a TaskQueueCumulativeStatisticsResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> TaskQueueCumulativeStatisticsResource object represented by the provided JSON </returns> 
        public static TaskQueueCumulativeStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<TaskQueueCumulativeStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The average time from Task creation to reservation acceptance while in this TaskQueue
        /// </summary>
        [JsonProperty("avg_task_acceptance_time")]
        public int? AvgTaskAcceptanceTime { get; private set; }
        /// <summary>
        /// The start_time
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime? StartTime { get; private set; }
        /// <summary>
        /// The end_time
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; private set; }
        /// <summary>
        /// The total number of Reservations that were created for Tasks while in this TaskQueue
        /// </summary>
        [JsonProperty("reservations_created")]
        public int? ReservationsCreated { get; private set; }
        /// <summary>
        /// The total number of Reservations that were accepted for Tasks while in this TaskQueue
        /// </summary>
        [JsonProperty("reservations_accepted")]
        public int? ReservationsAccepted { get; private set; }
        /// <summary>
        /// The total number of Reservations that were rejected for Tasks while in this TaskQueue
        /// </summary>
        [JsonProperty("reservations_rejected")]
        public int? ReservationsRejected { get; private set; }
        /// <summary>
        /// The total number of Reservations that were timed out for Tasks while in this TaskQueue
        /// </summary>
        [JsonProperty("reservations_timed_out")]
        public int? ReservationsTimedOut { get; private set; }
        /// <summary>
        /// The total number of Reservations that were canceled for Tasks while in this TaskQueue
        /// </summary>
        [JsonProperty("reservations_canceled")]
        public int? ReservationsCanceled { get; private set; }
        /// <summary>
        /// The total number of Reservations that were rescinded
        /// </summary>
        [JsonProperty("reservations_rescinded")]
        public int? ReservationsRescinded { get; private set; }
        /// <summary>
        /// The splits of the tasks canceled and accepted based on the provided SplitByWaitTime parameter
        /// </summary>
        [JsonProperty("split_by_wait_time")]
        public object SplitByWaitTime { get; private set; }
        /// <summary>
        /// The task_queue_sid
        /// </summary>
        [JsonProperty("task_queue_sid")]
        public string TaskQueueSid { get; private set; }
        /// <summary>
        /// The wait duration stats for tasks that were accepted while in this TaskQueue
        /// </summary>
        [JsonProperty("wait_duration_until_accepted")]
        public object WaitDurationUntilAccepted { get; private set; }
        /// <summary>
        /// The wait duration stats for tasks that were canceled while in this TaskQueue
        /// </summary>
        [JsonProperty("wait_duration_until_canceled")]
        public object WaitDurationUntilCanceled { get; private set; }
        /// <summary>
        /// The total number of Tasks canceled while in this TaskQueue
        /// </summary>
        [JsonProperty("tasks_canceled")]
        public int? TasksCanceled { get; private set; }
        /// <summary>
        /// The total number of Tasks completed while in this TaskQueue
        /// </summary>
        [JsonProperty("tasks_completed")]
        public int? TasksCompleted { get; private set; }
        /// <summary>
        /// The total number of Tasks that were deleted while in this TaskQueue
        /// </summary>
        [JsonProperty("tasks_deleted")]
        public int? TasksDeleted { get; private set; }
        /// <summary>
        /// The total number of Tasks entered into this TaskQueue
        /// </summary>
        [JsonProperty("tasks_entered")]
        public int? TasksEntered { get; private set; }
        /// <summary>
        /// The total number of Tasks moved to another TaskQueue from this TaskQueue
        /// </summary>
        [JsonProperty("tasks_moved")]
        public int? TasksMoved { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private TaskQueueCumulativeStatisticsResource()
        {

        }
    }

}