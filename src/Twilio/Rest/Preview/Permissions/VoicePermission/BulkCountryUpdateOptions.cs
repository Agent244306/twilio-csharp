/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.Permissions.VoicePermission 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Create a bulk update request to update voice permissions for the given set of countries
    /// </summary>
    public class CreateBulkCountryUpdateOptions : IOptions<BulkCountryUpdateResource> 
    {
        /// <summary>
        /// Json list of update objects
        /// </summary>
        public string UpdateRequest { get; }

        /// <summary>
        /// Construct a new CreateBulkCountryUpdateOptions
        /// </summary>
        /// <param name="updateRequest"> Json list of update objects </param>
        public CreateBulkCountryUpdateOptions(string updateRequest)
        {
            UpdateRequest = updateRequest;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UpdateRequest != null)
            {
                p.Add(new KeyValuePair<string, string>("UpdateRequest", UpdateRequest));
            }

            return p;
        }
    }

}