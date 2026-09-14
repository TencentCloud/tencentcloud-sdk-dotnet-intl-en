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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGlobalAcceleratorRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Billing mode. PREPAID: prepaid mode, i.e., Monthly Subscription. POSTPAID: postpaid, i.e., pay-as-you-go. Default: POSTPAID. Currently, only pay-as-you-go is supported.</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>Description.</p><p>Parameter format: should not exceed 100 characters.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Cross-border type; HighQuality: dedicated BGP-IP cross-border; Unicom: China Unicom Direct Connect cross-border.</p>
        /// </summary>
        [JsonProperty("CrossBorderType")]
        public string CrossBorderType{ get; set; }

        /// <summary>
        /// <p>This Flag represents signing the cross-border service commitment. When using cross-border service, this field is required. True: represents signed.</p>
        /// </summary>
        [JsonProperty("CrossBorderPromiseFlag")]
        public bool? CrossBorderPromiseFlag{ get; set; }

        /// <summary>
        /// <p>Tag information.</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CrossBorderType", this.CrossBorderType);
            this.SetParamSimple(map, prefix + "CrossBorderPromiseFlag", this.CrossBorderPromiseFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

