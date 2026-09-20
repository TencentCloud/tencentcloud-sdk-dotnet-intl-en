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

    public class SubtitleFormatsOperation : AbstractModel
    {
        
        /// <summary>
        /// Operation type. Value range:
        /// <li>add: add the format list specified by Formats;</li>
        /// <li>delete: delete the format list specified by Formats;<l/i>
        /// <li>reset: Reset the configured format list to the format list specified by Formats.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Subtitle format list. Value range:
        /// <li>vtt: Generate a WebVTT subtitle file;</li>
        /// <li>srt: generate SRT subtitle file.</li>
        /// </summary>
        [JsonProperty("Formats")]
        public string[] Formats{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Formats.", this.Formats);
        }
    }
}

