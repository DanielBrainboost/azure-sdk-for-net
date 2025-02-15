// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> The updatable properties of the FirewallResource. </summary>
    public partial class FirewallUpdateProperties
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

        /// <summary> Initializes a new instance of <see cref="FirewallUpdateProperties"/>. </summary>
        public FirewallUpdateProperties()
        {
            FrontEndSettings = new ChangeTrackingList<FirewallFrontendSetting>();
        }

        /// <summary> Initializes a new instance of <see cref="FirewallUpdateProperties"/>. </summary>
        /// <param name="panETag"> panEtag info. </param>
        /// <param name="networkProfile"> Network settings. </param>
        /// <param name="isPanoramaManaged"> Panorama Managed: Default is False. Default will be CloudSec managed. </param>
        /// <param name="panoramaConfig"> Panorama Configuration. </param>
        /// <param name="associatedRulestack"> Associated Rulestack. </param>
        /// <param name="dnsSettings"> DNS settings for Firewall. </param>
        /// <param name="frontEndSettings"> Frontend settings for Firewall. </param>
        /// <param name="planData"> Billing plan information. </param>
        /// <param name="marketplaceDetails"> Marketplace details. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallUpdateProperties(ETag? panETag, FirewallNetworkProfile networkProfile, FirewallBooleanType? isPanoramaManaged, FirewallPanoramaConfiguration panoramaConfig, RulestackDetails associatedRulestack, FirewallDnsSettings dnsSettings, IList<FirewallFrontendSetting> frontEndSettings, FirewallBillingPlanInfo planData, PanFirewallMarketplaceDetails marketplaceDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PanETag = panETag;
            NetworkProfile = networkProfile;
            IsPanoramaManaged = isPanoramaManaged;
            PanoramaConfig = panoramaConfig;
            AssociatedRulestack = associatedRulestack;
            DnsSettings = dnsSettings;
            FrontEndSettings = frontEndSettings;
            PlanData = planData;
            MarketplaceDetails = marketplaceDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> panEtag info. </summary>
        public ETag? PanETag { get; set; }
        /// <summary> Network settings. </summary>
        public FirewallNetworkProfile NetworkProfile { get; set; }
        /// <summary> Panorama Managed: Default is False. Default will be CloudSec managed. </summary>
        public FirewallBooleanType? IsPanoramaManaged { get; set; }
        /// <summary> Panorama Configuration. </summary>
        public FirewallPanoramaConfiguration PanoramaConfig { get; set; }
        /// <summary> Associated Rulestack. </summary>
        public RulestackDetails AssociatedRulestack { get; set; }
        /// <summary> DNS settings for Firewall. </summary>
        public FirewallDnsSettings DnsSettings { get; set; }
        /// <summary> Frontend settings for Firewall. </summary>
        public IList<FirewallFrontendSetting> FrontEndSettings { get; }
        /// <summary> Billing plan information. </summary>
        public FirewallBillingPlanInfo PlanData { get; set; }
        /// <summary> Marketplace details. </summary>
        public PanFirewallMarketplaceDetails MarketplaceDetails { get; set; }
    }
}
