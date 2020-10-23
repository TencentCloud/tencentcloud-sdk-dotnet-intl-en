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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvData : AbstractModel
    {
        
        /// <summary>
        /// CVM instance type, which cannot be present together with InstanceTypes or InstanceTypeOptions at the same time.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// CVM image ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Information of the instance's system disk configuration
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// Information of the instance's data disk configuration
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// Information of the VPC configuration, which cannot be specified together with Zones and VirtualPrivateClouds.
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// Information of the public network bandwidth configuration
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// CVM instance display name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance login settings
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// Security group of the instance
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Enhanced service. This parameter is used to specify whether to enable Cloud Security, Cloud Monitoring and other services. If this parameter is not specified, Cloud Monitoring and Cloud Security will be enabled by default.
        /// </summary>
        [JsonProperty("EnhancedService")]
        public EnhancedService EnhancedService{ get; set; }

        /// <summary>
        /// CVM instance billing method <br><li>POSTPAID_BY_HOUR: pay-as-you-go by the hour <br><li>SPOTPAID: bidding <br>Default value: POSTPAID_BY_HOUR.
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Market-related options of the instance, such as parameters related to spot instance
        /// </summary>
        [JsonProperty("InstanceMarketOptions")]
        public InstanceMarketOptionsRequest InstanceMarketOptions{ get; set; }

        /// <summary>
        /// List of CVM instance types, which cannot be present together with InstanceType or InstanceTypeOptions at the same time. After the field is specified, the system will try creating compute nodes in the order of the models until successful creation and then stop the traversal process. Up to 10 models are supported.
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// CVM instance model configuration, which cannot be present together with InstanceType or InstanceTypes at the same time.
        /// </summary>
        [JsonProperty("InstanceTypeOptions")]
        public InstanceTypeOptions InstanceTypeOptions{ get; set; }

        /// <summary>
        /// List of availability zones (creation of CVM instances across availability zones is supported), which cannot be specified together with VirtualPrivateCloud or VirtualPrivateClouds at the same time.
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// List of VPCs (creation of CVM instances across VPCs is supported), which cannot be specified together with VirtualPrivateCloud or Zones at the same time.
        /// </summary>
        [JsonProperty("VirtualPrivateClouds")]
        public VirtualPrivateCloud[] VirtualPrivateClouds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "EnhancedService.", this.EnhancedService);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceMarketOptions.", this.InstanceMarketOptions);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamObj(map, prefix + "InstanceTypeOptions.", this.InstanceTypeOptions);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "VirtualPrivateClouds.", this.VirtualPrivateClouds);
        }
    }
}

