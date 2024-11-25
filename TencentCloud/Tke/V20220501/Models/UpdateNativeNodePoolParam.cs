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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateNativeNodePoolParam : AbstractModel
    {
        
        /// <summary>
        /// Scaling configuration
        /// </summary>
        [JsonProperty("Scaling")]
        public MachineSetScaling Scaling{ get; set; }

        /// <summary>
        /// Subnet list
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// Security group list
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// Automatic upgrade configuration
        /// </summary>
        [JsonProperty("UpgradeSettings")]
        public MachineUpgradeSettings UpgradeSettings{ get; set; }

        /// <summary>
        /// Whether to enable self-healing capability
        /// </summary>
        [JsonProperty("AutoRepair")]
        public bool? AutoRepair{ get; set; }

        /// <summary>
        /// Change the node billing type
        /// Currently, only pay-as-you-go to monthly subscription is supported:
        /// - PREPAID
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Billing configuration of monthly subscription models
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// System disk configuration
        /// </summary>
        [JsonProperty("SystemDisk")]
        public Disk SystemDisk{ get; set; }

        /// <summary>
        /// Machine system configuration
        /// </summary>
        [JsonProperty("Management")]
        public ManagementConfig Management{ get; set; }

        /// <summary>
        /// Fault self-healing rule name
        /// </summary>
        [JsonProperty("HealthCheckPolicyName")]
        public string HealthCheckPolicyName{ get; set; }

        /// <summary>
        /// hostname pattern string of native node pools
        /// </summary>
        [JsonProperty("HostNamePattern")]
        public string HostNamePattern{ get; set; }

        /// <summary>
        /// kubelet custom parameters
        /// </summary>
        [JsonProperty("KubeletArgs")]
        public string[] KubeletArgs{ get; set; }

        /// <summary>
        /// Predefined script
        /// </summary>
        [JsonProperty("Lifecycle")]
        public LifecycleConfig Lifecycle{ get; set; }

        /// <summary>
        /// Runtime root directory
        /// </summary>
        [JsonProperty("RuntimeRootDir")]
        public string RuntimeRootDir{ get; set; }

        /// <summary>
        /// Whether to enable Auto Scaling (AS)
        /// </summary>
        [JsonProperty("EnableAutoscaling")]
        public bool? EnableAutoscaling{ get; set; }

        /// <summary>
        /// List of models
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// Desired node count
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// Data disk list
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// ssh public key ID array
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Scaling.", this.Scaling);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "UpgradeSettings.", this.UpgradeSettings);
            this.SetParamSimple(map, prefix + "AutoRepair", this.AutoRepair);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamObj(map, prefix + "Management.", this.Management);
            this.SetParamSimple(map, prefix + "HealthCheckPolicyName", this.HealthCheckPolicyName);
            this.SetParamSimple(map, prefix + "HostNamePattern", this.HostNamePattern);
            this.SetParamArraySimple(map, prefix + "KubeletArgs.", this.KubeletArgs);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamSimple(map, prefix + "RuntimeRootDir", this.RuntimeRootDir);
            this.SetParamSimple(map, prefix + "EnableAutoscaling", this.EnableAutoscaling);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
        }
    }
}

