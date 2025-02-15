// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class GatewayKeysContract : IUtf8JsonSerializable, IJsonModel<GatewayKeysContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GatewayKeysContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GatewayKeysContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeysContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayKeysContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Primary != null)
            {
                writer.WritePropertyName("primary"u8);
                writer.WriteStringValue(Primary);
            }
            if (Secondary != null)
            {
                writer.WritePropertyName("secondary"u8);
                writer.WriteStringValue(Secondary);
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

        GatewayKeysContract IJsonModel<GatewayKeysContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeysContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GatewayKeysContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGatewayKeysContract(document.RootElement, options);
        }

        internal static GatewayKeysContract DeserializeGatewayKeysContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string primary = default;
            string secondary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primary"u8))
                {
                    primary = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondary"u8))
                {
                    secondary = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GatewayKeysContract(primary, secondary, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GatewayKeysContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeysContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GatewayKeysContract)} does not support '{options.Format}' format.");
            }
        }

        GatewayKeysContract IPersistableModel<GatewayKeysContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GatewayKeysContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGatewayKeysContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GatewayKeysContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GatewayKeysContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
