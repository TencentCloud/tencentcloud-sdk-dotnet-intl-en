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

    public class DescribeClusterBaselineRiskPolicyListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Appid of the cluster's account, used to specify the account for querying baseline risk policies.</p>
        /// </summary>
        [JsonProperty("ClusterAppid")]
        public ulong? ClusterAppid{ get; set; }

        /// <summary>
        /// <p>Cluster CaMD5</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// List of member IDs of the group account.
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterAppid", this.ClusterAppid);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

