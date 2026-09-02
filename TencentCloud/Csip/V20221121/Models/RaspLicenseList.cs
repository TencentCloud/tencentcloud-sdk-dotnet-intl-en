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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RaspLicenseList : AbstractModel
    {
        
        /// <summary>
        /// <p>Unique machine ID</p>
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Public IP Address</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>Private IP address.</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>Cloud tag information</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// <p>Protection edition information</p><ul><li>CriticalProtection Prioritized Protection package</li><li>Pro Container security-Pro Edition</li><li>Ultimate CWP-Flagship Edition</li></ul>
        /// </summary>
        [JsonProperty("ProtectionVersion")]
        public string[] ProtectionVersion{ get; set; }

        /// <summary>
        /// <p>Protection setting</p><ul><li>0 No configuration</li><li>1 Configured</li></ul>
        /// </summary>
        [JsonProperty("ConfigurationSetting")]
        public ulong? ConfigurationSetting{ get; set; }

        /// <summary>
        /// <p>Master switch</p><ul><li>0 Not enabled</li><li>1 Enabled</li></ul>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// <p>Vulnerability defense switch</p><ul><li>0 Not enabled</li><li>1 Enable</li></ul>
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// <p>Vulnerability defense mode</p><ul><li>0: standard</li><li>1: major event protection</li></ul>
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// <p>Vulnerability defense action</p><ul><li>0: Detection only</li><li>1: Detection and prevention</li></ul>
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// <p>Java Webshell Defense switch</p><ul><li>0 Not enabled</li><li>1 Enable</li></ul>
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// <p>More protection</p><ul><li>0: Do not inject into processes that will restart </li><li>1: Inject into processes that will restart</li></ul>
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }

        /// <summary>
        /// <p>Performance threshold configuration switch</p><ul><li>0 Not enabled</li><li>1 Enabled</li></ul>
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// <p>CPU threshold. Value range: 1–99.</p>
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// <p>Memory threshold. Value range: 1–99</p>
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// <p>Remaining memory threshold</p>
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// <p>Plug-in status</p><ul><li>0 Used normally</li><li>1 Anomaly exists</li><li>2 Inactive</li></ul>
        /// </summary>
        [JsonProperty("RaspException")]
        public ulong? RaspException{ get; set; }

        /// <summary>
        /// <p>Latest update time.</p>
        /// </summary>
        [JsonProperty("LatestUpdateTime")]
        public string LatestUpdateTime{ get; set; }

        /// <summary>
        /// <p>Cluster ID, available only for container assets</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>Cluster name, only available for container assets</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Order information</p>
        /// </summary>
        [JsonProperty("OrderDetail")]
        public OrderDetail OrderDetail{ get; set; }

        /// <summary>
        /// <p>Whether unbinding is allowed. false: not allowed; true: permission</p>
        /// </summary>
        [JsonProperty("IsUnBind")]
        public bool? IsUnBind{ get; set; }

        /// <summary>
        /// <p>uuid: unique ID of a machine. It has a value only when AssetType is CWP.</p>
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// <p>No injection/failure reason</p><p>Default value: empty</p><p>Values are available only if injection fails</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ProtectionVersion.", this.ProtectionVersion);
            this.SetParamSimple(map, prefix + "ConfigurationSetting", this.ConfigurationSetting);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VulDefEnable", this.VulDefEnable);
            this.SetParamSimple(map, prefix + "VulDefMode", this.VulDefMode);
            this.SetParamSimple(map, prefix + "VulDefAction", this.VulDefAction);
            this.SetParamSimple(map, prefix + "MemShellDefEnable", this.MemShellDefEnable);
            this.SetParamSimple(map, prefix + "SafeInject", this.SafeInject);
            this.SetParamSimple(map, prefix + "PerformanceLimit", this.PerformanceLimit);
            this.SetParamSimple(map, prefix + "PerformanceLimitCpu", this.PerformanceLimitCpu);
            this.SetParamSimple(map, prefix + "PerformanceLimitMem", this.PerformanceLimitMem);
            this.SetParamSimple(map, prefix + "PerformanceLimitMemAmount", this.PerformanceLimitMemAmount);
            this.SetParamSimple(map, prefix + "RaspException", this.RaspException);
            this.SetParamSimple(map, prefix + "LatestUpdateTime", this.LatestUpdateTime);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "OrderDetail.", this.OrderDetail);
            this.SetParamSimple(map, prefix + "IsUnBind", this.IsUnBind);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

