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

    public class RocketMQClusterConfig : AbstractModel
    {
        
        /// <summary>
        /// Upper limit of TPS per single namespace.
        /// </summary>
        [JsonProperty("MaxTpsPerNamespace")]
        [System.Obsolete]
        public ulong? MaxTpsPerNamespace{ get; set; }

        /// <summary>
        /// Maximum number of namespaces
        /// </summary>
        [JsonProperty("MaxNamespaceNum")]
        public ulong? MaxNamespaceNum{ get; set; }

        /// <summary>
        /// Number of used namespaces
        /// </summary>
        [JsonProperty("UsedNamespaceNum")]
        public ulong? UsedNamespaceNum{ get; set; }

        /// <summary>
        /// Maximum number of topics
        /// </summary>
        [JsonProperty("MaxTopicNum")]
        public ulong? MaxTopicNum{ get; set; }

        /// <summary>
        /// Number of used topics
        /// </summary>
        [JsonProperty("UsedTopicNum")]
        public ulong? UsedTopicNum{ get; set; }

        /// <summary>
        /// Maximum number of groups
        /// </summary>
        [JsonProperty("MaxGroupNum")]
        public ulong? MaxGroupNum{ get; set; }

        /// <summary>
        /// Number of used groups
        /// </summary>
        [JsonProperty("UsedGroupNum")]
        public ulong? UsedGroupNum{ get; set; }

        /// <summary>
        /// Maximum message retention period in milliseconds
        /// </summary>
        [JsonProperty("MaxRetentionTime")]
        public ulong? MaxRetentionTime{ get; set; }

        /// <summary>
        /// Maximum message delay in milliseconds
        /// </summary>
        [JsonProperty("MaxLatencyTime")]
        public ulong? MaxLatencyTime{ get; set; }

        /// <summary>
        /// The maximum number of queues in a single topic
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxQueuesPerTopic")]
        public ulong? MaxQueuesPerTopic{ get; set; }

        /// <summary>
        /// Topic distribution.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicDistribution")]
        public RocketMQTopicDistribution[] TopicDistribution{ get; set; }

        /// <summary>
        /// Maximum number of roles.
        /// </summary>
        [JsonProperty("MaxRoleNum")]
        public long? MaxRoleNum{ get; set; }

        /// <summary>
        /// TPS quota.
        /// </summary>
        [JsonProperty("MaxTpsLimit")]
        public long? MaxTpsLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxTpsPerNamespace", this.MaxTpsPerNamespace);
            this.SetParamSimple(map, prefix + "MaxNamespaceNum", this.MaxNamespaceNum);
            this.SetParamSimple(map, prefix + "UsedNamespaceNum", this.UsedNamespaceNum);
            this.SetParamSimple(map, prefix + "MaxTopicNum", this.MaxTopicNum);
            this.SetParamSimple(map, prefix + "UsedTopicNum", this.UsedTopicNum);
            this.SetParamSimple(map, prefix + "MaxGroupNum", this.MaxGroupNum);
            this.SetParamSimple(map, prefix + "UsedGroupNum", this.UsedGroupNum);
            this.SetParamSimple(map, prefix + "MaxRetentionTime", this.MaxRetentionTime);
            this.SetParamSimple(map, prefix + "MaxLatencyTime", this.MaxLatencyTime);
            this.SetParamSimple(map, prefix + "MaxQueuesPerTopic", this.MaxQueuesPerTopic);
            this.SetParamArrayObj(map, prefix + "TopicDistribution.", this.TopicDistribution);
            this.SetParamSimple(map, prefix + "MaxRoleNum", this.MaxRoleNum);
            this.SetParamSimple(map, prefix + "MaxTpsLimit", this.MaxTpsLimit);
        }
    }
}

