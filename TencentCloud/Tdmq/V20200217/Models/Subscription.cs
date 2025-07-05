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

    public class Subscription : AbstractModel
    {
        
        /// <summary>
        /// Topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Environment (namespace) name.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// The time when the consumer started connecting.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConnectedSince")]
        public string ConnectedSince{ get; set; }

        /// <summary>
        /// Consumer address.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerAddr")]
        public string ConsumerAddr{ get; set; }

        /// <summary>
        /// The number of consumers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerCount")]
        public string ConsumerCount{ get; set; }

        /// <summary>
        /// Consumer name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerName")]
        public string ConsumerName{ get; set; }

        /// <summary>
        /// The number of heaped messages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgBacklog")]
        public string MsgBacklog{ get; set; }

        /// <summary>
        /// Percentage of messages under this subscription that were discarded but not sent after TTL.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateExpired")]
        public string MsgRateExpired{ get; set; }

        /// <summary>
        /// The total number of messages delivered by the consumer per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgRateOut")]
        public string MsgRateOut{ get; set; }

        /// <summary>
        /// The size (in bytes) of messages consumed by the consumer per second.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MsgThroughputOut")]
        public string MsgThroughputOut{ get; set; }

        /// <summary>
        /// Subscription name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// Set of consumers.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerSets")]
        public Consumer[] ConsumerSets{ get; set; }

        /// <summary>
        /// Whether the consumer is online.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsOnline")]
        public bool? IsOnline{ get; set; }

        /// <summary>
        /// Set of consumption progress information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumersScheduleSets")]
        public ConsumersSchedule[] ConsumersScheduleSets{ get; set; }

        /// <summary>
        /// Remarks.
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
        /// Subscription type. Valid values: `Exclusive`, `Shared`, `Failover`, and `Key_Shared`. An empty string or `NULL`: Unknown.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// Whether messages are blocked as the limit of unacknowledged messages has been reached.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlockedSubscriptionOnUnackedMsgs")]
        public bool? BlockedSubscriptionOnUnackedMsgs{ get; set; }

        /// <summary>
        /// The maximum number of unacknowledged messages.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxUnackedMsgNum")]
        public long? MaxUnackedMsgNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "ConnectedSince", this.ConnectedSince);
            this.SetParamSimple(map, prefix + "ConsumerAddr", this.ConsumerAddr);
            this.SetParamSimple(map, prefix + "ConsumerCount", this.ConsumerCount);
            this.SetParamSimple(map, prefix + "ConsumerName", this.ConsumerName);
            this.SetParamSimple(map, prefix + "MsgBacklog", this.MsgBacklog);
            this.SetParamSimple(map, prefix + "MsgRateExpired", this.MsgRateExpired);
            this.SetParamSimple(map, prefix + "MsgRateOut", this.MsgRateOut);
            this.SetParamSimple(map, prefix + "MsgThroughputOut", this.MsgThroughputOut);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamArrayObj(map, prefix + "ConsumerSets.", this.ConsumerSets);
            this.SetParamSimple(map, prefix + "IsOnline", this.IsOnline);
            this.SetParamArrayObj(map, prefix + "ConsumersScheduleSets.", this.ConsumersScheduleSets);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "BlockedSubscriptionOnUnackedMsgs", this.BlockedSubscriptionOnUnackedMsgs);
            this.SetParamSimple(map, prefix + "MaxUnackedMsgNum", this.MaxUnackedMsgNum);
        }
    }
}

