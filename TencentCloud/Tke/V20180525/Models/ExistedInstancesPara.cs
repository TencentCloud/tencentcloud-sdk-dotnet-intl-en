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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExistedInstancesPara : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Additional parameter information required for the instance (currently not supported by the backend, we will implement this in future versions)
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// Enhanced services. This parameter is used to specify whether to enable Cloud Security, Cloud Monitor and other services. If this parameter is not specified, Cloud Monitor and Cloud Security are enabled by default.
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// Node login information (currently only supports using Password or single KeyIds)
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// Security group to which the instance belongs. This parameter can be obtained from the sgId field in the returned values of DescribeSecurityGroups. If this parameter is not specified, the default security group is bound. (Currently, you can only set a single sgId)
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// When reinstalling the system, you can specify the HostName of the modified instance (when the cluster is in HostName mode, this parameter is required, and the rule name is the same as the [Create CVM Instance](https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1) API HostName except for uppercase letters not being supported.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
        }
    }
}

