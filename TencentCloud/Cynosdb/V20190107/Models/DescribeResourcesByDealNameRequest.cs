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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourcesByDealNameRequest : AbstractModel
    {
        
        /// <summary>
        /// Billing order ID (if billing has not called back business delivery, the error code InvalidParameterValue.DealNameNotFound may occur. In this case, the business needs to retry the DescribeResourcesByDealName API until it succeeds).
        /// Enter at least one of DealName and DealNames. If both are entered, DealName takes precedence.
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }

        /// <summary>
        /// List of billing order IDs. You can query the resource information for several order IDs in a single query. If billing has not yet called back the business for delivery, the error code InvalidParameterValue.DealNameNotFound may occur. In this case, retry the DescribeResourcesByDealName API until it succeeds.
        /// Enter at least one of DealName and DealNames. If both are entered, DealName takes precedence.
        /// </summary>
        [JsonProperty("DealNames")]
        public string[] DealNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealName", this.DealName);
            this.SetParamArraySimple(map, prefix + "DealNames.", this.DealNames);
        }
    }
}

