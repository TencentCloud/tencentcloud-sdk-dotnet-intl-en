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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePushBandwidthAndFluxListRequest : AbstractModel
    {
        
        /// <summary>
        /// Query start time point, accurate to minute granularity. The interface query supports two time formats:
        /// 
        /// YYYY-MM-DDThh:mm:ssZ: UTC time format, refer to ISO date format descriptionfor details.
        /// 
        /// YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// 
        /// Queries for the most recent two months are supported. The span between query start and end time cannot exceed 31 days.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Query end time point, accurate to minute granularity. The interface query supports two time formats:
        /// 
        /// YYYY-MM-DDThh:mm:ssZ: UTC time format, refer to ISO date format descriptionfor details.
        /// 
        /// YYYY-MM-DD hh:mm:ss: When using this format, it represents Beijing time by default.
        /// 
        /// Queries for the most recent two months are supported. The span between query start and end time cannot exceed 31 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Domain name, you can fill in multiple. If left blank, it represents the overall data.
        /// </summary>
        [JsonProperty("PushDomains")]
        public string[] PushDomains{ get; set; }

        /// <summary>
        /// Optional values: Mainland: Query data for Mainland China (domestic). Oversea: Query data for international/regions such as Hong Kong, Macao, Taiwan (overseas). If left blank, it defaults to querying global data (domestic + overseas).
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// Data granularity, supports the following granularities: 5: 5-minute granularity (span cannot exceed 1 day), 60: 1-hour granularity (span cannot exceed 1 month), 1440: daily granularity (span cannot exceed 1 month). Default value: 5.
        /// </summary>
        [JsonProperty("Granularity")]
        public ulong? Granularity{ get; set; }

        /// <summary>
        /// Region, mapping table as follows: China Mainland: Mainland China, Asia Pacific I: Asia Pacific Region 1, Asia Pacific II: Asia Pacific Region 2, Asia Pacific III: Asia Pacific Region 3, Europe: Europe, North America: North America, South America: South America, Middle East: Middle East, Africa: Africa.
        /// </summary>
        [JsonProperty("RegionNames")]
        public string[] RegionNames{ get; set; }

        /// <summary>
        /// Country, the mapping table is referenced as follows in the document: https://cloud.tencent.com/document/product/267/34019.
        /// </summary>
        [JsonProperty("CountryNames")]
        public string[] CountryNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "PushDomains.", this.PushDomains);
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "Granularity", this.Granularity);
            this.SetParamArraySimple(map, prefix + "RegionNames.", this.RegionNames);
            this.SetParamArraySimple(map, prefix + "CountryNames.", this.CountryNames);
        }
    }
}

