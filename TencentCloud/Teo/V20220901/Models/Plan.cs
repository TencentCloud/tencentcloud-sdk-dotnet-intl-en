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
        /// Package type. valid values:.
        /// <Li>`Plan-Trial`: trial plan</li>.
        /// <Li>`Plan-Personal`: personal plan</li>.
        /// <Li>`Plan-Basic`: basic plan</li>.
        /// <Li>`Plan-Standard`: standard edition plan</li>.
        /// <li>plan-enterprise-v2: enterprise plan;</li>.
        /// <li>plan-enterprise-model-a: enterprise edition model a package.</li>.
        /// <Li>Plan-Enterprise: legacy enterprise plan.</li>.
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Package ID. such as edgeone-2y041pblwaxe.
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Service area. valid values:.
        /// <Li>`Mainland`: chinese mainland</li>.
        /// <li>`overseas`: global (chinese mainland not included)</li>.
        /// <Li>`Global`: global (chinese mainland included)</li>.
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Auto-Renew switch. valid values:.
        /// <li>true: automatic renewal is enabled.</li>.
        /// <li>false: automatic renewal is not enabled.</li>.
        /// </summary>
        [JsonProperty("AutoRenewal")]
        public bool? AutoRenewal{ get; set; }

        /// <summary>
        /// Package status. valid values:.
        /// <Li>Normal: indicates the normal status.</li>.
        /// <li>`expiring-soon`: will expire soon;</li>.
        /// <li>`expired`: expiration status;</li>.
        /// <Li>`Isolated`: isolated state</li>.
        /// <li>`overdue-isolated`: arrears isolated state.</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Payment type. valid values:.
        /// <Li>0: postpaid;</li>.
        /// <Li>1: prepaid.</li>.
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// Describes the site information bound to the package, including the site id, site name, and site status.
        /// </summary>
        [JsonProperty("ZonesInfo")]
        public ZoneInfo[] ZonesInfo{ get; set; }

        /// <summary>
        /// Smart acceleration request quantity in the package, unit: times.
        /// </summary>
        [JsonProperty("SmartRequestCapacity")]
        public long? SmartRequestCapacity{ get; set; }

        /// <summary>
        /// Specifies the VAU specification in the package. measurement unit: unit.
        /// </summary>
        [JsonProperty("VAUCapacity")]
        public long? VAUCapacity{ get; set; }

        /// <summary>
        /// Specifies the content acceleration traffic specification in the package, measurement unit: byte.
        /// </summary>
        [JsonProperty("AccTrafficCapacity")]
        public long? AccTrafficCapacity{ get; set; }

        /// <summary>
        /// Specifies the smart acceleration traffic specification in the package. measurement unit: byte.
        /// </summary>
        [JsonProperty("SmartTrafficCapacity")]
        public long? SmartTrafficCapacity{ get; set; }

        /// <summary>
        /// Specifies the DDoS protection traffic specification in the package, measurement unit: byte.
        /// </summary>
        [JsonProperty("DDoSTrafficCapacity")]
        public long? DDoSTrafficCapacity{ get; set; }

        /// <summary>
        /// Security traffic specification in the package. measurement unit: byte.
        /// </summary>
        [JsonProperty("SecTrafficCapacity")]
        public long? SecTrafficCapacity{ get; set; }

        /// <summary>
        /// Security requests in the package, unit: times.
        /// </summary>
        [JsonProperty("SecRequestCapacity")]
        public long? SecRequestCapacity{ get; set; }

        /// <summary>
        /// Specifies the layer 4 acceleration traffic specification in the package, measurement unit: byte.
        /// </summary>
        [JsonProperty("L4TrafficCapacity")]
        public long? L4TrafficCapacity{ get; set; }

        /// <summary>
        /// Specifies the network optimization traffic specification in the package for the chinese mainland, measurement unit: byte.
        /// </summary>
        [JsonProperty("CrossMLCTrafficCapacity")]
        public long? CrossMLCTrafficCapacity{ get; set; }

        /// <summary>
        /// Specifies whether the package allows binding to new sites. valid values:.
        /// <li>true: allows binding a new site.</li>.
        /// <li>`false`: cannot bind new sites.</li>.
        /// </summary>
        [JsonProperty("Bindable")]
        public string Bindable{ get; set; }

        /// <summary>
        /// Package activation time.
        /// </summary>
        [JsonProperty("EnabledTime")]
        public string EnabledTime{ get; set; }

        /// <summary>
        /// Plan expiration time.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Supported features of the package include: <li>ContentAcceleration: content acceleration feature;</li> <li>SmartAcceleration: intelligent acceleration feature;</li> <li>L4: L4 acceleration feature;</li> <li>Waf: advanced Web protection;</li> <li>QUIC: QUIC feature;</li> <li>CrossMLC: network optimization in the chinese mainland;</li> <li>ProcessMedia: media processing feature;</li> <li>L4DDoS: L4 DDoS protection feature;</li> L7DDoS feature will only appear in one of the following specifications: <li>L7DDoS.CM30G; layer-7 DDoS protection feature - 30G guaranteed minimum bandwidth specification in the chinese mainland;</li> <li>L7DDoS.CM60G; layer-7 DDoS protection feature - 60G guaranteed minimum bandwidth specification in the chinese mainland;</li> <li>L7DDoS.CM100G; layer-7 DDoS protection feature - 100G guaranteed minimum bandwidth specification in the chinese mainland;</li> <li>L7DDoS.Anycast300G; layer-7 DDoS protection feature - 300G guaranteed minimum bandwidth specification outside the chinese mainland with Anycast;</li> <li>L7DDoS.AnycastUnlimited; layer-7 DDoS protection feature - unlimited Anycast full protection outside the chinese mainland;</li> <li>L7DDoS.CM30G_Anycast300G; layer-7 DDoS protection feature - 30G guaranteed minimum bandwidth specification in the chinese mainland and 300G guaranteed minimum bandwidth specification outside the chinese mainland with Anycast;</li> <li>L7DDoS.CM60G_Anycast300G; layer-7 DDoS protection feature - 60G guaranteed minimum bandwidth specification in the chinese mainland and 300G guaranteed minimum bandwidth specification outside the chinese mainland with Anycast;</li> <li>L7DDoS.CM100G_Anycast300G; layer-7 DDoS protection feature - 100G guaranteed minimum bandwidth specification in the chinese mainland and 300G guaranteed minimum bandwidth specification outside the chinese mainland with Anycast;</li> <li>L7DDoS.CM30G_AnycastUnlimited; layer-7 DDoS protection feature - 30G guaranteed minimum bandwidth specification in the chinese mainland and unlimited Anycast full protection outside the chinese mainland;</li> <li>L7DDoS.CM60G_AnycastUnlimited; layer-7 DDoS protection feature - 60G guaranteed minimum bandwidth specification in the chinese mainland and unlimited Anycast full protection outside the chinese mainland;</li> <li>L7DDoS.CM100G_AnycastUnlimited; layer-7 DDoS protection feature - 100G guaranteed minimum bandwidth specification in the chinese mainland and unlimited Anycast full protection outside the chinese mainland;</li>.
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

