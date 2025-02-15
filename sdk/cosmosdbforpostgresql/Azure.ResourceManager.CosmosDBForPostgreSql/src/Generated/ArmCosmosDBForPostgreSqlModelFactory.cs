// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmCosmosDBForPostgreSqlModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="administratorLogin"> The administrator's login name of the servers in the cluster. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. Required for creation. </param>
        /// <param name="provisioningState"> Provisioning state of the cluster. </param>
        /// <param name="state"> A state of a cluster/server that is visible to user. </param>
        /// <param name="postgresqlVersion"> The major PostgreSQL version on all cluster servers. </param>
        /// <param name="citusVersion"> The Citus extension version on all cluster servers. </param>
        /// <param name="maintenanceWindow"> Maintenance window of a cluster. </param>
        /// <param name="preferredPrimaryZone"> Preferred primary availability zone (AZ) for all cluster servers. </param>
        /// <param name="isShardsOnCoordinatorEnabled"> If distributed tables are placed on coordinator or not. Should be set to 'true' on single node clusters. Requires shard rebalancing after value is changed. </param>
        /// <param name="isHAEnabled"> If high availability (HA) is enabled or not for the cluster. </param>
        /// <param name="coordinatorServerEdition"> The edition of a coordinator server (default: GeneralPurpose). Required for creation. </param>
        /// <param name="coordinatorStorageQuotaInMb"> The storage of a server in MB. Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="coordinatorVCores"> The vCores count of a server (max: 96). Required for creation. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="isCoordinatorPublicIPAccessEnabled"> If public access is enabled on coordinator. </param>
        /// <param name="nodeServerEdition"> The edition of a node server (default: MemoryOptimized). </param>
        /// <param name="nodeCount"> Worker node count of the cluster. When node count is 0, it represents a single node configuration with the ability to create distributed tables on that node. 2 or more worker nodes represent multi-node configuration. Node count value cannot be 1. Required for creation. </param>
        /// <param name="nodeStorageQuotaInMb"> The storage in MB on each worker node. See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="nodeVCores"> The compute in vCores on each worker node (max: 104). See https://learn.microsoft.com/azure/cosmos-db/postgresql/resources-compute for more information. </param>
        /// <param name="isNodePublicIPAccessEnabled"> If public access is enabled on worker nodes. </param>
        /// <param name="serverNames"> The list of server names in the cluster. </param>
        /// <param name="sourceResourceId"> The resource id of source cluster for read replica clusters. </param>
        /// <param name="sourceLocation"> The Azure region of source cluster for read replica clusters. </param>
        /// <param name="pointInTimeUTC"> Date and time in UTC (ISO8601 format) for cluster restore. </param>
        /// <param name="readReplicas"> The array of read replica clusters. </param>
        /// <param name="earliestRestoreOn"> The earliest restore point time (ISO8601 format) for the cluster. </param>
        /// <param name="privateEndpointConnections"> The private endpoint connections for a cluster. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlClusterData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlClusterData CosmosDBForPostgreSqlClusterData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string administratorLogin = null, string administratorLoginPassword = null, string provisioningState = null, string state = null, string postgresqlVersion = null, string citusVersion = null, CosmosDBForPostgreSqlMaintenanceWindow maintenanceWindow = null, string preferredPrimaryZone = null, bool? isShardsOnCoordinatorEnabled = null, bool? isHAEnabled = null, string coordinatorServerEdition = null, int? coordinatorStorageQuotaInMb = null, int? coordinatorVCores = null, bool? isCoordinatorPublicIPAccessEnabled = null, string nodeServerEdition = null, int? nodeCount = null, int? nodeStorageQuotaInMb = null, int? nodeVCores = null, bool? isNodePublicIPAccessEnabled = null, IEnumerable<CosmosDBForPostgreSqlServerNameItem> serverNames = null, ResourceIdentifier sourceResourceId = null, AzureLocation? sourceLocation = null, DateTimeOffset? pointInTimeUTC = null, IEnumerable<string> readReplicas = null, DateTimeOffset? earliestRestoreOn = null, IEnumerable<CosmosDBForPostgreSqlSimplePrivateEndpointConnection> privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();
            serverNames ??= new List<CosmosDBForPostgreSqlServerNameItem>();
            readReplicas ??= new List<string>();
            privateEndpointConnections ??= new List<CosmosDBForPostgreSqlSimplePrivateEndpointConnection>();

            return new CosmosDBForPostgreSqlClusterData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                administratorLogin,
                administratorLoginPassword,
                provisioningState,
                state,
                postgresqlVersion,
                citusVersion,
                maintenanceWindow,
                preferredPrimaryZone,
                isShardsOnCoordinatorEnabled,
                isHAEnabled,
                coordinatorServerEdition,
                coordinatorStorageQuotaInMb,
                coordinatorVCores,
                isCoordinatorPublicIPAccessEnabled,
                nodeServerEdition,
                nodeCount,
                nodeStorageQuotaInMb,
                nodeVCores,
                isNodePublicIPAccessEnabled,
                serverNames?.ToList(),
                sourceResourceId,
                sourceLocation,
                pointInTimeUTC,
                readReplicas?.ToList(),
                earliestRestoreOn,
                privateEndpointConnections?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlServerNameItem"/>. </summary>
        /// <param name="name"> The name of a server. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlServerNameItem"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlServerNameItem CosmosDBForPostgreSqlServerNameItem(string name = null, string fullyQualifiedDomainName = null)
        {
            return new CosmosDBForPostgreSqlServerNameItem(name, fullyQualifiedDomainName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlSimplePrivateEndpointConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="groupIds"> Group ids of the private endpoint connection. </param>
        /// <param name="privateLinkServiceConnectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlSimplePrivateEndpointConnection"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlSimplePrivateEndpointConnection CosmosDBForPostgreSqlSimplePrivateEndpointConnection(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, IEnumerable<string> groupIds = null, CosmosDBForPostgreSqlPrivateLinkServiceConnectionState privateLinkServiceConnectionState = null)
        {
            groupIds ??= new List<string>();

            return new CosmosDBForPostgreSqlSimplePrivateEndpointConnection(
                id,
                name,
                resourceType,
                systemData,
                privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null,
                groupIds?.ToList(),
                privateLinkServiceConnectionState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlClusterPatch"/>. </summary>
        /// <param name="tags"> Application-specific metadata in the form of key-value pairs. </param>
        /// <param name="administratorLoginPassword"> The password of the administrator login. Each cluster is created with pre-defined administrative role called ‘citus’. . </param>
        /// <param name="postgresqlVersion"> The major PostgreSQL version on all cluster servers. </param>
        /// <param name="citusVersion"> The Citus extension version on all cluster servers. </param>
        /// <param name="isShardsOnCoordinatorEnabled"> If distributed tables are placed on coordinator or not. Should be set to 'true' on single node clusters. Requires shard rebalancing after value is changed. </param>
        /// <param name="isHAEnabled"> If high availability (HA) is enabled or not for the cluster. </param>
        /// <param name="preferredPrimaryZone"> Preferred primary availability zone (AZ) for all cluster servers. </param>
        /// <param name="coordinatorServerEdition"> The edition of the coordinator (default: GeneralPurpose). </param>
        /// <param name="coordinatorStorageQuotaInMb"> The storage of the coordinator in MB. </param>
        /// <param name="coordinatorVCores"> The vCores count of the coordinator (max: 96). </param>
        /// <param name="isCoordinatorPublicIPAccessEnabled"> If public access is enabled on coordinator. </param>
        /// <param name="nodeServerEdition"> The edition of a node (default: MemoryOptimized). </param>
        /// <param name="nodeCount"> Worker node count of the cluster. When node count is 0, it represents a single node configuration with the ability to create distributed tables on that node. 2 or more worker nodes represent multi-node configuration. Node count value cannot be 1. </param>
        /// <param name="nodeStorageQuotaInMb"> The storage in MB on each worker node. </param>
        /// <param name="nodeVCores"> The compute in vCores on each worker node (max: 104). </param>
        /// <param name="isNodePublicIPAccessEnabled"> If public access is enabled on worker nodes. </param>
        /// <param name="maintenanceWindow"> Maintenance window of a cluster. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlClusterPatch"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlClusterPatch CosmosDBForPostgreSqlClusterPatch(IDictionary<string, string> tags = null, string administratorLoginPassword = null, string postgresqlVersion = null, string citusVersion = null, bool? isShardsOnCoordinatorEnabled = null, bool? isHAEnabled = null, string preferredPrimaryZone = null, string coordinatorServerEdition = null, int? coordinatorStorageQuotaInMb = null, int? coordinatorVCores = null, bool? isCoordinatorPublicIPAccessEnabled = null, string nodeServerEdition = null, int? nodeCount = null, int? nodeStorageQuotaInMb = null, int? nodeVCores = null, bool? isNodePublicIPAccessEnabled = null, CosmosDBForPostgreSqlMaintenanceWindow maintenanceWindow = null)
        {
            tags ??= new Dictionary<string, string>();

            return new CosmosDBForPostgreSqlClusterPatch(
                tags,
                administratorLoginPassword,
                postgresqlVersion,
                citusVersion,
                isShardsOnCoordinatorEnabled,
                isHAEnabled,
                preferredPrimaryZone,
                coordinatorServerEdition,
                coordinatorStorageQuotaInMb,
                coordinatorVCores,
                isCoordinatorPublicIPAccessEnabled,
                nodeServerEdition,
                nodeCount,
                nodeStorageQuotaInMb,
                nodeVCores,
                isNodePublicIPAccessEnabled,
                maintenanceWindow,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlClusterServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverEdition"> The edition of a server. </param>
        /// <param name="storageQuotaInMb"> The storage of a server in MB. </param>
        /// <param name="vCores"> The vCores count of a server. </param>
        /// <param name="isHAEnabled"> If high availability (HA) is enabled or not for the server. </param>
        /// <param name="isPublicIPAccessEnabled"> If public access is enabled on server. </param>
        /// <param name="isReadOnly"> If server database is set to read-only by system maintenance depending on high disk space usage. </param>
        /// <param name="administratorLogin"> The administrator's login name of the servers in the cluster. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="role"> The role of server in the cluster. </param>
        /// <param name="state"> A state of a cluster/server that is visible to user. </param>
        /// <param name="haState"> A state of HA feature for the cluster. </param>
        /// <param name="availabilityZone"> Availability Zone information of the server. </param>
        /// <param name="postgresqlVersion"> The major PostgreSQL version of server. </param>
        /// <param name="citusVersion"> The Citus extension version of server. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlClusterServerData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlClusterServerData CosmosDBForPostgreSqlClusterServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string serverEdition = null, int? storageQuotaInMb = null, int? vCores = null, bool? isHAEnabled = null, bool? isPublicIPAccessEnabled = null, bool? isReadOnly = null, string administratorLogin = null, string fullyQualifiedDomainName = null, CosmosDBForPostgreSqlServerRole? role = null, string state = null, string haState = null, string availabilityZone = null, string postgresqlVersion = null, string citusVersion = null)
        {
            return new CosmosDBForPostgreSqlClusterServerData(
                id,
                name,
                resourceType,
                systemData,
                serverEdition,
                storageQuotaInMb,
                vCores,
                isHAEnabled,
                isPublicIPAccessEnabled,
                isReadOnly,
                administratorLogin,
                fullyQualifiedDomainName,
                role,
                state,
                haState,
                availabilityZone,
                postgresqlVersion,
                citusVersion,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlServerConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="isRestartRequired"> If configuration change requires restart. </param>
        /// <param name="provisioningState"> Provisioning state of the configuration. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlServerConfigurationData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlServerConfigurationData CosmosDBForPostgreSqlServerConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string value = null, string source = null, string description = null, string defaultValue = null, CosmosDBForPostgreSqlConfigurationDataType? dataType = null, string allowedValues = null, bool? isRestartRequired = null, CosmosDBForPostgreSqlProvisioningState? provisioningState = null)
        {
            return new CosmosDBForPostgreSqlServerConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                value,
                source,
                description,
                defaultValue,
                dataType,
                allowedValues,
                isRestartRequired,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="isRestartRequired"> If configuration change requires restart. </param>
        /// <param name="serverRoleGroupConfigurations"> The list of server role group configuration values. </param>
        /// <param name="provisioningState"> Provisioning state of the configuration. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlConfigurationData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlConfigurationData CosmosDBForPostgreSqlConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string description = null, CosmosDBForPostgreSqlConfigurationDataType? dataType = null, string allowedValues = null, bool? isRestartRequired = null, IEnumerable<CosmosDBForPostgreSqlServerRoleGroupConfiguration> serverRoleGroupConfigurations = null, CosmosDBForPostgreSqlProvisioningState? provisioningState = null)
        {
            serverRoleGroupConfigurations ??= new List<CosmosDBForPostgreSqlServerRoleGroupConfiguration>();

            return new CosmosDBForPostgreSqlConfigurationData(
                id,
                name,
                resourceType,
                systemData,
                description,
                dataType,
                allowedValues,
                isRestartRequired,
                serverRoleGroupConfigurations?.ToList(),
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlServerRoleGroupConfiguration"/>. </summary>
        /// <param name="role"> The role of servers in the server role group. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlServerRoleGroupConfiguration"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlServerRoleGroupConfiguration CosmosDBForPostgreSqlServerRoleGroupConfiguration(CosmosDBForPostgreSqlServerRole role = default, string value = null, string defaultValue = null, string source = null)
        {
            return new CosmosDBForPostgreSqlServerRoleGroupConfiguration(role, value, defaultValue, source, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlFirewallRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the cluster firewall rule. Must be IPv4 format. </param>
        /// <param name="provisioningState"> Provisioning state of the firewall rule. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlFirewallRuleData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlFirewallRuleData CosmosDBForPostgreSqlFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null, CosmosDBForPostgreSqlProvisioningState? provisioningState = null)
        {
            return new CosmosDBForPostgreSqlFirewallRuleData(
                id,
                name,
                resourceType,
                systemData,
                startIPAddress,
                endIPAddress,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlRoleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="password"> The password of the cluster role. </param>
        /// <param name="provisioningState"> Provisioning state of the role. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlRoleData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlRoleData CosmosDBForPostgreSqlRoleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string password = null, CosmosDBForPostgreSqlProvisioningState? provisioningState = null)
        {
            return new CosmosDBForPostgreSqlRoleData(
                id,
                name,
                resourceType,
                systemData,
                password,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlClusterNameAvailabilityContent"/>. </summary>
        /// <param name="name"> Cluster name to verify. </param>
        /// <param name="resourceType"> Resource type used for verification. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlClusterNameAvailabilityContent"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlClusterNameAvailabilityContent CosmosDBForPostgreSqlClusterNameAvailabilityContent(string name = null, CosmosDBForPostgreSqlNameAvailabilityResourceType resourceType = default)
        {
            return new CosmosDBForPostgreSqlClusterNameAvailabilityContent(name, resourceType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CosmosDBForPostgreSqlClusterNameAvailabilityResult"/>. </summary>
        /// <param name="message"> Error message. </param>
        /// <param name="isNameAvailable"> Indicates whether the cluster name is available. </param>
        /// <param name="name"> Name of the cluster. </param>
        /// <param name="resourceType"> Type of the cluster. </param>
        /// <returns> A new <see cref="Models.CosmosDBForPostgreSqlClusterNameAvailabilityResult"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlClusterNameAvailabilityResult CosmosDBForPostgreSqlClusterNameAvailabilityResult(string message = null, bool? isNameAvailable = null, string name = null, ResourceType? resourceType = null)
        {
            return new CosmosDBForPostgreSqlClusterNameAvailabilityResult(message, isNameAvailable, name, resourceType, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupIds"> The group ids for the private endpoint resource. </param>
        /// <param name="privateEndpointId"> The private endpoint resource. </param>
        /// <param name="connectionState"> A collection of information about the state of the connection between service consumer and provider. </param>
        /// <param name="provisioningState"> The provisioning state of the private endpoint connection resource. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionData CosmosDBForPostgreSqlPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<string> groupIds = null, ResourceIdentifier privateEndpointId = null, CosmosDBForPostgreSqlPrivateLinkServiceConnectionState connectionState = null, CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState? provisioningState = null)
        {
            groupIds ??= new List<string>();

            return new CosmosDBForPostgreSqlPrivateEndpointConnectionData(
                id,
                name,
                resourceType,
                systemData,
                groupIds?.ToList(),
                privateEndpointId != null ? ResourceManagerModelFactory.SubResource(privateEndpointId) : null,
                connectionState,
                provisioningState,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlPrivateLinkResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <param name="requiredZoneNames"> The private link resource private link DNS zone name. </param>
        /// <returns> A new <see cref="CosmosDBForPostgreSql.CosmosDBForPostgreSqlPrivateLinkResourceData"/> instance for mocking. </returns>
        public static CosmosDBForPostgreSqlPrivateLinkResourceData CosmosDBForPostgreSqlPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new CosmosDBForPostgreSqlPrivateLinkResourceData(
                id,
                name,
                resourceType,
                systemData,
                groupId,
                requiredMembers?.ToList(),
                requiredZoneNames?.ToList(),
                serializedAdditionalRawData: null);
        }
    }
}
