// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridPartnerContent : IUtf8JsonSerializable, IJsonModel<EventGridPartnerContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridPartnerContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventGridPartnerContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridPartnerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridPartnerContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PartnerRegistrationImmutableId.HasValue)
            {
                writer.WritePropertyName("partnerRegistrationImmutableId"u8);
                writer.WriteStringValue(PartnerRegistrationImmutableId.Value);
            }
            if (PartnerName != null)
            {
                writer.WritePropertyName("partnerName"u8);
                writer.WriteStringValue(PartnerName);
            }
            if (AuthorizationExpireOn.HasValue)
            {
                writer.WritePropertyName("authorizationExpirationTimeInUtc"u8);
                writer.WriteStringValue(AuthorizationExpireOn.Value, "O");
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

        EventGridPartnerContent IJsonModel<EventGridPartnerContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridPartnerContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridPartnerContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridPartnerContent(document.RootElement, options);
        }

        internal static EventGridPartnerContent DeserializeEventGridPartnerContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? partnerRegistrationImmutableId = default;
            string partnerName = default;
            DateTimeOffset? authorizationExpirationTimeInUtc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partnerRegistrationImmutableId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partnerRegistrationImmutableId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("partnerName"u8))
                {
                    partnerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationExpirationTimeInUtc"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authorizationExpirationTimeInUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventGridPartnerContent(partnerRegistrationImmutableId, partnerName, authorizationExpirationTimeInUtc, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridPartnerContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridPartnerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridPartnerContent)} does not support '{options.Format}' format.");
            }
        }

        EventGridPartnerContent IPersistableModel<EventGridPartnerContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridPartnerContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridPartnerContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridPartnerContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridPartnerContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
