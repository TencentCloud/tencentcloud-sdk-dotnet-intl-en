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

    public class HeadTailTemplate : AbstractModel
    {
        
        /// <summary>
        /// Opening and ending template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Template name. Supports up to 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Supports up to 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Opening candidate list. When used, the one closest to the main content resolution is selected. If identical candidates exist, the first one is used. Supports up to 5.
        /// </summary>
        [JsonProperty("HeadCandidateSet")]
        public string[] HeadCandidateSet{ get; set; }

        /// <summary>
        /// Ending candidate list. When used, the candidate with the resolution closest to the main content is selected. If identical candidates exist, the first one is used. Supports up to 5 candidates.
        /// </summary>
        [JsonProperty("TailCandidateSet")]
        public string[] TailCandidateSet{ get; set; }

        /// <summary>
        /// Filling method. When the video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "padding". Optional filling modes:
        /// <li> stretch: stretches each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li>
        /// <li> gauss: Gaussian blur, maintain video aspect ratio, and apply Gaussian blur to the remaining edge part;</li>
        /// <li> white: Leave blank, maintain video aspect ratio, edge remainder filled with white;</li>
        /// <li> black: Fill with black. Maintain the video aspect ratio and fill the remaining edges with black.</li>
        /// Default value: stretch.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Template creation time in ISO date format (https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Template last modified time, use [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamArraySimple(map, prefix + "HeadCandidateSet.", this.HeadCandidateSet);
            this.SetParamArraySimple(map, prefix + "TailCandidateSet.", this.TailCandidateSet);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

