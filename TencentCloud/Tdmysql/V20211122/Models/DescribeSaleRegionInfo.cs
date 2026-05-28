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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSaleRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>English string of Region</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Purchasable Zone list</p>
        /// </summary>
        [JsonProperty("ZoneList")]
        public DescribeSaleZonesInfo[] ZoneList{ get; set; }

        /// <summary>
        /// <p>Region Chinese character string</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>Whether to sell. 1: sell, 0: do not sell</p>
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// <p>Optional quantity of multiple availability</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AvailableZoneNum")]
        public long? AvailableZoneNum{ get; set; }

        /// <summary>
        /// <p>Whether to allow usage log replica</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsSupportedLogReplica")]
        public bool? IsSupportedLogReplica{ get; set; }

        /// <summary>
        /// <p>Availability zone combination</p>
        /// </summary>
        [JsonProperty("ZoneGroup")]
        public DescribeSaleZonesGroup[] ZoneGroup{ get; set; }

        /// <summary>
        /// <p>Whether serverless is supported</p>
        /// </summary>
        [JsonProperty("IsSupportServerless")]
        public bool? IsSupportServerless{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "AvailableZoneNum", this.AvailableZoneNum);
            this.SetParamSimple(map, prefix + "IsSupportedLogReplica", this.IsSupportedLogReplica);
            this.SetParamArrayObj(map, prefix + "ZoneGroup.", this.ZoneGroup);
            this.SetParamSimple(map, prefix + "IsSupportServerless", this.IsSupportServerless);
        }
    }
}

