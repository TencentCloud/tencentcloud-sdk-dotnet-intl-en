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

    public class Topic : AbstractModel
    {
        
        /// <summary>
        /// Average size of the messages published in the last interval in bytes.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AverageMsgSize")]
        public string AverageMsgSize{ get; set; }

        /// <summary>
        /// The number of consumers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// The total number of recorded messages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastConfirmedEntry")]
        public string LastConfirmedEntry{ get; set; }

        /// <summary>
        /// Time when the last ledger was created.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastLedgerCreatedTimestamp")]
        public string LastLedgerCreatedTimestamp{ get; set; }

        /// <summary>
        /// The number of messages published by local and replicated publishers per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateIn")]
        public string MsgRateIn{ get; set; }

        /// <summary>
        /// The total number of messages delivered by local and replicated consumers per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// The size (in bytes) of messages published by local and replicated publishers per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgThroughputIn")]
        public string MsgThroughputIn{ get; set; }

        /// <summary>
        /// The size (in bytes) of messages delivered by local and replicated consumers per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// The total number of recorded messages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NumberOfEntries")]
        public string NumberOfEntries{ get; set; }

        /// <summary>
        /// Partition count ≤ 0: there are no subpartitions in the topic.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Partitions")]
        public long? Partitions{ get; set; }

        /// <summary>
        /// The number of producers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProducerCount")]
        public string ProducerCount{ get; set; }

        /// <summary>
        /// The size of all stored messages in bytes.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalSize")]
        public string TotalSize{ get; set; }

        /// <summary>
        /// Subpartitions in a partitioned topic.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubTopicSets")]
        public PartitionsTopic[] SubTopicSets{ get; set; }

        /// <summary>
        /// Topic type description:
        /// 0: General message;
        /// 1: Globally sequential message;
        /// 2: Partitionally sequential message;
        /// 3: Retry letter topic;
        /// 4: Dead letter topic;
        /// 5: Transaction message.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicType")]
        public ulong? TopicType{ get; set; }

        /// <summary>
        /// Environment (namespace) name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Topic name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Remarks (up to 128 characters).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The maximum number of producers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProducerLimit")]
        public string ProducerLimit{ get; set; }

        /// <summary>
        /// The maximum number of consumers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerLimit")]
        public string ConsumerLimit{ get; set; }

        /// <summary>
        /// `0`: Non-persistent and non-partitioned
        /// `1`: Non-persistent and partitioned
        /// `2`: Persistent and non-partitioned
        /// `3`: Persistent and partitioned
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PulsarTopicType")]
        public long? PulsarTopicType{ get; set; }

        /// <summary>
        /// Retention period for unconsumed messages in seconds.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Tenant alias customized by users. if there is no, reuse the professional cluster ID.
        /// </summary>
        [JsonProperty("Tenant")]
        public string Tenant{ get; set; }

        /// <summary>
        /// Whether exception consumer isolation is enabled.
        /// </summary>
        [JsonProperty("IsolateConsumerEnable")]
        public bool? IsolateConsumerEnable{ get; set; }

        /// <summary>
        /// Specifies the consumer Ack timeout period in seconds.
        /// </summary>
        [JsonProperty("AckTimeOut")]
        public long? AckTimeOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AverageMsgSize", this.AverageMsgSize);
            this.SetParamSimple(map, prefix + "ConsumerCount", this.ConsumerCount);
            this.SetParamSimple(map, prefix + "LastConfirmedEntry", this.LastConfirmedEntry);
            this.SetParamSimple(map, prefix + "LastLedgerCreatedTimestamp", this.LastLedgerCreatedTimestamp);
            this.SetParamSimple(map, prefix + "MsgRateIn", this.MsgRateIn);
            this.SetParamSimple(map, prefix + "MsgRateOut", this.MsgRateOut);
            this.SetParamSimple(map, prefix + "MsgThroughputIn", this.MsgThroughputIn);
            this.SetParamSimple(map, prefix + "MsgThroughputOut", this.MsgThroughputOut);
            this.SetParamSimple(map, prefix + "NumberOfEntries", this.NumberOfEntries);
            this.SetParamSimple(map, prefix + "Partitions", this.Partitions);
            this.SetParamSimple(map, prefix + "ProducerCount", this.ProducerCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
            this.SetParamArrayObj(map, prefix + "SubTopicSets.", this.SubTopicSets);
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ProducerLimit", this.ProducerLimit);
            this.SetParamSimple(map, prefix + "ConsumerLimit", this.ConsumerLimit);
            this.SetParamSimple(map, prefix + "PulsarTopicType", this.PulsarTopicType);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Tenant", this.Tenant);
            this.SetParamSimple(map, prefix + "IsolateConsumerEnable", this.IsolateConsumerEnable);
            this.SetParamSimple(map, prefix + "AckTimeOut", this.AckTimeOut);
        }
    }
}

