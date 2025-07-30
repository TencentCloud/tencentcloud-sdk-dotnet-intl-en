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

    public class UsageDetail : AbstractModel
    {
        
        /// <summary>
        /// Ad insertion configuration uniq_id.
        /// </summary>
        [JsonProperty("UniqId")]
        public string UniqId{ get; set; }

        /// <summary>
        /// Ad insertion configuration id.
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Ad insertion configuration name.
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// Ad type.
        /// </summary>
        [JsonProperty("AdType")]
        public string AdType{ get; set; }

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
        /// Number of ad exposures.
        /// </summary>
        [JsonProperty("Impression")]
        public ulong? Impression{ get; set; }

        /// <summary>
        /// Number of ad playbacks started.
        /// </summary>
        [JsonProperty("Start")]
        public ulong? Start{ get; set; }

        /// <summary>
        /// Ad plays at 1/4 point.
        /// </summary>
        [JsonProperty("FirstQuarter")]
        public ulong? FirstQuarter{ get; set; }

        /// <summary>
        /// Ad plays at 1/2 point.
        /// </summary>
        [JsonProperty("Midpoint")]
        public ulong? Midpoint{ get; set; }

        /// <summary>
        /// Ad plays at 3/4 point.
        /// </summary>
        [JsonProperty("ThirdQuarter")]
        public ulong? ThirdQuarter{ get; set; }

        /// <summary>
        /// Number of ad playbacks completed.
        /// </summary>
        [JsonProperty("Complete")]
        public ulong? Complete{ get; set; }

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
        /// Fill factor for personalized ads.
        /// </summary>
        [JsonProperty("MidFillRate")]
        public float? MidFillRate{ get; set; }

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
        /// Ad replacement rate.
        /// </summary>
        [JsonProperty("PreReplaceRate")]
        public float? PreReplaceRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqId", this.UniqId);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "AdType", this.AdType);
            this.SetParamSimple(map, prefix + "AdRequestSuccess", this.AdRequestSuccess);
            this.SetParamSimple(map, prefix + "AdRequestFail", this.AdRequestFail);
            this.SetParamSimple(map, prefix + "Impression", this.Impression);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "FirstQuarter", this.FirstQuarter);
            this.SetParamSimple(map, prefix + "Midpoint", this.Midpoint);
            this.SetParamSimple(map, prefix + "ThirdQuarter", this.ThirdQuarter);
            this.SetParamSimple(map, prefix + "Complete", this.Complete);
            this.SetParamSimple(map, prefix + "AdMarkerTime", this.AdMarkerTime);
            this.SetParamSimple(map, prefix + "ReplacedTime", this.ReplacedTime);
            this.SetParamSimple(map, prefix + "MidFillRate", this.MidFillRate);
            this.SetParamSimple(map, prefix + "PreReqNum", this.PreReqNum);
            this.SetParamSimple(map, prefix + "PreReplacedNum", this.PreReplacedNum);
            this.SetParamSimple(map, prefix + "PreReplaceRate", this.PreReplaceRate);
        }
    }
}

