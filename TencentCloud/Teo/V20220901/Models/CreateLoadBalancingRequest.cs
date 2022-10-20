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

    public class CreateLoadBalancingRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The load balancing hostname.
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
        /// The ID of the primary origin group.
        /// </summary>
        [JsonProperty("OriginGroupId")]
        public string OriginGroupId{ get; set; }

        /// <summary>
        /// The ID of the secondary origin group (only available when `Type=proxied`). If not specified, it indicates that secondary origins are not used.
        /// </summary>
        [JsonProperty("BackupOriginGroupId")]
        public string BackupOriginGroupId{ get; set; }

        /// <summary>
        /// When `Type=dns_only`, it indicates the amount of time that DNS records remain in the cache of a DNS server.
        /// Value range: 60-86400 (in seconds). If it’s not specified, the default value 600 will be used.
        /// </summary>
        [JsonProperty("TTL")]
        public ulong? TTL{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AdvancedOriginGroups")]
        public AdvancedOriginGroup[] AdvancedOriginGroups{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "OriginGroupId", this.OriginGroupId);
            this.SetParamSimple(map, prefix + "BackupOriginGroupId", this.BackupOriginGroupId);
            this.SetParamSimple(map, prefix + "TTL", this.TTL);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArrayObj(map, prefix + "AdvancedOriginGroups.", this.AdvancedOriginGroups);
        }
    }
}

