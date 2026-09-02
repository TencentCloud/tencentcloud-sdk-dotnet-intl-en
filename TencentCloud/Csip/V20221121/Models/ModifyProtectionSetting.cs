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

    public class ModifyProtectionSetting : AbstractModel
    {
        
        /// <summary>
        /// Unique asset ID.
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// Master switch. Valid values: 0 (disabled) and 1 (enabled).
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// Vulnerability defense switch. Valid values: 0 (disabled) and 1 (enabled).
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// Vulnerability defense mode. Valid values: 0 (standard) and 1 (major event protection).
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// Vulnerability defense action. Valid values: 0 (detection only) and 1 (detection and prevention).
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// In-memory webshell defense switch. Valid values: 0 (disabled) and 1 (enabled).
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// Performance limit switch. Valid values: 0 (disabled) and 1 (enabled).
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// CPU threshold. Value range: 1–99.
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// Memory threshold. Value range: 1–99.
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// Remaining memory threshold.
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// Additional protection. Valid values: 0 (do not inject into processes that will restart) and 1 (inject into processes that will restart).
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VulDefEnable", this.VulDefEnable);
            this.SetParamSimple(map, prefix + "VulDefMode", this.VulDefMode);
            this.SetParamSimple(map, prefix + "VulDefAction", this.VulDefAction);
            this.SetParamSimple(map, prefix + "MemShellDefEnable", this.MemShellDefEnable);
            this.SetParamSimple(map, prefix + "PerformanceLimit", this.PerformanceLimit);
            this.SetParamSimple(map, prefix + "PerformanceLimitCpu", this.PerformanceLimitCpu);
            this.SetParamSimple(map, prefix + "PerformanceLimitMem", this.PerformanceLimitMem);
            this.SetParamSimple(map, prefix + "PerformanceLimitMemAmount", this.PerformanceLimitMemAmount);
            this.SetParamSimple(map, prefix + "SafeInject", this.SafeInject);
        }
    }
}

