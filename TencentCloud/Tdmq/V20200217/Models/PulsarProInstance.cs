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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PulsarProInstance : AbstractModel
    {
        
        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance version
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public string InstanceVersion{ get; set; }

        /// <summary>
        /// Instance status. Valid values: `0` (Creating), `1` (Normal), `2` (Isolated), `3` (Terminated), `4` (Abnormal), `5` (Delivery failed), `6` (Adjusting configuration), `7` (Configuration adjustment failed).
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Instance specification name
        /// </summary>
        [JsonProperty("ConfigDisplay")]
        public string ConfigDisplay{ get; set; }

        /// <summary>
        /// Peak TPS
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// Storage capacity in GB
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// Instance expiration time in milliseconds
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// Renewal mode. Valid values: `0` (Manual renewal, which is the default mode), `1` (Auto-renewal), `2` (Manual renewal, which is specified by users).
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Payment mode. Valid values: `0` (Pay-as-you-go), `1` (Monthly subscription).
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Instance specification ID
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// Elastic TPS beyond the specification
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ScalableTps")]
        public ulong? ScalableTps{ get; set; }

        /// <summary>
        /// VPC ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Peak bandwidth in Mbps
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ConfigDisplay", this.ConfigDisplay);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "ScalableTps", this.ScalableTps);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
        }
    }
}

