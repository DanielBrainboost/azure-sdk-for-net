// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class MongoDBCursorMethodsProperties : IUtf8JsonSerializable, IJsonModel<MongoDBCursorMethodsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBCursorMethodsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBCursorMethodsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCursorMethodsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCursorMethodsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Project != null)
            {
                writer.WritePropertyName("project"u8);
                JsonSerializer.Serialize(writer, Project);
            }
            if (Sort != null)
            {
                writer.WritePropertyName("sort"u8);
                JsonSerializer.Serialize(writer, Sort);
            }
            if (Skip != null)
            {
                writer.WritePropertyName("skip"u8);
                JsonSerializer.Serialize(writer, Skip);
            }
            if (Limit != null)
            {
                writer.WritePropertyName("limit"u8);
                JsonSerializer.Serialize(writer, Limit);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        MongoDBCursorMethodsProperties IJsonModel<MongoDBCursorMethodsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCursorMethodsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCursorMethodsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCursorMethodsProperties(document.RootElement, options);
        }

        internal static MongoDBCursorMethodsProperties DeserializeMongoDBCursorMethodsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> project = default;
            DataFactoryElement<string> sort = default;
            DataFactoryElement<int> skip = default;
            DataFactoryElement<int> limit = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("project"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    project = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sort = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("skip"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skip = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("limit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limit = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new MongoDBCursorMethodsProperties(project, sort, skip, limit, additionalProperties);
        }

        BinaryData IPersistableModel<MongoDBCursorMethodsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCursorMethodsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBCursorMethodsProperties)} does not support '{options.Format}' format.");
            }
        }

        MongoDBCursorMethodsProperties IPersistableModel<MongoDBCursorMethodsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCursorMethodsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBCursorMethodsProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBCursorMethodsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBCursorMethodsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
