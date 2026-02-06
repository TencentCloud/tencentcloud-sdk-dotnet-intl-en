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

    public class AccessAnalysisDetail : AbstractModel
    {
        
        /// <summary>
        /// Number of active devices
        /// </summary>
        [JsonProperty("ActiveCount")]
        public long? ActiveCount{ get; set; }

        /// <summary>
        /// Average visit duration per user
        /// </summary>
        [JsonProperty("AvgDevice")]
        public string AvgDevice{ get; set; }

        /// <summary>
        /// Average visit duration per session
        /// </summary>
        [JsonProperty("AvgOnce")]
        public string AvgOnce{ get; set; }

        /// <summary>
        /// Average opens per user
        /// </summary>
        [JsonProperty("AvgOpenCount")]
        public string AvgOpenCount{ get; set; }

        /// <summary>
        /// Date
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }

        /// <summary>
        /// Data time
        /// </summary>
        [JsonProperty("FlushTime")]
        public string FlushTime{ get; set; }

        /// <summary>
        /// Number of new devices
        /// </summary>
        [JsonProperty("NewCount")]
        public long? NewCount{ get; set; }

        /// <summary>
        /// Number of opens
        /// </summary>
        [JsonProperty("OpenCount")]
        public long? OpenCount{ get; set; }

        /// <summary>
        /// Number of shares
        /// </summary>
        [JsonProperty("TotalShareNum")]
        public long? TotalShareNum{ get; set; }

        /// <summary>
        /// Cumulative users
        /// </summary>
        [JsonProperty("TotalUserNum")]
        public long? TotalUserNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActiveCount", this.ActiveCount);
            this.SetParamSimple(map, prefix + "AvgDevice", this.AvgDevice);
            this.SetParamSimple(map, prefix + "AvgOnce", this.AvgOnce);
            this.SetParamSimple(map, prefix + "AvgOpenCount", this.AvgOpenCount);
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
            this.SetParamSimple(map, prefix + "FlushTime", this.FlushTime);
            this.SetParamSimple(map, prefix + "NewCount", this.NewCount);
            this.SetParamSimple(map, prefix + "OpenCount", this.OpenCount);
            this.SetParamSimple(map, prefix + "TotalShareNum", this.TotalShareNum);
            this.SetParamSimple(map, prefix + "TotalUserNum", this.TotalUserNum);
        }
    }
}

