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
    public partial class InstancePoolFamilyCapability : IUtf8JsonSerializable, IJsonModel<InstancePoolFamilyCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstancePoolFamilyCapability>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstancePoolFamilyCapability>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolFamilyCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstancePoolFamilyCapability)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && !(SupportedLicenseTypes is ChangeTrackingList<LicenseTypeCapability> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedLicenseTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedLicenseTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(SupportedVcoresValues is ChangeTrackingList<InstancePoolVcoresCapability> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("supportedVcoresValues"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedVcoresValues)
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

        InstancePoolFamilyCapability IJsonModel<InstancePoolFamilyCapability>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolFamilyCapability>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstancePoolFamilyCapability)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancePoolFamilyCapability(document.RootElement, options);
        }

        internal static InstancePoolFamilyCapability DeserializeInstancePoolFamilyCapability(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IReadOnlyList<LicenseTypeCapability> supportedLicenseTypes = default;
            IReadOnlyList<InstancePoolVcoresCapability> supportedVcoresValues = default;
            SqlCapabilityStatus? status = default;
            string reason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                if (property.NameEquals("supportedVcoresValues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InstancePoolVcoresCapability> array = new List<InstancePoolVcoresCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InstancePoolVcoresCapability.DeserializeInstancePoolVcoresCapability(item, options));
                    }
                    supportedVcoresValues = array;
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
            return new InstancePoolFamilyCapability(
                name,
                supportedLicenseTypes ?? new ChangeTrackingList<LicenseTypeCapability>(),
                supportedVcoresValues ?? new ChangeTrackingList<InstancePoolVcoresCapability>(),
                status,
                reason,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstancePoolFamilyCapability>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolFamilyCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InstancePoolFamilyCapability)} does not support '{options.Format}' format.");
            }
        }

        InstancePoolFamilyCapability IPersistableModel<InstancePoolFamilyCapability>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolFamilyCapability>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstancePoolFamilyCapability(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InstancePoolFamilyCapability)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstancePoolFamilyCapability>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
