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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionDetail : AbstractModel
    {
        
        /// <summary>
        /// Region ID
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// Region name in Chinese or English
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// Region where the data center locates
        /// </summary>
        [JsonProperty("RegionArea")]
        public string RegionArea{ get; set; }

        /// <summary>
        /// Name of the region where the data center locates
        /// </summary>
        [JsonProperty("RegionAreaName")]
        public string RegionAreaName{ get; set; }

        /// <summary>
        /// Data center type. `dc`: data center; `ec`: edge server.
        /// </summary>
        [JsonProperty("IDCType")]
        public string IDCType{ get; set; }

        /// <summary>
        /// Feature bitmap. Valid values:
        /// `0`: the feature is not supported;
        /// `1`: the feature is supported.
        /// Each bit in the bitmap represents a feature:
        /// 1st bit: layer-4 acceleration;
        /// 2nd bit: layer-7 acceleration;
        /// 3rd bit: HTTP3 access;
        /// 4th bit: IPv6;
        /// 5th bit: dedicated BGP access;
        /// 6th bit: non-BGP access;
        /// 7th bit: QoS acceleration.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FeatureBitmap")]
        public ulong? FeatureBitmap{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionArea", this.RegionArea);
            this.SetParamSimple(map, prefix + "RegionAreaName", this.RegionAreaName);
            this.SetParamSimple(map, prefix + "IDCType", this.IDCType);
            this.SetParamSimple(map, prefix + "FeatureBitmap", this.FeatureBitmap);
        }
    }
}

