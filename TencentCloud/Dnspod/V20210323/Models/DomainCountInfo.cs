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

namespace TencentCloud.Dnspod.V20210323.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainCountInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of eligible domains
        /// </summary>
        [JsonProperty("DomainTotal")]
        public ulong? DomainTotal{ get; set; }

        /// <summary>
        /// Number of all domains that can be viewed by the user
        /// </summary>
        [JsonProperty("AllTotal")]
        public ulong? AllTotal{ get; set; }

        /// <summary>
        /// Number of domains added under the user account
        /// </summary>
        [JsonProperty("MineTotal")]
        public ulong? MineTotal{ get; set; }

        /// <summary>
        /// Number of domains shared with the user
        /// </summary>
        [JsonProperty("ShareTotal")]
        public ulong? ShareTotal{ get; set; }

        /// <summary>
        /// Number of paid domains
        /// </summary>
        [JsonProperty("VipTotal")]
        public ulong? VipTotal{ get; set; }

        /// <summary>
        /// Number of suspended domains
        /// </summary>
        [JsonProperty("PauseTotal")]
        public ulong? PauseTotal{ get; set; }

        /// <summary>
        /// Number of domains with a DNS configuration error
        /// </summary>
        [JsonProperty("ErrorTotal")]
        public ulong? ErrorTotal{ get; set; }

        /// <summary>
        /// Number of locked domains
        /// </summary>
        [JsonProperty("LockTotal")]
        public ulong? LockTotal{ get; set; }

        /// <summary>
        /// Number of blocked domains
        /// </summary>
        [JsonProperty("SpamTotal")]
        public ulong? SpamTotal{ get; set; }

        /// <summary>
        /// Number of domains that will expire within 30 days
        /// </summary>
        [JsonProperty("VipExpire")]
        public ulong? VipExpire{ get; set; }

        /// <summary>
        /// Number of domains shared with others
        /// </summary>
        [JsonProperty("ShareOutTotal")]
        public ulong? ShareOutTotal{ get; set; }

        /// <summary>
        /// Number of domains in the specified group
        /// </summary>
        [JsonProperty("GroupTotal")]
        public ulong? GroupTotal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainTotal", this.DomainTotal);
            this.SetParamSimple(map, prefix + "AllTotal", this.AllTotal);
            this.SetParamSimple(map, prefix + "MineTotal", this.MineTotal);
            this.SetParamSimple(map, prefix + "ShareTotal", this.ShareTotal);
            this.SetParamSimple(map, prefix + "VipTotal", this.VipTotal);
            this.SetParamSimple(map, prefix + "PauseTotal", this.PauseTotal);
            this.SetParamSimple(map, prefix + "ErrorTotal", this.ErrorTotal);
            this.SetParamSimple(map, prefix + "LockTotal", this.LockTotal);
            this.SetParamSimple(map, prefix + "SpamTotal", this.SpamTotal);
            this.SetParamSimple(map, prefix + "VipExpire", this.VipExpire);
            this.SetParamSimple(map, prefix + "ShareOutTotal", this.ShareOutTotal);
            this.SetParamSimple(map, prefix + "GroupTotal", this.GroupTotal);
        }
    }
}

