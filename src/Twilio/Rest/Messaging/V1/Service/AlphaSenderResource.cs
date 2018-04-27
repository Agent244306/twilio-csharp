/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// AlphaSenderResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Messaging.V1.Service 
{

    public class AlphaSenderResource : Resource 
    {
        private static Request BuildCreateRequest(CreateAlphaSenderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathServiceSid + "/AlphaSenders",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static AlphaSenderResource Create(CreateAlphaSenderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<AlphaSenderResource> CreateAsync(CreateAlphaSenderOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="alphaSender"> An Alphanumeric Sender ID string, up to 11 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static AlphaSenderResource Create(string pathServiceSid, string alphaSender, ITwilioRestClient client = null)
        {
            var options = new CreateAlphaSenderOptions(pathServiceSid, alphaSender);
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="alphaSender"> An Alphanumeric Sender ID string, up to 11 characters. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<AlphaSenderResource> CreateAsync(string pathServiceSid, 
                                                                                         string alphaSender, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateAlphaSenderOptions(pathServiceSid, alphaSender);
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAlphaSenderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathServiceSid + "/AlphaSenders",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static ResourceSet<AlphaSenderResource> Read(ReadAlphaSenderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AlphaSenderResource>.FromJson("alpha_senders", response.Content);
            return new ResourceSet<AlphaSenderResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AlphaSenderResource>> ReadAsync(ReadAlphaSenderOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AlphaSenderResource>.FromJson("alpha_senders", response.Content);
            return new ResourceSet<AlphaSenderResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static ResourceSet<AlphaSenderResource> Read(string pathServiceSid, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadAlphaSenderOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AlphaSenderResource>> ReadAsync(string pathServiceSid, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadAlphaSenderOptions(pathServiceSid){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AlphaSenderResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AlphaSenderResource>.FromJson("alpha_senders", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AlphaSenderResource> NextPage(Page<AlphaSenderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Messaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AlphaSenderResource>.FromJson("alpha_senders", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AlphaSenderResource> PreviousPage(Page<AlphaSenderResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Messaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AlphaSenderResource>.FromJson("alpha_senders", response.Content);
        }

        private static Request BuildFetchRequest(FetchAlphaSenderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathServiceSid + "/AlphaSenders/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static AlphaSenderResource Fetch(FetchAlphaSenderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<AlphaSenderResource> FetchAsync(FetchAlphaSenderOptions options, 
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
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static AlphaSenderResource Fetch(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAlphaSenderOptions(pathServiceSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<AlphaSenderResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchAlphaSenderOptions(pathServiceSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAlphaSenderOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathServiceSid + "/AlphaSenders/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static bool Delete(DeleteAlphaSenderOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete AlphaSender parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAlphaSenderOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of AlphaSender </returns> 
        public static bool Delete(string pathServiceSid, string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAlphaSenderOptions(pathServiceSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of AlphaSender </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteAlphaSenderOptions(pathServiceSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AlphaSenderResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AlphaSenderResource object represented by the provided JSON </returns> 
        public static AlphaSenderResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AlphaSenderResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The 34 character unique sid of the Alpha Sender ID.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The 34 character unique sid of the Account.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The 34 character unique sid of the Messaging Service.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// The date that this resource was created.
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date that this resource was last updated.
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An Alphanumeric Sender ID string, up to 11 characters.
        /// </summary>
        [JsonProperty("alpha_sender")]
        public string AlphaSender { get; private set; }
        /// <summary>
        /// An array of values that indicate whether the number can receive calls or messages.
        /// </summary>
        [JsonProperty("capabilities")]
        public List<object> Capabilities { get; private set; }
        /// <summary>
        /// The absolute URL for this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private AlphaSenderResource()
        {

        }
    }

}