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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDedicatedClusterOrdersRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter by CDC id.
        /// </summary>
        [JsonProperty("DedicatedClusterIds")]
        public string[] DedicatedClusterIds{ get; set; }

        /// <summary>
        /// Filter by CDC order id.
        /// </summary>
        [JsonProperty("DedicatedClusterOrderIds")]
        public string DedicatedClusterOrderIds{ get; set; }

        /// <summary>
        /// Offset, 0 by default For further information on Offset, please refer to relevant sections in API [Overview] (https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of returned pieces, 20 by default and can be up to 100. For further information on Limit, please refer to relevant sections in API [Overview] (https://intl.cloud.tencent.com/document/api/213/15688?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// The order status is the filter condition: PENDING INCONSTRUCTION DELIVERING DELIVERED EXPIRED CANCELLED OFFLINE
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// The order type is the filter condition: CREATE EXTEND
        /// </summary>
        [JsonProperty("ActionType")]
        public string ActionType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OrderTypes")]
        public string[] OrderTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DedicatedClusterIds.", this.DedicatedClusterIds);
            this.SetParamSimple(map, prefix + "DedicatedClusterOrderIds", this.DedicatedClusterOrderIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ActionType", this.ActionType);
            this.SetParamArraySimple(map, prefix + "OrderTypes.", this.OrderTypes);
        }
    }
}

