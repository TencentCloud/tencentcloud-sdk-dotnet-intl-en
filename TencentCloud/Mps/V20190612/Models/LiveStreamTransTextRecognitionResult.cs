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

    public class LiveStreamTransTextRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// The text transcript.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// The PTS (seconds) of the start of a segment.
        /// </summary>
        [JsonProperty("StartPtsTime")]
        public float? StartPtsTime{ get; set; }

        /// <summary>
        /// The PTS (seconds) of the end of a segment.
        /// </summary>
        [JsonProperty("EndPtsTime")]
        public float? EndPtsTime{ get; set; }

        /// <summary>
        /// The confidence score for a segment. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// The translation.
        /// </summary>
        [JsonProperty("Trans")]
        public string Trans{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SteadyState")]
        public bool? SteadyState{ get; set; }

        /// <summary>
        /// User ID in the result of real-time translation via WebSocket and TRTC.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamSimple(map, prefix + "StartPtsTime", this.StartPtsTime);
            this.SetParamSimple(map, prefix + "EndPtsTime", this.EndPtsTime);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Trans", this.Trans);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SteadyState", this.SteadyState);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
        }
    }
}

