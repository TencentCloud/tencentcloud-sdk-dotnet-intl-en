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

    public class MediaMiniProgramReviewInfoItem : AbstractModel
    {
        
        /// <summary>
        /// Template ID, which is the ID of the transcoding template corresponding to the video published on WeChat Mini Program. 0 represents the source video.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Video metadata.
        /// </summary>
        [JsonProperty("MetaData")]
        public MediaMetaData MetaData{ get; set; }

        /// <summary>
        /// Video playback address for WeChat Mini Program audit
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Status of video release on WeChat Mini Program
        /// <li>Pass: succeeded.</li>
        /// <li>Rejected: rejected.</li>
        /// </summary>
        [JsonProperty("ReviewResult")]
        public string ReviewResult{ get; set; }

        /// <summary>
        /// WeChat Mini Program audit element.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReviewSummary")]
        public MediaMiniProgramReviewElem[] ReviewSummary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "MetaData.", this.MetaData);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "ReviewResult", this.ReviewResult);
            this.SetParamArrayObj(map, prefix + "ReviewSummary.", this.ReviewSummary);
        }
    }
}

