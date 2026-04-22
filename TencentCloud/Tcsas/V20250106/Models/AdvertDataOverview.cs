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

    public class AdvertDataOverview : AbstractModel
    {
        
        /// <summary>
        /// Estimated revenue
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EstimatedEarnings")]
        public string EstimatedEarnings{ get; set; }

        /// <summary>
        /// Requests
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestsNumber")]
        public long? RequestsNumber{ get; set; }

        /// <summary>
        /// Impressions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Impressions")]
        public long? Impressions{ get; set; }

        /// <summary>
        /// Taps
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClicksNumber")]
        public long? ClicksNumber{ get; set; }

        /// <summary>
        /// Impressions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ECPM")]
        public string ECPM{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EstimatedEarnings", this.EstimatedEarnings);
            this.SetParamSimple(map, prefix + "RequestsNumber", this.RequestsNumber);
            this.SetParamSimple(map, prefix + "Impressions", this.Impressions);
            this.SetParamSimple(map, prefix + "ClicksNumber", this.ClicksNumber);
            this.SetParamSimple(map, prefix + "ECPM", this.ECPM);
        }
    }
}

