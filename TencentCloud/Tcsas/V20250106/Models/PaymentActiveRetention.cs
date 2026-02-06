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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PaymentActiveRetention : AbstractModel
    {
        
        /// <summary>
        /// Day 1 active retention of paying users
        /// </summary>
        [JsonProperty("OneDayRetentionUsers")]
        public long? OneDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 2 active retention of paying users
        /// </summary>
        [JsonProperty("TwoDayRetentionUsers")]
        public long? TwoDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 3 active retention of paying users
        /// </summary>
        [JsonProperty("ThreeDayRetentionUsers")]
        public long? ThreeDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 4 active retention of paying users
        /// </summary>
        [JsonProperty("FourDayRetentionUsers")]
        public long? FourDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 5 active retention of paying users
        /// </summary>
        [JsonProperty("FiveDayRetentionUsers")]
        public long? FiveDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 6 active retention of paying users
        /// </summary>
        [JsonProperty("SixDayRetentionUsers")]
        public long? SixDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 7 active retention of paying users
        /// </summary>
        [JsonProperty("SevenDayRetentionUsers")]
        public long? SevenDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 14 active retention of paying users
        /// </summary>
        [JsonProperty("FourteenDayRetentionUsers")]
        public long? FourteenDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 15 active retention of paying users
        /// </summary>
        [JsonProperty("FifteenDayRetentionUsers")]
        public long? FifteenDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 30 active retention of paying users
        /// </summary>
        [JsonProperty("ThirtyDayRetentionUsers")]
        public long? ThirtyDayRetentionUsers{ get; set; }

        /// <summary>
        /// Number of paying users
        /// </summary>
        [JsonProperty("PaymentUserNum")]
        public long? PaymentUserNum{ get; set; }

        /// <summary>
        /// Data time in YYYYMMDD format
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OneDayRetentionUsers", this.OneDayRetentionUsers);
            this.SetParamSimple(map, prefix + "TwoDayRetentionUsers", this.TwoDayRetentionUsers);
            this.SetParamSimple(map, prefix + "ThreeDayRetentionUsers", this.ThreeDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FourDayRetentionUsers", this.FourDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FiveDayRetentionUsers", this.FiveDayRetentionUsers);
            this.SetParamSimple(map, prefix + "SixDayRetentionUsers", this.SixDayRetentionUsers);
            this.SetParamSimple(map, prefix + "SevenDayRetentionUsers", this.SevenDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FourteenDayRetentionUsers", this.FourteenDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FifteenDayRetentionUsers", this.FifteenDayRetentionUsers);
            this.SetParamSimple(map, prefix + "ThirtyDayRetentionUsers", this.ThirtyDayRetentionUsers);
            this.SetParamSimple(map, prefix + "PaymentUserNum", this.PaymentUserNum);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
        }
    }
}

