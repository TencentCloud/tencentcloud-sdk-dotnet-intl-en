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

    public class ModifyEnvironmentAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Namespace name.
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Retention period for unconsumed messages in seconds. Value range: 60s to 1,296,000s (or 15 days).
        /// </summary>
        [JsonProperty("MsgTTL")]
        public ulong? MsgTTL{ get; set; }

        /// <summary>
        /// Remarks (up to 128 characters).
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Message retention policy
        /// </summary>
        [JsonProperty("RetentionPolicy")]
        public RetentionPolicy RetentionPolicy{ get; set; }

        /// <summary>
        /// Whether to enable "Auto-Create Subscription"
        /// </summary>
        [JsonProperty("AutoSubscriptionCreation")]
        public bool? AutoSubscriptionCreation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "MsgTTL", this.MsgTTL);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "RetentionPolicy.", this.RetentionPolicy);
            this.SetParamSimple(map, prefix + "AutoSubscriptionCreation", this.AutoSubscriptionCreation);
        }
    }
}

