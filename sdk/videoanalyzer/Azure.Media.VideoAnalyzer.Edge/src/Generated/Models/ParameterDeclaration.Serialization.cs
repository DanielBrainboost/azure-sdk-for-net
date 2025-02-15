// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class ParameterDeclaration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Default != null)
            {
                writer.WritePropertyName("default"u8);
                writer.WriteStringValue(Default);
            }
            writer.WriteEndObject();
        }

        internal static ParameterDeclaration DeserializeParameterDeclaration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ParameterType type = default;
            string description = default;
            string @default = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ParameterType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("default"u8))
                {
                    @default = property.Value.GetString();
                    continue;
                }
            }
            return new ParameterDeclaration(name, type, description, @default);
        }
    }
}
