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

    public class FaceConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Face recognition task switch. Available values:</p><li>ON: enable intelligent face recognition task;</li><li>OFF: disable intelligent face recognition task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Face recognition filter score. When the recognition result reaches this score or above, the recognition result will be returned. Default: 95 points. Value range: 0-100.</p>
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// <p>Filter tag for default characters, specifying the tags of default characters to return. If not filled or left empty, all default character results will be returned. Available tag values:</p><li>entertainment: entertainment star;</li><li>sport: sports celebrity;</li><li>politician: relevant people.</li>
        /// </summary>
        [JsonProperty("DefaultLibraryLabelSet")]
        public string[] DefaultLibraryLabelSet{ get; set; }

        /// <summary>
        /// <p>Filter tags for user-defined characters, specifying the tags of user-defined characters to return. If not specified or empty, all user-defined character results are returned.<br>The number of tags can be up to 100, and each tag can be up to 16 characters in length.</p>
        /// </summary>
        [JsonProperty("UserDefineLibraryLabelSet")]
        public string[] UserDefineLibraryLabelSet{ get; set; }

        /// <summary>
        /// <p>Figure library selection. Available values:</p><li>Default: use the default figure library;</li><li>UserDefine: use a user-defined figure library.</li><li>All: use both the default and user-defined figure libraries.</li>Default value: All, use the system default figure library and user-defined figure library.
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

