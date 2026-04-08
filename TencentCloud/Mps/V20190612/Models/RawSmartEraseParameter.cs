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

    public class RawSmartEraseParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>Removal Type</p><ul><li>subtitle removal</li><li>watermark removal</li><li>privacy protection</li></ul>
        /// </summary>
        [JsonProperty("EraseType")]
        public string EraseType{ get; set; }

        /// <summary>
        /// <p>Subtitle erasing configuration;<br>This field is required when the value of EraseType is set to subtitle.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EraseSubtitleConfig")]
        public SmartEraseSubtitleConfig EraseSubtitleConfig{ get; set; }

        /// <summary>
        /// <p>Watermark erasing configuration.<br>This field is required when the value of EraseType is set to watermark.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EraseWatermarkConfig")]
        public SmartEraseWatermarkConfig EraseWatermarkConfig{ get; set; }

        /// <summary>
        /// <p>Privacy protection configuration.<br>This field is required when the value of EraseType is privacy.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ErasePrivacyConfig")]
        public SmartErasePrivacyConfig ErasePrivacyConfig{ get; set; }

        /// <summary>
        /// <p>id of the subtitle removal suppression template.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public long? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>Suppression configuration, enabled by default, moves subtitles back to the original subtitle position.</p>
        /// </summary>
        [JsonProperty("UseOriginalPos")]
        public long? UseOriginalPos{ get; set; }

        /// <summary>
        /// <p>Suppression configuration, enabled by default. When enabled, use the original subtitle font size.</p>
        /// </summary>
        [JsonProperty("UseOriginalSize")]
        public long? UseOriginalSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EraseType", this.EraseType);
            this.SetParamObj(map, prefix + "EraseSubtitleConfig.", this.EraseSubtitleConfig);
            this.SetParamObj(map, prefix + "EraseWatermarkConfig.", this.EraseWatermarkConfig);
            this.SetParamObj(map, prefix + "ErasePrivacyConfig.", this.ErasePrivacyConfig);
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "UseOriginalPos", this.UseOriginalPos);
            this.SetParamSimple(map, prefix + "UseOriginalSize", this.UseOriginalSize);
        }
    }
}

