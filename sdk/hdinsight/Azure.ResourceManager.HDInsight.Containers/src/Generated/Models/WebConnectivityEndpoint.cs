// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Web connectivity endpoint details. </summary>
    internal partial class WebConnectivityEndpoint
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WebConnectivityEndpoint"/>. </summary>
        /// <param name="fqdn"> Web connectivity endpoint. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fqdn"/> is null. </exception>
        internal WebConnectivityEndpoint(string fqdn)
        {
            if (fqdn == null)
            {
                throw new ArgumentNullException(nameof(fqdn));
            }

            Fqdn = fqdn;
        }

        /// <summary> Initializes a new instance of <see cref="WebConnectivityEndpoint"/>. </summary>
        /// <param name="fqdn"> Web connectivity endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WebConnectivityEndpoint(string fqdn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Fqdn = fqdn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="WebConnectivityEndpoint"/> for deserialization. </summary>
        internal WebConnectivityEndpoint()
        {
        }

        /// <summary> Web connectivity endpoint. </summary>
        public string Fqdn { get; }
    }
}
