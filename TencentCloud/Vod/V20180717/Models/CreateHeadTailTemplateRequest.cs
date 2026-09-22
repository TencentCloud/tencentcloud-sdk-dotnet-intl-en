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

    public class CreateHeadTailTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Template name, length limited to 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Template description information. The length cannot exceed 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Opening candidate list. Fill in the FileId of the video. During transcoding, the opening with the aspect ratio closest to the main content is automatically selected (if the aspect ratios are identical, candidates positioned towards the front take precedence). Supports up to 5 title candidates.
        /// </summary>
        [JsonProperty("HeadCandidateSet")]
        public string[] HeadCandidateSet{ get; set; }

        /// <summary>
        /// Ending candidate list. Fill in the FileId of the video. During transcoding, the ending with the aspect ratio closest to that of the main content is automatically selected (if the aspect ratios are identical, candidates positioned towards the front take precedence). Supports up to 5 candidate endings.
        /// </summary>
        [JsonProperty("TailCandidateSet")]
        public string[] TailCandidateSet{ get; set; }

        /// <summary>
        /// Filling method. When the width and height parameters in the video stream configuration are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "padding". Optional filling methods:
        /// <li> stretch: stretches each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li>
        /// <li> gauss: Gaussian blur, maintain video aspect ratio, and apply Gaussian blur to the remaining edge part;</li>
        /// <li> white: leave blank, maintain video aspect ratio, edge remainder filled with white;</li>
        /// <li> black: black edges. The video aspect ratio remains unchanged, and the remaining edges are filled with black.</li>
        /// Default value: stretch.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArraySimple(map, prefix + "HeadCandidateSet.", this.HeadCandidateSet);
            this.SetParamArraySimple(map, prefix + "TailCandidateSet.", this.TailCandidateSet);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

