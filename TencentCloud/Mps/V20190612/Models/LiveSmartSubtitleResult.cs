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

    public class LiveSmartSubtitleResult : AbstractModel
    {
        
        /// <summary>
        /// Recognized text.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Translate the starting PTS time of a segment, in seconds.
        /// </summary>
        [JsonProperty("StartPTSTime")]
        public float? StartPTSTime{ get; set; }

        /// <summary>
        /// End PTS time of a translated segment, in seconds.
        /// </summary>
        [JsonProperty("EndPTSTime")]
        public float? EndPTSTime{ get; set; }

        /// <summary>
        /// Translated text.
        /// </summary>
        [JsonProperty("Trans")]
        public string Trans{ get; set; }

        /// <summary>
        /// Translation started at UTC time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Translation ends at UTC time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Steady-State tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SteadyState")]
        public bool? SteadyState{ get; set; }

        /// <summary>
        /// websocket and trtc real-time translation UserId.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "StartPTSTime", this.StartPTSTime);
            this.SetParamSimple(map, prefix + "EndPTSTime", this.EndPTSTime);
            this.SetParamSimple(map, prefix + "Trans", this.Trans);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SteadyState", this.SteadyState);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

