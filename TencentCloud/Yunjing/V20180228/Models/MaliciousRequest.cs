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

    public class MaliciousRequest : AbstractModel
    {
        
        /// <summary>
        /// Record ID.
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
        /// Malicious request domain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Number of malicious requests.
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Process name.
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Record status.
        /// <li>UN_OPERATED: to be processed</li>
        /// <li>TRUSTED: trusted</li>
        /// <li>UN_TRUSTED: untrusted</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Malicious request domain name description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Reference address.
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// Discovery time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Record merge time.
        /// </summary>
        [JsonProperty("MergeTime")]
        public string MergeTime{ get; set; }

        /// <summary>
        /// Process MD5
        /// Value.
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// Executed command line.
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// Process `PID`.
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MergeTime", this.MergeTime);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
        }
    }
}

