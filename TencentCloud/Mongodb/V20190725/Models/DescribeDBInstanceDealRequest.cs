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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceDealRequest : AbstractModel
    {
        
        /// <summary>
        /// Order ID.
        /// - Pay-as-you-go instance. It can be obtained through the output parameter **DealId** of the [CreateDBInstanceHour](https://www.tencentcloud.comom/document/product/240/38570?from_cn_redirect=1) API.
        /// - Yearly/monthly subscription instance. It can be obtained through the output parameter **DealId** of the [CreateDBInstance](https://www.tencentcloud.comom/document/product/240/38571?from_cn_redirect=1) API.
        /// </summary>
        [JsonProperty("DealId")]
        public string DealId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DealId", this.DealId);
        }
    }
}

