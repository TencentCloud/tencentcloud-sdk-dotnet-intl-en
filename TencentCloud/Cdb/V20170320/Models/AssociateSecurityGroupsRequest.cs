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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociateSecurityGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// Security group ID, which can be obtained through the [DescribeDBSecurityGroups](https://www.tencentcloud.com/document/api/236/15854?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("SecurityGroupId")]
        public string SecurityGroupId{ get; set; }

        /// <summary>
        /// Instance ID list, an array consisting of one or more instance IDs. You can obtain it through the [DescribeDBInstances](https://www.tencentcloud.com/document/product/236/15872?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// This parameter takes effect only when the IDs of read-only replicas are passed in. If this parameter is set to `False` or left empty, the security group will be bound to the RO groups of these read-only replicas. If this parameter is set to `True`, the security group will be bound to the read-only replicas themselves.
        /// </summary>
        [JsonProperty("ForReadonlyInstance")]
        public bool? ForReadonlyInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecurityGroupId", this.SecurityGroupId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "ForReadonlyInstance", this.ForReadonlyInstance);
        }
    }
}

