// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Communication;

namespace Azure.Communication.CallingServer
{
    internal partial class AcsCallParticipantInternal
    {
        internal static AcsCallParticipantInternal DeserializeAcsCallParticipantInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModel identifier = default;
            bool? isMuted = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("isMuted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isMuted = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AcsCallParticipantInternal(identifier, isMuted);
        }
    }
}
