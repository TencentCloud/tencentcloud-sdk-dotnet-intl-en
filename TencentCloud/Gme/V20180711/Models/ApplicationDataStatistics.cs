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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplicationDataStatistics : AbstractModel
    {
        
        /// <summary>
        /// Application ID
        /// </summary>
        [JsonProperty("BizId")]
        public ulong? BizId{ get; set; }

        /// <summary>
        /// Number of DAU metrics
        /// </summary>
        [JsonProperty("DauDataNum")]
        public ulong? DauDataNum{ get; set; }

        /// <summary>
        /// DAUs in the Chinese mainland
        /// </summary>
        [JsonProperty("DauDataMainland")]
        public StatisticsItem[] DauDataMainland{ get; set; }

        /// <summary>
        /// DAUs outside the Chinese mainland
        /// </summary>
        [JsonProperty("DauDataOversea")]
        public StatisticsItem[] DauDataOversea{ get; set; }

        /// <summary>
        /// Total DAUs
        /// </summary>
        [JsonProperty("DauDataSum")]
        public StatisticsItem[] DauDataSum{ get; set; }

        /// <summary>
        /// Number of Voice Chat metrics
        /// </summary>
        [JsonProperty("DurationDataNum")]
        public ulong? DurationDataNum{ get; set; }

        /// <summary>
        /// Duration of Voice Chat in the Chinese mainland (in minutes)
        /// </summary>
        [JsonProperty("DurationDataMainland")]
        public StatisticsItem[] DurationDataMainland{ get; set; }

        /// <summary>
        /// Duration of Voice Chat outside the Chinese mainland (in minutes)
        /// </summary>
        [JsonProperty("DurationDataOversea")]
        public StatisticsItem[] DurationDataOversea{ get; set; }

        /// <summary>
        /// Total duration of Voice Chat (in minutes)
        /// </summary>
        [JsonProperty("DurationDataSum")]
        public StatisticsItem[] DurationDataSum{ get; set; }

        /// <summary>
        /// Number of PCU metrics
        /// </summary>
        [JsonProperty("PcuDataNum")]
        public ulong? PcuDataNum{ get; set; }

        /// <summary>
        /// PCUs in the Chinese mainland
        /// </summary>
        [JsonProperty("PcuDataMainland")]
        public StatisticsItem[] PcuDataMainland{ get; set; }

        /// <summary>
        /// PCUs outside the Chinese mainland
        /// </summary>
        [JsonProperty("PcuDataOversea")]
        public StatisticsItem[] PcuDataOversea{ get; set; }

        /// <summary>
        /// Total PCUs
        /// </summary>
        [JsonProperty("PcuDataSum")]
        public StatisticsItem[] PcuDataSum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizId", this.BizId);
            this.SetParamSimple(map, prefix + "DauDataNum", this.DauDataNum);
            this.SetParamArrayObj(map, prefix + "DauDataMainland.", this.DauDataMainland);
            this.SetParamArrayObj(map, prefix + "DauDataOversea.", this.DauDataOversea);
            this.SetParamArrayObj(map, prefix + "DauDataSum.", this.DauDataSum);
            this.SetParamSimple(map, prefix + "DurationDataNum", this.DurationDataNum);
            this.SetParamArrayObj(map, prefix + "DurationDataMainland.", this.DurationDataMainland);
            this.SetParamArrayObj(map, prefix + "DurationDataOversea.", this.DurationDataOversea);
            this.SetParamArrayObj(map, prefix + "DurationDataSum.", this.DurationDataSum);
            this.SetParamSimple(map, prefix + "PcuDataNum", this.PcuDataNum);
            this.SetParamArrayObj(map, prefix + "PcuDataMainland.", this.PcuDataMainland);
            this.SetParamArrayObj(map, prefix + "PcuDataOversea.", this.PcuDataOversea);
            this.SetParamArrayObj(map, prefix + "PcuDataSum.", this.PcuDataSum);
        }
    }
}

