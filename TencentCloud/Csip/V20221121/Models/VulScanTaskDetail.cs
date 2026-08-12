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

    public class VulScanTaskDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Task ID.</p>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// <p>Creator AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>Instance id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Instance name.</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>Public ip address</p>
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// <p>Private ip</p>
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// <p>os</p>
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// <p>Scan status (SUCCESS: Scan complete/successful, OFFLINE: Client offline, TIMEOUT: Scan timeout, FAILED: Scan failed, UNSUPPORTED: Client version too low/Do not support scanning, TERMINATED: Terminated, TERMINATING: Terminating)</p><p>Enumeration value:</p><ul><li>SCANNING: Scanning</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Scan start time</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Scan end time</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Vulnerability count</p>
        /// </summary>
        [JsonProperty("Vuls")]
        public ulong? Vuls{ get; set; }

        /// <summary>
        /// <p>Failure reason</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Vuls", this.Vuls);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

