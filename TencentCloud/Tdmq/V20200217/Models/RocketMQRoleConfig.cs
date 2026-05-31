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

    public class RocketMQRoleConfig : AbstractModel
    {
        
        /// <summary>
        /// Role name, corresponding to the secret key.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// accessKey
        /// </summary>
        [JsonProperty("RoleToken")]
        public string RoleToken{ get; set; }

        /// <summary>
        /// Namespace
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// Role permission
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Permission type. Permissions are granted by cluster by default. Cluster: cluster level; TopicAndGroup: topic/consumer group level.
        /// </summary>
        [JsonProperty("PermType")]
        public string PermType{ get; set; }

        /// <summary>
        /// Permission configuration in the topic and group dimensions.
        /// </summary>
        [JsonProperty("DetailedRolePerms")]
        public DetailedRolePerm[] DetailedRolePerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RoleToken", this.RoleToken);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PermType", this.PermType);
            this.SetParamArrayObj(map, prefix + "DetailedRolePerms.", this.DetailedRolePerms);
        }
    }
}

