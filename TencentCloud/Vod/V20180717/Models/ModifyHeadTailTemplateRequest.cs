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

    public class ModifyHeadTailTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Opening and ending template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Template name. Length limited to 64 characters. If not passed, no modification is made.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limited to 256 characters. If not passed, no modification is made. If passed empty, the description is cleared.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Opening candidate list. Fill in the FileId of the video. During transcoding, the opening closest to the aspect ratio of the main content is automatically selected. If the aspect ratios are identical, the candidate positioned towards the front takes precedence. A maximum of 5 title candidates is supported. Not passing this parameter means no modification, while passing an empty array means clearing.
        /// </summary>
        [JsonProperty("HeadCandidateSet")]
        public string[] HeadCandidateSet{ get; set; }

        /// <summary>
        /// Ending candidate list. Fill in the FileId of the video. During transcoding, the ending with the aspect ratio closest to the main content is automatically selected. If the aspect ratios are identical, candidates positioned towards the front take precedence. A maximum of 5 title candidates is supported. Not passing this parameter means no modification. Passing an empty array means clearing.
        /// </summary>
        [JsonProperty("TailCandidateSet")]
        public string[] TailCandidateSet{ get; set; }

        /// <summary>
        /// Filling method. When the aspect ratio of the video stream configuration width and height parameters is inconsistent with that of the original video, the processing method for transcoding is "padding". Optional filling methods:
        /// <li> stretch: Stretch each frame to fill the entire screen, which may cause the transcoded video to be "squashed" or "stretched";</li>
        /// <li> gauss: Gaussian blur, maintain video aspect ratio, and use Gaussian blur for the remaining edge part;</li>
        /// <li> white: leave blank, maintain video aspect ratio, and fill the remaining edges with white;</li>
        /// <li> black: Fill with black. Maintain the video aspect ratio and fill the remaining edges with black.</li>
        /// The default value is no modification.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArraySimple(map, prefix + "HeadCandidateSet.", this.HeadCandidateSet);
            this.SetParamArraySimple(map, prefix + "TailCandidateSet.", this.TailCandidateSet);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

