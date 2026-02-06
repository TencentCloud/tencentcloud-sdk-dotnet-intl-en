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

    public class OverviewDetail : AbstractModel
    {
        
        /// <summary>
        /// Time
        /// </summary>
        [JsonProperty("DataTime")]
        public string DataTime{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("MNPName")]
        public string MNPName{ get; set; }

        /// <summary>
        /// Category
        /// </summary>
        [JsonProperty("MNPType")]
        public string MNPType{ get; set; }

        /// <summary>
        /// Estimated revenue
        /// </summary>
        [JsonProperty("EstimatedEarnings")]
        public string EstimatedEarnings{ get; set; }

        /// <summary>
        /// Requests
        /// </summary>
        [JsonProperty("RequestsNumber")]
        public long? RequestsNumber{ get; set; }

        /// <summary>
        /// Impressions
        /// </summary>
        [JsonProperty("Impressions")]
        public long? Impressions{ get; set; }

        /// <summary>
        /// Effective Cost Per Mille
        /// </summary>
        [JsonProperty("ECPM")]
        public string ECPM{ get; set; }

        /// <summary>
        /// Taps
        /// </summary>
        [JsonProperty("ClicksNumber")]
        public long? ClicksNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataTime", this.DataTime);
            this.SetParamSimple(map, prefix + "MNPName", this.MNPName);
            this.SetParamSimple(map, prefix + "MNPType", this.MNPType);
            this.SetParamSimple(map, prefix + "EstimatedEarnings", this.EstimatedEarnings);
            this.SetParamSimple(map, prefix + "RequestsNumber", this.RequestsNumber);
            this.SetParamSimple(map, prefix + "Impressions", this.Impressions);
            this.SetParamSimple(map, prefix + "ECPM", this.ECPM);
            this.SetParamSimple(map, prefix + "ClicksNumber", this.ClicksNumber);
        }
    }
}

