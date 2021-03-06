/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Preview.TrustedComms.BrandedChannel
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Associate a channel to a branded channel
    /// </summary>
    public class CreateChannelOptions : IOptions<ChannelResource>
    {
        /// <summary>
        /// Branded Channel Sid.
        /// </summary>
        public string PathBrandedChannelSid { get; }
        /// <summary>
        /// Phone Number Sid to be branded.
        /// </summary>
        public string PhoneNumberSid { get; }

        /// <summary>
        /// Construct a new CreateChannelOptions
        /// </summary>
        /// <param name="pathBrandedChannelSid"> Branded Channel Sid. </param>
        /// <param name="phoneNumberSid"> Phone Number Sid to be branded. </param>
        public CreateChannelOptions(string pathBrandedChannelSid, string phoneNumberSid)
        {
            PathBrandedChannelSid = pathBrandedChannelSid;
            PhoneNumberSid = phoneNumberSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PhoneNumberSid != null)
            {
                p.Add(new KeyValuePair<string, string>("PhoneNumberSid", PhoneNumberSid.ToString()));
            }

            return p;
        }
    }

}