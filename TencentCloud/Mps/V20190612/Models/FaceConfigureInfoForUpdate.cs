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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceConfigureInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Face Recognition task switch. Valid values:
        /// <li>ON: Enable intelligent face recognition task.</li>
        /// <li>OFF: Disables the intelligent face recognition task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Face recognition filter score. Returns the recognition result when the recognition result reaches this score or higher. Value ranges from 0 to 100.
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// Default character filter tag. Specify the tag of the default character to be returned. If left blank or empty, all default character results will be returned. Tag value range:
        /// <li>entertainment: entertainment star;</li>
        /// <li>Sport: sports celebrity;</li>
        /// <li>politician: sensitive person.</li>
        /// </summary>
        [JsonProperty("DefaultLibraryLabelSet")]
        public string[] DefaultLibraryLabelSet{ get; set; }

        /// <summary>
        /// User-defined character filter tag. Specify the tag of the user-defined character to return. If left blank or empty, all custom character results are returned.
        /// The number of tags is up to 100, and each tag can have up to 16 characters.
        /// </summary>
        [JsonProperty("UserDefineLibraryLabelSet")]
        public string[] UserDefineLibraryLabelSet{ get; set; }

        /// <summary>
        /// Figure library selection. Available values:
        /// <li>Default: Use default character library;</li>
        /// <li>UserDefine: Use the user-defined character library.</li>
        /// <li>All: Use default character library and user-defined character library simultaneously.</li>
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

