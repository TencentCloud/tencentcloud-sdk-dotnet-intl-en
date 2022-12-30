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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReviewAudioVideoSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// The start time offset (seconds) of the segment.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// The end time offset (seconds) of the segment.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// The confidence score of the segment.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// The processing suggestion for the segment. Valid values:
        /// <li>review: The content may be non-compliant. Please review it.</li>
        /// <li>block: The content is non-compliant. We recommend you block it.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// The most likely label for the segment. Valid values:
        /// <li>Porn</li>
        /// <li>Terrorism</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// The sublabel for the segment. This parameter is valid only if `Form` is `Image` or `Voice`.
        /// Valid values when `Form` is `Image` and `Label` is `Porn`:
        /// <li>porn</li>
        /// <li>vulgar</li>
        /// 
        /// Valid values when `Form` is `Image` and `Label` is `Terrorism`:
        /// <li>guns</li>
        /// <li>bloody</li>
        /// <li>banners</li>
        /// <li>scenario (terrorist scenes)</li>
        /// <li>explosion</li>
        /// 
        /// Valid values when `Form` is `Voice` and `Label` is `Porn`:
        /// <li>moan</li>
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// The format of the suspicious segment detected. Valid values:
        /// <li>Image</li>
        /// <li>OCR</li>
        /// <li>ASR</li>
        /// <li>Voice</li>
        /// </summary>
        [JsonProperty("Form")]
        public string Form{ get; set; }

        /// <summary>
        /// The pixel coordinates ([x1, y1, x2, y2]) of the top-left corner and bottom-right corner of the suspicious text. This parameter is valid only if `Form` is `OCR`.
        /// <font color=red>Note</font>: This parameter is not supported currently.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// The content of the suspicious text detected. This parameter is valid only if `Form` is `OCR` or `ASR`.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// The keywords that match the suspicious text. This parameter is valid only if `Form` is `OCR` or `ASR`.
        /// </summary>
        [JsonProperty("KeywordSet")]
        public string[] KeywordSet{ get; set; }

        /// <summary>
        /// The URL of a suspected image (which will be deleted
        ///  after `PicUrlExpireTime`).
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// The expiration time of the suspected image URL in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
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

