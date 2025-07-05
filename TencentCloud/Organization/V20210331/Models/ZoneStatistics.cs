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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneStatistics : AbstractModel
    {
        
        /// <summary>
        /// User quota.
        /// </summary>
        [JsonProperty("UserQuota")]
        public long? UserQuota{ get; set; }

        /// <summary>
        /// User group quota.
        /// </summary>
        [JsonProperty("GroupQuota")]
        public long? GroupQuota{ get; set; }

        /// <summary>
        /// Permission configuration quota.
        /// </summary>
        [JsonProperty("RoleConfigurationQuota")]
        public long? RoleConfigurationQuota{ get; set; }

        /// <summary>
        /// System policy quota bound to the permission configuration.
        /// </summary>
        [JsonProperty("SystemPolicyPerRoleConfigurationQuota")]
        public long? SystemPolicyPerRoleConfigurationQuota{ get; set; }

        /// <summary>
        /// Number of users.
        /// </summary>
        [JsonProperty("UserCount")]
        public long? UserCount{ get; set; }

        /// <summary>
        /// Number of user groups.
        /// </summary>
        [JsonProperty("GroupCount")]
        public long? GroupCount{ get; set; }

        /// <summary>
        /// Number of permission configurations.
        /// </summary>
        [JsonProperty("RoleConfigurationCount")]
        public long? RoleConfigurationCount{ get; set; }

        /// <summary>
        /// Number of synchronized users.
        /// </summary>
        [JsonProperty("UserProvisioningCount")]
        public long? UserProvisioningCount{ get; set; }

        /// <summary>
        /// Number of synchronized roles.
        /// </summary>
        [JsonProperty("RoleConfigurationSyncCount")]
        public long? RoleConfigurationSyncCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserQuota", this.UserQuota);
            this.SetParamSimple(map, prefix + "GroupQuota", this.GroupQuota);
            this.SetParamSimple(map, prefix + "RoleConfigurationQuota", this.RoleConfigurationQuota);
            this.SetParamSimple(map, prefix + "SystemPolicyPerRoleConfigurationQuota", this.SystemPolicyPerRoleConfigurationQuota);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "GroupCount", this.GroupCount);
            this.SetParamSimple(map, prefix + "RoleConfigurationCount", this.RoleConfigurationCount);
            this.SetParamSimple(map, prefix + "UserProvisioningCount", this.UserProvisioningCount);
            this.SetParamSimple(map, prefix + "RoleConfigurationSyncCount", this.RoleConfigurationSyncCount);
        }
    }
}

