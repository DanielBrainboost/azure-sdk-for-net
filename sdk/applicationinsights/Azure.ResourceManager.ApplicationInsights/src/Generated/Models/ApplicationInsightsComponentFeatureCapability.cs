// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component feature capability. </summary>
    public partial class ApplicationInsightsComponentFeatureCapability
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

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeatureCapability"/>. </summary>
        internal ApplicationInsightsComponentFeatureCapability()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationInsightsComponentFeatureCapability"/>. </summary>
        /// <param name="name"> The name of the capability. </param>
        /// <param name="description"> The description of the capability. </param>
        /// <param name="value"> The value of the capability. </param>
        /// <param name="unit"> The unit of the capability. </param>
        /// <param name="meterId"> The meter used for the capability. </param>
        /// <param name="meterRateFrequency"> The meter rate of the meter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationInsightsComponentFeatureCapability(string name, string description, string value, string unit, string meterId, string meterRateFrequency, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Description = description;
            Value = value;
            Unit = unit;
            MeterId = meterId;
            MeterRateFrequency = meterRateFrequency;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the capability. </summary>
        public string Name { get; }
        /// <summary> The description of the capability. </summary>
        public string Description { get; }
        /// <summary> The value of the capability. </summary>
        public string Value { get; }
        /// <summary> The unit of the capability. </summary>
        public string Unit { get; }
        /// <summary> The meter used for the capability. </summary>
        public string MeterId { get; }
        /// <summary> The meter rate of the meter. </summary>
        public string MeterRateFrequency { get; }
    }
}
