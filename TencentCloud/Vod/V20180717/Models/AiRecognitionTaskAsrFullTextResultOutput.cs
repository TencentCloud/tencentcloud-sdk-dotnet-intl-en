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

    public class AiRecognitionTaskAsrFullTextResultOutput : AbstractModel
    {
        
        /// <summary>
        /// List of segments for full speech recognition.
        /// <font color=red>Note</font>: This list only shows the first 100 elements. To obtain the complete result, get it from the file corresponding to SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public AiRecognitionTaskAsrFullTextSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// URL of the speech full text recognition Segment List File. The content of the file is in JSON format, and its data structure is consistent with the fields of SegmentSet. (The file is not retained permanently. It will be deleted after reaching the SegmentSetFileUrlExpireTime time point.)
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the full speech recognition segment list file URL, using the [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }

        /// <summary>
        /// Generated subtitle list, corresponding to SubtitleFormats in speech full-text recognition task control parameter (https://www.tencentcloud.com/document/api/266/31773?from_cn_redirect=1#AsrFullTextConfigureInfo).
        /// </summary>
        [JsonProperty("SubtitleSet")]
        public AiRecognitionTaskAsrFullTextResultOutputSubtitleItem[] SubtitleSet{ get; set; }

        /// <summary>
        /// Generated subtitle file Url, corresponding to SubtitleFormat in speech full-text recognition task control parameter (https://www.tencentcloud.com/document/api/266/31773?from_cn_redirect=1#AsrFullTextConfigureInfo).
        /// </summary>
        [JsonProperty("SubtitleUrl")]
        public string SubtitleUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
            this.SetParamArrayObj(map, prefix + "SubtitleSet.", this.SubtitleSet);
            this.SetParamSimple(map, prefix + "SubtitleUrl", this.SubtitleUrl);
        }
    }
}

