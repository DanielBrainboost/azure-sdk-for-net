// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmAutoBackupSettings : IUtf8JsonSerializable, IJsonModel<SqlVmAutoBackupSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlVmAutoBackupSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlVmAutoBackupSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoBackupSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmAutoBackupSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (IsEncryptionEnabled.HasValue)
            {
                writer.WritePropertyName("enableEncryption"u8);
                writer.WriteBooleanValue(IsEncryptionEnabled.Value);
            }
            if (RetentionPeriodInDays.HasValue)
            {
                writer.WritePropertyName("retentionPeriod"u8);
                writer.WriteNumberValue(RetentionPeriodInDays.Value);
            }
            if (StorageAccountUri != null)
            {
                writer.WritePropertyName("storageAccountUrl"u8);
                writer.WriteStringValue(StorageAccountUri.AbsoluteUri);
            }
            if (StorageContainerName != null)
            {
                writer.WritePropertyName("storageContainerName"u8);
                writer.WriteStringValue(StorageContainerName);
            }
            if (StorageAccessKey != null)
            {
                writer.WritePropertyName("storageAccessKey"u8);
                writer.WriteStringValue(StorageAccessKey);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (AreSystemDbsIncludedInBackup.HasValue)
            {
                writer.WritePropertyName("backupSystemDbs"u8);
                writer.WriteBooleanValue(AreSystemDbsIncludedInBackup.Value);
            }
            if (BackupScheduleType.HasValue)
            {
                writer.WritePropertyName("backupScheduleType"u8);
                writer.WriteStringValue(BackupScheduleType.Value.ToString());
            }
            if (FullBackupFrequency.HasValue)
            {
                writer.WritePropertyName("fullBackupFrequency"u8);
                writer.WriteStringValue(FullBackupFrequency.Value.ToString());
            }
            if (!(DaysOfWeek is ChangeTrackingList<SqlVmAutoBackupDayOfWeek> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("daysOfWeek"u8);
                writer.WriteStartArray();
                foreach (var item in DaysOfWeek)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (FullBackupStartHour.HasValue)
            {
                writer.WritePropertyName("fullBackupStartTime"u8);
                writer.WriteNumberValue(FullBackupStartHour.Value);
            }
            if (FullBackupWindowHours.HasValue)
            {
                writer.WritePropertyName("fullBackupWindowHours"u8);
                writer.WriteNumberValue(FullBackupWindowHours.Value);
            }
            if (LogBackupFrequency.HasValue)
            {
                writer.WritePropertyName("logBackupFrequency"u8);
                writer.WriteNumberValue(LogBackupFrequency.Value);
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

        SqlVmAutoBackupSettings IJsonModel<SqlVmAutoBackupSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoBackupSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlVmAutoBackupSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlVmAutoBackupSettings(document.RootElement, options);
        }

        internal static SqlVmAutoBackupSettings DeserializeSqlVmAutoBackupSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enable = default;
            bool? enableEncryption = default;
            int? retentionPeriod = default;
            Uri storageAccountUrl = default;
            string storageContainerName = default;
            string storageAccessKey = default;
            string password = default;
            bool? backupSystemDbs = default;
            SqVmBackupScheduleType? backupScheduleType = default;
            SqlVmFullBackupFrequency? fullBackupFrequency = default;
            IList<SqlVmAutoBackupDayOfWeek> daysOfWeek = default;
            int? fullBackupStartTime = default;
            int? fullBackupWindowHours = default;
            int? logBackupFrequency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableEncryption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("retentionPeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionPeriod = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("storageAccountUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageContainerName"u8))
                {
                    storageContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageAccessKey"u8))
                {
                    storageAccessKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupSystemDbs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupSystemDbs = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("backupScheduleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupScheduleType = new SqVmBackupScheduleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fullBackupFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupFrequency = new SqlVmFullBackupFrequency(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("daysOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlVmAutoBackupDayOfWeek> array = new List<SqlVmAutoBackupDayOfWeek>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SqlVmAutoBackupDayOfWeek(item.GetString()));
                    }
                    daysOfWeek = array;
                    continue;
                }
                if (property.NameEquals("fullBackupStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupStartTime = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("fullBackupWindowHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupWindowHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logBackupFrequency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logBackupFrequency = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlVmAutoBackupSettings(
                enable,
                enableEncryption,
                retentionPeriod,
                storageAccountUrl,
                storageContainerName,
                storageAccessKey,
                password,
                backupSystemDbs,
                backupScheduleType,
                fullBackupFrequency,
                daysOfWeek ?? new ChangeTrackingList<SqlVmAutoBackupDayOfWeek>(),
                fullBackupStartTime,
                fullBackupWindowHours,
                logBackupFrequency,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlVmAutoBackupSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoBackupSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlVmAutoBackupSettings)} does not support '{options.Format}' format.");
            }
        }

        SqlVmAutoBackupSettings IPersistableModel<SqlVmAutoBackupSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlVmAutoBackupSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlVmAutoBackupSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlVmAutoBackupSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlVmAutoBackupSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
