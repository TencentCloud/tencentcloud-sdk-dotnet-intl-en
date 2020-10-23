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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Permission group ID
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// You can enter a single IP or IP range, such as 10.1.10.11 or 10.10.1.0/24. The default visiting address is `*`, indicating that all IPs are allowed. Please note that you need to enter the CVM instance's private IP here.
        /// </summary>
        [JsonProperty("AuthClientIp")]
        public string AuthClientIp{ get; set; }

        /// <summary>
        /// Rule priority. Value range: 1-100. 1 represents the highest priority, while 100 the lowest
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Read/write permission. Valid values: RO (read-only), RW (read & write). Default value: RO
        /// </summary>
        [JsonProperty("RWPermission")]
        public string RWPermission{ get; set; }

        /// <summary>
        /// User permission. Valid values: all_squash, no_all_squash, root_squash, no_root_squash. Specifically, all_squash: any visiting user will be mapped to an anonymous user or user group; no_all_squash: a visiting user will be first matched with a local user, and if the match fails, it will be mapped to an anonymous user or user group; root_squash: a visiting root user will be mapped to an anonymous user or user group; no_root_squash: a visiting root user will be allowed to maintain root account permissions. Default value: root_squash.
        /// </summary>
        [JsonProperty("UserPermission")]
        public string UserPermission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "AuthClientIp", this.AuthClientIp);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "RWPermission", this.RWPermission);
            this.SetParamSimple(map, prefix + "UserPermission", this.UserPermission);
        }
    }
}

