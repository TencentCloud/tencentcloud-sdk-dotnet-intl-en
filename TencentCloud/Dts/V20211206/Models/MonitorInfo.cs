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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonitorInfo : AbstractModel
    {
        
        /// <summary>
        /// The number of the current partition, starting from 0.
        /// </summary>
        [JsonProperty("PartitionNo")]
        public long? PartitionNo{ get; set; }

        /// <summary>
        /// The offset of the current partition.
        /// </summary>
        [JsonProperty("ConsumerGroupOffset")]
        public long? ConsumerGroupOffset{ get; set; }

        /// <summary>
        /// The amount of unconsumed data in the current partition.
        /// </summary>
        [JsonProperty("ConsumerGroupLag")]
        public long? ConsumerGroupLag{ get; set; }

        /// <summary>
        /// The consumption delay of the current partition (in seconds).
        /// </summary>
        [JsonProperty("Latency")]
        public long? Latency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionNo", this.PartitionNo);
            this.SetParamSimple(map, prefix + "ConsumerGroupOffset", this.ConsumerGroupOffset);
            this.SetParamSimple(map, prefix + "ConsumerGroupLag", this.ConsumerGroupLag);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
        }
    }
}

