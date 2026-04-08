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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartSubtitleTaskTransTextSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Confidence of a recognized segment. Value range: 0-100.</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>Start time offset of a recognized segment, in seconds.</p>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// <p>End time offset of a recognized segment, in seconds.</p>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// <p>Recognized text.</p>
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// <p>Translated text.</p>
        /// </summary>
        [JsonProperty("Trans")]
        public string Trans{ get; set; }

        /// <summary>
        /// <p>Word timestamp information.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Wordlist")]
        public WordResult[] Wordlist{ get; set; }

        /// <summary>
        /// <p>Speaker ID (if speaker recognition is enabled)</p>
        /// </summary>
        [JsonProperty("SpeakerId")]
        public string SpeakerId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "Trans", this.Trans);
            this.SetParamArrayObj(map, prefix + "Wordlist.", this.Wordlist);
            this.SetParamSimple(map, prefix + "SpeakerId", this.SpeakerId);
        }
    }
}

