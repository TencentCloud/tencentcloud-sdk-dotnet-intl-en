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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// Organization ID
        /// </summary>
        [JsonProperty("OrganizationId")]
        public string OrganizationId{ get; set; }

        /// <summary>
        /// Whether to obtain the device list of the current level and sub-levels. Default value: false.
        /// </summary>
        [JsonProperty("IsContainSubLevel")]
        public bool? IsContainSubLevel{ get; set; }

        /// <summary>
        /// Whether the devices already associated with the current user are included. Default value: false.
        /// </summary>
        [JsonProperty("IsContainUser")]
        public bool? IsContainUser{ get; set; }

        /// <summary>
        /// Device access protocol. 1: RTMP, 2: GB, 3: GW, 4: IVCP (private protocol)
        /// </summary>
        [JsonProperty("AccessProtocol")]
        public ulong? AccessProtocol{ get; set; }

        /// <summary>
        /// Device type. 1: IPC, 2: NVR
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// Device status. 0: unregistered; 1: online; 2: offline; 3: disabled.	
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Service node ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Keyword for fuzzy search of devices
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }

        /// <summary>
        /// Uin of the current user
        /// </summary>
        [JsonProperty("CurrentUin")]
        public ulong? CurrentUin{ get; set; }

        /// <summary>
        /// Page number. Default value: 1.
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// Number of items per page. Default value: 20. Maximum: 10000 per page.
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationId", this.OrganizationId);
            this.SetParamSimple(map, prefix + "IsContainSubLevel", this.IsContainSubLevel);
            this.SetParamSimple(map, prefix + "IsContainUser", this.IsContainUser);
            this.SetParamSimple(map, prefix + "AccessProtocol", this.AccessProtocol);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
            this.SetParamSimple(map, prefix + "CurrentUin", this.CurrentUin);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
        }
    }
}

