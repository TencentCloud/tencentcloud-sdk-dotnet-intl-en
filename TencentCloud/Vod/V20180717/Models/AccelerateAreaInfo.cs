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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AccelerateAreaInfo : AbstractModel
    {
        
        /// <summary>
        /// Acceleration region. Available values:
        /// <li>Chinese Mainland: within the Chinese mainland (excluding Hong Kong (China), Macao (China), and Taiwan (China)).</li>
        /// <li>Outside Chinese Mainland: outside the Chinese mainland.</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Tencent disable reason. Available values:
        /// <li>ForLegalReasons: Acceleration disabled due to legal reasons;</li>
        /// <li>ForOverdueBills: Acceleration is disabled due to service suspension for overdue payment.</li>
        /// </summary>
        [JsonProperty("TencentDisableReason")]
        public string TencentDisableReason{ get; set; }

        /// <summary>
        /// CNAME domain name corresponding to the acceleration domain.
        /// </summary>
        [JsonProperty("TencentEdgeDomain")]
        public string TencentEdgeDomain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "TencentDisableReason", this.TencentDisableReason);
            this.SetParamSimple(map, prefix + "TencentEdgeDomain", this.TencentEdgeDomain);
        }
    }
}

