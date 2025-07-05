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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcGeoIPBlockConfig : AbstractModel
    {
        
        /// <summary>
        /// Region type. Valid values:
        /// `oversea`: Outside the Chinese mainland.
        /// `china`: The Chinese mainland.
        /// `customized`: User-specified region.
        /// ]
        /// </summary>
        [JsonProperty("RegionType")]
        public string RegionType{ get; set; }

        /// <summary>
        /// Blocking action. Valid values:
        /// `drop`: Block the request.
        /// `alg`: Verify the request via CAPTCHA.
        /// ]
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Configuration ID, which is generated after a configuration is added. This field is only required to modify or delete a configuration.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// This field is required when RegionType is `customized`; it can be left empty when RegionType is `china` or `oversea`.
        /// </summary>
        [JsonProperty("AreaList")]
        public long?[] AreaList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionType", this.RegionType);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "AreaList.", this.AreaList);
        }
    }
}

