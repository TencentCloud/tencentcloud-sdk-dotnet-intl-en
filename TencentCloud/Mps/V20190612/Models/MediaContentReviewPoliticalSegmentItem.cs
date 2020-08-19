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

namespace TencentCloud.Mps.V20190612.Models
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
        /// Score of a suspected politically sensitive segment.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Suggestion for politically sensitive information detection of a suspected segment. Valid values:
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Name of a politically sensitive figure or violating photo.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Tags for the results of politically sensitive information detection of suspected video segments. The relationship between the `LabelSet` parameter in the content audit template [controlling tasks of video politically sensitive information detection](https://intl.cloud.tencent.com/document/api/862/37615?from_cn_redirect=1#PoliticalImgReviewTemplateInfo) and this parameter is as follows:
        /// violation_photo:
        /// <li>violation_photo: violating photo.</li>
        /// politician:
        /// <li>nation_politician: head of state/government;</li>
        /// <li>province_politician: province/state leader;</li>
        /// <li>bureau_politician: ministry leader;</li>
        /// <li>county_politician: county/city leader;</li>
        /// <li>rural_politician: town leader;</li>
        /// <li>sensitive_politician: politically sensitive figure.</li>
        /// <li>foreign_politician: head of a foreign country/government.</li>
        /// entertainment:
        /// <li>sensitive_entertainment: sensitive entertainment celebrity.</li>
        /// sport:
        /// <li>sensitive_sport: sensitive sports figure.</li>
        /// entrepreneur:
        /// <li>sensitive_entrepreneur: sensitive business figure.</li>
        /// scholar:
        /// <li>sensitive_scholar: sensitive educator.</li>
        /// celebrity:
        /// <li>sensitive_celebrity: sensitive well-known figure;</li>
        /// <li>historical_celebrity: well-known historical figure.</li>
        /// military:
        /// <li>sensitive_military: militarily sensitive figure.</li>
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
        /// Zone coordinates (at the pixel level) of a politically sensitive figure or violating photo: [x1, y1, x2, y2], i.e., the coordinates of the top-left and bottom-right corners.
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// Expiration time of a suspected image URL in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("PicUrlExpireTime")]
        public string PicUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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

