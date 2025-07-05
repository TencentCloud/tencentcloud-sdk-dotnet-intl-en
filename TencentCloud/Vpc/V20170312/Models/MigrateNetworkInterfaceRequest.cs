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

    public class MigrateNetworkInterfaceRequest : AbstractModel
    {
        
        /// <summary>
        /// The ID of the ENI instance, such as `eni-m6dyj72l`.
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// The ID of the CVM bound to the ENI, such as `ins-r8hr2upy`.
        /// </summary>
        [JsonProperty("SourceInstanceId")]
        public string SourceInstanceId{ get; set; }

        /// <summary>
        /// ID of the destination CVM instance to be migrated.
        /// </summary>
        [JsonProperty("DestinationInstanceId")]
        public string DestinationInstanceId{ get; set; }

        /// <summary>
        /// ENI mount method. Valid values: 0: standard; 1: extension; default value: 0
        /// </summary>
        [JsonProperty("AttachType")]
        public ulong? AttachType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "SourceInstanceId", this.SourceInstanceId);
            this.SetParamSimple(map, prefix + "DestinationInstanceId", this.DestinationInstanceId);
            this.SetParamSimple(map, prefix + "AttachType", this.AttachType);
        }
    }
}

