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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MQTTClientSubscription : AbstractModel
    {
        
        /// <summary>
        /// Subscribed topic.
        /// </summary>
        [JsonProperty("TopicFilter")]
        public string TopicFilter{ get; set; }

        /// <summary>
        /// Service quality grade.
        /// Up to once.
        /// At least once.
        /// Exactly once.
        /// </summary>
        [JsonProperty("Qos")]
        public long? Qos{ get; set; }

        /// <summary>
        /// Indicates the heaped messages.
        /// </summary>
        [JsonProperty("Lag")]
        public long? Lag{ get; set; }

        /// <summary>
        /// Unconfirmed delivery count.
        /// </summary>
        [JsonProperty("Inflight")]
        public long? Inflight{ get; set; }

        /// <summary>
        /// Describes the user attribute.
        /// </summary>
        [JsonProperty("UserProperties")]
        public SubscriptionUserProperty[] UserProperties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicFilter", this.TopicFilter);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Lag", this.Lag);
            this.SetParamSimple(map, prefix + "Inflight", this.Inflight);
            this.SetParamArrayObj(map, prefix + "UserProperties.", this.UserProperties);
        }
    }
}

