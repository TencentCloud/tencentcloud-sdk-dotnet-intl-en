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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCfsRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// Permission group ID, which can be obtained through the api [DescribeCfsPGroups](https://www.tencentcloud.com/document/api/582/38157?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// Rule ID, which can be obtained through the [DescribeCfsRules](https://www.tencentcloud.com/document/api/582/38156?from_cn_redirect=1) api.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// You can enter a single IP or IP range, such as 10.1.10.11 or 10.10.1.0/24. The default visiting address is `*`, indicating that all IPs are allowed. Please note that you need to enter the CVM instance's private IP here.
        /// </summary>
        [JsonProperty("AuthClientIp")]
        public string AuthClientIp{ get; set; }

        /// <summary>
        /// Read/write permission. Valid values: RO (read-only), RW (read & write). Default value: RO
        /// </summary>
        [JsonProperty("RWPermission")]
        public string RWPermission{ get; set; }

        /// <summary>
        /// User permission. valid values: all_squash, no_all_squash, root_squash, no_root_squash. default value: root_squash.
        /// All_squash: all accessing users (including the root user) will be mapped to anonymous users or groups.
        /// no_all_squash: all accessing users (including the root user) retain original UID/GID information.
        /// root_squash: maps visiting root user to anonymous user or user group. non-root user keeps original UID/GID information.
        /// no_root_squash: has the same effect as no_all_squash. all accessing users (including the root user) retain their original UID/GID information.
        /// </summary>
        [JsonProperty("UserPermission")]
        public string UserPermission{ get; set; }

        /// <summary>
        /// Rule priority. value range: 1-100. among them, 1 is the highest and 100 is the minimum. default value: 100.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "AuthClientIp", this.AuthClientIp);
            this.SetParamSimple(map, prefix + "RWPermission", this.RWPermission);
            this.SetParamSimple(map, prefix + "UserPermission", this.UserPermission);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

