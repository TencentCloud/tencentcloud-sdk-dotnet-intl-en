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

    public class ModifySubscriptionAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Topic name, which is unique under the same account in an individual region. It is a string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`).
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// Subscription name, which is unique in the same topic under the same account in an individual region. It is a string of up to 64 characters, which must begin with a letter and can contain letters, digits, and dashes (`-`).
        /// </summary>
        [JsonProperty("SubscriptionName")]
        public string SubscriptionName{ get; set; }

        /// <summary>
        /// CMQ push server retry policy in case an error occurs while pushing a message to `Endpoint`. Valid values:
        /// 1. BACKOFF_RETRY: backoff retry, which is to retry at a fixed interval, discard the message after a certain number of retries, and continue to push the next message.
        /// 2. EXPONENTIAL_DECAY_RETRY: exponential decay retry, which is to retry at an exponentially increasing interval, such as 1s, 2s, 4s, 8s, and so on. As a message can be retained in a topic for one day, failed messages will be discarded at most after one day of retry. Default value: EXPONENTIAL_DECAY_RETRY.
        /// </summary>
        [JsonProperty("NotifyStrategy")]
        public string NotifyStrategy{ get; set; }

        /// <summary>
        /// Push content format. Valid values: 1. JSON, 2. SIMPLIFIED, i.e., the raw format. If `Protocol` is `queue`, this value must be `SIMPLIFIED`. If `Protocol` is `HTTP`, both options are acceptable, and the default value is `JSON`.
        /// </summary>
        [JsonProperty("NotifyContentFormat")]
        public string NotifyContentFormat{ get; set; }

        /// <summary>
        /// Message body tag (used for message filtering). The number of tags cannot exceed 5, and each tag can contain up to 16 characters. It is used in conjunction with the `MsgTag` parameter of `(Batch)PublishMessage`. Rules: 1. If `FilterTag` is not set, no matter whether `MsgTag` is set, the subscription will receive all messages published to the topic; 2. If the `FilterTag` array has a value, only when at least one of the values in the array also exists in the `MsgTag` array (i.e., `FilterTag` and `MsgTag` have an intersection) can the subscription receive messages published to the topic; 3. If the `FilterTag` array has a value, but `MsgTag` is not set, then no message published to the topic will be received, which can be considered as a special case of rule 2 as `FilterTag` and `MsgTag` do not intersect in this case. The overall design idea of rules is based on the intention of the subscriber.
        /// </summary>
        [JsonProperty("FilterTags")]
        public string[] FilterTags{ get; set; }

        /// <summary>
        /// The number of `BindingKey` cannot exceed 5, and the length of each `BindingKey` cannot exceed 64 bytes. This field indicates the filtering policy for subscribing to and receiving messages. Each `BindingKey` can contain up to 15 `.`, i.e., up to 16 phrases.
        /// </summary>
        [JsonProperty("BindingKey")]
        public string[] BindingKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "SubscriptionName", this.SubscriptionName);
            this.SetParamSimple(map, prefix + "NotifyStrategy", this.NotifyStrategy);
            this.SetParamSimple(map, prefix + "NotifyContentFormat", this.NotifyContentFormat);
            this.SetParamArraySimple(map, prefix + "FilterTags.", this.FilterTags);
            this.SetParamArraySimple(map, prefix + "BindingKey.", this.BindingKey);
        }
    }
}

