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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyClusterMachineRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>Node name list.</p>
        /// </summary>
        [JsonProperty("MachineNames")]
        public string[] MachineNames{ get; set; }

        /// <summary>
        /// <p>display name of the machine</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>System disk C</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public Disk SystemDisk{ get; set; }

        /// <summary>
        /// <p>Security group list</p>
        /// </summary>
        [JsonProperty("SecurityGroupIDs")]
        public string[] SecurityGroupIDs{ get; set; }

        /// <summary>
        /// <p>Node prepayment information.</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>Change node billing type</p><p>Enumeration value:</p><ul><li>POSTPAID_BY_HOUR: The targeted billing type is pay-as-you-go.</li><li>PREPAID: The targeted billing type is annual and monthly subscription.</li></ul>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Whether to switch the billing mode of the elastic data cloud disk simultaneously. Value ranges from true to false: true indicates switching the billing mode of the elastic data cloud disk, false indicates not switching the billing mode of the elastic data cloud disk. Default value: true.</p><p>Default value: true</p>
        /// </summary>
        [JsonProperty("ModifyPortableDataDisk")]
        public bool? ModifyPortableDataDisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamArraySimple(map, prefix + "MachineNames.", this.MachineNames);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIDs.", this.SecurityGroupIDs);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ModifyPortableDataDisk", this.ModifyPortableDataDisk);
        }
    }
}

