// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class UniformInt64RangePartitionScheme : IUtf8JsonSerializable, IJsonModel<UniformInt64RangePartitionScheme>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UniformInt64RangePartitionScheme>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UniformInt64RangePartitionScheme>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UniformInt64RangePartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UniformInt64RangePartitionScheme)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("lowKey"u8);
            writer.WriteNumberValue(LowKey);
            writer.WritePropertyName("highKey"u8);
            writer.WriteNumberValue(HighKey);
            writer.WritePropertyName("partitionScheme"u8);
            writer.WriteStringValue(PartitionScheme.ToString());
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

        UniformInt64RangePartitionScheme IJsonModel<UniformInt64RangePartitionScheme>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UniformInt64RangePartitionScheme>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UniformInt64RangePartitionScheme)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUniformInt64RangePartitionScheme(document.RootElement, options);
        }

        internal static UniformInt64RangePartitionScheme DeserializeUniformInt64RangePartitionScheme(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            long lowKey = default;
            long highKey = default;
            PartitionScheme partitionScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lowKey"u8))
                {
                    lowKey = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("highKey"u8))
                {
                    highKey = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("partitionScheme"u8))
                {
                    partitionScheme = new PartitionScheme(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UniformInt64RangePartitionScheme(partitionScheme, serializedAdditionalRawData, count, lowKey, highKey);
        }

        BinaryData IPersistableModel<UniformInt64RangePartitionScheme>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UniformInt64RangePartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UniformInt64RangePartitionScheme)} does not support '{options.Format}' format.");
            }
        }

        UniformInt64RangePartitionScheme IPersistableModel<UniformInt64RangePartitionScheme>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UniformInt64RangePartitionScheme>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUniformInt64RangePartitionScheme(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UniformInt64RangePartitionScheme)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UniformInt64RangePartitionScheme>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
