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

    public class LLMComprehendFaceRecognition : AbstractModel
    {
        
        /// <summary>
        /// <p>Face recognition task switch</p><p>Enumeration value:</p><ul><li>ON: Enable intelligent face recognition task</li><li>OFF: Disable intelligent face recognition task</li></ul><p>Default value: OFF</p>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Face recognition filter score. The recognition result is returned when it reaches or exceeds this score.</p><p>Value ranges from 0 to 100.</p><p>Default value: 95.</p>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// <p>Default character filter tag. Specifies the tag of the default character to return. If left blank or empty, all default character results are returned.</p><p>Enumeration value:</p><ul><li>entertainment: entertainment star</li><li>sport: sports celebrity</li><li>politician: political figure</li></ul>
        /// </summary>
        [JsonProperty("DefaultLibraryLabelSet")]
        public string[] DefaultLibraryLabelSet{ get; set; }

        /// <summary>
        /// <p>User-defined character filter tag specifies the tags of user-defined characters to return. If left blank or empty, all customized figure results are returned.</p><p>Input limit: The number of tags is limited to 100, and each tag is limited to 16 characters in length.</p>
        /// </summary>
        [JsonProperty("UserDefineLibraryLabelSet")]
        public string[] UserDefineLibraryLabelSet{ get; set; }

        /// <summary>
        /// <p>Figure library selection</p><p>Enumeration value:</p><ul><li>Default: Use default figure library</li><li>UserDefine: Use user-defined figure library</li><li>All: Use default and user-defined figure libraries simultaneously</li></ul><p>Default value: All</p>
        /// </summary>
        [JsonProperty("FaceLibrary")]
        public string FaceLibrary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "DefaultLibraryLabelSet.", this.DefaultLibraryLabelSet);
            this.SetParamArraySimple(map, prefix + "UserDefineLibraryLabelSet.", this.UserDefineLibraryLabelSet);
            this.SetParamSimple(map, prefix + "FaceLibrary", this.FaceLibrary);
        }
    }
}

