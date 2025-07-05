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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDosAttackEventRequest : AbstractModel
    {
        
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
        /// Number of items
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// Set of DDoS policy group IDs
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// Site set
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// Protocol type. Valid values: {tcp,udp,all}
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// Whether to show details. Valid values: Y (yes), N (no).
        /// </summary>
        [JsonProperty("IsShowDetail")]
        public string IsShowDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "IsShowDetail", this.IsShowDetail);
        }
    }
}

