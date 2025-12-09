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

    public class CmqQueue : AbstractModel
    {
        
        /// <summary>
        /// Message queue ID.
        /// </summary>
        [JsonProperty("QueueId")]
        public string QueueId{ get; set; }

        /// <summary>
        /// Message queue name.
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Limit on the number of messages produced per second. The size of consumed messages is 1.1 times this value.
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Bandwidth limit.
        /// </summary>
        [JsonProperty("Bps")]
        public ulong? Bps{ get; set; }

        /// <summary>
        /// Specifies the maximum retention time for in-flight messages, which must be less than the message retention period.
        /// </summary>
        [JsonProperty("MaxDelaySeconds")]
        public ulong? MaxDelaySeconds{ get; set; }

        /// <summary>
        /// Maximum number of heaped messages. The value range is 1,000,000–10,000,000 during the beta test and can be 1,000,000–1,000,000,000 after the product is officially released. The default value is 10,000,000 during the beta test and will be 100,000,000 after the product is officially released.
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// Long polling waiting time for message receipt. Value range 0-30 seconds, default value 0.
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// Message retention period. The value range is 60-1,296,000 seconds (1 min-15 days), with a default value of 345,600 seconds (4 days).
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Message visibility timeout period. The value range is 1-43,200 seconds (within 12 hours), with a default value of 30.
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// Maximum message length. Range: 1,024-1,048,576 bytes (i.e., 1K-1,024K). Default value is 65,536.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Maximum message backtracking time for backtracking queues, range 0-43,200 seconds. 0 means message backtracking is not enabled.
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// Creation time of queues. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// The last time the queue attribute was modified. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// Total number of active messages (not being consumed) in queue, an approximate value.
        /// </summary>
        [JsonProperty("ActiveMsgNum")]
        public ulong? ActiveMsgNum{ get; set; }

        /// <summary>
        /// Total number of inactive messages (being consumed) in queue, an approximate value.
        /// </summary>
        [JsonProperty("InactiveMsgNum")]
        public ulong? InactiveMsgNum{ get; set; }

        /// <summary>
        /// Number of delayed messages.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DelayMsgNum")]
        public ulong? DelayMsgNum{ get; set; }

        /// <summary>
        /// Number of retained messages which have been deleted by the `DelMsg` API but are still within their rewind time range.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RewindMsgNum")]
        public ulong? RewindMsgNum{ get; set; }

        /// <summary>
        /// Minimum unconsumed time of message in seconds.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MinMsgTime")]
        public ulong? MinMsgTime{ get; set; }

        /// <summary>
        /// Transaction message queue. true: transaction message type; false: other message types.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Transaction")]
        public bool? Transaction{ get; set; }

        /// <summary>
        /// Dead letter queue.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterSource")]
        public CmqDeadLetterSource[] DeadLetterSource{ get; set; }

        /// <summary>
        /// Dead letter queue policy.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadLetterPolicy")]
        public CmqDeadLetterPolicy DeadLetterPolicy{ get; set; }

        /// <summary>
        /// Transaction message policy.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransactionPolicy")]
        public CmqTransactionPolicy TransactionPolicy{ get; set; }

        /// <summary>
        /// Creator `Uin`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// Associated tag.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Message trace. true: enabled; false: not enabled
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }

        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("TenantId")]
        public string TenantId{ get; set; }

        /// <summary>
        /// Specifies the namespace name.
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// Cluster status. 0: Creating, 1: Normal, 2: Deleting, 3: Deleted, 4: Isolating, 5: Creation failed, 6: Deletion failed
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Maximum Number of Unacknowledged Messages
        /// </summary>
        [JsonProperty("MaxUnackedMsgNum")]
        public long? MaxUnackedMsgNum{ get; set; }

        /// <summary>
        /// Maximum Message Backlog Size (bytes)
        /// </summary>
        [JsonProperty("MaxMsgBacklogSize")]
        public long? MaxMsgBacklogSize{ get; set; }

        /// <summary>
        /// Queue retrospective storage space. Value range: 1024 MB to 10240 MB. 0 indicates disabled.
        /// </summary>
        [JsonProperty("RetentionSizeInMB")]
        public ulong? RetentionSizeInMB{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueId", this.QueueId);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "Bps", this.Bps);
            this.SetParamSimple(map, prefix + "MaxDelaySeconds", this.MaxDelaySeconds);
            this.SetParamSimple(map, prefix + "MaxMsgHeapNum", this.MaxMsgHeapNum);
            this.SetParamSimple(map, prefix + "PollingWaitSeconds", this.PollingWaitSeconds);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "VisibilityTimeout", this.VisibilityTimeout);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "RewindSeconds", this.RewindSeconds);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "ActiveMsgNum", this.ActiveMsgNum);
            this.SetParamSimple(map, prefix + "InactiveMsgNum", this.InactiveMsgNum);
            this.SetParamSimple(map, prefix + "DelayMsgNum", this.DelayMsgNum);
            this.SetParamSimple(map, prefix + "RewindMsgNum", this.RewindMsgNum);
            this.SetParamSimple(map, prefix + "MinMsgTime", this.MinMsgTime);
            this.SetParamSimple(map, prefix + "Transaction", this.Transaction);
            this.SetParamArrayObj(map, prefix + "DeadLetterSource.", this.DeadLetterSource);
            this.SetParamObj(map, prefix + "DeadLetterPolicy.", this.DeadLetterPolicy);
            this.SetParamObj(map, prefix + "TransactionPolicy.", this.TransactionPolicy);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MaxUnackedMsgNum", this.MaxUnackedMsgNum);
            this.SetParamSimple(map, prefix + "MaxMsgBacklogSize", this.MaxMsgBacklogSize);
            this.SetParamSimple(map, prefix + "RetentionSizeInMB", this.RetentionSizeInMB);
        }
    }
}

