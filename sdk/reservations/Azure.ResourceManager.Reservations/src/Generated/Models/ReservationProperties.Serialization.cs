// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationProperties : IUtf8JsonSerializable, IJsonModel<ReservationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReservationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReservationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ReservedResourceType.HasValue)
            {
                writer.WritePropertyName("reservedResourceType"u8);
                writer.WriteStringValue(ReservedResourceType.Value.ToString());
            }
            if (InstanceFlexibility.HasValue)
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (!(AppliedScopes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("appliedScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (AppliedScopeType.HasValue)
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (IsArchived.HasValue)
            {
                writer.WritePropertyName("archived"u8);
                writer.WriteBooleanValue(IsArchived.Value);
            }
            if (Capabilities != null)
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStringValue(Capabilities);
            }
            if (Quantity.HasValue)
            {
                writer.WritePropertyName("quantity"u8);
                writer.WriteNumberValue(Quantity.Value);
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (EffectOn.HasValue)
            {
                writer.WritePropertyName("effectiveDateTime"u8);
                writer.WriteStringValue(EffectOn.Value, "O");
            }
            if (BenefitStartOn.HasValue)
            {
                writer.WritePropertyName("benefitStartTime"u8);
                writer.WriteStringValue(BenefitStartOn.Value, "O");
            }
            if (options.Format != "W" && LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedDateTime"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (ExpireOn.HasValue)
            {
                writer.WritePropertyName("expiryDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "D");
            }
            if (ReservationExpireOn.HasValue)
            {
                writer.WritePropertyName("expiryDateTime"u8);
                writer.WriteStringValue(ReservationExpireOn.Value, "O");
            }
            if (ReviewOn.HasValue)
            {
                writer.WritePropertyName("reviewDateTime"u8);
                writer.WriteStringValue(ReviewOn.Value, "O");
            }
            if (SkuDescription != null)
            {
                writer.WritePropertyName("skuDescription"u8);
                writer.WriteStringValue(SkuDescription);
            }
            if (ExtendedStatusInfo != null)
            {
                writer.WritePropertyName("extendedStatusInfo"u8);
                writer.WriteObjectValue(ExtendedStatusInfo);
            }
            if (BillingPlan.HasValue)
            {
                writer.WritePropertyName("billingPlan"u8);
                writer.WriteStringValue(BillingPlan.Value.ToString());
            }
            if (options.Format != "W" && DisplayProvisioningState != null)
            {
                writer.WritePropertyName("displayProvisioningState"u8);
                writer.WriteStringValue(DisplayProvisioningState);
            }
            if (options.Format != "W" && ProvisioningSubState != null)
            {
                writer.WritePropertyName("provisioningSubState"u8);
                writer.WriteStringValue(ProvisioningSubState);
            }
            if (PurchaseOn.HasValue)
            {
                writer.WritePropertyName("purchaseDate"u8);
                writer.WriteStringValue(PurchaseOn.Value, "D");
            }
            if (ReservationPurchaseOn.HasValue)
            {
                writer.WritePropertyName("purchaseDateTime"u8);
                writer.WriteStringValue(ReservationPurchaseOn.Value, "O");
            }
            if (SplitProperties != null)
            {
                writer.WritePropertyName("splitProperties"u8);
                writer.WriteObjectValue(SplitProperties);
            }
            if (MergeProperties != null)
            {
                writer.WritePropertyName("mergeProperties"u8);
                writer.WriteObjectValue(MergeProperties);
            }
            if (SwapProperties != null)
            {
                writer.WritePropertyName("swapProperties"u8);
                writer.WriteObjectValue(SwapProperties);
            }
            if (AppliedScopeProperties != null)
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                writer.WriteObjectValue(AppliedScopeProperties);
            }
            if (BillingScopeId != null)
            {
                writer.WritePropertyName("billingScopeId"u8);
                writer.WriteStringValue(BillingScopeId);
            }
            if (IsRenewEnabled.HasValue)
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewEnabled.Value);
            }
            if (RenewSource != null)
            {
                writer.WritePropertyName("renewSource"u8);
                writer.WriteStringValue(RenewSource);
            }
            if (RenewDestination != null)
            {
                writer.WritePropertyName("renewDestination"u8);
                writer.WriteStringValue(RenewDestination);
            }
            if (RenewProperties != null)
            {
                writer.WritePropertyName("renewProperties"u8);
                writer.WriteObjectValue(RenewProperties);
            }
            if (Term.HasValue)
            {
                writer.WritePropertyName("term"u8);
                writer.WriteStringValue(Term.Value.ToString());
            }
            if (options.Format != "W" && UserFriendlyAppliedScopeType != null)
            {
                writer.WritePropertyName("userFriendlyAppliedScopeType"u8);
                writer.WriteStringValue(UserFriendlyAppliedScopeType);
            }
            if (options.Format != "W" && UserFriendlyRenewState != null)
            {
                writer.WritePropertyName("userFriendlyRenewState"u8);
                writer.WriteStringValue(UserFriendlyRenewState);
            }
            if (options.Format != "W" && Utilization != null)
            {
                writer.WritePropertyName("utilization"u8);
                writer.WriteObjectValue(Utilization);
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

        ReservationProperties IJsonModel<ReservationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ReservationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationProperties(document.RootElement, options);
        }

        internal static ReservationProperties DeserializeReservationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReservedResourceType? reservedResourceType = default;
            InstanceFlexibility? instanceFlexibility = default;
            string displayName = default;
            IReadOnlyList<string> appliedScopes = default;
            AppliedScopeType? appliedScopeType = default;
            bool? archived = default;
            string capabilities = default;
            int? quantity = default;
            ReservationProvisioningState? provisioningState = default;
            DateTimeOffset? effectiveDateTime = default;
            DateTimeOffset? benefitStartTime = default;
            DateTimeOffset? lastUpdatedDateTime = default;
            DateTimeOffset? expiryDate = default;
            DateTimeOffset? expiryDateTime = default;
            DateTimeOffset? reviewDateTime = default;
            string skuDescription = default;
            ExtendedStatusInfo extendedStatusInfo = default;
            ReservationBillingPlan? billingPlan = default;
            string displayProvisioningState = default;
            string provisioningSubState = default;
            DateTimeOffset? purchaseDate = default;
            DateTimeOffset? purchaseDateTime = default;
            ReservationSplitProperties splitProperties = default;
            ReservationMergeProperties mergeProperties = default;
            ReservationSwapProperties swapProperties = default;
            AppliedScopeProperties appliedScopeProperties = default;
            ResourceIdentifier billingScopeId = default;
            bool? renew = default;
            string renewSource = default;
            string renewDestination = default;
            RenewProperties renewProperties = default;
            ReservationTerm? term = default;
            string userFriendlyAppliedScopeType = default;
            string userFriendlyRenewState = default;
            ReservationPropertiesUtilization utilization = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("reservedResourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservedResourceType = new ReservedResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceFlexibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceFlexibility = new InstanceFlexibility(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appliedScopes"u8))
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
                    appliedScopes = array;
                    continue;
                }
                if (property.NameEquals("appliedScopeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedScopeType = new AppliedScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("archived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    archived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quantity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quantity = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ReservationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("effectiveDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    effectiveDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("benefitStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    benefitStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("expiryDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("reviewDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reviewDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("skuDescription"u8))
                {
                    skuDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedStatusInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedStatusInfo = ExtendedStatusInfo.DeserializeExtendedStatusInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingPlan = new ReservationBillingPlan(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayProvisioningState"u8))
                {
                    displayProvisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningSubState"u8))
                {
                    provisioningSubState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("purchaseDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchaseDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("purchaseDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purchaseDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("splitProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    splitProperties = ReservationSplitProperties.DeserializeReservationSplitProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mergeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mergeProperties = ReservationMergeProperties.DeserializeReservationMergeProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("swapProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    swapProperties = ReservationSwapProperties.DeserializeReservationSwapProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("appliedScopeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedScopeProperties = AppliedScopeProperties.DeserializeAppliedScopeProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("billingScopeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    billingScopeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("renew"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renew = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("renewSource"u8))
                {
                    renewSource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewDestination"u8))
                {
                    renewDestination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewProperties = RenewProperties.DeserializeRenewProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("term"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    term = new ReservationTerm(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userFriendlyAppliedScopeType"u8))
                {
                    userFriendlyAppliedScopeType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userFriendlyRenewState"u8))
                {
                    userFriendlyRenewState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("utilization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    utilization = ReservationPropertiesUtilization.DeserializeReservationPropertiesUtilization(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ReservationProperties(
                reservedResourceType,
                instanceFlexibility,
                displayName,
                appliedScopes ?? new ChangeTrackingList<string>(),
                appliedScopeType,
                archived,
                capabilities,
                quantity,
                provisioningState,
                effectiveDateTime,
                benefitStartTime,
                lastUpdatedDateTime,
                expiryDate,
                expiryDateTime,
                reviewDateTime,
                skuDescription,
                extendedStatusInfo,
                billingPlan,
                displayProvisioningState,
                provisioningSubState,
                purchaseDate,
                purchaseDateTime,
                splitProperties,
                mergeProperties,
                swapProperties,
                appliedScopeProperties,
                billingScopeId,
                renew,
                renewSource,
                renewDestination,
                renewProperties,
                term,
                userFriendlyAppliedScopeType,
                userFriendlyRenewState,
                utilization,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ReservationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ReservationProperties)} does not support '{options.Format}' format.");
            }
        }

        ReservationProperties IPersistableModel<ReservationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ReservationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeReservationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ReservationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ReservationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
