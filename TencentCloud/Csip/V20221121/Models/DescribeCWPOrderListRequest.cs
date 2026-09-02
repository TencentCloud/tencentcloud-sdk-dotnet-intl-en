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

    public class DescribeCWPOrderListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Take the intersection when filtering with multiple conditions</p><li>ProductCode: product code, starting with p_</li><li>SubProductCode: subproduct code, starting with sp_</li><li>InquireKey: billing item, starting with sv_</li><li>Status: resource status. 1: normal, 2: isolated, 3: terminated</li><li>PayMode: payment mode. 0: pay-as-you-go billing, 1: monthly subscription</li><li>ResourceId: resource ID</li><li>RenewFlag: auto-renewal label. 0: not needed by default (major customers have the auto-renewal ability), 1: auto-renewal, 2: manually set not to automatically renew</li><li>DealNames: sub-order number</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>Offset. Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Limit entries. Default: 10. Maximum: 100</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

