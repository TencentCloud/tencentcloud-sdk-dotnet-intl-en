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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Region : AbstractModel
    {
        
        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// Region name
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Area name
        /// </summary>
        [JsonProperty("AreaName")]
        public string AreaName{ get; set; }

        /// <summary>
        /// Region code
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// Region code (v3)
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RegionCodeV3")]
        public string RegionCodeV3{ get; set; }

        /// <summary>
        /// NONE: no special models are supported by default.\nCVM: the CVM type is supported.
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Support")]
        public string Support{ get; set; }

        /// <summary>
        /// Whether IPv6 is supported. `0` indicates no, and `1` indicates yes.
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Ipv6")]
        public long? Ipv6{ get; set; }

        /// <summary>
        /// Whether cross-AZ clusters are supported.`0` indicates no, and `1` indicates yes.
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("MultiZone")]
        public long? MultiZone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "AreaName", this.AreaName);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "RegionCodeV3", this.RegionCodeV3);
            this.SetParamSimple(map, prefix + "Support", this.Support);
            this.SetParamSimple(map, prefix + "Ipv6", this.Ipv6);
            this.SetParamSimple(map, prefix + "MultiZone", this.MultiZone);
        }
    }
}

