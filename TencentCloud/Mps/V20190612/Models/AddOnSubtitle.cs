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

    public class AddOnSubtitle : AbstractModel
    {
        
        /// <summary>
        /// <p>Insertion method. Valid values:</p><li>subtitle-stream: Inserts a subtitle track.</li><li>close-caption-708: Encodes CEA-708 subtitles into SEI frames.</li><li>close-caption-608: Encodes CEA-608 subtitles into SEI frames.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Subtitle file.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Subtitle")]
        public MediaInputInfo Subtitle{ get; set; }

        /// <summary>
        /// <p>Subtitle name.<br>Note: Only Chinese characters, letters, digits, spaces, underscores (_), hyphens (-), periods (.), and brackets are supported. The length cannot exceed 64 characters.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubtitleName")]
        public string SubtitleName{ get; set; }

        /// <summary>
        /// <p>Subtitle language, such as eng.</p>
        /// </summary>
        [JsonProperty("SubtitleLanguage")]
        public string SubtitleLanguage{ get; set; }

        /// <summary>
        /// <p>Subtitle output format. Valid values: {&quot;WebVTT&quot;,&quot;TTML&quot;}.<br>Default value: &quot;WebVTT&quot;.</p>
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// <p>Default subtitle track. When set to true, the current subtitle is designated as the default subtitle track. A maximum of 1 default subtitle track can be specified.<br>Default value: false.</p>
        /// </summary>
        [JsonProperty("DefaultTrack")]
        public bool? DefaultTrack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Subtitle.", this.Subtitle);
            this.SetParamSimple(map, prefix + "SubtitleName", this.SubtitleName);
            this.SetParamSimple(map, prefix + "SubtitleLanguage", this.SubtitleLanguage);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamSimple(map, prefix + "DefaultTrack", this.DefaultTrack);
        }
    }
}

