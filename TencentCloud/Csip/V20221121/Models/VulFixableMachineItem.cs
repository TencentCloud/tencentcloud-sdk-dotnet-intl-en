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

    public class VulFixableMachineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Vulnerability ID list, grouped by SupportAutoFix dimension: repairable vulnerability IDs when SupportAutoFix=1, non-repairable vulnerability IDs when SupportAutoFix=0</p>
        /// </summary>
        [JsonProperty("VulIds")]
        public long?[] VulIds{ get; set; }

        /// <summary>
        /// <p>Host instance ID.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Host name.</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>Host IP address.</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>public IP address</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>OS type<br>Enumeration value:<br>linux: Linux operating system<br>windows: Windows operating system</p>
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// <p>Operating system name.</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>Host online status<br>Enumeration value:<br>ONLINE: online<br>OFFLINE: offline</p>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// <p>Is auto-repair supported<br>Enumeration value:<br>0: No support<br>1: Support</p>
        /// </summary>
        [JsonProperty("SupportAutoFix")]
        public long? SupportAutoFix{ get; set; }

        /// <summary>
        /// <p>Current remediation status<br>Enumeration value:<br>0: Unfixed<br>1: In remediation<br>2: Fix failure<br>3: Repair successful<br>4: Timeout</p>
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// <p>Last repair time<br>Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)</p>
        /// </summary>
        [JsonProperty("LatestFixTime")]
        public string LatestFixTime{ get; set; }

        /// <summary>
        /// <p>Non-repairable reason. Returned when SupportAutoFix is 0.</p>
        /// </summary>
        [JsonProperty("NotFixableReason")]
        public string NotFixableReason{ get; set; }

        /// <summary>
        /// <p>Fix command list, returned when SupportAutoFix is 1</p>
        /// </summary>
        [JsonProperty("FixCommands")]
        public string[] FixCommands{ get; set; }

        /// <summary>
        /// <p>Associated component list</p>
        /// </summary>
        [JsonProperty("Components")]
        public string[] Components{ get; set; }

        /// <summary>
        /// <p>Asset tag list</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>Account AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Paid edition info<br>Enumeration value:<br>BASIC: Basic version<br>PRO: Pro edition<br>ULTIMATE: Flagship edition</p>
        /// </summary>
        [JsonProperty("PayVersion")]
        public string PayVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "SupportAutoFix", this.SupportAutoFix);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "LatestFixTime", this.LatestFixTime);
            this.SetParamSimple(map, prefix + "NotFixableReason", this.NotFixableReason);
            this.SetParamArraySimple(map, prefix + "FixCommands.", this.FixCommands);
            this.SetParamArraySimple(map, prefix + "Components.", this.Components);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "PayVersion", this.PayVersion);
        }
    }
}

