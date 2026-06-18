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

    public class DescribeLicenseBindListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>License ID. The value is the value of the LicenseId parameter under the List object of the DescribeLicenseList API.</p>
        /// </summary>
        [JsonProperty("LicenseId")]
        public ulong? LicenseId{ get; set; }

        /// <summary>
        /// <p>License type</p><p>Valid values:</p><ul><li>0: Pro Edition - pay-as-you-go</li><li>1: Pro Edition - monthly subscription (CWP)</li><li>2: Ultimate Edition - monthly subscription (CWP)</li><li>3: Lightweight Edition - LH monthly subscription</li><li>6: Pro Edition - monthly subscription (CSC)</li><li>7: Ultimate Edition - monthly subscription (CSC)</li></ul>
        /// </summary>
        [JsonProperty("LicenseType")]
        public ulong? LicenseType{ get; set; }

        /// <summary>
        /// <p>Resource ID. The value is the value of the ResourceId parameter under the List object of the DescribeLicenseList API.</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <li>Fuzzy search by InstanceID, IP, or <p>MachineName</p></li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// <p>The maximum number of entries. Default value: 10.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>Offset. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LicenseId", this.LicenseId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

