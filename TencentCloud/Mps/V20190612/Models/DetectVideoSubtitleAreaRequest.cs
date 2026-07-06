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

    public class DetectVideoSubtitleAreaRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Input information, which supports only URL and COS.</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>Video language. If you know the language of the video, you can specify this parameter to improve the recognition accuracy.</p><p>Enumeration values:</p><ul><li>zh_en: Chinese and English</li><li>en: English</li><li>ja: Japanese</li><li>ko: Korean</li></ul>
        /// </summary>
        [JsonProperty("VideoLanguage")]
        public string VideoLanguage{ get; set; }

        /// <summary>
        /// <p>Extended parameter. This is left empty by default.</p>
        /// </summary>
        [JsonProperty("UserExtPara")]
        public string UserExtPara{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamSimple(map, prefix + "VideoLanguage", this.VideoLanguage);
            this.SetParamSimple(map, prefix + "UserExtPara", this.UserExtPara);
        }
    }
}

