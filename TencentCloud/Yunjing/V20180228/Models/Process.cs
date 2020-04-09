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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Process : AbstractModel
    {
        
        /// <summary>
        /// Unique ID.
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// CWP agent `UUID`.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Private IP of server.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Process `Pid`.
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// Process `Ppid`.
        /// </summary>
        [JsonProperty("Ppid")]
        public ulong? Ppid{ get; set; }

        /// <summary>
        /// Process name.
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Process username.
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// OS.
        /// <li>WIN32: Windows 32-bit</li>
        /// <li>WIN64: Windows 64-bit</li>
        /// <li>LINUX32: Linux 32-bit</li>
        /// <li>LINUX64: Linux 64-bit</li>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// Process path.
        /// </summary>
        [JsonProperty("FullPath")]
        public string FullPath{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Ppid", this.Ppid);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "FullPath", this.FullPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

