// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningJobLimits.
    /// Please note <see cref="MachineLearningJobLimits"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MachineLearningSweepJobLimits"/> and <see cref="MachineLearningCommandJobLimits"/>.
    /// </summary>
    public abstract partial class MachineLearningJobLimits
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobLimits"/>. </summary>
        protected MachineLearningJobLimits()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobLimits"/>. </summary>
        /// <param name="jobLimitsType"> [Required] JobLimit type. </param>
        /// <param name="timeout"> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningJobLimits(JobLimitsType jobLimitsType, TimeSpan? timeout, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            JobLimitsType = jobLimitsType;
            Timeout = timeout;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> [Required] JobLimit type. </summary>
        internal JobLimitsType JobLimitsType { get; set; }
        /// <summary> The max run duration in ISO 8601 format, after which the job will be cancelled. Only supports duration with precision as low as Seconds. </summary>
        public TimeSpan? Timeout { get; set; }
    }
}
