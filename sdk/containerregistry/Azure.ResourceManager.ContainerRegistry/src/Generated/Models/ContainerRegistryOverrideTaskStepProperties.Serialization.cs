// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryOverrideTaskStepProperties : IUtf8JsonSerializable, IJsonModel<ContainerRegistryOverrideTaskStepProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryOverrideTaskStepProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryOverrideTaskStepProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryOverrideTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ContextPath != null)
            {
                writer.WritePropertyName("contextPath"u8);
                writer.WriteStringValue(ContextPath);
            }
            if (File != null)
            {
                writer.WritePropertyName("file"u8);
                writer.WriteStringValue(File);
            }
            if (!(Arguments is ChangeTrackingList<ContainerRegistryRunArgument> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("arguments"u8);
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Target != null)
            {
                writer.WritePropertyName("target"u8);
                writer.WriteStringValue(Target);
            }
            if (!(Values is ChangeTrackingList<ContainerRegistryTaskOverridableValue> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("values"u8);
                writer.WriteStartArray();
                foreach (var item in Values)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (UpdateTriggerToken != null)
            {
                writer.WritePropertyName("updateTriggerToken"u8);
                writer.WriteStringValue(UpdateTriggerToken);
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

        ContainerRegistryOverrideTaskStepProperties IJsonModel<ContainerRegistryOverrideTaskStepProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryOverrideTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryOverrideTaskStepProperties(document.RootElement, options);
        }

        internal static ContainerRegistryOverrideTaskStepProperties DeserializeContainerRegistryOverrideTaskStepProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string contextPath = default;
            string file = default;
            IList<ContainerRegistryRunArgument> arguments = default;
            string target = default;
            IList<ContainerRegistryTaskOverridableValue> values = default;
            string updateTriggerToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("contextPath"u8))
                {
                    contextPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    file = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arguments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryRunArgument> array = new List<ContainerRegistryRunArgument>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryRunArgument.DeserializeContainerRegistryRunArgument(item, options));
                    }
                    arguments = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("values"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerRegistryTaskOverridableValue> array = new List<ContainerRegistryTaskOverridableValue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerRegistryTaskOverridableValue.DeserializeContainerRegistryTaskOverridableValue(item, options));
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("updateTriggerToken"u8))
                {
                    updateTriggerToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryOverrideTaskStepProperties(
                contextPath,
                file,
                arguments ?? new ChangeTrackingList<ContainerRegistryRunArgument>(),
                target,
                values ?? new ChangeTrackingList<ContainerRegistryTaskOverridableValue>(),
                updateTriggerToken,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryOverrideTaskStepProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryOverrideTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryOverrideTaskStepProperties IPersistableModel<ContainerRegistryOverrideTaskStepProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryOverrideTaskStepProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryOverrideTaskStepProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryOverrideTaskStepProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryOverrideTaskStepProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
