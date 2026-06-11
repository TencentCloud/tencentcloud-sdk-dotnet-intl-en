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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetClusterListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID.</p>
        /// </summary>
        [JsonProperty("ClusterID")]
        public string ClusterID{ get; set; }

        /// <summary>
        /// <p>Cluster name.</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster status<br>CSR_RUNNING: Running<br>CSR_EXCEPTION: Exception<br>CSR_DEL: Deleted</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>ID of the bound cluster</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BindRuleID")]
        public string BindRuleID{ get; set; }

        /// <summary>
        /// <p>Binding rule name</p>
        /// </summary>
        [JsonProperty("BindRuleName")]
        public string BindRuleName{ get; set; }

        /// <summary>
        /// <p>ClusterType:<br>CT_TKE: tke cluster;<br>CT_USER_CREATE: user-built cluster;<br>CT_TKE_SERVERLESS: TKE Serverless Cluster;</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>Cluster edition</p>
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// <p>Memory capacity</p>
        /// </summary>
        [JsonProperty("MemLimit")]
        public long? MemLimit{ get; set; }

        /// <summary>
        /// <p>cpu</p>
        /// </summary>
        [JsonProperty("CpuLimit")]
        public long? CpuLimit{ get; set; }

        /// <summary>
        /// <p>Cluster audit switch status:<br>Closed/Closing/CloseFailed/Opened/Opening/OpenFailed</p>
        /// </summary>
        [JsonProperty("ClusterAuditStatus")]
        public string ClusterAuditStatus{ get; set; }

        /// <summary>
        /// <p>Access status:<br>Not connected: AccessedNone<br>Defended: AccessedDefended<br>No protection: AccessedInstalled<br>Partial protection: AccessedPartialDefence<br>Access exception: AccessedException<br>Uninstallation exception: AccessedUninstallException<br>Accessing: AccessedInstalling<br>Uninstalling: AccessedUninstalling</p>
        /// </summary>
        [JsonProperty("AccessedStatus")]
        public string AccessedStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterID", this.ClusterID);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BindRuleID", this.BindRuleID);
            this.SetParamSimple(map, prefix + "BindRuleName", this.BindRuleName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "ClusterAuditStatus", this.ClusterAuditStatus);
            this.SetParamSimple(map, prefix + "AccessedStatus", this.AccessedStatus);
        }
    }
}

