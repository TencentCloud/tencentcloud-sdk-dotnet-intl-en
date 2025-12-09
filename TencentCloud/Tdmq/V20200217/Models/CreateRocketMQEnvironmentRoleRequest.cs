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

    public class CreateRocketMQEnvironmentRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Role name.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// Authorization item, which can contain a non-empty character array of up to 2 items including produce and consume.
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// Required field, cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Permission configuration for topic and group dimensions.
        /// </summary>
        [JsonProperty("DetailedPerms")]
        public DetailedRolePerm[] DetailedPerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArrayObj(map, prefix + "DetailedPerms.", this.DetailedPerms);
        }
    }
}

