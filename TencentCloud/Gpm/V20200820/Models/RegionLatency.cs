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

namespace TencentCloud.Gpm.V20200820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RegionLatency : AbstractModel
    {
        
        /// <summary>
        /// Region
        /// ap-beijing          North China (Beijing)
        /// ap-chengdu          Southwest China (Chengdu)
        /// ap-guangzhou           South China (Guangzhou)
        /// ap-hongkong           Hong Kong/Macao/Taiwan (Hong Kong, China)
        /// ap-seoul          Asia Pacific (Seoul)
        /// ap-shanghai          East China (Shanghai)
        /// ap-singapore          Southeast Asia (Singapore)
        /// eu-frankfurt          Europe (Frankfurt)
        /// na-siliconvalley          Western US (Silicon Valley)
        /// na-toronto           North America (Toronto)
        /// ap-mumbai           Asia Pacific (Mumbai)
        /// na-ashburn          Eastern US (Virginia)
        /// ap-bangkok           Asia Pacific (Bangkok)
        /// eu-moscow           Europe (Moscow)
        /// ap-tokyo           Asia Pacific (Tokyo)
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Delay time in ms. Value range: 0 - 999999
        /// </summary>
        [JsonProperty("Latency")]
        public ulong? Latency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Latency", this.Latency);
        }
    }
}

