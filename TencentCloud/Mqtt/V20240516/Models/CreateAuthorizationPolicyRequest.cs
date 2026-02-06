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

    public class CreateAuthorizationPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// tencent cloud MQTT instance ID, obtained from the [DescribeInstanceList](https://www.tencentcloud.com/document/api/1778/111029?from_cn_redirect=1) api or console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Policy name, which cannot be empty, contains 3 to 64 characters, and supports chinese, letters, digits, "-", and "_".
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Policy version, defaults to 1. currently only support 1.
        /// </summary>
        [JsonProperty("PolicyVersion")]
        public long? PolicyVersion{ get; set; }

        /// <summary>
        /// Policy priority. a smaller value indicates higher priority and must be unique. a smaller priority ID means the policy takes effect with higher priority. see [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
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
        /// Operation, supports multiple selections separated by commas. see the data plane policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// Specifies the connection.
        /// Specifies the publish action.
        /// Sub. specifies the subscription.
        /// </summary>
        [JsonProperty("Actions")]
        public string Actions{ get; set; }

        /// <summary>
        /// Condition - message retention. refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// Matches message retention.
        /// Matches non-retention messages.
        /// 3. match retained and non-retained messages.
        /// </summary>
        [JsonProperty("Retain")]
        public long? Retain{ get; set; }

        /// <summary>
        /// Condition: specifies the service quality.
        /// 0: at most once.
        /// Minimum once.
        /// 2: exactly once.
        /// Refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Qos")]
        public string Qos{ get; set; }

        /// <summary>
        /// Specifies the resource and subscription to match. supports configuration of multiple match rules, separated by commas. see the data plane authorization policy description (https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Resources")]
        public string Resources{ get; set; }

        /// <summary>
        /// Specifies the condition-username.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// Client ID. supports regular expressions.
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Specifies the client IP address, supporting IP or CIDR. refer to the [data plane authorization policy description](https://www.tencentcloud.com/document/product/1778/109715?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// Specifies the remark information with a maximum length of 128 characters.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyVersion", this.PolicyVersion);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Effect", this.Effect);
            this.SetParamSimple(map, prefix + "Actions", this.Actions);
            this.SetParamSimple(map, prefix + "Retain", this.Retain);
            this.SetParamSimple(map, prefix + "Qos", this.Qos);
            this.SetParamSimple(map, prefix + "Resources", this.Resources);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

