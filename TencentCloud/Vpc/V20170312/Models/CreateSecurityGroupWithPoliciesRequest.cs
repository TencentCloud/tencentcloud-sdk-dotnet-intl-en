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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSecurityGroupWithPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// Security group can be named freely, but cannot exceed 60 characters.
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// The remarks for the security group. The maximum length is 100 characters.
        /// </summary>
        [JsonProperty("GroupDescription")]
        public string GroupDescription{ get; set; }

        /// <summary>
        /// Project ID. Default value: 0. You can query it on the <a href="https://console.cloud.tencent.com/project">project management page</a> of the Tencent Cloud console.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Security group policy set.
        /// </summary>
        [JsonProperty("SecurityGroupPolicySet")]
        public SecurityGroupPolicySet SecurityGroupPolicySet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupDescription", this.GroupDescription);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamObj(map, prefix + "SecurityGroupPolicySet.", this.SecurityGroupPolicySet);
        }
    }
}

