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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// Role name, which can contain up to 32 letters, digits, hyphens, and underscores.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// Cluster ID (required)
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Remarks (up to 128 characters).
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Batch binds namespace information.
        /// </summary>
        [JsonProperty("EnvironmentRoleSets")]
        public EnvironmentRoleSet[] EnvironmentRoleSets{ get; set; }

        /// <summary>
        /// Unbinds all namespaces. set to true.
        /// </summary>
        [JsonProperty("UnbindAllEnvironment")]
        public bool? UnbindAllEnvironment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "EnvironmentRoleSets.", this.EnvironmentRoleSets);
            this.SetParamSimple(map, prefix + "UnbindAllEnvironment", this.UnbindAllEnvironment);
        }
    }
}

