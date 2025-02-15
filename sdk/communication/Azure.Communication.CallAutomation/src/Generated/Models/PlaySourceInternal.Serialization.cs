// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class PlaySourceInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (PlaySourceCacheId != null)
            {
                writer.WritePropertyName("playSourceCacheId"u8);
                writer.WriteStringValue(PlaySourceCacheId);
            }
            if (File != null)
            {
                writer.WritePropertyName("file"u8);
                writer.WriteObjectValue(File);
            }
            if (Text != null)
            {
                writer.WritePropertyName("text"u8);
                writer.WriteObjectValue(Text);
            }
            if (Ssml != null)
            {
                writer.WritePropertyName("ssml"u8);
                writer.WriteObjectValue(Ssml);
            }
            writer.WriteEndObject();
        }
    }
}
