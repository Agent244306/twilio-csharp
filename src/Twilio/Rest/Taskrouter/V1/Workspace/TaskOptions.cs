/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1.Workspace
{

    /// <summary>
    /// FetchTaskOptions
    /// </summary>
    public class FetchTaskOptions : IOptions<TaskResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Task to fetch
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to fetch </param>
        /// <param name="pathSid"> The SID of the resource to fetch </param>
        public FetchTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// UpdateTaskOptions
    /// </summary>
    public class UpdateTaskOptions : IOptions<TaskResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Task to update
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The JSON string that describes the custom attributes of the task
        /// </summary>
        public string Attributes { get; set; }
        /// <summary>
        /// The new status of the task
        /// </summary>
        public TaskResource.StatusEnum AssignmentStatus { get; set; }
        /// <summary>
        /// The reason that the Task was canceled or complete
        /// </summary>
        public string Reason { get; set; }
        /// <summary>
        /// The Task's new priority value
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// When MultiTasking is enabled, specify the TaskChannel with the task to update
        /// </summary>
        public string TaskChannel { get; set; }

        /// <summary>
        /// Construct a new UpdateTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to update </param>
        /// <param name="pathSid"> The SID of the resource to update </param>
        public UpdateTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            if (AssignmentStatus != null)
            {
                p.Add(new KeyValuePair<string, string>("AssignmentStatus", AssignmentStatus.ToString()));
            }

            if (Reason != null)
            {
                p.Add(new KeyValuePair<string, string>("Reason", Reason));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteTaskOptions
    /// </summary>
    public class DeleteTaskOptions : IOptions<TaskResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Task to delete
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The SID of the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Task to delete </param>
        /// <param name="pathSid"> The SID of the resource to delete </param>
        public DeleteTaskOptions(string pathWorkspaceSid, string pathSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// ReadTaskOptions
    /// </summary>
    public class ReadTaskOptions : ReadOptions<TaskResource>
    {
        /// <summary>
        /// The SID of the Workspace with the Tasks to read
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The priority value of the Tasks to read
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// Returns the list of all Tasks in the Workspace with the specified assignment_status
        /// </summary>
        public List<string> AssignmentStatus { get; set; }
        /// <summary>
        /// The SID of the Workflow with the Tasks to read
        /// </summary>
        public string WorkflowSid { get; set; }
        /// <summary>
        /// The friendly name of the Workflow with the Tasks to read
        /// </summary>
        public string WorkflowName { get; set; }
        /// <summary>
        /// The SID of the TaskQueue with the Tasks to read
        /// </summary>
        public string TaskQueueSid { get; set; }
        /// <summary>
        /// The friendly_name of the TaskQueue with the Tasks to read
        /// </summary>
        public string TaskQueueName { get; set; }
        /// <summary>
        /// The task attributes of the Tasks to read
        /// </summary>
        public string EvaluateTaskAttributes { get; set; }
        /// <summary>
        /// Controls the order of the Tasks returned
        /// </summary>
        public string Ordering { get; set; }
        /// <summary>
        /// Whether to read Tasks with addons
        /// </summary>
        public bool? HasAddons { get; set; }

        /// <summary>
        /// Construct a new ReadTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace with the Tasks to read </param>
        public ReadTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
            AssignmentStatus = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (AssignmentStatus != null)
            {
                p.AddRange(AssignmentStatus.Select(prop => new KeyValuePair<string, string>("AssignmentStatus", prop)));
            }

            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }

            if (WorkflowName != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowName", WorkflowName));
            }

            if (TaskQueueSid != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueSid", TaskQueueSid.ToString()));
            }

            if (TaskQueueName != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskQueueName", TaskQueueName));
            }

            if (EvaluateTaskAttributes != null)
            {
                p.Add(new KeyValuePair<string, string>("EvaluateTaskAttributes", EvaluateTaskAttributes));
            }

            if (Ordering != null)
            {
                p.Add(new KeyValuePair<string, string>("Ordering", Ordering));
            }

            if (HasAddons != null)
            {
                p.Add(new KeyValuePair<string, string>("HasAddons", HasAddons.Value.ToString().ToLower()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateTaskOptions
    /// </summary>
    public class CreateTaskOptions : IOptions<TaskResource>
    {
        /// <summary>
        /// The SID of the Workspace that the new Task belongs to
        /// </summary>
        public string PathWorkspaceSid { get; }
        /// <summary>
        /// The amount of time in seconds the task is allowed to live
        /// </summary>
        public int? Timeout { get; set; }
        /// <summary>
        /// The priority to assign the new task and override the default
        /// </summary>
        public int? Priority { get; set; }
        /// <summary>
        /// When MultiTasking is enabled specify the TaskChannel by passing either its unique_name or SID
        /// </summary>
        public string TaskChannel { get; set; }
        /// <summary>
        /// The SID of the Workflow that you would like to handle routing for the new Task
        /// </summary>
        public string WorkflowSid { get; set; }
        /// <summary>
        /// A URL-encoded JSON string describing the attributes of the task
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new CreateTaskOptions
        /// </summary>
        /// <param name="pathWorkspaceSid"> The SID of the Workspace that the new Task belongs to </param>
        public CreateTaskOptions(string pathWorkspaceSid)
        {
            PathWorkspaceSid = pathWorkspaceSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Timeout != null)
            {
                p.Add(new KeyValuePair<string, string>("Timeout", Timeout.ToString()));
            }

            if (Priority != null)
            {
                p.Add(new KeyValuePair<string, string>("Priority", Priority.ToString()));
            }

            if (TaskChannel != null)
            {
                p.Add(new KeyValuePair<string, string>("TaskChannel", TaskChannel));
            }

            if (WorkflowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("WorkflowSid", WorkflowSid.ToString()));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

}