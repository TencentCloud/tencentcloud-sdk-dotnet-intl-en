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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddExistedInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Instance list. Spot instance is not supported.
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Detailed information of the instance
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// Enhanced services. This parameter is used to specify whether to enable Cloud Security, Cloud Monitoring and other services. If this parameter is not specified, Cloud Monitor and Cloud Security are enabled by default.
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// Node login information (currently only supports using Password or single KeyIds)
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// When reinstalling the system, you can specify the HostName of the modified instance (when the cluster is in HostName mode, this parameter is required, and the rule name is the same as the [Create CVM Instance](https://intl.cloud.tencent.com/document/product/213/15730?from_cn_redirect=1) API HostName except for uppercase letters not being supported.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Security group to which the instance belongs. This parameter can be obtained from the `sgId` field returned by DescribeSecurityGroups. If this parameter is not specified, the default security group is bound. (Currently, you can only set a single sgId)
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Node pool options
        /// </summary>
        [JsonProperty("NodePool")]
        public NodePoolOption NodePool{ get; set; }

        /// <summary>
        /// Skips the specified verification. Valid values: GlobalRouteCIDRCheck, VpcCniCIDRCheck
        /// </summary>
        [JsonProperty("SkipValidateOptions")]
        public string[] SkipValidateOptions{ get; set; }

        /// <summary>
        /// This API is used to customize the configuration of an instance, which corresponds to the "InstanceIds" one-to-one in sequence. If the InstanceAdvancedSettingsOverrides array is passed in, the default parameter "InstanceAdvancedSettings" will be overwritten. If the parameter InstanceAdvancedSettingsOverrides is not passed in, the parameter "InstanceAdvancedSettings" will take effect for each instance. The array length of "InstanceAdvancedSettingsOverride" should be the same as the array length of "InstanceIds". If its array length is greater than the "InstanceIds" array length, an error will be reported. If its array length is less than the "InstanceIds" array length, the instance without corresponding configuration will use the default configuration.
        /// </summary>
        [JsonProperty("InstanceAdvancedSettingsOverrides")]
        public InstanceAdvancedSettings[] InstanceAdvancedSettingsOverrides{ get; set; }

        /// <summary>
        /// Node image
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "NodePool.", this.NodePool);
            this.SetParamArraySimple(map, prefix + "SkipValidateOptions.", this.SkipValidateOptions);
            this.SetParamArrayObj(map, prefix + "InstanceAdvancedSettingsOverrides.", this.InstanceAdvancedSettingsOverrides);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
        }
    }
}

