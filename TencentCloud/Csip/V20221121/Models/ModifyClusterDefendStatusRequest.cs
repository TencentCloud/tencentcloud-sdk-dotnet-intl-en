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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterDefendStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Protection switch</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public bool? DefendStatus{ get; set; }

        /// <summary>
        /// Whether to unbind the host License under the cluster when disabling protection
        /// Enumeration values:
        /// true: synchronously unbind host authorization from all nodes in a cluster
        /// false: only stop container fees, nodes retain CWP protection
        /// Default value: `false`.
        /// Supplementary description: This parameter is valid only when DefendStatus=false (protection disabled).
        /// </summary>
        [JsonProperty("UnbindHostLicense")]
        public bool? UnbindHostLicense{ get; set; }

        /// <summary>
        /// <p>Cluster id array.</p>
        /// </summary>
        [JsonProperty("ClusterAssetIds")]
        [System.Obsolete]
        public string[] ClusterAssetIds{ get; set; }

        /// <summary>
        /// Member ID of the Called Group Account
        /// </summary>
        [JsonProperty("OperatedMemberId")]
        public string[] OperatedMemberId{ get; set; }

        /// <summary>
        /// <p>Group account member id.</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Cluster ca certificate md5 value, the unique identifier of the cluster</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5List")]
        public string[] ClusterCaMD5List{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "UnbindHostLicense", this.UnbindHostLicense);
            this.SetParamArraySimple(map, prefix + "ClusterAssetIds.", this.ClusterAssetIds);
            this.SetParamArraySimple(map, prefix + "OperatedMemberId.", this.OperatedMemberId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamArraySimple(map, prefix + "ClusterCaMD5List.", this.ClusterCaMD5List);
        }
    }
}

