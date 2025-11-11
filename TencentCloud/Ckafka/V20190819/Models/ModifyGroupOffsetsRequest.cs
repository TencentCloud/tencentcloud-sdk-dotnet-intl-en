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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGroupOffsetsRequest : AbstractModel
    {
        
        /// <summary>
        /// ckafka cluster instance Id. obtain through the API [DescribeInstances](https://www.tencentcloud.comom/document/product/597/40835?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Consumer group name. obtain through the API [DescribeConsumerGroup](https://www.tencentcloud.comom/document/product/597/40841?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Reset offset strategy. parameter meaning: 0. align with the shift-by parameter, move the offset forward or backward by shift entries. 1. alignment reference (by-duration, to-datetime, to-earliest, to-latest), move the offset to the specified timestamp position. 2. alignment reference (to-offset), move the offset to the specified offset position.
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// Specifies the topic name list that needs to reset.
        /// </summary>
        [JsonProperty("Topics")]
        public string[] Topics{ get; set; }

        /// <summary>
        /// When `strategy` is 0, this field is required. If it is above zero, the offset will be shifted backward by the value of the `shift`. If it is below zero, the offset will be shifted forward by the value of the `shift`. After a correct reset, the new offset should be (old_offset + shift). Note that if the new offset is smaller than the `earliest` parameter of the partition, it will be set to `earliest`, and if it is greater than the `latest` parameter of the partition, it will be set to `latest`
        /// </summary>
        [JsonProperty("Shift")]
        public long? Shift{ get; set; }

        /// <summary>
        /// In milliseconds. when strategy is 1, must include this field. among them, -2 means reset offset to the start position, -1 means reset to the latest position (equivalent to clearing), other values represent the specified time. obtain the offset at the specified time in the topic and reset. notably, if no message exists at the specified time, get the last offset.
        /// </summary>
        [JsonProperty("ShiftTimestamp")]
        public long? ShiftTimestamp{ get; set; }

        /// <summary>
        /// Position of the offset that needs to be reset. When `strategy` is 2, this field is required
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// List of partitions that need to be reset. If the topics parameter is not specified, reset partitions in the corresponding partition list of all topics. If the topics parameter is specified, reset partitions of the corresponding partition list of the specified topic list.
        /// </summary>
        [JsonProperty("Partitions")]
        public long?[] Partitions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamArraySimple(map, prefix + "Topics.", this.Topics);
            this.SetParamSimple(map, prefix + "Shift", this.Shift);
            this.SetParamSimple(map, prefix + "ShiftTimestamp", this.ShiftTimestamp);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "Partitions.", this.Partitions);
        }
    }
}

