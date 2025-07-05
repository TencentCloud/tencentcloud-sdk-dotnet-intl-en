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

namespace TencentCloud.Eiam.V20210420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListUsersInOrgNodeResponse : AbstractModel
    {
        
        /// <summary>
        /// User information list under the organization sub-node.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgNodeChildUserInfo")]
        public OrgNodeChildUserInfo[] OrgNodeChildUserInfo{ get; set; }

        /// <summary>
        /// Organization node ID, which is globally unique and can contain up to 64 characters.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgNodeId")]
        public string OrgNodeId{ get; set; }

        /// <summary>
        /// User information list.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserInfo")]
        public UserInfo[] UserInfo{ get; set; }

        /// <summary>
        /// Total number of users under the current organization node.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalUserNum")]
        public long? TotalUserNum{ get; set; }

        /// <summary>
        /// Organization ID path.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgNodeIdPath")]
        public string OrgNodeIdPath{ get; set; }

        /// <summary>
        /// Organization name path.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OrgNodeNamePath")]
        public string OrgNodeNamePath{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "OrgNodeChildUserInfo.", this.OrgNodeChildUserInfo);
            this.SetParamSimple(map, prefix + "OrgNodeId", this.OrgNodeId);
            this.SetParamArrayObj(map, prefix + "UserInfo.", this.UserInfo);
            this.SetParamSimple(map, prefix + "TotalUserNum", this.TotalUserNum);
            this.SetParamSimple(map, prefix + "OrgNodeIdPath", this.OrgNodeIdPath);
            this.SetParamSimple(map, prefix + "OrgNodeNamePath", this.OrgNodeNamePath);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

