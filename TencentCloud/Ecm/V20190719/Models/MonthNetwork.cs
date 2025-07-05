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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MonthNetwork : AbstractModel
    {
        
        /// <summary>
        /// Zone information of the node
        /// </summary>
        [JsonProperty("ZoneInfo")]
        public ZoneInfo ZoneInfo{ get; set; }

        /// <summary>
        /// Bandwidth month, such as `202103`
        /// </summary>
        [JsonProperty("Month")]
        public string Month{ get; set; }

        /// <summary>
        /// Bandwidth package ID format, such as `bwp-xxxxxxxx`
        /// </summary>
        [JsonProperty("BandwidthPkgId")]
        public string BandwidthPkgId{ get; set; }

        /// <summary>
        /// ISP abbreviation. Valid values: CUCC, CTCC, CMCC
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// Inbound bandwidth package peak. Value range: 0.0–xxx.xxx
        /// </summary>
        [JsonProperty("TrafficMaxIn")]
        public float? TrafficMaxIn{ get; set; }

        /// <summary>
        /// Outbound bandwidth package peak. Value range: 0.0–xxx.xxx
        /// </summary>
        [JsonProperty("TrafficMaxOut")]
        public float? TrafficMaxOut{ get; set; }

        /// <summary>
        /// Billable bandwidth. Value range: 0.0–xxx.xxx
        /// </summary>
        [JsonProperty("FeeTraffic")]
        public float? FeeTraffic{ get; set; }

        /// <summary>
        /// Start time of the monthly billable bandwidth in the format of `yyyy-mm-dd HH:mm:ss`
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the monthly billable bandwidth in the format of `yyyy-mm-dd HH:mm:ss`
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Number of actual valid days for the monthly billable bandwidth, which must be an integer greater than or equal to 0
        /// </summary>
        [JsonProperty("EffectiveDays")]
        public long? EffectiveDays{ get; set; }

        /// <summary>
        /// Actual number of days in the specified month, such as 30
        /// </summary>
        [JsonProperty("MonthDays")]
        public long? MonthDays{ get; set; }

        /// <summary>
        /// Proportion of the number of valid days, accurate to four decimal places, such as `0.2134`
        /// </summary>
        [JsonProperty("EffectiveDaysRate")]
        public float? EffectiveDaysRate{ get; set; }

        /// <summary>
        /// Billable bandwidth package type. Valid values: Address, LoadBalance, AddressIpv6
        /// </summary>
        [JsonProperty("BandwidthPkgType")]
        public string BandwidthPkgType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ZoneInfo.", this.ZoneInfo);
            this.SetParamSimple(map, prefix + "Month", this.Month);
            this.SetParamSimple(map, prefix + "BandwidthPkgId", this.BandwidthPkgId);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "TrafficMaxIn", this.TrafficMaxIn);
            this.SetParamSimple(map, prefix + "TrafficMaxOut", this.TrafficMaxOut);
            this.SetParamSimple(map, prefix + "FeeTraffic", this.FeeTraffic);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "EffectiveDays", this.EffectiveDays);
            this.SetParamSimple(map, prefix + "MonthDays", this.MonthDays);
            this.SetParamSimple(map, prefix + "EffectiveDaysRate", this.EffectiveDaysRate);
            this.SetParamSimple(map, prefix + "BandwidthPkgType", this.BandwidthPkgType);
        }
    }
}

