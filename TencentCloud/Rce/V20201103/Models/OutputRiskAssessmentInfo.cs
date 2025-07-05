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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputRiskAssessmentInfo : AbstractModel
    {
        
        /// <summary>
        /// Risk value.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Risk type.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// Device identification
        /// 
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// Extended attributes.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("ExtraInfo")]
        public OutputRiskAssessmentExtraInfoPair[] ExtraInfo{ get; set; }

        /// <summary>
        /// Token generation timestamp.
        /// Note: This field may return null, indicating that no valid value is found.
        /// </summary>
        [JsonProperty("TokenTime")]
        public string TokenTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamArrayObj(map, prefix + "ExtraInfo.", this.ExtraInfo);
            this.SetParamSimple(map, prefix + "TokenTime", this.TokenTime);
        }
    }
}

