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

    public class NativeNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Node name
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Machine status
        /// </summary>
        [JsonProperty("MachineState")]
        public string MachineState{ get; set; }

        /// <summary>
        /// Machine availability zone
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Node billing type. PREPAID: Monthly subscription; POSTPAID_BY_HOUR: Pay-as-you-go (default);
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Machine login status
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("LoginStatus")]
        public string LoginStatus{ get; set; }

        /// <summary>
        /// Whether to enable scale-in protection
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("IsProtectedFromScaleIn")]
        public bool? IsProtectedFromScaleIn{ get; set; }

        /// <summary>
        /// Machine name
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// Number of CPU cores (unit: cores)
        /// </summary>
        [JsonProperty("CPU")]
        public ulong? CPU{ get; set; }

        /// <summary>
        /// Number of GPU cores (unit: cores)
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GPU")]
        public ulong? GPU{ get; set; }

        /// <summary>
        /// Auto-renewal label
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Node billing mode (deprecated)
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Node memory capacity (unit: `GB`)
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Public network bandwidth configuration
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// Model family
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// Node private network IP
        /// </summary>
        [JsonProperty("LanIp")]
        public string LanIp{ get; set; }

        /// <summary>
        /// Model
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Billing expiration time of monthly subscription nodes
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// Security group list
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SecurityGroupIDs")]
        public string[] SecurityGroupIDs{ get; set; }

        /// <summary>
        /// VPC unique ID
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
        /// OS name
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OsImage")]
        public string OsImage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineState", this.MachineState);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "LoginStatus", this.LoginStatus);
            this.SetParamSimple(map, prefix + "IsProtectedFromScaleIn", this.IsProtectedFromScaleIn);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "GPU", this.GPU);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "LanIp", this.LanIp);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIDs.", this.SecurityGroupIDs);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "OsImage", this.OsImage);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}

