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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReviewAudioVideoSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// Time offset of the start of the suspected segment. Unit: second.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of the suspected segment, in seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Score of offensive information involved in suspected clips.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Result suggestions for identifying violations in suspected clips. Value range:
        /// <li>review: suspected violation, suggest re-examination;</li>
        /// <li>block: Confirmed violation. Suggest banning.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Label of the most likely rule violation in the suspected segment. Value range:
        /// <li>Porn: Pornography;</li>
        /// <li>Terror: violence.</li>
        /// <li>Polity: inappropriate information;</li>
        /// <li>Ad: advertisement;</li>
        /// <li>Illegal: illegal;</li>
        /// <li>Abuse: verbal abuse;</li>
        /// <li>Moan: panting.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Rule-violating subtag.
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// Suspected segment violation type. Value range:
        /// <li>Image: People or icons in the image;</li>
        /// <li>OCR: text on the screen;</li>
        /// <li>ASR: text in speech.</li>
        /// <li>Voice: sound.</li>
        /// </summary>
        [JsonProperty("Form")]
        public string Form{ get; set; }

        /// <summary>
        /// Valid when `Form` is `Image` or `OCR`. Indicates the area coordinates (pixel-level) where the suspect, icon, or text appears, in the format [x1, y1, x2, y2], which are the coordinates of the top-left corner and bottom-right corner.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Valid when Form is OCR or ASR. Indicates the recognized OCR or ASR text content.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// Valid when Form is OCR or ASR. It indicates the list of violation keywords hit by suspicious fragments.
        /// </summary>
        [JsonProperty("KeywordSet")]
        public string[] KeywordSet{ get; set; }

        /// <summary>
        /// Suspected image URL (images are not retained permanently and will reach
        /// Images will be deleted after the PicUrlExpireTime time point).
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Expiration time of the suspected image URL in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("PicUrlExpireTime")]
        public string PicUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Form", this.Form);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamArraySimple(map, prefix + "KeywordSet.", this.KeywordSet);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "PicUrlExpireTime", this.PicUrlExpireTime);
        }
    }
}

