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

    public class SuperNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance name
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Auto-renewal label
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Resource type
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// CPU specification of nodes (unit: cores).
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CPU")]
        public float? CPU{ get; set; }

        /// <summary>
        /// Total number of CPUs of Pods on nodes (unit: cores).
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UsedCPU")]
        public float? UsedCPU{ get; set; }

        /// <summary>
        /// Memory specification of nodes (unit: Gi).
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// Total memory of Pods on nodes (unit: Gi).
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UsedMemory")]
        public float? UsedMemory{ get; set; }

        /// <summary>
        /// Availability zone
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Unique VPC ID
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet unique ID
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Effective time
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ActiveAt")]
        public string ActiveAt{ get; set; }

        /// <summary>
        /// Expiration time
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// Maximum schedulable CPU specification for a single Pod
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MaxCPUScheduledPod")]
        public long? MaxCPUScheduledPod{ get; set; }

        /// <summary>
        /// Instance attributes
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceAttribute")]
        public string InstanceAttribute{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "UsedCPU", this.UsedCPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "UsedMemory", this.UsedMemory);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ActiveAt", this.ActiveAt);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "MaxCPUScheduledPod", this.MaxCPUScheduledPod);
            this.SetParamSimple(map, prefix + "InstanceAttribute", this.InstanceAttribute);
        }
    }
}

