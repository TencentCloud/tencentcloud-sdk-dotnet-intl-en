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

    public class CreateTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance Id</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/597/40835?from_cn_redirect=1">DescribeInstances</a></p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Can only contain letters, digits, underscore, "-", ".". </p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>Number of partitions, more than 0</p>
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// <p>Replica count cannot be over the number of brokers, with a maximum of 3</p>
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public long? ReplicaNum{ get; set; }

        /// <summary>
        /// <p>ip allowlist switch, 1: on; 0: off, default off</p>
        /// </summary>
        [JsonProperty("EnableWhiteList")]
        public long? EnableWhiteList{ get; set; }

        /// <summary>
        /// <p>Ip whitelist, Quota limit, essential when enableWhileList=1</p>
        /// </summary>
        [JsonProperty("IpWhiteList")]
        public string[] IpWhiteList{ get; set; }

        /// <summary>
        /// <p>Log cleanup policy. Log cleanup mode, defaults to "delete". "delete": logs are deleted by retention time. "compact": logs are compressed by key. "compact, delete": logs are compressed by key and deleted by retention time.</p>
        /// </summary>
        [JsonProperty("CleanUpPolicy")]
        public string CleanUpPolicy{ get; set; }

        /// <summary>
        /// <p>Topic remark</p><p>Input parameter limit: No more than 64 characters</p>
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// <p>Minimum sync replica count</p><p>Default value: 1</p><p>Minimum value: 1</p>
        /// </summary>
        [JsonProperty("MinInsyncReplicas")]
        public long? MinInsyncReplicas{ get; set; }

        /// <summary>
        /// <p>Whether to allow unsynchronized replicas to be elected as leader, 0: not allowed, 1: allowed, default not allowed</p>
        /// </summary>
        [JsonProperty("UncleanLeaderElectionEnable")]
        public long? UncleanLeaderElectionEnable{ get; set; }

        /// <summary>
        /// <p>Optional parameter, message retention period</p><p>Value ranges from 60000 to 7776000000</p><p>Unit: ms</p><p>Default value: 7200000</p>
        /// </summary>
        [JsonProperty("RetentionMs")]
        public long? RetentionMs{ get; set; }

        /// <summary>
        /// <p>Duration of Segment shard scrolling</p><p>Unit: ms</p><p>Default value: 86400000</p><p>Minimum value: 86400000ms (1 day)</p>
        /// </summary>
        [JsonProperty("SegmentMs")]
        public long? SegmentMs{ get; set; }

        /// <summary>
        /// <p>Maximum topic messages in Bytes, minimum value 1024 Bytes (1 KB), maximum value 12582912 Bytes (12 MB)</p>
        /// </summary>
        [JsonProperty("MaxMessageBytes")]
        public long? MaxMessageBytes{ get; set; }

        /// <summary>
        /// <p>Preset ACL rule, 1: on 0: off, default is off</p>
        /// </summary>
        [JsonProperty("EnableAclRule")]
        public long? EnableAclRule{ get; set; }

        /// <summary>
        /// <p>Preset ACL rule name</p>
        /// </summary>
        [JsonProperty("AclRuleName")]
        public string AclRuleName{ get; set; }

        /// <summary>
        /// <p>Option, retain file size. Defaults to -1, unit Byte, current min value is 1073741824.</p><p>Value ranges from [1073741824, 1099511627776]</p><p>Unit: Byte</p><p>Special value: -1 indicates unlimited</p>
        /// </summary>
        [JsonProperty("RetentionBytes")]
        public long? RetentionBytes{ get; set; }

        /// <summary>
        /// <p>Tag list</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>Time type for message saving: CreateTime/LogAppendTime</p>
        /// </summary>
        [JsonProperty("LogMsgTimestampType")]
        public string LogMsgTimestampType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "EnableWhiteList", this.EnableWhiteList);
            this.SetParamArraySimple(map, prefix + "IpWhiteList.", this.IpWhiteList);
            this.SetParamSimple(map, prefix + "CleanUpPolicy", this.CleanUpPolicy);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "MinInsyncReplicas", this.MinInsyncReplicas);
            this.SetParamSimple(map, prefix + "UncleanLeaderElectionEnable", this.UncleanLeaderElectionEnable);
            this.SetParamSimple(map, prefix + "RetentionMs", this.RetentionMs);
            this.SetParamSimple(map, prefix + "SegmentMs", this.SegmentMs);
            this.SetParamSimple(map, prefix + "MaxMessageBytes", this.MaxMessageBytes);
            this.SetParamSimple(map, prefix + "EnableAclRule", this.EnableAclRule);
            this.SetParamSimple(map, prefix + "AclRuleName", this.AclRuleName);
            this.SetParamSimple(map, prefix + "RetentionBytes", this.RetentionBytes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LogMsgTimestampType", this.LogMsgTimestampType);
        }
    }
}

