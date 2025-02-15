// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class IPPoolInfo : IUtf8JsonSerializable, IJsonModel<IPPoolInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IPPoolInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IPPoolInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPoolInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPPoolInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Used != null)
            {
                writer.WritePropertyName("used"u8);
                writer.WriteStringValue(Used);
            }
            if (options.Format != "W" && Available != null)
            {
                writer.WritePropertyName("available"u8);
                writer.WriteStringValue(Available);
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

        IPPoolInfo IJsonModel<IPPoolInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPoolInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IPPoolInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIPPoolInfo(document.RootElement, options);
        }

        internal static IPPoolInfo DeserializeIPPoolInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string used = default;
            string available = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("used"u8))
                {
                    used = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("available"u8))
                {
                    available = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IPPoolInfo(used, available, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IPPoolInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPoolInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IPPoolInfo)} does not support '{options.Format}' format.");
            }
        }

        IPPoolInfo IPersistableModel<IPPoolInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IPPoolInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIPPoolInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IPPoolInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IPPoolInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
