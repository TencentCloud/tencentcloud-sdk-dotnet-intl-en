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

    public class RetentionData : AbstractModel
    {
        
        /// <summary>
        /// Number of active users
        /// </summary>
        [JsonProperty("ActiveUserCount")]
        public long? ActiveUserCount{ get; set; }

        /// <summary>
        /// Day 1 retention of active users
        /// </summary>
        [JsonProperty("OneDayRetentionUsers")]
        public long? OneDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 2 retention of active users
        /// </summary>
        [JsonProperty("TwoDayRetentionUsers")]
        public long? TwoDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 3 retention of active users
        /// </summary>
        [JsonProperty("ThreeDayRetentionUsers")]
        public long? ThreeDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 4 retention of active users
        /// </summary>
        [JsonProperty("FourDayRetentionUsers")]
        public long? FourDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 5 retention of active users
        /// </summary>
        [JsonProperty("FiveDayRetentionUsers")]
        public long? FiveDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 6 retention of active users
        /// </summary>
        [JsonProperty("SixDayRetentionUsers")]
        public long? SixDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 7 retention of active users
        /// </summary>
        [JsonProperty("SevenDayRetentionUsers")]
        public long? SevenDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 14 retention of active users
        /// </summary>
        [JsonProperty("FourteenDayRetentionUsers")]
        public long? FourteenDayRetentionUsers{ get; set; }

        /// <summary>
        /// Day 30 retention of active users
        /// </summary>
        [JsonProperty("ThirtyDayRetentionUsers")]
        public long? ThirtyDayRetentionUsers{ get; set; }

        /// <summary>
        /// Number of new users
        /// </summary>
        [JsonProperty("NewUserCount")]
        public long? NewUserCount{ get; set; }

        /// <summary>
        /// Day 1 retention of new users
        /// </summary>
        [JsonProperty("OneDayRetentionNewUsers")]
        public long? OneDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 2 retention of new users
        /// </summary>
        [JsonProperty("TwoDayRetentionNewUsers")]
        public long? TwoDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 3 retention of new users
        /// </summary>
        [JsonProperty("ThreeDayRetentionNewUsers")]
        public long? ThreeDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 4 retention of new users
        /// </summary>
        [JsonProperty("FourDayRetentionNewUsers")]
        public long? FourDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 5 retention of new users
        /// </summary>
        [JsonProperty("FiveDayRetentionNewUsers")]
        public long? FiveDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 6 retention of new users
        /// </summary>
        [JsonProperty("SixDayRetentionNewUsers")]
        public long? SixDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 7 retention of new users
        /// </summary>
        [JsonProperty("SevenDayRetentionNewUsers")]
        public long? SevenDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 14 retention of new users
        /// </summary>
        [JsonProperty("FourteenDayRetentionNewUsers")]
        public long? FourteenDayRetentionNewUsers{ get; set; }

        /// <summary>
        /// Day 30 retention of new users
        /// </summary>
        [JsonProperty("ThirtyDayRetentionNewUsers")]
        public long? ThirtyDayRetentionNewUsers{ get; set; }

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
            this.SetParamSimple(map, prefix + "ActiveUserCount", this.ActiveUserCount);
            this.SetParamSimple(map, prefix + "OneDayRetentionUsers", this.OneDayRetentionUsers);
            this.SetParamSimple(map, prefix + "TwoDayRetentionUsers", this.TwoDayRetentionUsers);
            this.SetParamSimple(map, prefix + "ThreeDayRetentionUsers", this.ThreeDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FourDayRetentionUsers", this.FourDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FiveDayRetentionUsers", this.FiveDayRetentionUsers);
            this.SetParamSimple(map, prefix + "SixDayRetentionUsers", this.SixDayRetentionUsers);
            this.SetParamSimple(map, prefix + "SevenDayRetentionUsers", this.SevenDayRetentionUsers);
            this.SetParamSimple(map, prefix + "FourteenDayRetentionUsers", this.FourteenDayRetentionUsers);
            this.SetParamSimple(map, prefix + "ThirtyDayRetentionUsers", this.ThirtyDayRetentionUsers);
            this.SetParamSimple(map, prefix + "NewUserCount", this.NewUserCount);
            this.SetParamSimple(map, prefix + "OneDayRetentionNewUsers", this.OneDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "TwoDayRetentionNewUsers", this.TwoDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "ThreeDayRetentionNewUsers", this.ThreeDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "FourDayRetentionNewUsers", this.FourDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "FiveDayRetentionNewUsers", this.FiveDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "SixDayRetentionNewUsers", this.SixDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "SevenDayRetentionNewUsers", this.SevenDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "FourteenDayRetentionNewUsers", this.FourteenDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "ThirtyDayRetentionNewUsers", this.ThirtyDayRetentionNewUsers);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
        }
    }
}

