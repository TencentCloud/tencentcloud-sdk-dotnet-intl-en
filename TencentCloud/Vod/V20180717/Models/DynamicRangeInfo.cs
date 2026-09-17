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

    public class DynamicRangeInfo : AbstractModel
    {
        
        /// <summary>
        /// Visual dynamic range information. Valid values:
        /// <li>SDR: Standard Dynamic Range;</li>
        /// <li>HDR: High Dynamic Range.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// High dynamic range type. Valid when Type is HDR. Currently supported valid values:
        /// <li>hdr10: refers to the hdr10 standard;</li>
        /// <li>hlg: refers to the hlg standard.</li>
        /// </summary>
        [JsonProperty("HDRType")]
        public string HDRType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "HDRType", this.HDRType);
        }
    }
}

