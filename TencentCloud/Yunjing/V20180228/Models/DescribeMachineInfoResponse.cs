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

    public class DescribeMachineInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// Server IP.
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// Days under protection by CWP
        /// </summary>
        [JsonProperty("ProtectDays")]
        public ulong? ProtectDays{ get; set; }

        /// <summary>
        /// OS.
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// Server name.
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// Status.
        /// <li>ONLINE: online</li>
        /// <li>OFFLINE: offline</li>
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// Unique ID of CVM or BM instance.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Public IP of server.
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// CVM or BM instance `Uuid`.
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// CWP agent `Uuid`.
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// Whether CWP Pro is activated.
        /// <li>true: yes</li>
        /// <li>false: no</li>
        /// </summary>
        [JsonProperty("IsProVersion")]
        public bool? IsProVersion{ get; set; }

        /// <summary>
        /// CWP Pro activation time.
        /// </summary>
        [JsonProperty("ProVersionOpenDate")]
        public string ProVersionOpenDate{ get; set; }

        /// <summary>
        /// Server type.
        /// <li>CVM: CVM</li>
        /// <li>BM: BM</li>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// Server region, such as ap-guangzhou or ap-shanghai
        /// </summary>
        [JsonProperty("MachineRegion")]
        public string MachineRegion{ get; set; }

        /// <summary>
        /// Server status.
        /// <li>POSTPAY: post-paid, i.e., pay-as-you-go </li>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// Number of trojans left for free scan.
        /// </summary>
        [JsonProperty("FreeMalwaresLeft")]
        public ulong? FreeMalwaresLeft{ get; set; }

        /// <summary>
        /// Number of vulnerability left for free scan.
        /// </summary>
        [JsonProperty("FreeVulsLeft")]
        public ulong? FreeVulsLeft{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "ProtectDays", this.ProtectDays);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "IsProVersion", this.IsProVersion);
            this.SetParamSimple(map, prefix + "ProVersionOpenDate", this.ProVersionOpenDate);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "MachineRegion", this.MachineRegion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "FreeMalwaresLeft", this.FreeMalwaresLeft);
            this.SetParamSimple(map, prefix + "FreeVulsLeft", this.FreeVulsLeft);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

