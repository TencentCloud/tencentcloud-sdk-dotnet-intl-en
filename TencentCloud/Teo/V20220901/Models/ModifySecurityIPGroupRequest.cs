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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySecurityIPGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone Id.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// IP group configuration.
        /// </summary>
        [JsonProperty("IPGroup")]
        public IPGroup IPGroup{ get; set; }

        /// <summary>
        /// Operation type. Valid values: <li> append: Add a new IP address to the IPGroup or set a scheduled expiration time;</li><li> remove: Delete a specified IP address or its scheduled expiration time from the IPGroup;</li><li> update: Replace all content in Content or ExpireInfo of the IPGroup, and modifications to the name of the IPGroup are allowed.</li>Notes for the append operation: <li> When adding a scheduled expiration time for an IP or range, it must be later than the current time. If the IP or range does not exist in the group, you must add it in the Content parameter simultaneously. If the IP or range already has an expiration time, the new time will override the original time.</li>Notes for the remove operation: <li> When deleting an IP or range, related unexpired scheduled expiration times will also be deleted;</li> <li> When deleting a scheduled expiration time, you can only delete a time that is not expired.</li>Notes for the update operation: <li> When replacing the content of Content, unexpired times of IPs or ranges not in Content will be deleted;</li> <li> When replacing the content of IPExpireInfo, the IPs or ranges in IPExpireInfo must be in Content or exist in the IP group.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamObj(map, prefix + "IPGroup.", this.IPGroup);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

