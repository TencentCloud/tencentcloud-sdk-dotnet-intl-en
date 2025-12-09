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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoleItem : AbstractModel
    {
        
        /// <summary>
        /// Role name.
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// Whether to enable consumption.
        /// </summary>
        [JsonProperty("PermRead")]
        public bool? PermRead{ get; set; }

        /// <summary>
        /// Whether to enable production
        /// </summary>
        [JsonProperty("PermWrite")]
        public bool? PermWrite{ get; set; }

        /// <summary>
        /// Access Key
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Secret Key
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Role creation time. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// Role update time. **It is a Unix timestamp (ms).**
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public long? ModifiedTime{ get; set; }

        /// <summary>
        /// Specifies the types of permissions. the default is to authorize by Cluster (Cluster: at the Cluster level; TopicAndGroup: topic and consumer group level).
        /// </summary>
        [JsonProperty("PermType")]
        public string PermType{ get; set; }

        /// <summary>
        /// Permission configuration in Topic and Group dimension.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DetailedRolePerms")]
        public DetailedRolePerm[] DetailedRolePerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "PermRead", this.PermRead);
            this.SetParamSimple(map, prefix + "PermWrite", this.PermWrite);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "PermType", this.PermType);
            this.SetParamArrayObj(map, prefix + "DetailedRolePerms.", this.DetailedRolePerms);
        }
    }
}

