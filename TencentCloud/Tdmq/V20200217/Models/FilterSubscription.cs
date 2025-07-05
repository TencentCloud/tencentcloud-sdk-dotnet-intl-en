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

    public class FilterSubscription : AbstractModel
    {
        
        /// <summary>
        /// Whether to only display subscriptions that include real consumers.
        /// </summary>
        [JsonProperty("ConsumerHasCount")]
        public bool? ConsumerHasCount{ get; set; }

        /// <summary>
        /// Whether to only display subscriptions with heaped messages.
        /// </summary>
        [JsonProperty("ConsumerHasBacklog")]
        public bool? ConsumerHasBacklog{ get; set; }

        /// <summary>
        /// Whether to only display subscriptions with messages discarded after expiration.
        /// </summary>
        [JsonProperty("ConsumerHasExpired")]
        public bool? ConsumerHasExpired{ get; set; }

        /// <summary>
        /// Filter by subscription name for exact query.
        /// </summary>
        [JsonProperty("SubscriptionNames")]
        public string[] SubscriptionNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerHasCount", this.ConsumerHasCount);
            this.SetParamSimple(map, prefix + "ConsumerHasBacklog", this.ConsumerHasBacklog);
            this.SetParamSimple(map, prefix + "ConsumerHasExpired", this.ConsumerHasExpired);
            this.SetParamArraySimple(map, prefix + "SubscriptionNames.", this.SubscriptionNames);
        }
    }
}

