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

    public class AdTrendChart : AbstractModel
    {
        
        /// <summary>
        /// Estimated revenue
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EstimatedEarnings")]
        public AnalysisData[] EstimatedEarnings{ get; set; }

        /// <summary>
        /// Requests
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RequestsNumber")]
        public AnalysisData[] RequestsNumber{ get; set; }

        /// <summary>
        /// Impressions
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Impressions")]
        public AnalysisData[] Impressions{ get; set; }

        /// <summary>
        /// Effective Cost Per Mille
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ECPM")]
        public AnalysisData[] ECPM{ get; set; }

        /// <summary>
        /// Taps
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClicksNumber")]
        public AnalysisData[] ClicksNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "EstimatedEarnings.", this.EstimatedEarnings);
            this.SetParamArrayObj(map, prefix + "RequestsNumber.", this.RequestsNumber);
            this.SetParamArrayObj(map, prefix + "Impressions.", this.Impressions);
            this.SetParamArrayObj(map, prefix + "ECPM.", this.ECPM);
            this.SetParamArrayObj(map, prefix + "ClicksNumber.", this.ClicksNumber);
        }
    }
}

