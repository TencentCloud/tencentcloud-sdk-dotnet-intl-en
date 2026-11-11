/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Plan : AbstractModel
    {
        
        /// <summary>
        /// <p>Plan type. Valid values:</p><li>plan-trial: Trial Edition plan;</li><li>plan-personal: Personal Edition plan;</li><li>plan-basic: Basic Edition plan;</li><li>plan-standard: Standard Edition plan;</li><li>plan-enterprise-v2: Enterprise Edition plan;</li><li>plan-enterprise-model-a: Enterprise Edition Model A plan;</li><li>plan-enterprise: Legacy Enterprise Edition plan;</li><li>plan-makers-pro: Makers Pro Edition plan;</li><li>plan-makers-business: Makers Business Edition plan;</li><p>Valid values:</p><ul><li>plan-trial: Trial Edition plan</li><li>plan-personal: Personal Edition plan</li><li>plan-basic: Basic Edition plan</li><li>plan-standard: Standard Edition plan</li><li>plan-enterprise-v2: Enterprise Edition plan</li><li>plan-enterprise-model-a: Enterprise Edition Model A plan</li><li>plan-enterprise: Legacy Enterprise Edition plan</li><li>plan-makers-pro: Makers Pro Edition plan</li><li>plan-makers-business: Makers Business Edition plan</li></ul>
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// <p>Plan ID, in the format of edgeone-2y041pblwaxe.</p>
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// <p>Service region. Valid values:</p><li>mainland: Chinese mainland;</li><li>overseas: Global (excluding the Chinese mainland);</li><li>global: Global (including the Chinese mainland).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>Auto-renewal switch. Valid values:</p><li>true: Auto-renewal enabled;</li><li>false: Auto-renewal disabled.</li>
        /// </summary>
        [JsonProperty("AutoRenewal")]
        public bool? AutoRenewal{ get; set; }

        /// <summary>
        /// <p>Plan status. Valid values:</p><li>normal: Normal;</li><li>expiring-soon: Expiring soon;</li><li>expired: Expired;</li><li>isolated: Isolated;</li><li>overdue-isolated: Isolated due to overdue payment.</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Billing type. Valid values:</p><li>0: Postpaid;</li><li>1: Prepaid.</li>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>Information of the sites bound to the plan, including site id, site name, and site status.</p>
        /// </summary>
        [JsonProperty("ZonesInfo")]
        public ZoneInfo[] ZonesInfo{ get; set; }

        /// <summary>
        /// <p>Quota of smart acceleration requests in the plan, in the unit of requests.</p>
        /// </summary>
        [JsonProperty("SmartRequestCapacity")]
        public long? SmartRequestCapacity{ get; set; }

        /// <summary>
        /// <p>VAU quota in the plan, in the unit of VAUs.</p>
        /// </summary>
        [JsonProperty("VAUCapacity")]
        public long? VAUCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of content acceleration traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("AccTrafficCapacity")]
        public long? AccTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of client authentication traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("ClientAuthTrafficCapacity")]
        public long? ClientAuthTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of smart acceleration traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("SmartTrafficCapacity")]
        public long? SmartTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of DDoS protection traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("DDoSTrafficCapacity")]
        public long? DDoSTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of security traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("SecTrafficCapacity")]
        public long? SecTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of security requests in the plan, in the unit of requests.</p>
        /// </summary>
        [JsonProperty("SecRequestCapacity")]
        public long? SecRequestCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of L4 acceleration traffic in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("L4TrafficCapacity")]
        public long? L4TrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Quota of network optimization traffic for the Chinese mainland in the plan, in the unit of bytes.</p>
        /// </summary>
        [JsonProperty("CrossMLCTrafficCapacity")]
        public long? CrossMLCTrafficCapacity{ get; set; }

        /// <summary>
        /// <p>Whether the plan allows binding new sites. Valid values:</p><li>true: Allows binding new sites;</li><li>false: Does not allow binding new sites.</li>
        /// </summary>
        [JsonProperty("Bindable")]
        public string Bindable{ get; set; }

        /// <summary>
        /// <p>Time when the plan takes effect.</p>
        /// </summary>
        [JsonProperty("EnabledTime")]
        public string EnabledTime{ get; set; }

        /// <summary>
        /// <p>Expiration time of the plan.</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// <p>Features supported by the plan. Valid values: <li>ContentAcceleration: content acceleration;</li><li>SmartAcceleration: smart acceleration;</li><li>L4: L4 acceleration;</li><li>Waf: advanced Web protection;</li><li>QUIC: QUIC;</li><li>CrossMLC: network optimization for the Chinese mainland;</li><li>ProcessMedia: media processing;</li><li>L4DDoS: L4 DDoS protection.</li>Only one of the following L7DDoS specifications can appear: <li>L7DDoS.CM30G: L7 DDoS protection - 30 Gbps guaranteed bandwidth in the Chinese mainland;</li><li>L7DDoS.CM60G: L7 DDoS protection - 60 Gbps guaranteed bandwidth in the Chinese mainland;</li><li>L7DDoS.CM100G: L7 DDoS protection - 100 Gbps guaranteed bandwidth in the Chinese mainland;</li><li>L7DDoS.Anycast300G: L7 DDoS protection - 300 Gbps Anycast guaranteed bandwidth outside the Chinese mainland;</li><li>L7DDoS.AnycastUnlimited: L7 DDoS protection - unlimited Anycast full protection outside the Chinese mainland;</li><li>L7DDoS.CM30G_Anycast300G: L7 DDoS protection - 30 Gbps guaranteed bandwidth in the Chinese mainland and 300 Gbps Anycast guaranteed bandwidth outside the Chinese mainland;</li><li>L7DDoS.CM60G_Anycast300G: L7 DDoS protection - 60 Gbps guaranteed bandwidth in the Chinese mainland and 300 Gbps Anycast guaranteed bandwidth outside the Chinese mainland;</li><li>L7DDoS.CM100G_Anycast300G: L7 DDoS protection - 100 Gbps guaranteed bandwidth in the Chinese mainland and 300 Gbps Anycast guaranteed bandwidth outside the Chinese mainland;</li><li>L7DDoS.CM30G_AnycastUnlimited: L7 DDoS protection - 30 Gbps guaranteed bandwidth in the Chinese mainland and unlimited Anycast full protection outside the Chinese mainland;</li><li>L7DDoS.CM60G_AnycastUnlimited: L7 DDoS protection - 60 Gbps guaranteed bandwidth in the Chinese mainland and unlimited Anycast full protection outside the Chinese mainland;</li><li>L7DDoS.CM100G_AnycastUnlimited: L7 DDoS protection - 100 Gbps guaranteed bandwidth in the Chinese mainland and unlimited Anycast full protection outside the Chinese mainland.</li></p>
        /// </summary>
        [JsonProperty("Features")]
        public string[] Features{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "AutoRenewal", this.AutoRenewal);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamArrayObj(map, prefix + "ZonesInfo.", this.ZonesInfo);
            this.SetParamSimple(map, prefix + "SmartRequestCapacity", this.SmartRequestCapacity);
            this.SetParamSimple(map, prefix + "VAUCapacity", this.VAUCapacity);
            this.SetParamSimple(map, prefix + "AccTrafficCapacity", this.AccTrafficCapacity);
            this.SetParamSimple(map, prefix + "ClientAuthTrafficCapacity", this.ClientAuthTrafficCapacity);
            this.SetParamSimple(map, prefix + "SmartTrafficCapacity", this.SmartTrafficCapacity);
            this.SetParamSimple(map, prefix + "DDoSTrafficCapacity", this.DDoSTrafficCapacity);
            this.SetParamSimple(map, prefix + "SecTrafficCapacity", this.SecTrafficCapacity);
            this.SetParamSimple(map, prefix + "SecRequestCapacity", this.SecRequestCapacity);
            this.SetParamSimple(map, prefix + "L4TrafficCapacity", this.L4TrafficCapacity);
            this.SetParamSimple(map, prefix + "CrossMLCTrafficCapacity", this.CrossMLCTrafficCapacity);
            this.SetParamSimple(map, prefix + "Bindable", this.Bindable);
            this.SetParamSimple(map, prefix + "EnabledTime", this.EnabledTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamArraySimple(map, prefix + "Features.", this.Features);
        }
    }
}

