// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Request payload for create or update Disk Pool request. </summary>
    public partial class DiskPoolCreateOrUpdateContent : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DiskPoolCreateOrUpdateContent"/>. </summary>
        /// <param name="sku"> Determines the SKU of the Disk Pool. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> or <paramref name="subnetId"/> is null. </exception>
        public DiskPoolCreateOrUpdateContent(StoragePoolSku sku, AzureLocation location, ResourceIdentifier subnetId)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }
            if (subnetId == null)
            {
                throw new ArgumentNullException(nameof(subnetId));
            }

            Sku = sku;
            Tags = new ChangeTrackingDictionary<string, string>();
            Location = location;
            ManagedByExtended = new ChangeTrackingList<string>();
            AvailabilityZones = new ChangeTrackingList<string>();
            Disks = new ChangeTrackingList<WritableSubResource>();
            SubnetId = subnetId;
            AdditionalCapabilities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> Determines the SKU of the Disk Pool. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <param name="managedBy"> Azure resource id. Indicates if this resource is managed by another Azure resource. </param>
        /// <param name="managedByExtended"> List of Azure resource ids that manage this resource. </param>
        /// <param name="availabilityZones"> Logical zone for Disk Pool resource; example: ["1"]. </param>
        /// <param name="disks"> List of Azure Managed Disks to attach to a Disk Pool. </param>
        /// <param name="subnetId"> Azure Resource ID of a Subnet for the Disk Pool. </param>
        /// <param name="additionalCapabilities"> List of additional capabilities for a Disk Pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiskPoolCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, StoragePoolSku sku, IDictionary<string, string> tags, AzureLocation location, string managedBy, IList<string> managedByExtended, IList<string> availabilityZones, IList<WritableSubResource> disks, ResourceIdentifier subnetId, IList<string> additionalCapabilities, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            Tags = tags;
            Location = location;
            ManagedBy = managedBy;
            ManagedByExtended = managedByExtended;
            AvailabilityZones = availabilityZones;
            Disks = disks;
            SubnetId = subnetId;
            AdditionalCapabilities = additionalCapabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiskPoolCreateOrUpdateContent"/> for deserialization. </summary>
        internal DiskPoolCreateOrUpdateContent()
        {
        }

        /// <summary> Determines the SKU of the Disk Pool. </summary>
        public StoragePoolSku Sku { get; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation Location { get; }
        /// <summary> Azure resource id. Indicates if this resource is managed by another Azure resource. </summary>
        public string ManagedBy { get; set; }
        /// <summary> List of Azure resource ids that manage this resource. </summary>
        public IList<string> ManagedByExtended { get; }
        /// <summary> Logical zone for Disk Pool resource; example: ["1"]. </summary>
        public IList<string> AvailabilityZones { get; }
        /// <summary> List of Azure Managed Disks to attach to a Disk Pool. </summary>
        public IList<WritableSubResource> Disks { get; }
        /// <summary> Azure Resource ID of a Subnet for the Disk Pool. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> List of additional capabilities for a Disk Pool. </summary>
        public IList<string> AdditionalCapabilities { get; }
    }
}
