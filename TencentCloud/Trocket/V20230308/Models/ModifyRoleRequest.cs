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

    public class ModifyRoleRequest : AbstractModel
    {
        
        /// <summary>
        /// TDMQ RocketMQ instance ID. It can be obtained from the API [DescribeFusionInstanceList](https://www.tencentcloud.comom/document/api/1493/106745?from_cn_redirect=1) or the console.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Role name. It can be obtained from [RoleItem](https://www.tencentcloud.comom/document/api/1493/96031?from_cn_redirect=1#RoleItem) returned by the API [DescribeRoleList](https://www.tencentcloud.comom/document/api/1493/98862?from_cn_redirect=1) or from the console.
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

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
        /// Specifies the types of permissions. the default is to authorize by Cluster (Cluster: at the Cluster level; TopicAndGroup: topic and consumer group dimension).
        /// </summary>
        [JsonProperty("PermType")]
        public string PermType{ get; set; }

        /// <summary>
        /// Remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Permission configuration in the topic/group dimension. It is required when the permission type parameter is set to TopicAndGroup.
        /// </summary>
        [JsonProperty("DetailedPerms")]
        public DetailedRolePerm[] DetailedPerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "PermRead", this.PermRead);
            this.SetParamSimple(map, prefix + "PermWrite", this.PermWrite);
            this.SetParamSimple(map, prefix + "PermType", this.PermType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "DetailedPerms.", this.DetailedPerms);
        }
    }
}

