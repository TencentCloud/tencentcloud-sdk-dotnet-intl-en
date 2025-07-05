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

    public class TopicDetail : AbstractModel
    {
        
        /// <summary>
        /// Topic name
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Topic ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Number of partitions
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// Number of replicas
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// Whether to enable IP authentication allowlist. true: yes, false: no
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public bool? EnableWhiteList{ get; set; }

        /// <summary>
        /// Number of IPs in IP allowlist
        /// </summary>
        [JsonProperty("IpWhiteListCount")]
        public long? IpWhiteListCount{ get; set; }

        /// <summary>
        /// COS bucket for data backup: address of the destination COS bucket
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ForwardCosBucket")]
        public string ForwardCosBucket{ get; set; }

        /// <summary>
        /// Status of data backup to COS. 1: not enabled, 0: enabled
        /// </summary>
        [JsonProperty("ForwardStatus")]
        public long? ForwardStatus{ get; set; }

        /// <summary>
        /// Frequency of data backup to COS
        /// </summary>
        [JsonProperty("ForwardInterval")]
        public long? ForwardInterval{ get; set; }

        /// <summary>
        /// Advanced configuration
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Config")]
        public Config Config{ get; set; }

        /// <summary>
        /// Message retention time configuration (for recording the latest retention time)
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetentionTimeConfig")]
        public TopicRetentionTimeConfigRsp RetentionTimeConfig{ get; set; }

        /// <summary>
        /// `0`: normal, `1`: deleted, `2`: deleting
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Tag list
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamSimple(map, prefix + "IpWhiteListCount", this.IpWhiteListCount);
            this.SetParamSimple(map, prefix + "ForwardCosBucket", this.ForwardCosBucket);
            this.SetParamSimple(map, prefix + "ForwardStatus", this.ForwardStatus);
            this.SetParamSimple(map, prefix + "ForwardInterval", this.ForwardInterval);
            this.SetParamObj(map, prefix + "Config.", this.Config);
            this.SetParamObj(map, prefix + "RetentionTimeConfig.", this.RetentionTimeConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

