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
    public partial class ConnectToSourceSqlServerTaskOutputLoginLevel : IUtf8JsonSerializable, IJsonModel<ConnectToSourceSqlServerTaskOutputLoginLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceSqlServerTaskOutputLoginLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToSourceSqlServerTaskOutputLoginLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputLoginLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && LoginType.HasValue)
            {
                writer.WritePropertyName("loginType"u8);
                writer.WriteStringValue(LoginType.Value.ToString());
            }
            if (options.Format != "W" && DefaultDatabase != null)
            {
                writer.WritePropertyName("defaultDatabase"u8);
                writer.WriteStringValue(DefaultDatabase);
            }
            if (options.Format != "W" && IsEnabled.HasValue)
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && MigrationEligibility != null)
            {
                writer.WritePropertyName("migrationEligibility"u8);
                writer.WriteObjectValue(MigrationEligibility);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        ConnectToSourceSqlServerTaskOutputLoginLevel IJsonModel<ConnectToSourceSqlServerTaskOutputLoginLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputLoginLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskOutputLoginLevel(document.RootElement, options);
        }

        internal static ConnectToSourceSqlServerTaskOutputLoginLevel DeserializeConnectToSourceSqlServerTaskOutputLoginLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            LoginType? loginType = default;
            string defaultDatabase = default;
            bool? isEnabled = default;
            MigrationEligibilityInfo migrationEligibility = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loginType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loginType = new LoginType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultDatabase"u8))
                {
                    defaultDatabase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("migrationEligibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationEligibility = MigrationEligibilityInfo.DeserializeMigrationEligibilityInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectToSourceSqlServerTaskOutputLoginLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                name,
                loginType,
                defaultDatabase,
                isEnabled,
                migrationEligibility);
        }

        BinaryData IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputLoginLevel)} does not support '{options.Format}' format.");
            }
        }

        ConnectToSourceSqlServerTaskOutputLoginLevel IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToSourceSqlServerTaskOutputLoginLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutputLoginLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceSqlServerTaskOutputLoginLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
