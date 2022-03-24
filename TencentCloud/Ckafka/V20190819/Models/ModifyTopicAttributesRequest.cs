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

    public class ModifyTopicAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Topic remarks string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`).
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// IP allowlist switch. 1: enabled, 0: disabled.
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public long? EnableWhiteList{ get; set; }

        /// <summary>
        /// Default value: 1.
        /// </summary>
        [JsonProperty("MinInsyncReplicas")]
        public long? MinInsyncReplicas{ get; set; }

        /// <summary>
        /// 0: false, 1: true. Default value: 0.
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// Message retention period in ms. The current minimum value is 60,000 ms.
        /// </summary>
        [JsonProperty("RetentionMs")]
        public long? RetentionMs{ get; set; }

        /// <summary>
        /// Segment rolling duration in ms. The current minimum value is 86,400,000 ms.
        /// </summary>
        [JsonProperty("SegmentMs")]
        public long? SegmentMs{ get; set; }

        /// <summary>
        /// Maximum topic message length in bytes. The maximum value is 8,388,608 bytes (i.e., 8 MB).
        /// </summary>
        [JsonProperty("MaxMessageBytes")]
        public long? MaxMessageBytes{ get; set; }

        /// <summary>
        /// Message deletion policy. Valid values: delete, compact
        /// </summary>
        [JsonProperty("CleanUpPolicy")]
        public string CleanUpPolicy{ get; set; }

        /// <summary>
        /// IP allowlist, which is required if the value of `enableWhileList` is 1.
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// Preset ACL rule. `1`: enable, `0`: disable. Default value: `0`.
        /// </summary>
        [JsonProperty("EnableAclRule")]
        public long? EnableAclRule{ get; set; }

        /// <summary>
        /// Name of the preset ACL rule.
        /// </summary>
        [JsonProperty("AclRuleName")]
        public string AclRuleName{ get; set; }

        /// <summary>
        /// Message retention file size in bytes, which is an optional parameter. Default value: -1. Currently, the min value that can be entered is 1,048,576 B.
        /// </summary>
        [JsonProperty("RetentionBytes")]
        public long? RetentionBytes{ get; set; }

        /// <summary>
        /// Tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Production throttling in MB/sec.
        /// </summary>
        [JsonProperty("QuotaProducerByteRate")]
        public long? QuotaProducerByteRate{ get; set; }

        /// <summary>
        /// Consumption throttling in MB/sec.
        /// </summary>
        [JsonProperty("QuotaConsumerByteRate")]
        public long? QuotaConsumerByteRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamSimple(map, prefix + "MinInsyncReplicas", this.MinInsyncReplicas);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "RetentionMs", this.RetentionMs);
            this.SetParamSimple(map, prefix + "SegmentMs", this.SegmentMs);
            this.SetParamSimple(map, prefix + "MaxMessageBytes", this.MaxMessageBytes);
            this.SetParamSimple(map, prefix + "CleanUpPolicy", this.CleanUpPolicy);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "EnableAclRule", this.EnableAclRule);
            this.SetParamSimple(map, prefix + "AclRuleName", this.AclRuleName);
            this.SetParamSimple(map, prefix + "RetentionBytes", this.RetentionBytes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "QuotaProducerByteRate", this.QuotaProducerByteRate);
            this.SetParamSimple(map, prefix + "QuotaConsumerByteRate", this.QuotaConsumerByteRate);
        }
    }
}

