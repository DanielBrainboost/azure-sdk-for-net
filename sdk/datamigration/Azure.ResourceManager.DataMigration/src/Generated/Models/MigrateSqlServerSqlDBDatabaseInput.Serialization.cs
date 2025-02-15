// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlDBDatabaseInput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlDBDatabaseInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlDBDatabaseInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlDBDatabaseInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBDatabaseInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (TargetDatabaseName != null)
            {
                writer.WritePropertyName("targetDatabaseName"u8);
                writer.WriteStringValue(TargetDatabaseName);
            }
            if (MakeSourceDBReadOnly.HasValue)
            {
                writer.WritePropertyName("makeSourceDbReadOnly"u8);
                writer.WriteBooleanValue(MakeSourceDBReadOnly.Value);
            }
            if (!(TableMap is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tableMap"u8);
                writer.WriteStartObject();
                foreach (var item in TableMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (SchemaSetting != null)
            {
                writer.WritePropertyName("schemaSetting"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SchemaSetting);
#else
                using (JsonDocument document = JsonDocument.Parse(SchemaSetting))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
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

        MigrateSqlServerSqlDBDatabaseInput IJsonModel<MigrateSqlServerSqlDBDatabaseInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBDatabaseInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlDBDatabaseInput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlDBDatabaseInput DeserializeMigrateSqlServerSqlDBDatabaseInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string targetDatabaseName = default;
            bool? makeSourceDBReadOnly = default;
            IDictionary<string, string> tableMap = default;
            BinaryData schemaSetting = default;
            string id = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatabaseName"u8))
                {
                    targetDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("makeSourceDbReadOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    makeSourceDBReadOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tableMap"u8))
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
                    tableMap = dictionary;
                    continue;
                }
                if (property.NameEquals("schemaSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaSetting = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlDBDatabaseInput(
                name,
                targetDatabaseName,
                makeSourceDBReadOnly,
                tableMap ?? new ChangeTrackingDictionary<string, string>(),
                schemaSetting,
                id,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlDBDatabaseInput IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlDBDatabaseInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlDBDatabaseInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlDBDatabaseInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
