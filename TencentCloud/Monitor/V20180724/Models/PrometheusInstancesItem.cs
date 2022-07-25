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

    public class PrometheusInstancesItem : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance billing mode. Valid values:
        /// <ul>
        /// <li>2: Monthly subscription</li>
        /// <li>3: Pay-as-you-go</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public long? InstanceChargeType{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// AZ
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

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
        /// Storage period
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataRetentionTime")]
        public long? DataRetentionTime{ get; set; }

        /// <summary>
        /// Instance status. Valid values:
        /// <ul>
        /// <li>1: Creating</li>
        /// <li>2: Running</li>
        /// <li>3: Abnormal</li>
        /// <li>4: Rebooting</li>
        /// <li>5: Terminating</li>
        /// <li>6: Service suspended</li>
        /// <li>8: Suspending service for overdue payment</li>
        /// <li>9: Service suspended for overdue payment</li>
        /// </ul>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public long? InstanceStatus{ get; set; }

        /// <summary>
        /// Grafana dashboard URL
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrafanaURL")]
        public string GrafanaURL{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Whether Grafana is enabled
        /// <li>0: Disabled</li>
        /// <li>1: Enabled</li>
        /// </summary>
        [JsonProperty("EnableGrafana")]
        public long? EnableGrafana{ get; set; }

        /// <summary>
        /// Instance IPv4 address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IPv4Address")]
        public string IPv4Address{ get; set; }

        /// <summary>
        /// List of tags associated with the instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public PrometheusTag[] TagSpecification{ get; set; }

        /// <summary>
        /// Expiration time of the purchased instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Billing status
        /// <ul>
        /// <li>1: Normal</li>
        /// <li>2: Expired</li>
        /// <li>3: Terminated</li>
        /// <li>4: Assigning</li>
        /// <li>5: Assignment failed</li>
        /// </ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public long? ChargeStatus{ get; set; }

        /// <summary>
        /// Specification name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// Auto-renewal flag
        /// <ul>
        /// <li>0: Auto-renewal not enabled</li>
        /// <li>1: Auto-renewal enabled</li>
        /// <li>2: Auto-renewal prohibited</li>
        /// <li>-1: Invalid</ii>
        /// </ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// Expiring soon
        /// <ul>
        /// <li>0: No</li>
        /// <li>1: Yes</li>
        /// </ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsNearExpire")]
        public long? IsNearExpire{ get; set; }

        /// <summary>
        /// The token required for data writing
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AuthToken")]
        public string AuthToken{ get; set; }

        /// <summary>
        /// Prometheus remote write address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RemoteWrite")]
        public string RemoteWrite{ get; set; }

        /// <summary>
        /// Prometheus HTTP API root address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ApiRootPath")]
        public string ApiRootPath{ get; set; }

        /// <summary>
        /// Proxy address
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyAddress")]
        public string ProxyAddress{ get; set; }

        /// <summary>
        /// Grafana status
        /// <ul>
        /// <li>1: Creating</li>
        /// <li>2: Running</li>
        /// <li>3: Abnormal</li>
        /// <li>4: Restarting</li>
        /// <li>5: Terminating</li>
        /// <li>6: Service suspended</li>
        /// <li>7: Deleted</li>
        /// </ul>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrafanaStatus")]
        public long? GrafanaStatus{ get; set; }

        /// <summary>
        /// Grafana IP allowlist, where IPs are separated by comma.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrafanaIpWhiteList")]
        public string GrafanaIpWhiteList{ get; set; }

        /// <summary>
        /// Instance authorization information
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Grant")]
        public PrometheusInstanceGrantInfo Grant{ get; set; }

        /// <summary>
        /// ID of the bound Grafana instance
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("GrafanaInstanceId")]
        public string GrafanaInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DataRetentionTime", this.DataRetentionTime);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "GrafanaURL", this.GrafanaURL);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "EnableGrafana", this.EnableGrafana);
            this.SetParamSimple(map, prefix + "IPv4Address", this.IPv4Address);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "IsNearExpire", this.IsNearExpire);
            this.SetParamSimple(map, prefix + "AuthToken", this.AuthToken);
            this.SetParamSimple(map, prefix + "RemoteWrite", this.RemoteWrite);
            this.SetParamSimple(map, prefix + "ApiRootPath", this.ApiRootPath);
            this.SetParamSimple(map, prefix + "ProxyAddress", this.ProxyAddress);
            this.SetParamSimple(map, prefix + "GrafanaStatus", this.GrafanaStatus);
            this.SetParamSimple(map, prefix + "GrafanaIpWhiteList", this.GrafanaIpWhiteList);
            this.SetParamObj(map, prefix + "Grant.", this.Grant);
            this.SetParamSimple(map, prefix + "GrafanaInstanceId", this.GrafanaInstanceId);
        }
    }
}

