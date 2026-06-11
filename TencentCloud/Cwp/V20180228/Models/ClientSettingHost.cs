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

    public class ClientSettingHost : AbstractModel
    {
        
        /// <summary>
        /// Record ID of the corresponding database host
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Host name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Public IP address
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// Private IP address
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// Host QUUID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// Host status
        /// <li>OFFLINE: Offline</li>
        /// <li>ONLINE: Online</li>
        /// <li>SHUTDOWN: Shut down</li>
        /// <li>UNINSTALLED: Unprotected</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// ins-sad143
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Region information
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// Additional information
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// <li>0: disabled</li>
        /// <li>1:  Enable</li>
        /// <li>2: Enabled </li>
        /// <li>3: Turning off</li>
        /// <li>9: not set</li>
        /// </summary>
        [JsonProperty("FunctionStatus")]
        public ulong? FunctionStatus{ get; set; }

        /// <summary>
        /// The following fixed values require special handling by the frontend, other failures can be shown directly.
        /// 1. UNINSTALLED -- Not installed
        /// 2. NEED_UPGRADE -- Upgrade required
        /// 3. NOT_RUNNING -- Shutdown
        /// 4. NO_PASSWORD -- Password login is not enabled and cannot be enabled.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Reason for failure
        /// </summary>
        [JsonProperty("MessageDesc")]
        public string MessageDesc{ get; set; }

        /// <summary>
        /// Instance status
        /// <li>RUNNING: running</li>
        /// <li>STOPPED: Shut down</li>
        /// <li>EXPIRED: To be recycled</li>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "FunctionStatus", this.FunctionStatus);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "MessageDesc", this.MessageDesc);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
        }
    }
}

