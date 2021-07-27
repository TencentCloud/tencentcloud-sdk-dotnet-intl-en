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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpotMixedAllocationPolicy : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BaseCapacity")]
        public ulong? BaseCapacity{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OnDemandPercentageAboveBaseCapacity")]
        public ulong? OnDemandPercentageAboveBaseCapacity{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SpotAllocationStrategy")]
        public string SpotAllocationStrategy{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CompensateWithBaseInstance")]
        public bool? CompensateWithBaseInstance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BaseCapacity", this.BaseCapacity);
            this.SetParamSimple(map, prefix + "OnDemandPercentageAboveBaseCapacity", this.OnDemandPercentageAboveBaseCapacity);
            this.SetParamSimple(map, prefix + "SpotAllocationStrategy", this.SpotAllocationStrategy);
            this.SetParamSimple(map, prefix + "CompensateWithBaseInstance", this.CompensateWithBaseInstance);
        }
    }
}

