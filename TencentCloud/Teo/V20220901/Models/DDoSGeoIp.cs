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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSGeoIp : AbstractModel
    {
        
        /// <summary>
        /// Whether to clear the blocklist of the region. Values:
        /// <li>`off`: Clear the blocklist of the region.</li>
        /// <li>`on`: Perform no operations.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Region information. For more information on the ID, see [DescribeSecurityPolicyRegions](https://tcloud4api.woa.com/document/product/1657/81247?!preview&!document=1).
        /// </summary>
        [JsonProperty("RegionIds")]
        public long?[] RegionIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "RegionIds.", this.RegionIds);
        }
    }
}

