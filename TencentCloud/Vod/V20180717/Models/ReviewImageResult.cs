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

    public class ReviewImageResult : AbstractModel
    {
        
        /// <summary>
        /// Result suggestion for image moderation. Value range:
        /// <li>pass: it is recommended to pass;</li>
        /// <li>review: suggest re-examination;</li>
        /// <li>block: suggest banning.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Tag that is most likely to violate the rule. Valid when Suggestion is review or block. Value range:
        /// <li>Porn: Pornography;</li>
        /// <li>Terror: violence.</li>
        /// <li>Polity: inappropriate information;</li>
        /// <li>Ad: advertisement;</li>
        /// <li>Illegal: illegal activities;</li>
        /// <li>Abuse: abusive language.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Valid when Suggestion is review or block. It indicates the most likely prohibited forms. Value range:
        /// <li>Image: people or icons in the image;</li>
        /// <li>OCR: text on the screen.</li>
        /// </summary>
        [JsonProperty("Form")]
        public string Form{ get; set; }

        /// <summary>
        /// List of video clips suspected of containing violation information.
        /// <font color=red>Note</font>: This list can only display up to the first 10 elements. To obtain the complete result, get it from the file corresponding to SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public ReviewImageSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// URL of the video clip list file involved in suspicion of violation information. The file content is in JSON format, and its data structure is consistent with the fields of SegmentSet. (The file is not retained permanently. It will be deleted after reaching the SegmentSetFileUrlExpireTime time point.)
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// URL expiry time of the list of video clips suspected of involving violation information in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Form", this.Form);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

