/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Sync.V1.Service.SyncMap 
{

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Fetch a specific Sync Map Permission.
    /// </summary>
    public class FetchSyncMapPermissionOptions : IOptions<SyncMapPermissionResource> 
    {
        /// <summary>
        /// Sync Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Sync Map SID or unique name.
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// Identity of the user to whom the Sync Map Permission applies.
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new FetchSyncMapPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sync Service Instance SID or unique name. </param>
        /// <param name="pathMapSid"> Sync Map SID or unique name. </param>
        /// <param name="pathIdentity"> Identity of the user to whom the Sync Map Permission applies. </param>
        public FetchSyncMapPermissionOptions(string pathServiceSid, string pathMapSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathIdentity = pathIdentity;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Delete a specific Sync Map Permission.
    /// </summary>
    public class DeleteSyncMapPermissionOptions : IOptions<SyncMapPermissionResource> 
    {
        /// <summary>
        /// Sync Service Instance SID or unique name
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Sync Map SID or unique name.
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// Identity of the user to whom the Sync Map Permission applies.
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new DeleteSyncMapPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sync Service Instance SID or unique name </param>
        /// <param name="pathMapSid"> Sync Map SID or unique name. </param>
        /// <param name="pathIdentity"> Identity of the user to whom the Sync Map Permission applies. </param>
        public DeleteSyncMapPermissionOptions(string pathServiceSid, string pathMapSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathIdentity = pathIdentity;
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
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Retrieve a list of all Permissions applying to a Sync Map.
    /// </summary>
    public class ReadSyncMapPermissionOptions : ReadOptions<SyncMapPermissionResource> 
    {
        /// <summary>
        /// Sync Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Sync Map SID or unique name.
        /// </summary>
        public string PathMapSid { get; }

        /// <summary>
        /// Construct a new ReadSyncMapPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sync Service Instance SID or unique name. </param>
        /// <param name="pathMapSid"> Sync Map SID or unique name. </param>
        public ReadSyncMapPermissionOptions(string pathServiceSid, string pathMapSid)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
    /// 
    /// Update an identity's access to a specific Sync Map.
    /// </summary>
    public class UpdateSyncMapPermissionOptions : IOptions<SyncMapPermissionResource> 
    {
        /// <summary>
        /// Sync Service Instance SID or unique name.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Sync Map SID or unique name.
        /// </summary>
        public string PathMapSid { get; }
        /// <summary>
        /// Identity of the user to whom the Sync Map Permission applies.
        /// </summary>
        public string PathIdentity { get; }
        /// <summary>
        /// Read access.
        /// </summary>
        public bool? Read { get; }
        /// <summary>
        /// Write access.
        /// </summary>
        public bool? Write { get; }
        /// <summary>
        /// Manage access.
        /// </summary>
        public bool? Manage { get; }

        /// <summary>
        /// Construct a new UpdateSyncMapPermissionOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sync Service Instance SID or unique name. </param>
        /// <param name="pathMapSid"> Sync Map SID or unique name. </param>
        /// <param name="pathIdentity"> Identity of the user to whom the Sync Map Permission applies. </param>
        /// <param name="read"> Read access. </param>
        /// <param name="write"> Write access. </param>
        /// <param name="manage"> Manage access. </param>
        public UpdateSyncMapPermissionOptions(string pathServiceSid, 
                                              string pathMapSid, 
                                              string pathIdentity, 
                                              bool? read, 
                                              bool? write, 
                                              bool? manage)
        {
            PathServiceSid = pathServiceSid;
            PathMapSid = pathMapSid;
            PathIdentity = pathIdentity;
            Read = read;
            Write = write;
            Manage = manage;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Read != null)
            {
                p.Add(new KeyValuePair<string, string>("Read", Read.Value.ToString().ToLower()));
            }

            if (Write != null)
            {
                p.Add(new KeyValuePair<string, string>("Write", Write.Value.ToString().ToLower()));
            }

            if (Manage != null)
            {
                p.Add(new KeyValuePair<string, string>("Manage", Manage.Value.ToString().ToLower()));
            }

            return p;
        }
    }

}