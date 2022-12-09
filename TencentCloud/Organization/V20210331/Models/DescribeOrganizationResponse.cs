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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOrganizationResponse : AbstractModel
    {
        
        /// <summary>
        /// Organization ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgId")]
        public long? OrgId{ get; set; }

        /// <summary>
        /// Creator UIN.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostUin")]
        public long? HostUin{ get; set; }

        /// <summary>
        /// Creator name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// Organization type.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgType")]
        public long? OrgType{ get; set; }

        /// <summary>
        /// Whether the member is the organization admin. Valid values: `true` (yes); `false` (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsManager")]
        public bool? IsManager{ get; set; }

        /// <summary>
        /// Policy type. Valid values: `Financial` (finance management).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgPolicyType")]
        public string OrgPolicyType{ get; set; }

        /// <summary>
        /// Policy name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgPolicyName")]
        public string OrgPolicyName{ get; set; }

        /// <summary>
        /// List of member financial permissions.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgPermission")]
        public OrgPermission[] OrgPermission{ get; set; }

        /// <summary>
        /// Organization root node ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RootNodeId")]
        public long? RootNodeId{ get; set; }

        /// <summary>
        /// Organization creation time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Member joining time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("JoinTime")]
        public string JoinTime{ get; set; }

        /// <summary>
        /// Whether the member is allowed to leave. Valid values: `Allow`, `Denied`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAllowQuit")]
        public string IsAllowQuit{ get; set; }

        /// <summary>
        /// Payer UIN.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayUin")]
        public string PayUin{ get; set; }

        /// <summary>
        /// Payer name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PayName")]
        public string PayName{ get; set; }

        /// <summary>
        /// Whether the member is the trusted service admin. Valid values: `true` (yes); `false` (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAssignManager")]
        public bool? IsAssignManager{ get; set; }

        /// <summary>
        /// Whether the member is the verified entity admin. Valid values: `true` (yes); `false` (no).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsAuthManager")]
        public bool? IsAuthManager{ get; set; }

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
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "HostUin", this.HostUin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "OrgType", this.OrgType);
            this.SetParamSimple(map, prefix + "IsManager", this.IsManager);
            this.SetParamSimple(map, prefix + "OrgPolicyType", this.OrgPolicyType);
            this.SetParamSimple(map, prefix + "OrgPolicyName", this.OrgPolicyName);
            this.SetParamArrayObj(map, prefix + "OrgPermission.", this.OrgPermission);
            this.SetParamSimple(map, prefix + "RootNodeId", this.RootNodeId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "JoinTime", this.JoinTime);
            this.SetParamSimple(map, prefix + "IsAllowQuit", this.IsAllowQuit);
            this.SetParamSimple(map, prefix + "PayUin", this.PayUin);
            this.SetParamSimple(map, prefix + "PayName", this.PayName);
            this.SetParamSimple(map, prefix + "IsAssignManager", this.IsAssignManager);
            this.SetParamSimple(map, prefix + "IsAuthManager", this.IsAuthManager);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

