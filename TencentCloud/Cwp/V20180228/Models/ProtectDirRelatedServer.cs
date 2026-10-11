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

    public class ProtectDirRelatedServer : AbstractModel
    {
        
        /// <summary>
        /// Unique ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Server IP address
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Server system
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// Number of associated directories
        /// </summary>
        [JsonProperty("RelateDirNum")]
        public ulong? RelateDirNum{ get; set; }

        /// <summary>
        /// Protection status
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public ulong? ProtectStatus{ get; set; }

        /// <summary>
        /// Protection switch
        /// </summary>
        [JsonProperty("ProtectSwitch")]
        public ulong? ProtectSwitch{ get; set; }

        /// <summary>
        /// Auto recovery switch
        /// </summary>
        [JsonProperty("AutoRestoreSwitchStatus")]
        public ulong? AutoRestoreSwitchStatus{ get; set; }

        /// <summary>
        /// Unique server ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Whether it has been authorized
        /// </summary>
        [JsonProperty("Authorization")]
        public bool? Authorization{ get; set; }

        /// <summary>
        /// Abnormal status
        /// </summary>
        [JsonProperty("Exception")]
        public ulong? Exception{ get; set; }

        /// <summary>
        /// Transition progress
        /// </summary>
        [JsonProperty("Progress")]
        public ulong? Progress{ get; set; }

        /// <summary>
        /// Exception message
        /// </summary>
        [JsonProperty("ExceptionMessage")]
        public string ExceptionMessage{ get; set; }

        /// <summary>
        /// Host Additional Information
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "RelateDirNum", this.RelateDirNum);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "ProtectSwitch", this.ProtectSwitch);
            this.SetParamSimple(map, prefix + "AutoRestoreSwitchStatus", this.AutoRestoreSwitchStatus);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamSimple(map, prefix + "Exception", this.Exception);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "ExceptionMessage", this.ExceptionMessage);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

