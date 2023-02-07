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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrometheusInstanceDetailResponse : AbstractModel
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
        /// VPC ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Subnet ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Instance status. Valid values:
        /// 
        /// `1`: Creating
        /// `2`: Running
        /// `3`: Abnormal
        /// `4`: Rebooting
        /// `5`: Terminating
        /// `6`: Service suspended
        /// `8`: Suspending service for overdue payment
        /// `9`: Service suspended for overdue payment
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// Billing status
        /// 
        /// `1`: Normal
        /// `2`: Expired
        /// `3`: Terminated
        /// `4`: Assigning
        /// `5`: Failed to assign
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public long? ChargeStatus{ get; set; }

        /// <summary>
        /// Whether Grafana is enabled
        /// `0`: Disabled
        /// `1`: Enabled
        /// </summary>
        [JsonProperty("EnableGrafana")]
        public long? EnableGrafana{ get; set; }

        /// <summary>
        /// Grafana dashboard URL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrafanaURL")]
        public string GrafanaURL{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// 
        /// `2`: Monthly subscription
        /// `3`: Pay-as-you-go
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }

        /// <summary>
        /// Specification name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// Storage period
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataRetentionTime")]
        public long? DataRetentionTime{ get; set; }

        /// <summary>
        /// Expiration time of the purchased instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Auto-renewal flag
        /// 
        /// `0`: Auto-renewal not enabled
        /// `1`: Auto-renewal enabled
        /// `2`: Auto-renewal prohibited
        /// `-1`: Invalid
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "EnableGrafana", this.EnableGrafana);
            this.SetParamSimple(map, prefix + "GrafanaURL", this.GrafanaURL);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "DataRetentionTime", this.DataRetentionTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

