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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectionDetail : AbstractModel
    {
        
        /// <summary>
        /// Enablement status of each configuration item
        /// </summary>
        [JsonProperty("ConfigItems")]
        public ProtectionConfigItem[] ConfigItems{ get; set; }

        /// <summary>
        /// Number of assets to protect
        /// </summary>
        [JsonProperty("EligibleAssetCount")]
        public long? EligibleAssetCount{ get; set; }

        /// <summary>
        /// Number of protected assets
        /// </summary>
        [JsonProperty("ProtectedAssetCount")]
        public long? ProtectedAssetCount{ get; set; }

        /// <summary>
        /// Coverage percentage.
        /// Value range: [0, 100].
        /// </summary>
        [JsonProperty("CoveragePercent")]
        public long? CoveragePercent{ get; set; }

        /// <summary>
        /// List of products about to expire
        /// </summary>
        [JsonProperty("ExpiringProducts")]
        public ExpiringProduct[] ExpiringProducts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ConfigItems.", this.ConfigItems);
            this.SetParamSimple(map, prefix + "EligibleAssetCount", this.EligibleAssetCount);
            this.SetParamSimple(map, prefix + "ProtectedAssetCount", this.ProtectedAssetCount);
            this.SetParamSimple(map, prefix + "CoveragePercent", this.CoveragePercent);
            this.SetParamArrayObj(map, prefix + "ExpiringProducts.", this.ExpiringProducts);
        }
    }
}

