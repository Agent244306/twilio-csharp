using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Trunking.V1.Trunk 
{

    /// <summary>
    /// FetchCredentialListOptions
    /// </summary>
    public class FetchCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchCredentialListOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchCredentialListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// DeleteCredentialListOptions
    /// </summary>
    public class DeleteCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteCredentialListOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="pathSid"> The sid </param>
        public DeleteCredentialListOptions(string pathTrunkSid, string pathSid)
        {
            PathTrunkSid = pathTrunkSid;
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
    /// CreateCredentialListOptions
    /// </summary>
    public class CreateCredentialListOptions : IOptions<CredentialListResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }
        /// <summary>
        /// The credential_list_sid
        /// </summary>
        public string CredentialListSid { get; }

        /// <summary>
        /// Construct a new CreateCredentialListOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        /// <param name="credentialListSid"> The credential_list_sid </param>
        public CreateCredentialListOptions(string pathTrunkSid, string credentialListSid)
        {
            PathTrunkSid = pathTrunkSid;
            CredentialListSid = credentialListSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (CredentialListSid != null)
            {
                p.Add(new KeyValuePair<string, string>("CredentialListSid", CredentialListSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadCredentialListOptions
    /// </summary>
    public class ReadCredentialListOptions : ReadOptions<CredentialListResource> 
    {
        /// <summary>
        /// The trunk_sid
        /// </summary>
        public string PathTrunkSid { get; }

        /// <summary>
        /// Construct a new ReadCredentialListOptions
        /// </summary>
        ///
        /// <param name="pathTrunkSid"> The trunk_sid </param>
        public ReadCredentialListOptions(string pathTrunkSid)
        {
            PathTrunkSid = pathTrunkSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}