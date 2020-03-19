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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceConfigureInfo : AbstractModel
    {
        
        /// <summary>
        /// Switch of a face recognition task. Valid values:
        /// <li>ON: Enables an intelligent face recognition task;</li>
        /// <li>OFF: Disables an intelligent face recognition task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Face recognition filter score. If this score is reached or exceeded, a recognition result will be returned. Value range: 0–100. Default value: 95.
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// Default figure filter tag, which specifies the default figure tag that needs to be returned. If this parameter is left empty or an empty value is entered, all results of the default figures will be returned. Valid values:
        /// <li>entertainment: Entertainment celebrity;</li>
        /// <li>sport: Sports celebrity;</li>
        /// <li>politician: Politically sensitive figure.</li>
        /// </summary>
        [JsonProperty("DefaultLibraryLabelSet")]
        public string[] DefaultLibraryLabelSet{ get; set; }

        /// <summary>
        /// Custom figure filter tag, which specifies the custom figure tag that needs to be returned. If this parameter is left empty or an empty value is entered, all results of the custom figures will be returned. Valid values:
        /// There can be up to 10 tags, each with a length limit of 16 characters.
        /// </summary>
        [JsonProperty("UserDefineLibraryLabelSet")]
        public string[] UserDefineLibraryLabelSet{ get; set; }

        /// <summary>
        /// Figure library. Valid values:
        /// <li>Default: Default figure library;</li>
        /// <li>UserDefine: Custom figure library.</li>
        /// <li>All: Both default and custom figure libraries will be used.</li>
        /// Default value: All (both default and custom figure libraries will be used.)
        /// </summary>
        [JsonProperty("FaceLibrary")]
        public string FaceLibrary{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "DefaultLibraryLabelSet.", this.DefaultLibraryLabelSet);
            this.SetParamArraySimple(map, prefix + "UserDefineLibraryLabelSet.", this.UserDefineLibraryLabelSet);
            this.SetParamSimple(map, prefix + "FaceLibrary", this.FaceLibrary);
        }
    }
}

