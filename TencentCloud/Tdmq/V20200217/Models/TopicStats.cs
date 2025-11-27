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

    public class TopicStats : AbstractModel
    {
        
        /// <summary>
        /// Broker node.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BrokerName")]
        public string BrokerName{ get; set; }

        /// <summary>
        /// Queue number.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QueueId")]
        public long? QueueId{ get; set; }

        /// <summary>
        /// Minimum offset.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinOffset")]
        public long? MinOffset{ get; set; }

        /// <summary>
        /// Specifies the maximum offset.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxOffset")]
        public long? MaxOffset{ get; set; }

        /// <summary>
        /// Message count.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MessageCount")]
        public long? MessageCount{ get; set; }

        /// <summary>
        /// Last message write time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastUpdateTimestamp")]
        public long? LastUpdateTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BrokerName", this.BrokerName);
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "MinOffset", this.MinOffset);
            this.SetParamSimple(map, prefix + "MaxOffset", this.MaxOffset);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "LastUpdateTimestamp", this.LastUpdateTimestamp);
        }
    }
}

