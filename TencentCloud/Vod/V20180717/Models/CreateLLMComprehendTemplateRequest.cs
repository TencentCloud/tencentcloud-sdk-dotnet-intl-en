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

    public class CreateLLMComprehendTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Parsing level. Available values are:</p><ul><li>Audio: audio-level parsing</li><li>Video: video-level parsing</li></ul>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574">application</a> ID. For customers who activate VOD services on or after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications, whether it is the default application or a newly created application.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Large model parsing template name. Length limit: 64 characters.</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Large model parsing template description. Length limit: 256 characters.</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>Segment summary parsing configuration<br>Note: In the current version, segment summary must be enabled to parse normally.</p>
        /// </summary>
        [JsonProperty("Summary")]
        public LLMComprehendSummary Summary{ get; set; }

        /// <summary>
        /// <p>Text transcribing and parsing configuration</p>
        /// </summary>
        [JsonProperty("Asr")]
        public LLMComprehendAsr Asr{ get; set; }

        /// <summary>
        /// <p>Face recognition configuration</p>
        /// </summary>
        [JsonProperty("FaceRecognition")]
        public LLMComprehendFaceRecognition FaceRecognition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "Summary.", this.Summary);
            this.SetParamObj(map, prefix + "Asr.", this.Asr);
            this.SetParamObj(map, prefix + "FaceRecognition.", this.FaceRecognition);
        }
    }
}

