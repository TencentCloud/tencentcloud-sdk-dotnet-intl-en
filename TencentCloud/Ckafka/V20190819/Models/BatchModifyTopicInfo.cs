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

    public class BatchModifyTopicInfo : AbstractModel
    {
        
        /// <summary>
        /// Topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// The number of partitions.
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Number of replicas.
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }

        /// <summary>
        /// Message deletion policy. Valid values: `delete`, `compact`.
        /// </summary>
        [JsonProperty("CleanUpPolicy")]
        public string CleanUpPolicy{ get; set; }

        /// <summary>
        /// The minimum number of replicas specified by `min.insync.replicas` when the producer sets `request.required.acks` to `-1`.
        /// </summary>
        [JsonProperty("MinInsyncReplicas")]
        public long? MinInsyncReplicas{ get; set; }

        /// <summary>
        /// Whether to allow a non-ISR replica to be the leader.
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public bool? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// Message retention period in topic dimension in milliseconds. Value range: 1 minute to 90 days.
        /// </summary>
        [JsonProperty("RetentionMs")]
        public long? RetentionMs{ get; set; }

        /// <summary>
        /// Message retention size in topic dimension. Value range: 1 MB - 1024 GB.
        /// </summary>
        [JsonProperty("RetentionBytes")]
        public long? RetentionBytes{ get; set; }

        /// <summary>
        /// Segment rolling duration in milliseconds. Value range: 1-90 days.
        /// </summary>
        [JsonProperty("SegmentMs")]
        public long? SegmentMs{ get; set; }

        /// <summary>
        /// Message size per batch. Value range: 1 KB - 12 MB.
        /// </summary>
        [JsonProperty("MaxMessageBytes")]
        public long? MaxMessageBytes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "CleanUpPolicy", this.CleanUpPolicy);
            this.SetParamSimple(map, prefix + "MinInsyncReplicas", this.MinInsyncReplicas);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "RetentionMs", this.RetentionMs);
            this.SetParamSimple(map, prefix + "RetentionBytes", this.RetentionBytes);
            this.SetParamSimple(map, prefix + "SegmentMs", this.SegmentMs);
            this.SetParamSimple(map, prefix + "MaxMessageBytes", this.MaxMessageBytes);
        }
    }
}

