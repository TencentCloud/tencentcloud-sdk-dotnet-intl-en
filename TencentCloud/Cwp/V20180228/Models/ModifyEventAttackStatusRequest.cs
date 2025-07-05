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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEventAttackStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// An array of event IDs that need to be modified, and batch operation is supported.
        /// </summary>
        [JsonProperty("Ids")]
        public ulong?[] Ids{ get; set; }

        /// <summary>
        /// Whether to update all, i.e. whether to operate on all events; this parameter is invalid when IDs are not left blank.
        /// </summary>
        [JsonProperty("All")]
        public bool? All{ get; set; }

        /// <summary>
        /// 0: Pending 1: Processed 2: Allowlisted 3: Ignored 4: Deleted 
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Filter criteria
        /// <li>Type: String attack status: 0: attempted attack; 1: attack succeeded: required: no</li>
        /// <li>Status: String event processing status: 0: pending 1: processed; 2: allowlisted; 3: ignored; 4: deleted: required: no</li>
        /// <li>SrcIP - String source IP - required: no</li>
        /// <li>DstPort - String attack target port - required: no</li>
        /// <li>MachineName - String host name - required: no</li>
        /// <li>InstanceID - String host instance ID - required: no</li>
        /// <li>Quuids - String host CVM UUID - required: no</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Excluded IDs
        /// </summary>
        [JsonProperty("ExcludeId")]
        public ulong?[] ExcludeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Ids.", this.Ids);
            this.SetParamSimple(map, prefix + "All", this.All);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "ExcludeId.", this.ExcludeId);
        }
    }
}

