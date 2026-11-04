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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginOperation : AbstractModel
    {
        
        /// <summary>
        /// Whether external calls are allowed
        /// </summary>
        [JsonProperty("AllowExternalAccess")]
        public bool? AllowExternalAccess{ get; set; }

        /// <summary>
        /// <p>Billing type.</p><p>Valid values:</p><ul><li>0: free</li><li>1: open beta</li><li>2: official fees</li></ul>
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// Plug-in category identifier
        /// </summary>
        [JsonProperty("CategoryKey")]
        public string CategoryKey{ get; set; }

        /// <summary>
        /// Plug-in overview
        /// </summary>
        [JsonProperty("Introduction")]
        public string Introduction{ get; set; }

        /// <summary>
        /// Whether it is a selection
        /// </summary>
        [JsonProperty("IsRecommended")]
        public bool? IsRecommended{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllowExternalAccess", this.AllowExternalAccess);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamSimple(map, prefix + "CategoryKey", this.CategoryKey);
            this.SetParamSimple(map, prefix + "Introduction", this.Introduction);
            this.SetParamSimple(map, prefix + "IsRecommended", this.IsRecommended);
        }
    }
}

