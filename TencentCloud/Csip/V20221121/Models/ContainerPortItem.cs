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

    public class ContainerPortItem : AbstractModel
    {
        
        /// <summary>
        /// Name of the listening process
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Listening port in container
        /// </summary>
        [JsonProperty("ContainerPort")]
        public long? ContainerPort{ get; set; }

        /// <summary>
        /// Process running user
        /// </summary>
        [JsonProperty("RunAs")]
        public string RunAs{ get; set; }

        /// <summary>
        /// Containerized process ID
        /// </summary>
        [JsonProperty("ContainerPID")]
        public long? ContainerPID{ get; set; }

        /// <summary>
        /// Host private IP address
        /// </summary>
        [JsonProperty("HostInnerIP")]
        public string HostInnerIP{ get; set; }

        /// <summary>
        /// Public network IP address of the host machine.
        /// </summary>
        [JsonProperty("HostPublicIP")]
        public string HostPublicIP{ get; set; }

        /// <summary>
        /// Host machine mapping port
        /// </summary>
        [JsonProperty("PublicPort")]
        public long? PublicPort{ get; set; }

        /// <summary>
        /// Network protocol type.
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ContainerPort", this.ContainerPort);
            this.SetParamSimple(map, prefix + "RunAs", this.RunAs);
            this.SetParamSimple(map, prefix + "ContainerPID", this.ContainerPID);
            this.SetParamSimple(map, prefix + "HostInnerIP", this.HostInnerIP);
            this.SetParamSimple(map, prefix + "HostPublicIP", this.HostPublicIP);
            this.SetParamSimple(map, prefix + "PublicPort", this.PublicPort);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
        }
    }
}

