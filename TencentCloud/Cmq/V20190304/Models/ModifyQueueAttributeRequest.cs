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

namespace TencentCloud.Cmq.V20190304.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyQueueAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Queue name, which is unique under the same account in an individual region. It is a string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`).
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// Maximum number of heaped messages. The value range is 1,000,000–10,000,000 during the beta test and can be 1,000,000–1,000,000,000 after the product is officially released. The default value is 10,000,000 during the beta test and will be 100,000,000 after the product is officially released.
        /// </summary>
        [JsonProperty("MaxMsgHeapNum")]
        public ulong? MaxMsgHeapNum{ get; set; }

        /// <summary>
        /// Long polling wait time for message reception. Value range: 0–30 seconds. Default value: 0.
        /// </summary>
        [JsonProperty("PollingWaitSeconds")]
        public ulong? PollingWaitSeconds{ get; set; }

        /// <summary>
        /// Message visibility timeout period. Value range: 1–43200 seconds (i.e., 12 hours). Default value: 30.
        /// </summary>
        [JsonProperty("VisibilityTimeout")]
        public ulong? VisibilityTimeout{ get; set; }

        /// <summary>
        /// Maximum message length. Value range: 1024–65536 bytes (i.e., 1–64 KB). Default value: 65536.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Message retention period. Value range: 60–1296000 seconds (i.e., 1 minute–15 days). Default value: 345600 (i.e., 4 days).
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Maximum message rewindable period. Value range: 0–msgRetentionSeconds (maximum message retention period of a queue). 0 means not to enable message rewinding.
        /// </summary>
        [JsonProperty("RewindSeconds")]
        public ulong? RewindSeconds{ get; set; }

        /// <summary>
        /// First query time
        /// </summary>
        [JsonProperty("FirstQueryInterval")]
        public ulong? FirstQueryInterval{ get; set; }

        /// <summary>
        /// Maximum number of queries
        /// </summary>
        [JsonProperty("MaxQueryCount")]
        public ulong? MaxQueryCount{ get; set; }

        /// <summary>
        /// Dead letter queue name
        /// </summary>
        [JsonProperty("DeadLetterQueueName")]
        public string DeadLetterQueueName{ get; set; }

        /// <summary>
        /// Maximum period in seconds before an unconsumed message expires, which is required if `MaxTimeToLivepolicy` is 1. Value range: 300–43200. This value should be smaller than `MsgRetentionSeconds` (maximum message retention period)
        /// </summary>
        [JsonProperty("MaxTimeToLive")]
        public ulong? MaxTimeToLive{ get; set; }

        /// <summary>
        /// Maximum number of receipts
        /// </summary>
        [JsonProperty("MaxReceiveCount")]
        public ulong? MaxReceiveCount{ get; set; }

        /// <summary>
        /// Dead letter queue policy
        /// </summary>
        [JsonProperty("Policy")]
        public ulong? Policy{ get; set; }

        /// <summary>
        /// Whether to enable message trace. true: yes, false: no. If this field is left empty, the feature will not be enabled.
        /// </summary>
        [JsonProperty("Trace")]
        public bool? Trace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "MaxMsgHeapNum", this.MaxMsgHeapNum);
            this.SetParamSimple(map, prefix + "PollingWaitSeconds", this.PollingWaitSeconds);
            this.SetParamSimple(map, prefix + "VisibilityTimeout", this.VisibilityTimeout);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "RewindSeconds", this.RewindSeconds);
            this.SetParamSimple(map, prefix + "FirstQueryInterval", this.FirstQueryInterval);
            this.SetParamSimple(map, prefix + "MaxQueryCount", this.MaxQueryCount);
            this.SetParamSimple(map, prefix + "DeadLetterQueueName", this.DeadLetterQueueName);
            this.SetParamSimple(map, prefix + "MaxTimeToLive", this.MaxTimeToLive);
            this.SetParamSimple(map, prefix + "MaxReceiveCount", this.MaxReceiveCount);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
        }
    }
}

