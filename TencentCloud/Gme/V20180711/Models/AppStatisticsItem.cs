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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppStatisticsItem : AbstractModel
    {
        
        /// <summary>
        /// Voice Chat statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealtimeSpeechStatisticsItem")]
        public RealTimeSpeechStatisticsItem RealtimeSpeechStatisticsItem{ get; set; }

        /// <summary>
        /// Voice Message statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceMessageStatisticsItem")]
        public VoiceMessageStatisticsItem VoiceMessageStatisticsItem{ get; set; }

        /// <summary>
        /// Phrase Filtering statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VoiceFilterStatisticsItem")]
        public VoiceFilterStatisticsItem VoiceFilterStatisticsItem{ get; set; }

        /// <summary>
        /// Reference period
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// Recording-to-Text usage statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AudioTextStatisticsItem")]
        public AudioTextStatisticsItem AudioTextStatisticsItem{ get; set; }

        /// <summary>
        /// Stream-to-Text usage statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StreamTextStatisticsItem")]
        public StreamTextStatisticsItem StreamTextStatisticsItem{ get; set; }

        /// <summary>
        /// Usage statistics of Voice-to-Text of outside-MLC requests
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OverseaTextStatisticsItem")]
        public OverseaTextStatisticsItem OverseaTextStatisticsItem{ get; set; }

        /// <summary>
        /// Real-time Voice-to-Text usage statistics
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RealtimeTextStatisticsItem")]
        public RealtimeTextStatisticsItem RealtimeTextStatisticsItem{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "RealtimeSpeechStatisticsItem.", this.RealtimeSpeechStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceMessageStatisticsItem.", this.VoiceMessageStatisticsItem);
            this.SetParamObj(map, prefix + "VoiceFilterStatisticsItem.", this.VoiceFilterStatisticsItem);
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamObj(map, prefix + "AudioTextStatisticsItem.", this.AudioTextStatisticsItem);
            this.SetParamObj(map, prefix + "StreamTextStatisticsItem.", this.StreamTextStatisticsItem);
            this.SetParamObj(map, prefix + "OverseaTextStatisticsItem.", this.OverseaTextStatisticsItem);
            this.SetParamObj(map, prefix + "RealtimeTextStatisticsItem.", this.RealtimeTextStatisticsItem);
        }
    }
}

