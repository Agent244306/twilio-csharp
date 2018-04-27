/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
/// 
/// ParticipantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Proxy.V1.Service.Session 
{

    public class ParticipantResource : Resource 
    {
        private static Request BuildFetchRequest(FetchParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Fetch a specific Participant.
        /// </summary>
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Fetch(FetchParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Participant.
        /// </summary>
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(FetchParticipantOptions options, 
                                                                                        ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a specific Participant.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Fetch(string pathServiceSid, 
                                                string pathSessionSid, 
                                                string pathSid, 
                                                ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(pathServiceSid, pathSessionSid, pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a specific Participant.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(string pathServiceSid, 
                                                                                        string pathSessionSid, 
                                                                                        string pathSid, 
                                                                                        ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(pathServiceSid, pathSessionSid, pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Retrieve a list of all Participants in a Session.
        /// </summary>
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ResourceSet<ParticipantResource> Read(ReadParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Participants in a Session.
        /// </summary>
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(ReadParticipantOptions options, 
                                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of all Participants in a Session.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="identifier"> The identifier </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ResourceSet<ParticipantResource> Read(string pathServiceSid, 
                                                            string pathSessionSid, 
                                                            string identifier = null, 
                                                            int? pageSize = null, 
                                                            long? limit = null, 
                                                            ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(pathServiceSid, pathSessionSid){Identifier = identifier, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of all Participants in a Session.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="identifier"> The identifier </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(string pathServiceSid, 
                                                                                                    string pathSessionSid, 
                                                                                                    string identifier = null, 
                                                                                                    int? pageSize = null, 
                                                                                                    long? limit = null, 
                                                                                                    ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(pathServiceSid, pathSessionSid){Identifier = identifier, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ParticipantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ParticipantResource> NextPage(Page<ParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Proxy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ParticipantResource> PreviousPage(Page<ParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Proxy,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }

        private static Request BuildCreateRequest(CreateParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// Add a new Participant to the Session
        /// </summary>
        /// <param name="options"> Create Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Create(CreateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Add a new Participant to the Session
        /// </summary>
        /// <param name="options"> Create Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> CreateAsync(CreateParticipantOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Add a new Participant to the Session
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="identifier"> The phone number of this Participant. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="proxyIdentifier"> The proxy phone number to use for this Participant. </param>
        /// <param name="proxyIdentifierSid"> The proxy_identifier_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Create(string pathServiceSid, 
                                                 string pathSessionSid, 
                                                 string identifier, 
                                                 string friendlyName = null, 
                                                 string proxyIdentifier = null, 
                                                 string proxyIdentifierSid = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new CreateParticipantOptions(pathServiceSid, pathSessionSid, identifier){FriendlyName = friendlyName, ProxyIdentifier = proxyIdentifier, ProxyIdentifierSid = proxyIdentifierSid};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Add a new Participant to the Session
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="identifier"> The phone number of this Participant. </param>
        /// <param name="friendlyName"> A human readable description of this resource. </param>
        /// <param name="proxyIdentifier"> The proxy phone number to use for this Participant. </param>
        /// <param name="proxyIdentifierSid"> The proxy_identifier_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> CreateAsync(string pathServiceSid, 
                                                                                         string pathSessionSid, 
                                                                                         string identifier, 
                                                                                         string friendlyName = null, 
                                                                                         string proxyIdentifier = null, 
                                                                                         string proxyIdentifierSid = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new CreateParticipantOptions(pathServiceSid, pathSessionSid, identifier){FriendlyName = friendlyName, ProxyIdentifier = proxyIdentifier, ProxyIdentifierSid = proxyIdentifierSid};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// Delete a specific Participant. This is a soft-delete.  The participant remains associated with the session and
        /// cannot be re-added.  Participants are only permanently deleted when the session is deleted.
        /// </summary>
        /// <param name="options"> Delete Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static bool Delete(DeleteParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Participant. This is a soft-delete.  The participant remains associated with the session and
        /// cannot be re-added.  Participants are only permanently deleted when the session is deleted.
        /// </summary>
        /// <param name="options"> Delete Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteParticipantOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// Delete a specific Participant. This is a soft-delete.  The participant remains associated with the session and
        /// cannot be re-added.  Participants are only permanently deleted when the session is deleted.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static bool Delete(string pathServiceSid, 
                                  string pathSessionSid, 
                                  string pathSid, 
                                  ITwilioRestClient client = null)
        {
            var options = new DeleteParticipantOptions(pathServiceSid, pathSessionSid, pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// Delete a specific Participant. This is a soft-delete.  The participant remains associated with the session and
        /// cannot be re-added.  Participants are only permanently deleted when the session is deleted.
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Participant. </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathServiceSid, 
                                                                          string pathSessionSid, 
                                                                          string pathSid, 
                                                                          ITwilioRestClient client = null)
        {
            var options = new DeleteParticipantOptions(pathServiceSid, pathSessionSid, pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Proxy,
                "/v1/Services/" + options.PathServiceSid + "/Sessions/" + options.PathSessionSid + "/Participants/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Update(UpdateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> UpdateAsync(UpdateParticipantOptions options, 
                                                                                         ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="identifier"> The identifier </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="proxyIdentifier"> The proxy_identifier </param>
        /// <param name="proxyIdentifierSid"> The proxy_identifier_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Update(string pathServiceSid, 
                                                 string pathSessionSid, 
                                                 string pathSid, 
                                                 string identifier = null, 
                                                 string friendlyName = null, 
                                                 string proxyIdentifier = null, 
                                                 string proxyIdentifierSid = null, 
                                                 ITwilioRestClient client = null)
        {
            var options = new UpdateParticipantOptions(pathServiceSid, pathSessionSid, pathSid){Identifier = identifier, FriendlyName = friendlyName, ProxyIdentifier = proxyIdentifier, ProxyIdentifierSid = proxyIdentifierSid};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathSid"> The sid </param>
        /// <param name="identifier"> The identifier </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="proxyIdentifier"> The proxy_identifier </param>
        /// <param name="proxyIdentifierSid"> The proxy_identifier_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> UpdateAsync(string pathServiceSid, 
                                                                                         string pathSessionSid, 
                                                                                         string pathSid, 
                                                                                         string identifier = null, 
                                                                                         string friendlyName = null, 
                                                                                         string proxyIdentifier = null, 
                                                                                         string proxyIdentifierSid = null, 
                                                                                         ITwilioRestClient client = null)
        {
            var options = new UpdateParticipantOptions(pathServiceSid, pathSessionSid, pathSid){Identifier = identifier, FriendlyName = friendlyName, ProxyIdentifier = proxyIdentifier, ProxyIdentifierSid = proxyIdentifierSid};
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ParticipantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ParticipantResource object represented by the provided JSON </returns> 
        public static ParticipantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ParticipantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// A string that uniquely identifies this Participant.
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        [JsonProperty("session_sid")]
        public string SessionSid { get; private set; }
        /// <summary>
        /// Service Sid.
        /// </summary>
        [JsonProperty("service_sid")]
        public string ServiceSid { get; private set; }
        /// <summary>
        /// Account Sid.
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// A human readable description of this resource.
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The phone number of this Participant.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; private set; }
        /// <summary>
        /// Proxy Identifier.
        /// </summary>
        [JsonProperty("proxy_identifier")]
        public string ProxyIdentifier { get; private set; }
        /// <summary>
        /// Proxy Identifier Sid.
        /// </summary>
        [JsonProperty("proxy_identifier_sid")]
        public string ProxyIdentifierSid { get; private set; }
        /// <summary>
        /// The date this Participant was deleted
        /// </summary>
        [JsonProperty("date_deleted")]
        public DateTime? DateDeleted { get; private set; }
        /// <summary>
        /// The date this Participant was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this Participant was updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The URL of this resource.
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Nested resource URLs.
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ParticipantResource()
        {

        }
    }

}