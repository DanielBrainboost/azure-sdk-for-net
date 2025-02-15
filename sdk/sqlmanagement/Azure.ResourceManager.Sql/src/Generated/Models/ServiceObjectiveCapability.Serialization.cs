// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ServiceObjectiveCapability : IUtf8JsonSerializable, IJsonModel<ServiceObjectiveCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceObjectiveCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceObjectiveCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceObjectiveCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceObjectiveCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id.HasValue)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && !(SupportedMaxSizes is ChangeTrackingList<MaxSizeRangeCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedMaxSizes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaxSizes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && PerformanceLevel != null)
            {
                writer.WritePropertyName("performanceLevel"u8);
                writer.WriteObjectValue(PerformanceLevel);
            }
            if (options.Format != "W" && Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W" && !(SupportedLicenseTypes is ChangeTrackingList<LicenseTypeCapability> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedLicenseTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedLicenseTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && IncludedMaxSize != null)
            {
                writer.WritePropertyName("includedMaxSize"u8);
                writer.WriteObjectValue(IncludedMaxSize);
            }
            if (options.Format != "W" && IsZoneRedundant.HasValue)
            {
                writer.WritePropertyName("zoneRedundant"u8);
                writer.WriteBooleanValue(IsZoneRedundant.Value);
            }
            if (options.Format != "W" && SupportedAutoPauseDelay != null)
            {
                writer.WritePropertyName("supportedAutoPauseDelay"u8);
                writer.WriteObjectValue(SupportedAutoPauseDelay);
            }
            if (options.Format != "W" && !(SupportedMinCapacities is ChangeTrackingList<MinCapacityCapability> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("supportedMinCapacities"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMinCapacities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ComputeModel != null)
            {
                writer.WritePropertyName("computeModel"u8);
                writer.WriteStringValue(ComputeModel);
            }
            if (options.Format != "W" && !(SupportedMaintenanceConfigurations is ChangeTrackingList<MaintenanceConfigurationCapability> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("supportedMaintenanceConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedMaintenanceConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
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

        ServiceObjectiveCapability IJsonModel<ServiceObjectiveCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceObjectiveCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceObjectiveCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceObjectiveCapability(document.RootElement, options);
        }

        internal static ServiceObjectiveCapability DeserializeServiceObjectiveCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? id = default;
            string name = default;
            IReadOnlyList<MaxSizeRangeCapability> supportedMaxSizes = default;
            PerformanceLevelCapability performanceLevel = default;
            SqlSku sku = default;
            IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes = default;
            MaxSizeCapability includedMaxSize = default;
            bool? zoneRedundant = default;
            AutoPauseDelayTimeRange supportedAutoPauseDelay = default;
            IReadOnlyList<MinCapacityCapability> supportedMinCapacities = default;
            string computeModel = default;
            IReadOnlyList<MaintenanceConfigurationCapability> supportedMaintenanceConfigurations = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaxSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item, options));
                    }
                    supportedMaxSizes = array;
                    continue;
                }
                if (property.NameEquals("performanceLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performanceLevel = PerformanceLevelCapability.DeserializePerformanceLevelCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item, options));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value, options);
                    continue;
                }
                if (property.NameEquals("zoneRedundant"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundant = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedAutoPauseDelay"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedAutoPauseDelay = AutoPauseDelayTimeRange.DeserializeAutoPauseDelayTimeRange(property.Value, options);
                    continue;
                }
                if (property.NameEquals("supportedMinCapacities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MinCapacityCapability> array = new List<MinCapacityCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MinCapacityCapability.DeserializeMinCapacityCapability(item, options));
                    }
                    supportedMinCapacities = array;
                    continue;
                }
                if (property.NameEquals("computeModel"u8))
                {
                    computeModel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaintenanceConfigurationCapability> array = new List<MaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaintenanceConfigurationCapability.DeserializeMaintenanceConfigurationCapability(item, options));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceObjectiveCapability(
                id,
                name,
                supportedMaxSizes ?? new ChangeTrackingList<MaxSizeRangeCapability>(),
                performanceLevel,
                sku,
                supportedLicenseTypes ?? new ChangeTrackingList<LicenseTypeCapability>(),
                includedMaxSize,
                zoneRedundant,
                supportedAutoPauseDelay,
                supportedMinCapacities ?? new ChangeTrackingList<MinCapacityCapability>(),
                computeModel,
                supportedMaintenanceConfigurations ?? new ChangeTrackingList<MaintenanceConfigurationCapability>(),
                status,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceObjectiveCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceObjectiveCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceObjectiveCapability)} does not support '{options.Format}' format.");
            }
        }

        ServiceObjectiveCapability IPersistableModel<ServiceObjectiveCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceObjectiveCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceObjectiveCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceObjectiveCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceObjectiveCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
