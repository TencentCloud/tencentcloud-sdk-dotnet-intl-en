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
        /// Site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// IP group configuration.
        /// </summary>
        [JsonProperty("IPGroup")]
        public IPGroup IPGroup{ get; set; }

        /// <summary>
        /// Operation type. valid values: <li>`append`: add new IP addresses or set scheduled expiration time to `IPGroup`;</li> <li>`remove`: delete specified IP addresses or their scheduled expiration time from `IPGroup`;</li> <li>`update`: replace all Content of `Content` or `ExpireInfo` in `IPGroup` and modify the IPGroup name.</li>  notes for `append` operation: <li>when adding a scheduled expiration time for an IP or range, it must be later than the current time. if the IP or range does not exist in the group, it must be added to the `Content` parameter simultaneously. if the IP or range already has an expiration time, the new time will overwrite the original one.</li>  notes for `remove` operation: <li>when deleting an IP or range, related unexpired scheduled expiration times will also be deleted;</li> <li>when deleting a scheduled expiration time, only currently unexpired times can be removed.</li>  notes for `update` operation: <li>when replacing `Content`, unexpired times of ips or ranges not in `Content` will be deleted;</li> <li>when replacing `IPExpireInfo`, the ips or ranges in `IPExpireInfo` must exist in `Content` or the IP group.</li>.
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

