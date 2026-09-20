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

    public class MediaContentReviewPoliticalSegmentItem : AbstractModel
    {
        
        /// <summary>
        /// Offset time of the start of the suspected segment. Unit: seconds.
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a suspected segment, in seconds.
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Score of the suspected segment.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Result suggestions for suspected segments involving inappropriate information. Value range:
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Involves inappropriate information and violative icon names.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Result tags of suspected segments involving inappropriate information. Mapping between the LabelSet parameter in the [task control parameter for frames involving inappropriate information](https://www.tencentcloud.com/document/api/266/31773?from_cn_redirect=1#PoliticalImgReviewTemplateInfo) of the audio/video moderation template and the value range of this parameter:
        /// violation_photo:
        /// <li>violation_photo: Violation icon.</li>
        /// politician:
        /// <li>nation_politician: State leaders;</li>
        /// <li>province_politician: provincial and ministerial leaders;</li>
        /// <li>bureau_politician: bureau-level official;</li>
        /// <li>county_politician: county-level official;</li>
        /// <li>rural_politician: township-level official;</li>
        /// <li>sensitive_politician: relevant people involved in rule violations;</li>
        /// <li>foreign_politician: state leaders of other countries.</li>
        /// entertainment:
        /// <li>sensitive_entertainment: banned people in the entertainment industry.</li>
        /// sport:
        /// <li>sensitive_sport: sports celebrity involved in rule violations.</li>
        /// entrepreneur:
        /// <li>sensitive_entrepreneur: commercial figure involved in rule violation.</li>
        /// scholar:
        /// <li>sensitive_scholar: Educational scholar in rule violation.</li>
        /// celebrity:
        /// <li>sensitive_celebrity: rule-violating celebrity;</li>
        /// <li>historical_celebrity: Historical celebrity.</li>
        /// military:
        /// <li>sensitive_military: relevant people involved in rule violations.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Suspected image URL (images are not retained permanently and will be deleted upon reaching
        /// Images will be deleted after the PicUrlExpireTime time point).
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Area coordinates (pixel level) where inappropriate information or violation icons appear, [x1, y1, x2, y2], i.e. coordinates of the top-left corner and bottom-right corner.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Deprecated. Please use `PicUrlExpireTime`.
        /// </summary>
        [JsonProperty("PicUrlExpireTimeStamp")]
        [System.Obsolete]
        public long? PicUrlExpireTimeStamp{ get; set; }

        /// <summary>
        /// URL expiration time of the suspected image in ISO date format (https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
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

