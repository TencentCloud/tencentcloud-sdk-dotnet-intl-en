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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIntlDomainPriceNewListRequest : AbstractModel
    {
        
        /// <summary>
        /// The list of domain suffixes for which you want to query prices. This parameter defaults to all suffixes.
        /// </summary>
        [JsonProperty("TldList")]
        public string[] TldList{ get; set; }

        /// <summary>
        /// The purchase year of the domains for which you want to query prices. This parameter defaults to all years.
        /// </summary>
        [JsonProperty("Year")]
        public long?[] Year{ get; set; }

        /// <summary>
        /// The domain purchase type. Valid values: `new`, `renew`, `redem` (redeem), `tran` (transfer in).
        /// </summary>
        [JsonProperty("Operation")]
        public string[] Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "TldList.", this.TldList);
            this.SetParamArraySimple(map, prefix + "Year.", this.Year);
            this.SetParamArraySimple(map, prefix + "Operation.", this.Operation);
        }
    }
}

