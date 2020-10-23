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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetCcnRegionBandwidthLimitsRequest : AbstractModel
    {
        
        /// <summary>
        /// The CCN instance ID, such as `ccn-f49l6u0z`.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The filter condition.
        /// <li>sregion - String - (Filter condition) Filter by the source region, such as 'ap-guangzhou'.</li>
        /// <li>dregion - String - (Filter condition) Filter by the destination region, such as 'ap-shanghai-bm'.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// The sorting condition. Valid values: `BandwidthLimit` and `ExpireTime`.
        /// </summary>
        [JsonProperty("SortedBy")]
        public string SortedBy{ get; set; }

        /// <summary>
        /// The offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The returned quantity.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// In ascending or descending order. Valid values: 'ASC' and 'DESC'.
        /// </summary>
        [JsonProperty("OrderBy")]
        public string OrderBy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "SortedBy", this.SortedBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderBy", this.OrderBy);
        }
    }
}

