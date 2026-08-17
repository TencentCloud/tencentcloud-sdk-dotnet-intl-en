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

    public class MediaContentReviewPoliticalSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// Start time offset of a suspected segment, in seconds.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a suspected segment, in seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Suspected segment sensitivity score.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Suspected segment sensitive result suggestion, value ranges from...to...
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Sensitive person, violative icon name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Suspected segment sensitive result Tag. The mapping between the LabelSet parameter in the content moderation template [visual sensitive task control parameter](https://www.tencentcloud.com/document/api/862/37615?from_cn_redirect=1#PoliticalImgReviewTemplateInfo) and the parameter value range of this parameter:
        /// violation_photo:
        /// <li>violation_photo: violation icon.</li>
        /// politician:
        /// <li>nation_politician: State leaders;</li>
        /// <li>province_politician: provincial and ministerial leaders;</li>
        /// <li>bureau_politician: bureau-level official;</li>
        /// <li>county_politician: county-level official;</li>
        /// <li>rural_politician: township-level official;</li>
        /// <li>sensitive_politician: sensitive person.</li>
        /// <li>foreign_politician: state leaders of other countries.</li>
        /// entertainment:
        /// <li>sensitive_entertainment: sensitive entertainment figure.</li>
        /// sport:
        /// <li>Sensitive_sport: sensitive sports celebrity.</li>
        /// entrepreneur:
        /// <li>sensitive_entrepreneur: sensitive entrepreneur.</li>
        /// scholar:
        /// <li>sensitive_scholar: Sensitive educational scholars.</li>
        /// celebrity:
        /// <li>sensitive_celebrity: sensitive celebrity.</li>
        /// <li>historical_celebrity: historical celebrity.</li>
        /// military:
        /// <li>sensitive_military: sensitive military figure.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Suspected image URL (Images are not retained permanently upon arrival)
        /// The image will be deleted after the PicUrlExpireTime time point.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Area coordinates of sensitive person and violation icon occurrence (pixel-level), [x1, y1, x2, y2], i.e., coordinates of the top-left corner and coordinate of the bottom-right corner.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Expiration time of the suspected image URL, using the ISO date format (https://www.tencentcloud.com/document/product/862/37710?from_cn_redirect=1#52).
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
            this.SetParamSimple(map, prefix + "PicUrlExpireTime", this.PicUrlExpireTime);
        }
    }
}

