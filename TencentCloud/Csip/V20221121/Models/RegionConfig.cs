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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Region.</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Region in Chinese</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>Outside Chinese Mainland or not</p>
        /// </summary>
        [JsonProperty("Foreign")]
        public long? Foreign{ get; set; }

        /// <summary>
        /// <p>Region code</p>
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// <p>Whether self-driving cloud</p>
        /// </summary>
        [JsonProperty("IsAutoDriveCloud")]
        public long? IsAutoDriveCloud{ get; set; }

        /// <summary>
        /// <p>nat support</p>
        /// </summary>
        [JsonProperty("IsSupportNat")]
        public long? IsSupportNat{ get; set; }

        /// <summary>
        /// <p>Region information</p>
        /// </summary>
        [JsonProperty("RegionArea")]
        public string RegionArea{ get; set; }

        /// <summary>
        /// <p>Region in English</p>
        /// </summary>
        [JsonProperty("RegionNameEN")]
        public string RegionNameEN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Foreign", this.Foreign);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "IsAutoDriveCloud", this.IsAutoDriveCloud);
            this.SetParamSimple(map, prefix + "IsSupportNat", this.IsSupportNat);
            this.SetParamSimple(map, prefix + "RegionArea", this.RegionArea);
            this.SetParamSimple(map, prefix + "RegionNameEN", this.RegionNameEN);
        }
    }
}

