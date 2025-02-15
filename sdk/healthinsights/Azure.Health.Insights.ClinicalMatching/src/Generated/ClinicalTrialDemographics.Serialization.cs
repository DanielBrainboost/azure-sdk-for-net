// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class ClinicalTrialDemographics : IUtf8JsonSerializable, IJsonModel<ClinicalTrialDemographics>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClinicalTrialDemographics>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClinicalTrialDemographics>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDemographics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrialDemographics)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AcceptedSex.HasValue)
            {
                writer.WritePropertyName("acceptedSex"u8);
                writer.WriteStringValue(AcceptedSex.Value.ToString());
            }
            if (AcceptedAgeRange != null)
            {
                writer.WritePropertyName("acceptedAgeRange"u8);
                writer.WriteObjectValue(AcceptedAgeRange);
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

        ClinicalTrialDemographics IJsonModel<ClinicalTrialDemographics>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDemographics>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClinicalTrialDemographics)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClinicalTrialDemographics(document.RootElement, options);
        }

        internal static ClinicalTrialDemographics DeserializeClinicalTrialDemographics(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ClinicalTrialAcceptedSex? acceptedSex = default;
            AcceptedAgeRange acceptedAgeRange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acceptedSex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptedSex = new ClinicalTrialAcceptedSex(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("acceptedAgeRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    acceptedAgeRange = AcceptedAgeRange.DeserializeAcceptedAgeRange(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClinicalTrialDemographics(acceptedSex, acceptedAgeRange, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClinicalTrialDemographics>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDemographics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrialDemographics)} does not support '{options.Format}' format.");
            }
        }

        ClinicalTrialDemographics IPersistableModel<ClinicalTrialDemographics>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClinicalTrialDemographics>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClinicalTrialDemographics(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClinicalTrialDemographics)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClinicalTrialDemographics>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ClinicalTrialDemographics FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeClinicalTrialDemographics(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
