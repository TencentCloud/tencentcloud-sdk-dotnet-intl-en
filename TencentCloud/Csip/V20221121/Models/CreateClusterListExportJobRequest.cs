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

    public class CreateClusterListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>List of Universal Filter Criteria. Supported filter fields:<br>ClusterId: CLUSTER ID, exact match.<br>ClusterName: CLUSTER name, fuzzy matching.<br>ClusterType: CLUSTER type, exact match. Values: TKE_MANAGED_CLUSTER (Tencent Cloud Standard CLUSTER), TKE_INDEPENDENT_CLUSTER (Standard CLUSTER Master SELF-maintenance), TKE_SERVERLESS_CLUSTER (SERVERLESS CLUSTER), TKE_EDGE_CLUSTER (EDGE CLUSTER), SELF_BUILT (SELF-BUILT within Tencent Cloud), SELF_BUILT_OTHER (non-Tencent Cloud SELF-BUILT/hybrid cloud).<br>RunStatus: CLUSTER Running status, exact match. Values: Running, Exception, Unknown.<br>AccessedStatus: access status, exact match. Values: AccessedNone (not integrated), AccessedInstalling (is being connected), AccessedException (access Exception), AccessedInstalled (integrated).<br>DefendStatus: protection status, exact match. Values: Enabled (defended), Partial (Partial protection), Disabled (no protection).<br>RiskStatus: risk check status, exact match.<br>RiskLevel: risk level, exact match. Values: CRITICAL, HIGH, MEDIUM, LOW, NONE (no risk).<br>HasHighRisk: only filter clusters with HIGH risk or higher. No value is required. Passing in HasHighRisk takes effect.<br>Region: Region, exact match.<br>OwnerName: owner, fuzzy matching.<br>ClusterAssetIds: CLUSTER asset ID, exact match.<br>ExcludeClusterAssetIds: excluded CLUSTER asset ID, exact exclusion.</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>Exportable fields</p>
        /// </summary>
        [JsonProperty("ExportFields")]
        public string[] ExportFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "ExportFields.", this.ExportFields);
        }
    }
}

