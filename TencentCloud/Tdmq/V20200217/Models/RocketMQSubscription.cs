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

    public class RocketMQSubscription : AbstractModel
    {
        
        /// <summary>
        /// Topic name
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// Topic type.
        /// Normal.
        /// GlobalOrder specifies the global sequential order.
        /// Partitionally sequential.
        /// Transactional message.
        /// DelayScheduled specifies the delayed message.
        /// Retry.
        /// DeadLetter. specifies the dead letter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Number of partitions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }

        /// <summary>
        /// Filter mode, which can be TAG or SQL.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpressionType")]
        public string ExpressionType{ get; set; }

        /// <summary>
        /// Filter expression.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubString")]
        public string SubString{ get; set; }

        /// <summary>
        /// Subscription status:.
        /// Consistent subscription relationship.
        /// Inconsistent subscription relationship.
        /// 2. unknown.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Number of heaped consumer groups.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerLag")]
        public long? ConsumerLag{ get; set; }

        /// <summary>
        /// Instance ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Specifies the consumer group name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumerGroup")]
        public string ConsumerGroup{ get; set; }

        /// <summary>
        /// Online status
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsOnline")]
        public bool? IsOnline{ get; set; }

        /// <summary>
        /// Consumption type.
        /// Broadcast consumption.
        /// Specifies the cluster consumption.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ConsumeType")]
        public long? ConsumeType{ get; set; }

        /// <summary>
        /// Subscription consistency.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Consistency")]
        public long? Consistency{ get; set; }

        /// <summary>
        /// Last consumption progress update time, in seconds
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// Maximum number of retries.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MaxRetryTimes")]
        public long? MaxRetryTimes{ get; set; }

        /// <summary>
        /// Protocol type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientProtocol")]
        public string ClientProtocol{ get; set; }

        /// <summary>
        /// Client subscription details.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientSubscriptionInfos")]
        public ClientSubscriptionInfo[] ClientSubscriptionInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
            this.SetParamSimple(map, prefix + "ExpressionType", this.ExpressionType);
            this.SetParamSimple(map, prefix + "SubString", this.SubString);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ConsumerLag", this.ConsumerLag);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ConsumerGroup", this.ConsumerGroup);
            this.SetParamSimple(map, prefix + "IsOnline", this.IsOnline);
            this.SetParamSimple(map, prefix + "ConsumeType", this.ConsumeType);
            this.SetParamSimple(map, prefix + "Consistency", this.Consistency);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "MaxRetryTimes", this.MaxRetryTimes);
            this.SetParamSimple(map, prefix + "ClientProtocol", this.ClientProtocol);
            this.SetParamArrayObj(map, prefix + "ClientSubscriptionInfos.", this.ClientSubscriptionInfos);
        }
    }
}

