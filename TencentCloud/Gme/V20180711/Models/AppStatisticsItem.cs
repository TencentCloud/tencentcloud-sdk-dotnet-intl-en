/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppStatisticsItem : AbstractModel
    {
        
        /// <summary>
        /// Voice chat statistics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealtimeSpeechStatisticsItem")]
        public RealTimeSpeechStatisticsItem RealtimeSpeechStatisticsItem{ get; set; }

        /// <summary>
        /// Voice messaging statistics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceMessageStatisticsItem")]
        public VoiceMessageStatisticsItem VoiceMessageStatisticsItem{ get; set; }

        /// <summary>
        /// Phrase filtering statistics
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceFilterStatisticsItem")]
        public VoiceFilterStatisticsItem VoiceFilterStatisticsItem{ get; set; }

        /// <summary>
        /// Statistical period
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RealtimeSpeechStatisticsItem.", this.RealtimeSpeechStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceMessageStatisticsItem.", this.VoiceMessageStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceFilterStatisticsItem.", this.VoiceFilterStatisticsItem);
            this.SetParamSimple(map, prefix + "Date", this.Date);
        }
    }
}

