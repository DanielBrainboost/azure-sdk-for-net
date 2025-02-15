// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class FailoverReplicationProtectedItemDetails : IUtf8JsonSerializable, IJsonModel<FailoverReplicationProtectedItemDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FailoverReplicationProtectedItemDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FailoverReplicationProtectedItemDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverReplicationProtectedItemDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverReplicationProtectedItemDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (TestVmName != null)
            {
                writer.WritePropertyName("testVmName"u8);
                writer.WriteStringValue(TestVmName);
            }
            if (TestVmFriendlyName != null)
            {
                writer.WritePropertyName("testVmFriendlyName"u8);
                writer.WriteStringValue(TestVmFriendlyName);
            }
            if (NetworkConnectionStatus != null)
            {
                writer.WritePropertyName("networkConnectionStatus"u8);
                writer.WriteStringValue(NetworkConnectionStatus);
            }
            if (NetworkFriendlyName != null)
            {
                writer.WritePropertyName("networkFriendlyName"u8);
                writer.WriteStringValue(NetworkFriendlyName);
            }
            if (Subnet != null)
            {
                writer.WritePropertyName("subnet"u8);
                writer.WriteStringValue(Subnet);
            }
            if (RecoveryPointId != null)
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (RecoveryPointOn.HasValue)
            {
                writer.WritePropertyName("recoveryPointTime"u8);
                writer.WriteStringValue(RecoveryPointOn.Value, "O");
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

        FailoverReplicationProtectedItemDetails IJsonModel<FailoverReplicationProtectedItemDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverReplicationProtectedItemDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FailoverReplicationProtectedItemDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFailoverReplicationProtectedItemDetails(document.RootElement, options);
        }

        internal static FailoverReplicationProtectedItemDetails DeserializeFailoverReplicationProtectedItemDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string friendlyName = default;
            string testVmName = default;
            string testVmFriendlyName = default;
            string networkConnectionStatus = default;
            string networkFriendlyName = default;
            string subnet = default;
            ResourceIdentifier recoveryPointId = default;
            DateTimeOffset? recoveryPointTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testVmName"u8))
                {
                    testVmName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("testVmFriendlyName"u8))
                {
                    testVmFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkConnectionStatus"u8))
                {
                    networkConnectionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFriendlyName"u8))
                {
                    networkFriendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnet"u8))
                {
                    subnet = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FailoverReplicationProtectedItemDetails(
                name,
                friendlyName,
                testVmName,
                testVmFriendlyName,
                networkConnectionStatus,
                networkFriendlyName,
                subnet,
                recoveryPointId,
                recoveryPointTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<FailoverReplicationProtectedItemDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverReplicationProtectedItemDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FailoverReplicationProtectedItemDetails)} does not support '{options.Format}' format.");
            }
        }

        FailoverReplicationProtectedItemDetails IPersistableModel<FailoverReplicationProtectedItemDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FailoverReplicationProtectedItemDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFailoverReplicationProtectedItemDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FailoverReplicationProtectedItemDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FailoverReplicationProtectedItemDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
