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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LoadBalancing : AbstractModel
    {
        
        /// <summary>
        /// The load balancer ID.
        /// </summary>
        [JsonProperty("LoadBalancingId")]
        public string LoadBalancingId{ get; set; }

        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Subdomain name. You can use @ to represent the root domain.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// The proxy mode. Values:
        /// <li>`dns_only`: Only DNS</li>
        /// <li>`proxied`: Proxied</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The cache time of DNS records when `Type=dns_only`.
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// The load balancer status. Values:
        /// <li>`online`: Deployed</li>
        /// <li>`process`: Deployment in progress</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Schedules domain names.
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// The ID of the primary origin group.
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// The ID of the secondary origin group. If not specified, it indicates that secondary origins are not used.
        /// </summary>
        [JsonProperty("BackupOriginGroupId")]
        public string BackupOriginGroupId{ get; set; }

        /// <summary>
        /// The update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The origin-pull type. Values:
        /// <li>`normal`: Primary/Secondary origin-pull</li>
        /// <li>`advanced`: Advanced origin-pull</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// Advanced origin-pull configuration. This field is valid when `OriginType=advanced`.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AdvancedOriginGroups")]
        public AdvancedOriginGroup[] AdvancedOriginGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancingId", this.LoadBalancingId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamSimple(map, prefix + "BackupOriginGroupId", this.BackupOriginGroupId);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArrayObj(map, prefix + "AdvancedOriginGroups.", this.AdvancedOriginGroups);
        }
    }
}

