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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttackSourceNode : AbstractModel
    {
        
        /// <summary>
        /// Event ID. If this parameter is left blank, no corresponding event exists.
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// BRUTEFORCE: password cracking; MALWARE: Trojan; BASH: high-risk command; RISK_DNS: malicious request; LOGIN: cross-region log-in; HOST: host node; TIME_ORDER: general node.
        /// </summary>
        [JsonProperty("EventType")]
        public string EventType{ get; set; }

        /// <summary>
        /// Node IP address. When the node is HOST, the value is the IP address of this node.
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Level. 0: prompt; 1: low-risk; 2: medium-risk; 3: high-risk; 4: critical.
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// Node ID
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

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
        /// General node description
        /// </summary>
        [JsonProperty("NodeDesc")]
        public string NodeDesc{ get; set; }

        /// <summary>
        /// Timeline number. Nodes with the same number belong to the same timeline.
        /// </summary>
        [JsonProperty("TimeLineNum")]
        public ulong? TimeLineNum{ get; set; }

        /// <summary>
        /// Node details
        /// </summary>
        [JsonProperty("NodeDetail")]
        public string NodeDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "NodeDesc", this.NodeDesc);
            this.SetParamSimple(map, prefix + "TimeLineNum", this.TimeLineNum);
            this.SetParamSimple(map, prefix + "NodeDetail", this.NodeDetail);
        }
    }
}

