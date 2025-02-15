// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    [PersistableModelProxy(typeof(UnknownOnYourDataAuthenticationOptions))]
    public partial class OnYourDataAuthenticationOptions : IUtf8JsonSerializable, IJsonModel<OnYourDataAuthenticationOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnYourDataAuthenticationOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnYourDataAuthenticationOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataAuthenticationOptions)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
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

        OnYourDataAuthenticationOptions IJsonModel<OnYourDataAuthenticationOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnYourDataAuthenticationOptions)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnYourDataAuthenticationOptions(document.RootElement, options);
        }

        internal static OnYourDataAuthenticationOptions DeserializeOnYourDataAuthenticationOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "APIKey": return OnYourDataApiKeyAuthenticationOptions.DeserializeOnYourDataApiKeyAuthenticationOptions(element, options);
                    case "ConnectionString": return OnYourDataConnectionStringAuthenticationOptions.DeserializeOnYourDataConnectionStringAuthenticationOptions(element, options);
                    case "KeyAndKeyId": return OnYourDataKeyAndKeyIdAuthenticationOptions.DeserializeOnYourDataKeyAndKeyIdAuthenticationOptions(element, options);
                    case "EncodedAPIKey": return OnYourDataEncodedApiKeyAuthenticationOptions.DeserializeOnYourDataEncodedApiKeyAuthenticationOptions(element, options);
                    case "AccessToken": return OnYourDataAccessTokenAuthenticationOptions.DeserializeOnYourDataAccessTokenAuthenticationOptions(element, options);
                    case "SystemAssignedManagedIdentity": return OnYourDataSystemAssignedManagedIdentityAuthenticationOptions.DeserializeOnYourDataSystemAssignedManagedIdentityAuthenticationOptions(element, options);
                    case "UserAssignedManagedIdentity": return OnYourDataUserAssignedManagedIdentityAuthenticationOptions.DeserializeOnYourDataUserAssignedManagedIdentityAuthenticationOptions(element, options);
                }
            }
            return UnknownOnYourDataAuthenticationOptions.DeserializeUnknownOnYourDataAuthenticationOptions(element, options);
        }

        BinaryData IPersistableModel<OnYourDataAuthenticationOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnYourDataAuthenticationOptions)} does not support '{options.Format}' format.");
            }
        }

        OnYourDataAuthenticationOptions IPersistableModel<OnYourDataAuthenticationOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnYourDataAuthenticationOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnYourDataAuthenticationOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnYourDataAuthenticationOptions)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnYourDataAuthenticationOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static OnYourDataAuthenticationOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeOnYourDataAuthenticationOptions(document.RootElement);
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
