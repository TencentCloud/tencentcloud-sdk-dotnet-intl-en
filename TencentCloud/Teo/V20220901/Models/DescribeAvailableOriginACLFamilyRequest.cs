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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAvailableOriginACLFamilyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Site ID.</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>Filter criteria. The maximum number of Filters.Values is 20. If this parameter is left empty, all available versions under the current site are returned. The IP range control domain of origin protection includes the standard control domain and the streamlined control domain. The main difference between the standard control domain and the streamlined control domain is the quantity difference of origin IP ranges provided. The latter has fewer IP ranges, however it is limited in use. Contact technical support if needed. Specific values are as follows:<br>Detailed filter criteria are as follows:<br>OriginACLFamily: filter by control domain;</p><li>gaz: standard global availability zone control domain;</li><li>mlc: standard Chinese mainland availability zone control domain;</li><li>emc: standard global (excluding Chinese mainland) availability zone control domain;</li><li>plat-gaz: streamlined global availability zone control domain;</li><li>plat-mlc: streamlined Chinese mainland availability zone control domain;</li><li>plat-emc: streamlined global (excluding Chinese mainland) availability zone control domain;</li><li>plat-specific-gaz: custom edition global availability zone control domain;</li><li>plat-specific-mlc: custom edition Chinese mainland availability zone control domain;</li><li>plat-specific-emc: custom edition global (excluding Chinese mainland) availability zone control domain.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>The offset of paginated query. Default value: 0.</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>Number limit of paginated query. Default value: 20. Maximum value: 100.</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

