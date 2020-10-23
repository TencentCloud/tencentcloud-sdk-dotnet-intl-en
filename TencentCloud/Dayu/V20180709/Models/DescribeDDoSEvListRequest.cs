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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDoSEvListRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `bgp`: Anti-DDoS Pro (Single IP); `bgp-multip`: Anti-DDoS Pro (Multi-IP); `net`: Anti-DDoS Ultimate; `basic`: Anti-DDoS Basic
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Resource instance ID. If `Business` is `basic`, this field is not required (because Anti-DDoS Basic has no resource instance)
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Resource IP
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// Whether the elastic protection bandwidth is exceeded. Valid values: [yes, no]. If an empty string is entered, it means no filtering
        /// </summary>
        [JsonProperty("OverLoad")]
        public string OverLoad{ get; set; }

        /// <summary>
        /// Number of entries per page. A value of 0 means no pagination
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Page start offset, whose value is (page number - 1) * number of entries per page
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "OverLoad", this.OverLoad);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

