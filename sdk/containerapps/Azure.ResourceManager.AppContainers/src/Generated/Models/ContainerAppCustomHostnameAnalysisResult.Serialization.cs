// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCustomHostnameAnalysisResult : IUtf8JsonSerializable, IJsonModel<ContainerAppCustomHostnameAnalysisResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCustomHostnameAnalysisResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppCustomHostnameAnalysisResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && HostName != null)
            {
                writer.WritePropertyName("hostName"u8);
                writer.WriteStringValue(HostName);
            }
            if (options.Format != "W" && IsHostnameAlreadyVerified.HasValue)
            {
                writer.WritePropertyName("isHostnameAlreadyVerified"u8);
                writer.WriteBooleanValue(IsHostnameAlreadyVerified.Value);
            }
            if (options.Format != "W" && CustomDomainVerificationTest.HasValue)
            {
                writer.WritePropertyName("customDomainVerificationTest"u8);
                writer.WriteStringValue(CustomDomainVerificationTest.Value.ToSerialString());
            }
            if (options.Format != "W" && CustomDomainVerificationFailureInfo != null)
            {
                writer.WritePropertyName("customDomainVerificationFailureInfo"u8);
                writer.WriteObjectValue(CustomDomainVerificationFailureInfo);
            }
            if (options.Format != "W" && HasConflictOnManagedEnvironment.HasValue)
            {
                writer.WritePropertyName("hasConflictOnManagedEnvironment"u8);
                writer.WriteBooleanValue(HasConflictOnManagedEnvironment.Value);
            }
            if (options.Format != "W" && ConflictWithEnvironmentCustomDomain.HasValue)
            {
                writer.WritePropertyName("conflictWithEnvironmentCustomDomain"u8);
                writer.WriteBooleanValue(ConflictWithEnvironmentCustomDomain.Value);
            }
            if (options.Format != "W" && ConflictingContainerAppResourceId != null)
            {
                writer.WritePropertyName("conflictingContainerAppResourceId"u8);
                writer.WriteStringValue(ConflictingContainerAppResourceId);
            }
            if (!(CNameRecords is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(TxtRecords is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ARecords is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AlternateCNameRecords is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AlternateTxtRecords is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ContainerAppCustomHostnameAnalysisResult IJsonModel<ContainerAppCustomHostnameAnalysisResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCustomHostnameAnalysisResult(document.RootElement, options);
        }

        internal static ContainerAppCustomHostnameAnalysisResult DeserializeContainerAppCustomHostnameAnalysisResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string hostName = default;
            bool? isHostnameAlreadyVerified = default;
            ContainerAppDnsVerificationTestResult? customDomainVerificationTest = default;
            ContainerAppCustomDomainVerificationFailureInfo customDomainVerificationFailureInfo = default;
            bool? hasConflictOnManagedEnvironment = default;
            bool? conflictWithEnvironmentCustomDomain = default;
            string conflictingContainerAppResourceId = default;
            IReadOnlyList<string> cNameRecords = default;
            IReadOnlyList<string> txtRecords = default;
            IReadOnlyList<string> aRecords = default;
            IReadOnlyList<string> alternateCNameRecords = default;
            IReadOnlyList<string> alternateTxtRecords = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostName"u8))
                {
                    hostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isHostnameAlreadyVerified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHostnameAlreadyVerified = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationTest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationTest = property.Value.GetString().ToContainerAppDnsVerificationTestResult();
                    continue;
                }
                if (property.NameEquals("customDomainVerificationFailureInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customDomainVerificationFailureInfo = ContainerAppCustomDomainVerificationFailureInfo.DeserializeContainerAppCustomDomainVerificationFailureInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("hasConflictOnManagedEnvironment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasConflictOnManagedEnvironment = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictWithEnvironmentCustomDomain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conflictWithEnvironmentCustomDomain = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("conflictingContainerAppResourceId"u8))
                {
                    conflictingContainerAppResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cNameRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    cNameRecords = array;
                    continue;
                }
                if (property.NameEquals("txtRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    txtRecords = array;
                    continue;
                }
                if (property.NameEquals("aRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    aRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateCNameRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    alternateCNameRecords = array;
                    continue;
                }
                if (property.NameEquals("alternateTxtRecords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    alternateTxtRecords = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppCustomHostnameAnalysisResult(
                hostName,
                isHostnameAlreadyVerified,
                customDomainVerificationTest,
                customDomainVerificationFailureInfo,
                hasConflictOnManagedEnvironment,
                conflictWithEnvironmentCustomDomain,
                conflictingContainerAppResourceId,
                cNameRecords ?? new ChangeTrackingList<string>(),
                txtRecords ?? new ChangeTrackingList<string>(),
                aRecords ?? new ChangeTrackingList<string>(),
                alternateCNameRecords ?? new ChangeTrackingList<string>(),
                alternateTxtRecords ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppCustomHostnameAnalysisResult IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCustomHostnameAnalysisResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppCustomHostnameAnalysisResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCustomHostnameAnalysisResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCustomHostnameAnalysisResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
