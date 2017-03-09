using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Accounts.V1.Credential 
{

    /// <summary>
    /// Retrieves a collection of Public Key Credentials belonging to the account used to make the request
    /// </summary>
    public class ReadPublicKeyOptions : ReadOptions<PublicKeyResource> 
    {
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

    /// <summary>
    /// Create a new Public Key Credential
    /// </summary>
    public class CreatePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// URL encoded representation of the public key
        /// </summary>
        public string PublicKey { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The Subaccount this Credential should be associated with.
        /// </summary>
        public string AccountSid { get; set; }

        /// <summary>
        /// Construct a new CreatePublicKeyOptions
        /// </summary>
        ///
        /// <param name="publicKey"> URL encoded representation of the public key </param>
        public CreatePublicKeyOptions(string publicKey)
        {
            PublicKey = publicKey;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PublicKey != null)
            {
                p.Add(new KeyValuePair<string, string>("PublicKey", PublicKey.ToString()));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (AccountSid != null)
            {
                p.Add(new KeyValuePair<string, string>("AccountSid", AccountSid.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch the public key specified by the provided Credential Sid
    /// </summary>
    public class FetchPublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// Fetch by unique Credential Sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchPublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Credential Sid </param>
        public FetchPublicKeyOptions(string pathSid)
        {
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
    /// Modify the properties of a given Account
    /// </summary>
    public class UpdatePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// Fetch by unique Credential Sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdatePublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> Fetch by unique Credential Sid </param>
        public UpdatePublicKeyOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a Credential from your account
    /// </summary>
    public class DeletePublicKeyOptions : IOptions<PublicKeyResource> 
    {
        /// <summary>
        /// A 34 character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeletePublicKeyOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A 34 character string that uniquely identifies this resource. </param>
        public DeletePublicKeyOptions(string pathSid)
        {
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

}