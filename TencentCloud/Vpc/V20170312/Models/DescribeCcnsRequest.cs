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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCcnsRequest : AbstractModel
    {
        
        /// <summary>
        /// The CCN instance ID, such as `ccn-f49l6u0z`. Each request can have a maximum of 100 instances. `CcnIds` and `Filters` cannot be specified at the same time
        /// </summary>
        [JsonProperty("CcnIds")]
        public string[] CcnIds{ get; set; }

        /// <summary>
        /// Filter conditions. `CcnIds` and `Filters` cannot be specified at the same time.
        /// <li>ccn-id - String - (Filter condition) The unique ID of the CCN, such as `vpc-f49l6u0z`.</li>
        /// <li>ccn-name - String - (Filter condition) The CCN name.</li>
        /// <li>ccn-description - String - (Filter condition) CCN description.</li>
        /// <li>state - String - (Filter condition) The instance status. 'ISOLATED': Isolated (the account is in arrears and the service is suspended.) 'AVAILABLE': Running.</li>
        /// <li>tag-key - String - Required: no - (Filter condition) Filters by tag key.</li>
        /// <li>`tag:tag-key` - String - Required: no - (Filter condition) Filters by tag key pair. For this parameter, `tag-key` will be replaced with a specific tag key. For more information, see this example: **Querying the list of CCNs bound to tags**.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The returned quantity
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Order fields support `CcnId`, `CcnName`, `CreateTime`, `State`, and `QosLevel`
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Order methods. Ascending: `ASC`, Descending: `DESC`.
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CcnIds.", this.CcnIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

