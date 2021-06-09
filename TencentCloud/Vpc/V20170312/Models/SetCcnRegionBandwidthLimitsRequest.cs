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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetCcnRegionBandwidthLimitsRequest : AbstractModel
    {
        
        /// <summary>
        /// The CCN instance ID, such as `ccn-f49l6u0z`.
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// The outbound bandwidth cap of each CCN region.
        /// </summary>
        [JsonProperty("CcnRegionBandwidthLimits")]
        public CcnRegionBandwidthLimit[] CcnRegionBandwidthLimits{ get; set; }

        /// <summary>
        /// Whether to restore the region outbound bandwidth limit or inter-region bandwidth limit to default 1Gbps. Valid values: `false` (no); `true` (yes). Default value: `false`. When the parameter is set to `true`, the CCN instance created will not be displayed in the console.
        /// </summary>
        [JsonProperty("SetDefaultLimitFlag")]
        public bool? SetDefaultLimitFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArrayObj(map, prefix + "CcnRegionBandwidthLimits.", this.CcnRegionBandwidthLimits);
            this.SetParamSimple(map, prefix + "SetDefaultLimitFlag", this.SetDefaultLimitFlag);
        }
    }
}

