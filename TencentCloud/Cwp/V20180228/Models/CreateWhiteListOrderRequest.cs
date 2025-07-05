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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWhiteListOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// Authorization type
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// Number of authorizations (The minimum value is 1, and the maximum value is 99999.)
        /// </summary>
        [JsonProperty("LicenseNum")]
        public ulong? LicenseNum{ get; set; }

        /// <summary>
        /// Expiration time (The minimum value is 1.)
        /// </summary>
        [JsonProperty("Deadline")]
        public ulong? Deadline{ get; set; }

        /// <summary>
        /// Rule name, big asset center: asset_center
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Order type. 1: trial; 2: free; 3: experience; 4: free SSL certificate gift; 5: free CVM
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// Region: 1 Guangzhou; 9 Singapore. The default is 1. Do not select 9 unless necessary.
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// Additional parameters; JSON string, including ResourceId and LicenseType.
        /// </summary>
        [JsonProperty("ExtraParam")]
        public string ExtraParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "LicenseNum", this.LicenseNum);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ExtraParam", this.ExtraParam);
        }
    }
}

