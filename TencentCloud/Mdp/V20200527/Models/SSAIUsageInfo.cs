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

namespace TencentCloud.Mdp.V20200527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIUsageInfo : AbstractModel
    {
        
        /// <summary>
        /// Number of successful ad requests.
        /// </summary>
        [JsonProperty("AdRequestSuccess")]
        public ulong? AdRequestSuccess{ get; set; }

        /// <summary>
        /// Number of failed ad requests.
        /// </summary>
        [JsonProperty("AdRequestFail")]
        public ulong? AdRequestFail{ get; set; }

        /// <summary>
        /// Exposure count.
        /// </summary>
        [JsonProperty("Impression")]
        public ulong? Impression{ get; set; }

        /// <summary>
        /// Fill factor for personalized ads.
        /// </summary>
        [JsonProperty("MidFillRate")]
        public float? MidFillRate{ get; set; }

        /// <summary>
        /// Advertising tag time.
        /// </summary>
        [JsonProperty("AdMarkerTime")]
        public float? AdMarkerTime{ get; set; }

        /// <summary>
        /// Personalization replacement time.
        /// </summary>
        [JsonProperty("ReplacedTime")]
        public float? ReplacedTime{ get; set; }

        /// <summary>
        /// Ad replacement rate.
        /// </summary>
        [JsonProperty("PreReplaceRate")]
        public float? PreReplaceRate{ get; set; }

        /// <summary>
        /// Number of pre-roll ad requests.
        /// </summary>
        [JsonProperty("PreReqNum")]
        public ulong? PreReqNum{ get; set; }

        /// <summary>
        /// Number of pre-roll ad replacements.
        /// </summary>
        [JsonProperty("PreReplacedNum")]
        public ulong? PreReplacedNum{ get; set; }

        /// <summary>
        /// Configures usage for each ad.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UsageDetails")]
        public UsageDetail[] UsageDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AdRequestSuccess", this.AdRequestSuccess);
            this.SetParamSimple(map, prefix + "AdRequestFail", this.AdRequestFail);
            this.SetParamSimple(map, prefix + "Impression", this.Impression);
            this.SetParamSimple(map, prefix + "MidFillRate", this.MidFillRate);
            this.SetParamSimple(map, prefix + "AdMarkerTime", this.AdMarkerTime);
            this.SetParamSimple(map, prefix + "ReplacedTime", this.ReplacedTime);
            this.SetParamSimple(map, prefix + "PreReplaceRate", this.PreReplaceRate);
            this.SetParamSimple(map, prefix + "PreReqNum", this.PreReqNum);
            this.SetParamSimple(map, prefix + "PreReplacedNum", this.PreReplacedNum);
            this.SetParamArrayObj(map, prefix + "UsageDetails.", this.UsageDetails);
        }
    }
}

