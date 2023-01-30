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

    public class NetworkPolicyInfoItem : AbstractModel
    {
        
        /// <summary>
        /// Network policy name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Network policy description
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Publishing status:
        /// 
        /// `PublishedNoConfirm`: Enabled and to be confirmed.
        /// 
        /// `PublishedConfirmed`: Enabled and confirmed.
        /// 
        /// `unPublishing`: Disabled.
        /// 
        /// `Publishing`: Enabled.
        /// 
        /// `unPublishEdit`: To be enabled.
        /// </summary>
        [JsonProperty("PublishStatus")]
        public string PublishStatus{ get; set; }

        /// <summary>
        /// Policy type:
        /// 
        /// `System`: Synched from the cluster.
        /// 
        /// `Manual`: Added manually.
        /// </summary>
        [JsonProperty("PolicySourceType")]
        public string PolicySourceType{ get; set; }

        /// <summary>
        /// Policy space
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// Policy creation date
        /// </summary>
        [JsonProperty("PolicyCreateTime")]
        public string PolicyCreateTime{ get; set; }

        /// <summary>
        /// Policy type
        /// 
        /// kube-router: KubeRouter
        /// 
        /// cilium: Cilium
        /// </summary>
        [JsonProperty("NetworkPolicyPlugin")]
        public string NetworkPolicyPlugin{ get; set; }

        /// <summary>
        /// Policy publishing result
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublishResult")]
        public string PublishResult{ get; set; }

        /// <summary>
        /// Inbound rule
        /// 
        /// `1`: Allow all.
        /// 
        /// `2`: Reject all.
        /// 
        /// `3`: Custom.
        /// </summary>
        [JsonProperty("FromPolicyRule")]
        public long? FromPolicyRule{ get; set; }

        /// <summary>
        /// Inbound rule
        /// 
        /// `1`: Allow all.
        /// 
        /// `2`: Reject all.
        /// 
        /// `3`: Custom.
        /// </summary>
        [JsonProperty("ToPolicyRule")]
        public long? ToPolicyRule{ get; set; }

        /// <summary>
        /// Object
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// Network policy ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PublishStatus", this.PublishStatus);
            this.SetParamSimple(map, prefix + "PolicySourceType", this.PolicySourceType);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "PolicyCreateTime", this.PolicyCreateTime);
            this.SetParamSimple(map, prefix + "NetworkPolicyPlugin", this.NetworkPolicyPlugin);
            this.SetParamSimple(map, prefix + "PublishResult", this.PublishResult);
            this.SetParamSimple(map, prefix + "FromPolicyRule", this.FromPolicyRule);
            this.SetParamSimple(map, prefix + "ToPolicyRule", this.ToPolicyRule);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "Id", this.Id);
        }
    }
}

