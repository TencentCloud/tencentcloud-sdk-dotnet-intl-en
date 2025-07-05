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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkInterfaceAttachment : AbstractModel
    {
        
        /// <summary>
        /// CVM instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The serial number of ENI in the CVM instance.
        /// </summary>
        [JsonProperty("DeviceIndex")]
        public ulong? DeviceIndex{ get; set; }

        /// <summary>
        /// The account information of the CVM owner.
        /// </summary>
        [JsonProperty("InstanceAccountId")]
        public string InstanceAccountId{ get; set; }

        /// <summary>
        /// Binding time
        /// </summary>
        [JsonProperty("AttachTime")]
        public string AttachTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceIndex", this.DeviceIndex);
            this.SetParamSimple(map, prefix + "InstanceAccountId", this.InstanceAccountId);
            this.SetParamSimple(map, prefix + "AttachTime", this.AttachTime);
        }
    }
}

