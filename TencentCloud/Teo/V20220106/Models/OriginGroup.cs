/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginGroup : AbstractModel
    {
        
        /// <summary>
        /// Origin group ID
        /// </summary>
        [JsonProperty("OriginId")]
        public string OriginId{ get; set; }

        /// <summary>
        /// Origin group name
        /// </summary>
        [JsonProperty("OriginName")]
        public string OriginName{ get; set; }

        /// <summary>
        /// Origin-pull configuration type
        /// `area`: Origin-pull by the client IP’s region specified by `Area` in `OriginRecord`.
        /// `weight`: Origin-pull by the weight specified by `Weight` in `OriginRecord`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Record
        /// </summary>
        [JsonProperty("Record")]
        public OriginRecord[] Record{ get; set; }

        /// <summary>
        /// Update time
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Site ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Site name
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// Origin server type
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Whether the origin group uses layer-4 proxy.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApplicationProxyUsed")]
        public bool? ApplicationProxyUsed{ get; set; }

        /// <summary>
        /// Whether the origin group is used for load balancing.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LoadBalancingUsed")]
        public bool? LoadBalancingUsed{ get; set; }

        /// <summary>
        /// Origin status 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public OriginCheckOriginStatus Status{ get; set; }

        /// <summary>
        /// Proxy mode of the load balancing task associated with the origin group.
        /// `none`: This origin group is not used for load balancing.
        /// `dns_only`: Used for DNS-only load balancing 
        /// `proxied`: Used for proxied load balancing
        /// `both`: It’s used for both DNS-only and proxied load balancing.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LoadBalancingUsedType")]
        public string LoadBalancingUsedType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginId", this.OriginId);
            this.SetParamSimple(map, prefix + "OriginName", this.OriginName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Record.", this.Record);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "ApplicationProxyUsed", this.ApplicationProxyUsed);
            this.SetParamSimple(map, prefix + "LoadBalancingUsed", this.LoadBalancingUsed);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "LoadBalancingUsedType", this.LoadBalancingUsedType);
        }
    }
}

