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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RaspLicenseList : AbstractModel
    {
        
        /// <summary>
        /// Machine unique ID
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// Instance name
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// Cloud Tag Information
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// Version information
        /// -Prioritized Protection package
        /// -Container Security - Pro Edition
        /// -CWP - Flagship Edition
        /// </summary>
        [JsonProperty("ProtectionVersion")]
        public string[] ProtectionVersion{ get; set; }

        /// <summary>
        /// Protection setting
        /// -0 unconfigured
        /// -Configured
        /// </summary>
        [JsonProperty("ConfigurationSetting")]
        public ulong? ConfigurationSetting{ get; set; }

        /// <summary>
        /// Master switch
        /// -0 Not enabled
        /// - 1: enabled.
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// Vulnerability defense switch
        /// -0 Not enabled
        /// - 1: enabled.
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// Vulnerability defense mode
        /// -0 Standard
        /// -1. Major Event Support
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// Vulnerability defense action
        /// -0 Detect only
        /// -Detect + defend
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// Java Webshell Defense switch
        /// -0 Not enabled
        /// - 1: enabled.
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// More protection
        /// -0 Do not inject processes that will restart 
        /// -Inject a process that will restart
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }

        /// <summary>
        /// Performance threshold configuration switch
        /// -0 Not enabled
        /// - 1: enabled.
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// CPU threshold, Value 1-99
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// Memory threshold, value 1-99
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// Memory remaining threshold
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// Plug-in status
        /// -0 Use normally
        /// -1: Existence of anomalies
        /// -2 inactive
        /// </summary>
        [JsonProperty("RaspException")]
        public ulong? RaspException{ get; set; }

        /// <summary>
        /// Latest update time
        /// </summary>
        [JsonProperty("LatestUpdateTime")]
        public string LatestUpdateTime{ get; set; }

        /// <summary>
        /// Cluster ID, only valid for container assets
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster name, only container assets have values
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Order information
        /// </summary>
        [JsonProperty("OrderDetail")]
        public OrderDetail OrderDetail{ get; set; }

        /// <summary>
        /// Whether unbinding is allowed: false - not allowed, true - allowed.
        /// </summary>
        [JsonProperty("IsUnBind")]
        public bool? IsUnBind{ get; set; }

        /// <summary>
        /// uuid. Unique ID of the machine. Only valid when AssetType = CWP.
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// No injection/Failure reason of injection
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

