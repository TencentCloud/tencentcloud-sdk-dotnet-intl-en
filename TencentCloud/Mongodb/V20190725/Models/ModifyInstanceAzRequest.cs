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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceAzRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID, such as cmgo-p8vn****. Log in to the <a href="https://console.cloud.tencent.com/mongodb">MongoDB console</a> and copy the instance ID from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Availability zone ID where the primary node is located. For the method for obtaining, please see <a href="https://www.tencentcloud.com/document/product/240/3637?from_cn_redirect=1">Regions and Availability Zones</a>.</p>
        /// </summary>
        [JsonProperty("PrimaryNodeZone")]
        public string PrimaryNodeZone{ get; set; }

        /// <summary>
        /// <p>ID list of the availability zone where the secondary node resides.<br><strong>Note</strong>: It cannot contain the availability zones where the primary node and Hidden nodes reside.</p>
        /// </summary>
        [JsonProperty("SecondaryNodeZone")]
        public string[] SecondaryNodeZone{ get; set; }

        /// <summary>
        /// <p>If the current instance has no configuration for Hidden nodes, this parameter is not required.</p>
        /// </summary>
        [JsonProperty("HiddenNodeZone")]
        public string HiddenNodeZone{ get; set; }

        /// <summary>
        /// <p>List of AZ IDs where read-only nodes reside.<br><strong>Note</strong>: If the current instance contains read-only nodes, this parameter is required.</p>
        /// </summary>
        [JsonProperty("ReadonlyNodeZone")]
        public string[] ReadonlyNodeZone{ get; set; }

        /// <summary>
        /// <p>Specify the time policy for executing the availability zone switch.</p><ul><li>0: Execute the switch immediately.</li><li>1: Execute the switch within the set maintenance window. For details, please refer to <a href="https://www.tencentcloud.com/document/product/240/19910?from_cn_redirect=1">setting instance maintenance time</a>.</li></ul>
        /// </summary>
        [JsonProperty("InMaintenance")]
        public ulong? InMaintenance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PrimaryNodeZone", this.PrimaryNodeZone);
            this.SetParamArraySimple(map, prefix + "SecondaryNodeZone.", this.SecondaryNodeZone);
            this.SetParamSimple(map, prefix + "HiddenNodeZone", this.HiddenNodeZone);
            this.SetParamArraySimple(map, prefix + "ReadonlyNodeZone.", this.ReadonlyNodeZone);
            this.SetParamSimple(map, prefix + "InMaintenance", this.InMaintenance);
        }
    }
}

