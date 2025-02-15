// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Rooms
{
    internal partial class UpdateRoomRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (ValidFrom.HasValue)
            {
                writer.WritePropertyName("validFrom"u8);
                writer.WriteStringValue(ValidFrom.Value, "O");
            }
            if (ValidUntil.HasValue)
            {
                writer.WritePropertyName("validUntil"u8);
                writer.WriteStringValue(ValidUntil.Value, "O");
            }
            if (PstnDialOutEnabled.HasValue)
            {
                writer.WritePropertyName("pstnDialOutEnabled"u8);
                writer.WriteBooleanValue(PstnDialOutEnabled.Value);
            }
            writer.WriteEndObject();
        }
    }
}
