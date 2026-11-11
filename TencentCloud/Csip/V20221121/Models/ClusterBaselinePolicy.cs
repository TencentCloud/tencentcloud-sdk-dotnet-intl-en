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

    public class ClusterBaselinePolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Baseline policy ID.</p>
        /// </summary>
        [JsonProperty("PolicyID")]
        public ulong? PolicyID{ get; set; }

        /// <summary>
        /// <p>Baseline policy name.</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>Asset type to detect.<br>Enumeration values:<br>HOST: host<br>CLUSTER: container cluster</p>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>Baseline system parent category ID.</p>
        /// </summary>
        [JsonProperty("ParentCategoryID")]
        public ulong? ParentCategoryID{ get; set; }

        /// <summary>
        /// <p>Whether it is a system baseline policy. true means system policy, false means custom policy.</p>
        /// </summary>
        [JsonProperty("IsSystem")]
        public bool? IsSystem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyID", this.PolicyID);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "ParentCategoryID", this.ParentCategoryID);
            this.SetParamSimple(map, prefix + "IsSystem", this.IsSystem);
        }
    }
}

