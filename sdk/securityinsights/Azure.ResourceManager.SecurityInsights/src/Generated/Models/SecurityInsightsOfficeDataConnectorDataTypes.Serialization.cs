// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsOfficeDataConnectorDataTypes : IUtf8JsonSerializable, IJsonModel<SecurityInsightsOfficeDataConnectorDataTypes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsOfficeDataConnectorDataTypes>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsOfficeDataConnectorDataTypes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsOfficeDataConnectorDataTypes)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Exchange != null)
            {
                writer.WritePropertyName("exchange"u8);
                writer.WriteObjectValue(Exchange);
            }
            if (SharePoint != null)
            {
                writer.WritePropertyName("sharePoint"u8);
                writer.WriteObjectValue(SharePoint);
            }
            if (Teams != null)
            {
                writer.WritePropertyName("teams"u8);
                writer.WriteObjectValue(Teams);
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

        SecurityInsightsOfficeDataConnectorDataTypes IJsonModel<SecurityInsightsOfficeDataConnectorDataTypes>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsOfficeDataConnectorDataTypes)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsOfficeDataConnectorDataTypes(document.RootElement, options);
        }

        internal static SecurityInsightsOfficeDataConnectorDataTypes DeserializeSecurityInsightsOfficeDataConnectorDataTypes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OfficeDataConnectorDataTypesExchange exchange = default;
            OfficeDataConnectorDataTypesSharePoint sharePoint = default;
            OfficeDataConnectorDataTypesTeams teams = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("exchange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exchange = OfficeDataConnectorDataTypesExchange.DeserializeOfficeDataConnectorDataTypesExchange(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sharePoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharePoint = OfficeDataConnectorDataTypesSharePoint.DeserializeOfficeDataConnectorDataTypesSharePoint(property.Value, options);
                    continue;
                }
                if (property.NameEquals("teams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    teams = OfficeDataConnectorDataTypesTeams.DeserializeOfficeDataConnectorDataTypesTeams(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsOfficeDataConnectorDataTypes(exchange, sharePoint, teams, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsOfficeDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsOfficeDataConnectorDataTypes IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsOfficeDataConnectorDataTypes(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsOfficeDataConnectorDataTypes)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsOfficeDataConnectorDataTypes>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
