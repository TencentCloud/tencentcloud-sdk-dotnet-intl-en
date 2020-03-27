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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of eligible consumer groups
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Topic list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicList")]
        public ConsumerGroupTopic[] TopicList{ get; set; }

        /// <summary>
        /// Consumer group list
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupList")]
        public ConsumerGroup[] GroupList{ get; set; }

        /// <summary>
        /// Total number of partitions
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalPartition")]
        public long? TotalPartition{ get; set; }

        /// <summary>
        /// List of monitored partitions
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionListForMonitor")]
        public Partition[] PartitionListForMonitor{ get; set; }

        /// <summary>
        /// Total number of topics
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalTopic")]
        public long? TotalTopic{ get; set; }

        /// <summary>
        /// List of monitored topics
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicListForMonitor")]
        public ConsumerGroupTopic[] TopicListForMonitor{ get; set; }

        /// <summary>
        /// List of monitored groups
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GroupListForMonitor")]
        public Group[] GroupListForMonitor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "TopicList.", this.TopicList);
            this.SetParamArrayObj(map, prefix + "GroupList.", this.GroupList);
            this.SetParamSimple(map, prefix + "TotalPartition", this.TotalPartition);
            this.SetParamArrayObj(map, prefix + "PartitionListForMonitor.", this.PartitionListForMonitor);
            this.SetParamSimple(map, prefix + "TotalTopic", this.TotalTopic);
            this.SetParamArrayObj(map, prefix + "TopicListForMonitor.", this.TopicListForMonitor);
            this.SetParamArrayObj(map, prefix + "GroupListForMonitor.", this.GroupListForMonitor);
        }
    }
}

