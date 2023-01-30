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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortInfo : AbstractModel
    {
        
        /// <summary>
        /// Type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Public IP
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// Server port
        /// </summary>
        [JsonProperty("PublicPort")]
        public ulong? PublicPort{ get; set; }

        /// <summary>
        /// Container port
        /// </summary>
        [JsonProperty("ContainerPort")]
        public ulong? ContainerPort{ get; set; }

        /// <summary>
        /// Container PID
        /// </summary>
        [JsonProperty("ContainerPID")]
        public ulong? ContainerPID{ get; set; }

        /// <summary>
        /// Container name
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// Server ID
        /// </summary>
        [JsonProperty("HostID")]
        public string HostID{ get; set; }

        /// <summary>
        /// Server IP
        /// </summary>
        [JsonProperty("HostIP")]
        public string HostIP{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Monitored address in the container
        /// </summary>
        [JsonProperty("ListenContainer")]
        public string ListenContainer{ get; set; }

        /// <summary>
        /// Monitored address outside the container
        /// </summary>
        [JsonProperty("ListenHost")]
        public string ListenHost{ get; set; }

        /// <summary>
        /// Operating account
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Public IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PublicPort", this.PublicPort);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "ContainerPID", this.ContainerPID);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "HostID", this.HostID);
            this.SetParamSimple(map, prefix + "HostIP", this.HostIP);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ListenContainer", this.ListenContainer);
            this.SetParamSimple(map, prefix + "ListenHost", this.ListenHost);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
        }
    }
}

