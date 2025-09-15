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
        /// Field on which the AZ list is sorted. value range:.
        /// <Li>ZONE: sorted based on availability zone.</li>.
        /// INSTANCE_DISPLAY_LABEL: specifies the Tag DISPLAY sorting order based on availability zone. valid values: HIDDEN (hide), NORMAL (ordinary), SELECTED (chosen by default). defaults to ascending order: ['HIDDEN', 'NORMAL', 'SELECTED'].
        /// Specifies the default sorting order by availability zone.
        /// </summary>
        [JsonProperty("OrderField")]
        public string OrderField{ get; set; }

        /// <summary>
        /// Outputs the sorting order of the availability zone list. value range:.
        /// <Li>ASC: ascending order.</li>.
        /// <Li>DESC: sort in descending order.</li>.
        /// Specifies the default ascending order.
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

