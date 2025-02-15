// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ManagedDiskPatch : IUtf8JsonSerializable, IJsonModel<ManagedDiskPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedDiskPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedDiskPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDiskPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDiskPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (OSType.HasValue)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (DiskSizeGB.HasValue)
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (EncryptionSettingsGroup != null)
            {
                writer.WritePropertyName("encryptionSettingsCollection"u8);
                writer.WriteObjectValue(EncryptionSettingsGroup);
            }
            if (DiskIopsReadWrite.HasValue)
            {
                writer.WritePropertyName("diskIOPSReadWrite"u8);
                writer.WriteNumberValue(DiskIopsReadWrite.Value);
            }
            if (DiskMBpsReadWrite.HasValue)
            {
                writer.WritePropertyName("diskMBpsReadWrite"u8);
                writer.WriteNumberValue(DiskMBpsReadWrite.Value);
            }
            if (DiskIopsReadOnly.HasValue)
            {
                writer.WritePropertyName("diskIOPSReadOnly"u8);
                writer.WriteNumberValue(DiskIopsReadOnly.Value);
            }
            if (DiskMBpsReadOnly.HasValue)
            {
                writer.WritePropertyName("diskMBpsReadOnly"u8);
                writer.WriteNumberValue(DiskMBpsReadOnly.Value);
            }
            if (MaxShares.HasValue)
            {
                writer.WritePropertyName("maxShares"u8);
                writer.WriteNumberValue(MaxShares.Value);
            }
            if (Encryption != null)
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (NetworkAccessPolicy.HasValue)
            {
                writer.WritePropertyName("networkAccessPolicy"u8);
                writer.WriteStringValue(NetworkAccessPolicy.Value.ToString());
            }
            if (DiskAccessId != null)
            {
                writer.WritePropertyName("diskAccessId"u8);
                writer.WriteStringValue(DiskAccessId);
            }
            if (Tier != null)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier);
            }
            if (BurstingEnabled.HasValue)
            {
                writer.WritePropertyName("burstingEnabled"u8);
                writer.WriteBooleanValue(BurstingEnabled.Value);
            }
            if (PurchasePlan != null)
            {
                writer.WritePropertyName("purchasePlan"u8);
                writer.WriteObjectValue(PurchasePlan);
            }
            if (SupportedCapabilities != null)
            {
                writer.WritePropertyName("supportedCapabilities"u8);
                writer.WriteObjectValue(SupportedCapabilities);
            }
            if (options.Format != "W" && PropertyUpdatesInProgress != null)
            {
                writer.WritePropertyName("propertyUpdatesInProgress"u8);
                writer.WriteObjectValue(PropertyUpdatesInProgress);
            }
            if (SupportsHibernation.HasValue)
            {
                writer.WritePropertyName("supportsHibernation"u8);
                writer.WriteBooleanValue(SupportsHibernation.Value);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (DataAccessAuthMode.HasValue)
            {
                writer.WritePropertyName("dataAccessAuthMode"u8);
                writer.WriteStringValue(DataAccessAuthMode.Value.ToString());
            }
            if (IsOptimizedForFrequentAttach.HasValue)
            {
                writer.WritePropertyName("optimizedForFrequentAttach"u8);
                writer.WriteBooleanValue(IsOptimizedForFrequentAttach.Value);
            }
            writer.WriteEndObject();
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

        ManagedDiskPatch IJsonModel<ManagedDiskPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDiskPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDiskPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDiskPatch(document.RootElement, options);
        }

        internal static ManagedDiskPatch DeserializeManagedDiskPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            DiskSku sku = default;
            SupportedOperatingSystemType? osType = default;
            int? diskSizeGB = default;
            EncryptionSettingsGroup encryptionSettingsGroup = default;
            long? diskIOPSReadWrite = default;
            long? diskMBpsReadWrite = default;
            long? diskIOPSReadOnly = default;
            long? diskMBpsReadOnly = default;
            int? maxShares = default;
            DiskEncryption encryption = default;
            NetworkAccessPolicy? networkAccessPolicy = default;
            ResourceIdentifier diskAccessId = default;
            string tier = default;
            bool? burstingEnabled = default;
            DiskPurchasePlan purchasePlan = default;
            SupportedCapabilities supportedCapabilities = default;
            PropertyUpdatesInProgress propertyUpdatesInProgress = default;
            bool? supportsHibernation = default;
            DiskPublicNetworkAccess? publicNetworkAccess = default;
            DataAccessAuthMode? dataAccessAuthMode = default;
            bool? optimizedForFrequentAttach = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DiskSku.DeserializeDiskSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("osType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            osType = property0.Value.GetString().ToSupportedOperatingSystemType();
                            continue;
                        }
                        if (property0.NameEquals("diskSizeGB"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskSizeGB = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("encryptionSettingsCollection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionSettingsGroup = EncryptionSettingsGroup.DeserializeEncryptionSettingsGroup(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadWrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskIOPSReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadWrite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskMBpsReadWrite = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskIOPSReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskIOPSReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("diskMBpsReadOnly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskMBpsReadOnly = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maxShares"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxShares = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = DiskEncryption.DeserializeDiskEncryption(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("networkAccessPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkAccessPolicy = new NetworkAccessPolicy(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("diskAccessId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diskAccessId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tier"u8))
                        {
                            tier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("burstingEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            burstingEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("purchasePlan"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            purchasePlan = DiskPurchasePlan.DeserializeDiskPurchasePlan(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("supportedCapabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportedCapabilities = SupportedCapabilities.DeserializeSupportedCapabilities(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("propertyUpdatesInProgress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            propertyUpdatesInProgress = PropertyUpdatesInProgress.DeserializePropertyUpdatesInProgress(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("supportsHibernation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportsHibernation = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new DiskPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dataAccessAuthMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataAccessAuthMode = new DataAccessAuthMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("optimizedForFrequentAttach"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            optimizedForFrequentAttach = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedDiskPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                sku,
                osType,
                diskSizeGB,
                encryptionSettingsGroup,
                diskIOPSReadWrite,
                diskMBpsReadWrite,
                diskIOPSReadOnly,
                diskMBpsReadOnly,
                maxShares,
                encryption,
                networkAccessPolicy,
                diskAccessId,
                tier,
                burstingEnabled,
                purchasePlan,
                supportedCapabilities,
                propertyUpdatesInProgress,
                supportsHibernation,
                publicNetworkAccess,
                dataAccessAuthMode,
                optimizedForFrequentAttach,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedDiskPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDiskPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedDiskPatch)} does not support '{options.Format}' format.");
            }
        }

        ManagedDiskPatch IPersistableModel<ManagedDiskPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDiskPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedDiskPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedDiskPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedDiskPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
