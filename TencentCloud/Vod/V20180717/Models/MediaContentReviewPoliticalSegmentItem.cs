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

    public class MediaContentReviewPoliticalSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// Start time offset of a suspected segment in seconds.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a suspected segment in seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Confidence score for the detected politically sensitive content
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Processing suggestion for the detected politically sensitive content. Valid values:
        /// <li>pass</li>
        /// <li>review</li>
        /// <li>block</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Name of the politically sensitive content or banned images
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Labels for the detected politically sensitive content. The relationship between the values of this parameter and those of the `LabelSet` parameter in [PoliticalImgReviewTemplateInfo](https://intl.cloud.tencent.com/document/api/266/31773?from_cn_redirect=1#PoliticalImgReviewTemplateInfo) is as follows:
        /// violation_photo:
        /// <li>`violation_photo`: banned images</li>
        /// politician:
        /// <li>`nation_politician`: state leader of China</li>
        /// <li>`province_politician`: provincial officials</li>
        /// <li>`bureau_politician`: bureau-level officials</li>
        /// <li>`county_politician`: county-level officials</li>
        /// <li>`rural_politician`: township-level officials</li>
        /// <li>`sensitive_politician`: politically sensitive people</li>
        /// <li>`foreign_politician`: state leaders of other countries</li>
        /// entertainment:
        /// <li>`sensitive_entertainment`: banned people in the entertainment industry</li>
        /// sport:
        /// <li>`sensitive_sport`: banned sports celebrities</li>
        /// entrepreneur:
        /// <li>`sensitive_entrepreneur`: banned businesspeople</li>
        /// scholar:
        /// <li>sensitive_scholar: banned scholars</li>
        /// celebrity:
        /// <li>sensitive_celebrity: banned celebrities</li>
        /// <li>historical_celebrity: banned historical figures</li>
        /// military:
        /// <li>sensitive_military: banned people in military</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// URL of a suspected image (which will not be permanently stored
        ///  and will be deleted after `PicUrlExpireTime`).
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Coordinates (pixel) of the detected politically sensitive content or banned icons. The format is [x1, y1, x2, y2], which indicates the coordinates of the top-left and bottom-right corners.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// This field has been disused. Please use `PicUrlExpireTime`.
        /// </summary>
        [JsonProperty("PicUrlExpireTimeStamp")]
        public long? PicUrlExpireTimeStamp{ get; set; }

        /// <summary>
        /// Expiration time of suspected image URL in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamSimple(map, prefix + "PicUrlExpireTimeStamp", this.PicUrlExpireTimeStamp);
            this.SetParamSimple(map, prefix + "PicUrlExpireTime", this.PicUrlExpireTime);
        }
    }
}

