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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTawInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// Billing status
        /// </summary>
        [JsonProperty("ChargeStatuses")]
        public long?[] ChargeStatuses{ get; set; }

        /// <summary>
        /// Billing type
        /// </summary>
        [JsonProperty("ChargeTypes")]
        public long?[] ChargeTypes{ get; set; }

        /// <summary>
        /// Pagination limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("AreaIds")]
        public long?[] AreaIds{ get; set; }

        /// <summary>
        /// Instance status (1: creating; 2: running; 3: exceptional; 4: restarting; 5: stopping; 6: stopped; 7: terminating; 8: terminated)
        /// </summary>
        [JsonProperty("InstanceStatuses")]
        public long?[] InstanceStatuses{ get; set; }

        /// <summary>
        /// Instance ID
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// Filter parameter
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ChargeStatuses.", this.ChargeStatuses);
            this.SetParamArraySimple(map, prefix + "ChargeTypes.", this.ChargeTypes);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArraySimple(map, prefix + "AreaIds.", this.AreaIds);
            this.SetParamArraySimple(map, prefix + "InstanceStatuses.", this.InstanceStatuses);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

