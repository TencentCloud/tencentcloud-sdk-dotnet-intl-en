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

    public class CmqTopic : AbstractModel
    {
        
        /// <summary>
        /// Topic ID.
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// Topic name.
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Maximum lifetime of messages in a topic. After the time specified by this parameter has elapsed since sending to this topic, the message will be deleted whether or not it has been successfully pushed to the user. Measured in seconds and fixed at one day (86,400 seconds). This attribute cannot be modified.
        /// </summary>
        [JsonProperty("MsgRetentionSeconds")]
        public ulong? MsgRetentionSeconds{ get; set; }

        /// <summary>
        /// Maximum message length. value range: 1024-1048576 bytes (1-1024 kb). default value: 1048576.
        /// </summary>
        [JsonProperty("MaxMsgSize")]
        public ulong? MaxMsgSize{ get; set; }

        /// <summary>
        /// Number of messages published per second.
        /// </summary>
        [JsonProperty("Qps")]
        public ulong? Qps{ get; set; }

        /// <summary>
        /// Describes the filtering policy selected by users when creating subscriptions.
        /// FilterType = 1 means when users use Tag filtering with FilterTag.
        /// FilterType = 2 indicates user use BindingKey for filtering.
        /// </summary>
        [JsonProperty("FilterType")]
        public ulong? FilterType{ get; set; }

        /// <summary>
        /// Topic creation time. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// The last time the topic attribute was modified. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// Number of messages in the current topic (message backlog).
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// Creator `Uin`. The `resource` field for CAM authentication is composed of this field.
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
        /// 0: Pulsar, 1: RocketMQ
        /// </summary>
        [JsonProperty("BrokerType")]
        public long? BrokerType{ get; set; }

        /// <summary>
        /// Number of Subscriptions
        /// </summary>
        [JsonProperty("SubscriptionCount")]
        public long? SubscriptionCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "MsgRetentionSeconds", this.MsgRetentionSeconds);
            this.SetParamSimple(map, prefix + "MaxMsgSize", this.MaxMsgSize);
            this.SetParamSimple(map, prefix + "Qps", this.Qps);
            this.SetParamSimple(map, prefix + "FilterType", this.FilterType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Trace", this.Trace);
            this.SetParamSimple(map, prefix + "TenantId", this.TenantId);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BrokerType", this.BrokerType);
            this.SetParamSimple(map, prefix + "SubscriptionCount", this.SubscriptionCount);
        }
    }
}

