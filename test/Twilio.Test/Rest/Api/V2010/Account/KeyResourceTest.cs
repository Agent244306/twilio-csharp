/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Api.V2010.Account;

namespace Twilio.Tests.Rest.Api.V2010.Account
{

    [TestFixture]
    public class KeyTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Keys/SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                KeyResource.Fetch("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"SKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"foo\",\"date_created\": \"Mon, 13 Jun 2016 22:50:08 +0000\",\"date_updated\": \"Mon, 13 Jun 2016 22:50:08 +0000\"}"
                                     ));

            var response = KeyResource.Fetch("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Keys/SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                KeyResource.Update("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"SKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"foo\",\"date_created\": \"Mon, 13 Jun 2016 22:50:08 +0000\",\"date_updated\": \"Mon, 13 Jun 2016 22:50:08 +0000\"}"
                                     ));

            var response = KeyResource.Update("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Keys/SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                KeyResource.Delete("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = KeyResource.Delete("SKXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Api,
                "/2010-04-01/Accounts/ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Keys.json",
                ""
            );
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                KeyResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"keys\": [{\"sid\": \"SKaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"foo\",\"date_created\": \"Mon, 13 Jun 2016 22:50:08 +0000\",\"date_updated\": \"Mon, 13 Jun 2016 22:50:08 +0000\"}],\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Keys.json?PageSize=50&Page=0\",\"end\": 0,\"previous_page_uri\": null,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Keys.json?PageSize=50&Page=0\",\"page_size\": 50,\"start\": 0,\"next_page_uri\": null,\"page\": 0}"
                                     ));

            var response = KeyResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"keys\": [],\"first_page_uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Keys.json?PageSize=50&Page=0\",\"end\": 0,\"previous_page_uri\": null,\"uri\": \"/2010-04-01/Accounts/ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Keys.json?PageSize=50&Page=0\",\"page_size\": 50,\"start\": 0,\"next_page_uri\": null,\"page\": 0}"
                                     ));

            var response = KeyResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}