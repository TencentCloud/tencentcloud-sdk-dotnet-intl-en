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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBandwidthRangeResponse : AbstractModel
    {
        
        /// <summary>
        /// Standard bandwidth, which is the bandwidth allocated by the system to each node when an instance is purchased.
        /// </summary>
        [JsonProperty("BaseBandwidth")]
        public long? BaseBandwidth{ get; set; }

        /// <summary>
        /// The additional bandwidth of the instance. If the standard bandwidth does not meet your needs, you can increase the bandwidth on your own. <ul><li>If read-only replica is enabled, the total instance bandwidth = additional bandwidth * shard quantity + standard bandwidth * shard quantity * Max ([read-only replica quantity, 1]). The shard quantity in the standard architecture is 1. </li><li>If read-only replica is not enabled, the total instance bandwidth = additional bandwidth * shard quantity + standard bandwidth * shard quantity. The shard quantity in the standard architecture is 1.</li></ul>
        /// </summary>
        [JsonProperty("AddBandwidth")]
        public long? AddBandwidth{ get; set; }

        /// <summary>
        /// The lower limit for additional bandwidth
        /// </summary>
        [JsonProperty("MinAddBandwidth")]
        public long? MinAddBandwidth{ get; set; }

        /// <summary>
        /// The upper limit for additional bandwidth
        /// </summary>
        [JsonProperty("MaxAddBandwidth")]
        public long? MaxAddBandwidth{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BaseBandwidth", this.BaseBandwidth);
            this.SetParamSimple(map, prefix + "AddBandwidth", this.AddBandwidth);
            this.SetParamSimple(map, prefix + "MinAddBandwidth", this.MinAddBandwidth);
            this.SetParamSimple(map, prefix + "MaxAddBandwidth", this.MaxAddBandwidth);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

