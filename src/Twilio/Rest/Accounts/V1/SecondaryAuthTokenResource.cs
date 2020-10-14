/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// SecondaryAuthTokenResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Accounts.V1
{

    public class SecondaryAuthTokenResource : Resource
    {
        private static Request BuildCreateRequest(CreateSecondaryAuthTokenOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Accounts,
                "/v1/AuthTokens/Secondary",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Create a new secondary Auth Token
        /// </summary>
        /// <param name="options"> Create SecondaryAuthToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SecondaryAuthToken </returns>
        public static SecondaryAuthTokenResource Create(CreateSecondaryAuthTokenOptions options,
                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Create a new secondary Auth Token
        /// </summary>
        /// <param name="options"> Create SecondaryAuthToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SecondaryAuthToken </returns>
        public static async System.Threading.Tasks.Task<SecondaryAuthTokenResource> CreateAsync(CreateSecondaryAuthTokenOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Create a new secondary Auth Token
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SecondaryAuthToken </returns>
        public static SecondaryAuthTokenResource Create(ITwilioRestClient client = null)
        {
            var options = new CreateSecondaryAuthTokenOptions();
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Create a new secondary Auth Token
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SecondaryAuthToken </returns>
        public static async System.Threading.Tasks.Task<SecondaryAuthTokenResource> CreateAsync(ITwilioRestClient client = null)
        {
            var options = new CreateSecondaryAuthTokenOptions();
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteSecondaryAuthTokenOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Accounts,
                "/v1/AuthTokens/Secondary",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Delete the secondary Auth Token from your account
        /// </summary>
        /// <param name="options"> Delete SecondaryAuthToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SecondaryAuthToken </returns>
        public static bool Delete(DeleteSecondaryAuthTokenOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete the secondary Auth Token from your account
        /// </summary>
        /// <param name="options"> Delete SecondaryAuthToken parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SecondaryAuthToken </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteSecondaryAuthTokenOptions options,
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete the secondary Auth Token from your account
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of SecondaryAuthToken </returns>
        public static bool Delete(ITwilioRestClient client = null)
        {
            var options = new DeleteSecondaryAuthTokenOptions();
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete the secondary Auth Token from your account
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of SecondaryAuthToken </returns>
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(ITwilioRestClient client = null)
        {
            var options = new DeleteSecondaryAuthTokenOptions();
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a SecondaryAuthTokenResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> SecondaryAuthTokenResource object represented by the provided JSON </returns>
        public static SecondaryAuthTokenResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<SecondaryAuthTokenResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that the secondary Auth Token was created for
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The ISO 8601 formatted date and time in UTC when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 formatted date and time in UTC when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The generated secondary Auth Token
        /// </summary>
        [JsonProperty("secondary_auth_token")]
        public string SecondaryAuthToken { get; private set; }
        /// <summary>
        /// The URI for this resource, relative to `https://accounts.twilio.com`
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private SecondaryAuthTokenResource()
        {

        }
    }

}