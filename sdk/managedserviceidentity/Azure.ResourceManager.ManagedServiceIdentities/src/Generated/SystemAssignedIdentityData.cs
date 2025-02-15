// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A class representing the SystemAssignedIdentity data model.
    /// Describes a system assigned identity resource.
    /// </summary>
    public partial class SystemAssignedIdentityData : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SystemAssignedIdentityData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SystemAssignedIdentityData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SystemAssignedIdentityData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="tenantId"> The id of the tenant which the identity belongs to. </param>
        /// <param name="principalId"> The id of the service principal object associated with the created identity. </param>
        /// <param name="clientId"> The id of the app associated with the identity. This is a random generated UUID by MSI. </param>
        /// <param name="clientSecretUri"> The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SystemAssignedIdentityData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, Guid? tenantId, Guid? principalId, Guid? clientId, Uri clientSecretUri, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            TenantId = tenantId;
            PrincipalId = principalId;
            ClientId = clientId;
            ClientSecretUri = clientSecretUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SystemAssignedIdentityData"/> for deserialization. </summary>
        internal SystemAssignedIdentityData()
        {
        }

        /// <summary> The id of the tenant which the identity belongs to. </summary>
        public Guid? TenantId { get; }
        /// <summary> The id of the service principal object associated with the created identity. </summary>
        public Guid? PrincipalId { get; }
        /// <summary> The id of the app associated with the identity. This is a random generated UUID by MSI. </summary>
        public Guid? ClientId { get; }
        /// <summary> The ManagedServiceIdentity DataPlane URL that can be queried to obtain the identity credentials. </summary>
        public Uri ClientSecretUri { get; }
    }
}
