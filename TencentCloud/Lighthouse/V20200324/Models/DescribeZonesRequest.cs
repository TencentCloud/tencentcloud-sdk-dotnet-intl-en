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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeZonesRequest : AbstractModel
    {
        
        /// <summary>
        /// Sorting field. Valid values:
        /// <li>`ZONE`: Sort by the availability zone.
        /// <li>`INSTANCE_DISPLAY_LABEL`: Sort by visibility labels (`HIDDEN`, `NORMAL` and `SELECTED`). Default: ['HIDDEN', 'NORMAL', 'SELECTED'].
        /// The default value is `ZONE`.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Specifies how availability zones are listed. Valid values:
        /// <li>ASC: Ascending sort. 
        /// <li>DESC: Descending sort.
        /// The default value is `ASC`.
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderField", this.OrderField);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

