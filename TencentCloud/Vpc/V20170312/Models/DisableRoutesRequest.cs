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

    public class DisableRoutesRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique route table ID.
        /// </summary>
        [JsonProperty("RouteTableId")]
        public string RouteTableId{ get; set; }

        /// <summary>
        /// Routing policy ID. This parameter cannot be used simultaneously with RouteItemIds, but at least one of them should be entered. The value of this parameter can be obtained by querying the route list ([DescribeRouteTables](https://intl.cloud.tencent.com/document/product/215/15763?from_cn_redirect=1)).
        /// </summary>
        [JsonProperty("RouteIds")]
        public ulong?[] RouteIds{ get; set; }

        /// <summary>
        /// Unique routing policy ID. This parameter cannot be used simultaneously with RouteIds, but at least one of them should be entered. The value of this parameter can be obtained by querying the route list ([DescribeRouteTables](https://intl.cloud.tencent.com/document/product/215/15763?from_cn_redirect=1)).
        /// </summary>
        [JsonProperty("RouteItemIds")]
        public string[] RouteItemIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteTableId", this.RouteTableId);
            this.SetParamArraySimple(map, prefix + "RouteIds.", this.RouteIds);
            this.SetParamArraySimple(map, prefix + "RouteItemIds.", this.RouteItemIds);
        }
    }
}

