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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InquirePriceRenewInstancesResponse : AbstractModel
    {
        
        /// <summary>
        /// Price information. It defaults to the price information of the first instance in the list.
        /// </summary>
        [JsonProperty("Price")]
        public Price Price{ get; set; }

        /// <summary>
        /// List of data disk price information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DataDiskPriceSet")]
        public DataDiskPrice[] DataDiskPriceSet{ get; set; }

        /// <summary>
        /// Price list of the instances to be renewed.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("InstancePriceDetailSet")]
        public InstancePriceDetail[] InstancePriceDetailSet{ get; set; }

        /// <summary>
        /// Total price
        /// </summary>
        [JsonProperty("TotalPrice")]
        public TotalPrice TotalPrice{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Price.", this.Price);
            this.SetParamArrayObj(map, prefix + "DataDiskPriceSet.", this.DataDiskPriceSet);
            this.SetParamArrayObj(map, prefix + "InstancePriceDetailSet.", this.InstancePriceDetailSet);
            this.SetParamObj(map, prefix + "TotalPrice.", this.TotalPrice);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

