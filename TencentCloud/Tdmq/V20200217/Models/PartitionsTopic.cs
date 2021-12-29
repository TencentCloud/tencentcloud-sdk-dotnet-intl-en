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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PartitionsTopic : AbstractModel
    {
        
        /// <summary>
        /// Average size of the messages published in the last interval in bytes.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AverageMsgSize")]
        public string AverageMsgSize{ get; set; }

        /// <summary>
        /// Number of consumers.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// Total number of recorded messages.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastConfirmedEntry")]
        public string LastConfirmedEntry{ get; set; }

        /// <summary>
        /// Time when the last ledger was created.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastLedgerCreatedTimestamp")]
        public string LastLedgerCreatedTimestamp{ get; set; }

        /// <summary>
        /// Number of messages published by local and replicated publishers per second.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateIn")]
        public string MsgRateIn{ get; set; }

        /// <summary>
        /// Sum of the numbers of messages delivered by local and replicated consumers per second.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// Number of bytes of messages published by local and replicated publishers per second.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgThroughputIn")]
        public string MsgThroughputIn{ get; set; }

        /// <summary>
        /// Number of bytes of messages delivered by local and replicated consumers per second.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// Total number of recorded messages.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NumberOfEntries")]
        public string NumberOfEntries{ get; set; }

        /// <summary>
        /// Subpartition ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Partitions")]
        public long? Partitions{ get; set; }

        /// <summary>
        /// Number of producers.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProducerCount")]
        public string ProducerCount{ get; set; }

        /// <summary>
        /// Total amount of all stored messages in bytes.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalSize")]
        public string TotalSize{ get; set; }

        /// <summary>
        /// Topic type description.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicType")]
        public ulong? TopicType{ get; set; }


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
            this.SetParamSimple(map, prefix + "TopicType", this.TopicType);
        }
    }
}

