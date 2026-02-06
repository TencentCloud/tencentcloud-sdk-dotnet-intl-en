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

    public class AuthorizationPolicyItem : AbstractModel
    {
        
        /// <summary>
        /// Policy rule ID.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// MQTT cluster ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Specifies the policy rule name.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Rule syntax version. currently only support 1. defaults to 1.
        /// </summary>
        [JsonProperty("Version")]
        public long? Version{ get; set; }

        /// <summary>
        /// Policy priority. a smaller priority ID indicates the policy takes effect with higher priority. see [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Specifies the decision.
        /// allow specifies permission for access requests from devices that match this policy.
        /// deny: denies access requests to the device that override the policy.
        /// Refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Effect")]
        public string Effect{ get; set; }

        /// <summary>
        /// Operation.
        /// Specifies the connection.
        /// Publishes an mqtt message.
        /// Sub. specifies the subscription to mqtt messages.
        /// Refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Actions")]
        public string Actions{ get; set; }

        /// <summary>
        /// Resource. see the data plane authorization policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Resources")]
        public string Resources{ get; set; }

        /// <summary>
        /// Specifies the device ID for connection. refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Condition - username. refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Specifies the client IP address. see the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Condition - service quality. see the data plane authorization policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// Condition - message retention. refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// Indicates the match of retain messages.
        /// 2: indicates non-retain messages.
        /// 3: indicates matching retain and non-retain messages.
        /// </summary>
        [JsonProperty("Retain")]
        public long? Retain{ get; set; }

        /// <summary>
        /// Specifies the remark with length not exceeding 128 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Creation time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Update time. millisecond-level timestamp.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Effect", this.Effect);
            this.SetParamSimple(map, prefix + "Actions", this.Actions);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Retain", this.Retain);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

