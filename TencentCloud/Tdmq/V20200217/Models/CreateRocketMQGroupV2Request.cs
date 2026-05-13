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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRocketMQGroupV2Request : AbstractModel
    {
        
        /// <summary>
        /// consumer group name
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Namespace of the consumption group. The 4.x common Cluster Namespace is fixed as: tdmq_default
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Enable consumption
        /// </summary>
        [JsonProperty("ReadEnable")]
        public bool? ReadEnable{ get; set; }

        /// <summary>
        /// Enable broadcast consumption
        /// </summary>
        [JsonProperty("BroadcastEnable")]
        public bool? BroadcastEnable{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Group Type (TCP/HTTP)
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// Group Max Retry Count
        /// </summary>
        [JsonProperty("RetryMaxTimes")]
        public ulong? RetryMaxTimes{ get; set; }

        /// <summary>
        /// Tag list
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ReadEnable", this.ReadEnable);
            this.SetParamSimple(map, prefix + "BroadcastEnable", this.BroadcastEnable);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "RetryMaxTimes", this.RetryMaxTimes);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
        }
    }
}

