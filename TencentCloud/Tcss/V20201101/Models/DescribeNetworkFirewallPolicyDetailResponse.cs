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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNetworkFirewallPolicyDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Policy name
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Namespace
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Inbound type
        /// </summary>
        [JsonProperty("FromPolicyRule")]
        public long? FromPolicyRule{ get; set; }

        /// <summary>
        /// Outbound type
        /// </summary>
        [JsonProperty("ToPolicyRule")]
        public long? ToPolicyRule{ get; set; }

        /// <summary>
        /// Custom rule
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public NetworkCustomPolicy[] CustomPolicy{ get; set; }

        /// <summary>
        /// Pod selector
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// Policy description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Policy creation time
        /// </summary>
        [JsonProperty("PolicyCreateTime")]
        public string PolicyCreateTime{ get; set; }

        /// <summary>
        /// Policy source type. Valid values: `System` (synched from the cluster); `Manual` (added manually).
        /// </summary>
        [JsonProperty("PolicySourceType")]
        public string PolicySourceType{ get; set; }

        /// <summary>
        /// Network plugin of the network policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NetworkPolicyPlugin")]
        public string NetworkPolicyPlugin{ get; set; }

        /// <summary>
        /// Network policy status
        /// </summary>
        [JsonProperty("PublishStatus")]
        public string PublishStatus{ get; set; }

        /// <summary>
        /// Policy publishing result
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublishResult")]
        public string PublishResult{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "FromPolicyRule", this.FromPolicyRule);
            this.SetParamSimple(map, prefix + "ToPolicyRule", this.ToPolicyRule);
            this.SetParamArrayObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PolicyCreateTime", this.PolicyCreateTime);
            this.SetParamSimple(map, prefix + "PolicySourceType", this.PolicySourceType);
            this.SetParamSimple(map, prefix + "NetworkPolicyPlugin", this.NetworkPolicyPlugin);
            this.SetParamSimple(map, prefix + "PublishStatus", this.PublishStatus);
            this.SetParamSimple(map, prefix + "PublishResult", this.PublishResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

