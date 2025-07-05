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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComplianceWhitelistItem : AbstractModel
    {
        
        /// <summary>
        /// Allowed item ID
        /// </summary>
        [JsonProperty("WhitelistItemId")]
        public ulong? WhitelistItemId{ get; set; }

        /// <summary>
        /// ID of the customer check item
        /// </summary>
        [JsonProperty("CustomerPolicyItemId")]
        public ulong? CustomerPolicyItemId{ get; set; }

        /// <summary>
        /// Check item name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Compliance standard name
        /// </summary>
        [JsonProperty("StandardName")]
        public string StandardName{ get; set; }

        /// <summary>
        /// Compliance standard ID
        /// </summary>
        [JsonProperty("StandardId")]
        public ulong? StandardId{ get; set; }

        /// <summary>
        /// Number of assets affected by the check item
        /// </summary>
        [JsonProperty("AffectedAssetCount")]
        public ulong? AffectedAssetCount{ get; set; }

        /// <summary>
        /// Last update time
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// Allowed time
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhitelistItemId", this.WhitelistItemId);
            this.SetParamSimple(map, prefix + "CustomerPolicyItemId", this.CustomerPolicyItemId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "StandardName", this.StandardName);
            this.SetParamSimple(map, prefix + "StandardId", this.StandardId);
            this.SetParamSimple(map, prefix + "AffectedAssetCount", this.AffectedAssetCount);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
        }
    }
}

