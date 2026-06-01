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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyInst : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Instance name.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Instance type: 1 master primary instance; 2 read-only instance; 3 dr disaster recovery instance; 4 sdr (small disaster recovery) instance
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// Instance status. Valid values: 0: creating; 1: running; 4: isolation; 5: isolated.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Read-only weight. If the weight is automatically assigned by the system, this value does not take effect and only indicates whether the instance is enabled or not.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// Instance region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Availability zone to which the instance belongs
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance Node ID
        /// </summary>
        [JsonProperty("InstNodeId")]
        public string InstNodeId{ get; set; }

        /// <summary>
        /// Node role
        /// </summary>
        [JsonProperty("InstNodeRole")]
        public string InstNodeRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstNodeId", this.InstNodeId);
            this.SetParamSimple(map, prefix + "InstNodeRole", this.InstNodeRole);
        }
    }
}

