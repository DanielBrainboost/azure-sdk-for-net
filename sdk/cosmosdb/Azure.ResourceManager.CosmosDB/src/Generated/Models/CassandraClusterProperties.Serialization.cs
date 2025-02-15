// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraClusterProperties : IUtf8JsonSerializable, IJsonModel<CassandraClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CassandraClusterProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CassandraClusterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (RestoreFromBackupId != null)
            {
                writer.WritePropertyName("restoreFromBackupId"u8);
                writer.WriteStringValue(RestoreFromBackupId);
            }
            if (DelegatedManagementSubnetId != null)
            {
                writer.WritePropertyName("delegatedManagementSubnetId"u8);
                writer.WriteStringValue(DelegatedManagementSubnetId);
            }
            if (CassandraVersion != null)
            {
                writer.WritePropertyName("cassandraVersion"u8);
                writer.WriteStringValue(CassandraVersion);
            }
            if (ClusterNameOverride != null)
            {
                writer.WritePropertyName("clusterNameOverride"u8);
                writer.WriteStringValue(ClusterNameOverride);
            }
            if (AuthenticationMethod.HasValue)
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (InitialCassandraAdminPassword != null)
            {
                writer.WritePropertyName("initialCassandraAdminPassword"u8);
                writer.WriteStringValue(InitialCassandraAdminPassword);
            }
            if (PrometheusEndpoint != null)
            {
                writer.WritePropertyName("prometheusEndpoint"u8);
                writer.WriteObjectValue(PrometheusEndpoint);
            }
            if (IsRepairEnabled.HasValue)
            {
                writer.WritePropertyName("repairEnabled"u8);
                writer.WriteBooleanValue(IsRepairEnabled.Value);
            }
            if (!(ClientCertificates is ChangeTrackingList<CassandraCertificate> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("clientCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ClientCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExternalGossipCertificates is ChangeTrackingList<CassandraCertificate> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("externalGossipCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalGossipCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(GossipCertificates is ChangeTrackingList<CassandraCertificate> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("gossipCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in GossipCertificates)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ExternalSeedNodes is ChangeTrackingList<CassandraDataCenterSeedNode> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("externalSeedNodes"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalSeedNodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SeedNodes is ChangeTrackingList<CassandraDataCenterSeedNode> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("seedNodes"u8);
                writer.WriteStartArray();
                foreach (var item in SeedNodes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (HoursBetweenBackups.HasValue)
            {
                writer.WritePropertyName("hoursBetweenBackups"u8);
                writer.WriteNumberValue(HoursBetweenBackups.Value);
            }
            if (IsDeallocated.HasValue)
            {
                writer.WritePropertyName("deallocated"u8);
                writer.WriteBooleanValue(IsDeallocated.Value);
            }
            if (IsCassandraAuditLoggingEnabled.HasValue)
            {
                writer.WritePropertyName("cassandraAuditLoggingEnabled"u8);
                writer.WriteBooleanValue(IsCassandraAuditLoggingEnabled.Value);
            }
            if (ClusterType.HasValue)
            {
                writer.WritePropertyName("clusterType"u8);
                writer.WriteStringValue(ClusterType.Value.ToString());
            }
            if (ProvisionError != null)
            {
                writer.WritePropertyName("provisionError"u8);
                writer.WriteObjectValue(ProvisionError);
            }
            if (!(Extensions is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartArray();
                foreach (var item in Extensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(BackupSchedules is ChangeTrackingList<CassandraClusterBackupSchedule> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("backupSchedules"u8);
                writer.WriteStartArray();
                foreach (var item in BackupSchedules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        CassandraClusterProperties IJsonModel<CassandraClusterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CassandraClusterProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraClusterProperties(document.RootElement, options);
        }

        internal static CassandraClusterProperties DeserializeCassandraClusterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CassandraProvisioningState? provisioningState = default;
            string restoreFromBackupId = default;
            ResourceIdentifier delegatedManagementSubnetId = default;
            string cassandraVersion = default;
            string clusterNameOverride = default;
            CassandraAuthenticationMethod? authenticationMethod = default;
            string initialCassandraAdminPassword = default;
            CassandraDataCenterSeedNode prometheusEndpoint = default;
            bool? repairEnabled = default;
            IList<CassandraCertificate> clientCertificates = default;
            IList<CassandraCertificate> externalGossipCertificates = default;
            IReadOnlyList<CassandraCertificate> gossipCertificates = default;
            IList<CassandraDataCenterSeedNode> externalSeedNodes = default;
            IReadOnlyList<CassandraDataCenterSeedNode> seedNodes = default;
            int? hoursBetweenBackups = default;
            bool? deallocated = default;
            bool? cassandraAuditLoggingEnabled = default;
            CassandraClusterType? clusterType = default;
            CassandraError provisionError = default;
            IList<string> extensions = default;
            IList<CassandraClusterBackupSchedule> backupSchedules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new CassandraProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreFromBackupId"u8))
                {
                    restoreFromBackupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("delegatedManagementSubnetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delegatedManagementSubnetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cassandraVersion"u8))
                {
                    cassandraVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterNameOverride"u8))
                {
                    clusterNameOverride = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethod = new CassandraAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initialCassandraAdminPassword"u8))
                {
                    initialCassandraAdminPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("prometheusEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prometheusEndpoint = CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(property.Value, options);
                    continue;
                }
                if (property.NameEquals("repairEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    repairEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clientCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item, options));
                    }
                    clientCertificates = array;
                    continue;
                }
                if (property.NameEquals("externalGossipCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item, options));
                    }
                    externalGossipCertificates = array;
                    continue;
                }
                if (property.NameEquals("gossipCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraCertificate> array = new List<CassandraCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraCertificate.DeserializeCassandraCertificate(item, options));
                    }
                    gossipCertificates = array;
                    continue;
                }
                if (property.NameEquals("externalSeedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraDataCenterSeedNode> array = new List<CassandraDataCenterSeedNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(item, options));
                    }
                    externalSeedNodes = array;
                    continue;
                }
                if (property.NameEquals("seedNodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraDataCenterSeedNode> array = new List<CassandraDataCenterSeedNode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraDataCenterSeedNode.DeserializeCassandraDataCenterSeedNode(item, options));
                    }
                    seedNodes = array;
                    continue;
                }
                if (property.NameEquals("hoursBetweenBackups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hoursBetweenBackups = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deallocated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deallocated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cassandraAuditLoggingEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cassandraAuditLoggingEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("clusterType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterType = new CassandraClusterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisionError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisionError = CassandraError.DeserializeCassandraError(property.Value, options);
                    continue;
                }
                if (property.NameEquals("extensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    extensions = array;
                    continue;
                }
                if (property.NameEquals("backupSchedules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CassandraClusterBackupSchedule> array = new List<CassandraClusterBackupSchedule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraClusterBackupSchedule.DeserializeCassandraClusterBackupSchedule(item, options));
                    }
                    backupSchedules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CassandraClusterProperties(
                provisioningState,
                restoreFromBackupId,
                delegatedManagementSubnetId,
                cassandraVersion,
                clusterNameOverride,
                authenticationMethod,
                initialCassandraAdminPassword,
                prometheusEndpoint,
                repairEnabled,
                clientCertificates ?? new ChangeTrackingList<CassandraCertificate>(),
                externalGossipCertificates ?? new ChangeTrackingList<CassandraCertificate>(),
                gossipCertificates ?? new ChangeTrackingList<CassandraCertificate>(),
                externalSeedNodes ?? new ChangeTrackingList<CassandraDataCenterSeedNode>(),
                seedNodes ?? new ChangeTrackingList<CassandraDataCenterSeedNode>(),
                hoursBetweenBackups,
                deallocated,
                cassandraAuditLoggingEnabled,
                clusterType,
                provisionError,
                extensions ?? new ChangeTrackingList<string>(),
                backupSchedules ?? new ChangeTrackingList<CassandraClusterBackupSchedule>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CassandraClusterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterProperties)} does not support '{options.Format}' format.");
            }
        }

        CassandraClusterProperties IPersistableModel<CassandraClusterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CassandraClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCassandraClusterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CassandraClusterProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CassandraClusterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
