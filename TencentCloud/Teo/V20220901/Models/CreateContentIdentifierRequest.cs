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

    public class CreateContentIdentifierRequest : AbstractModel
    {
        
        /// <summary>
        /// Description of the content identifier. Length limited to 20 characters.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Target bundle ID to be bound. Enterprise edition only.<li>If a package already exists under your account, go to [Plan management](https://console.cloud.tencent.com/edgeone/package) to get the package ID, and bind the content identifier to that package directly;</li><li>If you currently have no bindable package, purchase an enterprise edition package first.</li>
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// Tag. This parameter is used for authority control over content identifiers. Go to the tag console (https://console.cloud.tencent.com/tag/taglist) first to create tags before you can input the corresponding tag key and tag value here.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

