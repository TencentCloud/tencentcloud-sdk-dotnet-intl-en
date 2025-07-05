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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CcnRegionBandwidthLimit : AbstractModel
    {
        
        /// <summary>
        /// Region, such as `ap-guangzhou`
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// The outbound bandwidth cap. Units: Mbps
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public ulong? BandwidthLimit{ get; set; }

        /// <summary>
        /// Whether it is a BM region. The default is `false`.
        /// </summary>
        [JsonProperty("IsBm")]
        public bool? IsBm{ get; set; }

        /// <summary>
        /// The target region, such as `ap-shanghai`
        /// Note: This field may return null, indicating no valid value.
        /// </summary>
        [JsonProperty("DstRegion")]
        public string DstRegion{ get; set; }

        /// <summary>
        /// Whether the target region is a BM region. The default is `false`.
        /// </summary>
        [JsonProperty("DstIsBm")]
        public bool? DstIsBm{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "IsBm", this.IsBm);
            this.SetParamSimple(map, prefix + "DstRegion", this.DstRegion);
            this.SetParamSimple(map, prefix + "DstIsBm", this.DstIsBm);
        }
    }
}

