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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteIpAccessControlV2Request : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Rule ID list, which supports deletion in batches.
        /// </summary>
        [JsonProperty("RuleIds")]
        public ulong?[] RuleIds{ get; set; }

        /// <summary>
        /// Whether to delete all IP blocklists/allowlists under the corresponding domain. True indicates deleting all; false indicates only deleting a specified IP list.
        /// </summary>
        [JsonProperty("DeleteAll")]
        public bool? DeleteAll{ get; set; }

        /// <summary>
        /// batch: indicates batch protection IP allowlists/blocklists.
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// IP allowlist/blocklist type. 40: IP allowlist; 42: IP blocklist.
        /// </summary>
        [JsonProperty("ActionType")]
        public ulong? ActionType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamSimple(map, prefix + "DeleteAll", this.DeleteAll);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
        }
    }
}
