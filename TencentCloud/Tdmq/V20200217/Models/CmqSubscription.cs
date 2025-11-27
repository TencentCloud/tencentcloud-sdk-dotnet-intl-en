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

    public class CmqSubscription : AbstractModel
    {
        
        /// <summary>
        /// Subscription name, which must be unique under the same account and same topic in a single region. the name is a string of no more than 64 characters, beginning with a letter, and the remaining part may contain letters, numbers, and hyphens (-).
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// Subscription ID. The subscription ID is used when monitoring data is pulled.
        /// </summary>
        [JsonProperty("SubscriptionId")]
        public string SubscriptionId{ get; set; }

        /// <summary>
        /// Subscription owner `APPID`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TopicOwner")]
        public ulong? TopicOwner{ get; set; }

        /// <summary>
        /// The number of messages waiting for shipping for this subscription.
        /// </summary>
        [JsonProperty("MsgCount")]
        public ulong? MsgCount{ get; set; }

        /// <summary>
        /// The last time the subscription attribute was modified. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("LastModifyTime")]
        public ulong? LastModifyTime{ get; set; }

        /// <summary>
        /// The time when the subscription was created. Returns a Unix timestamp, accurate to milliseconds.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Filtering policy for subscribing to and receiving messages.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindingKey")]
        public string[] BindingKey{ get; set; }

        /// <summary>
        /// The endpoint that receives notifications is differentiated by protocol: For HTTP, the endpoint must start with http://, and the host can be a domain name or IP; for queue, fill in queueName.
        /// </summary>
        [JsonProperty("Endpoint")]
        public string Endpoint{ get; set; }

        /// <summary>
        /// Describes the filtering policy selected by users when creating subscriptions.
        /// filterType = 1 indicates Tag filtering when users use filterTag.
        /// filterType = 2 indicates user use bindingKey for filtering.
        /// </summary>
        [JsonProperty("FilterTags")]
        public string[] FilterTags{ get; set; }

        /// <summary>
        /// The subscription protocol, currently supports two protocols: HTTP and queue. When the HTTP protocol is used, users need to set up their own web server to accept messages. When the queue protocol is used, messages will automatically be pushed to CMQ queues, and users can pull messages concurrently.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Specifies the CMQ push server retry policy when an error occurs while pushing messages to an endpoint. valid values:.
        /// BACKOFF_RETRY, backoff retry. retry at regular intervals, discard the message after a certain number of retries, and continue to push the next message.
        /// (2) EXPONENTIAL_DECAY_RETRY, EXPONENTIAL DECAY RETRY. the interval between retries increases exponentially, for example starting at 1s, followed by 2s, 4s, 8s... since the Topic message period is one day, RETRY for at most one day then discard the message. default value is EXPONENTIAL_DECAY_RETRY.
        /// </summary>
        [JsonProperty("NotifyStrategy")]
        public string NotifyStrategy{ get; set; }

        /// <summary>
        /// The format of the push content. Values: (1) JSON; (2) SIMPLIFIED, i.e., raw format. If protocol is queue, the value must be SIMPLIFIED. If protocol is HTTP, both values are acceptable, with the default being JSON.
        /// </summary>
        [JsonProperty("NotifyContentFormat")]
        public string NotifyContentFormat{ get; set; }

        /// <summary>
        /// Topic Name of the Subscription
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "SubscriptionId", this.SubscriptionId);
            this.SetParamSimple(map, prefix + "TopicOwner", this.TopicOwner);
            this.SetParamSimple(map, prefix + "MsgCount", this.MsgCount);
            this.SetParamSimple(map, prefix + "LastModifyTime", this.LastModifyTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "BindingKey.", this.BindingKey);
            this.SetParamSimple(map, prefix + "Endpoint", this.Endpoint);
            this.SetParamArraySimple(map, prefix + "FilterTags.", this.FilterTags);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "NotifyStrategy", this.NotifyStrategy);
            this.SetParamSimple(map, prefix + "NotifyContentFormat", this.NotifyContentFormat);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
        }
    }
}

