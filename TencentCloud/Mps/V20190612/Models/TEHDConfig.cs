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

    public class TEHDConfig : AbstractModel
    {
        
        /// <summary>
        /// Top speed Codec type. Available values:
        /// <li>TEHD-100: top speed codec-100 (video top speed codec).</li>
        /// <li>TEHD-200: top speed codec-200 (audio top speed codec).</li>
        /// If not specified, top speed Codec is not enabled.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Maximum video bitrate. Valid when Type is set to top speed Codec.
        /// If this is not specified or is set to 0, no upper limit is set for the video bitrate.
        /// </summary>
        [JsonProperty("MaxVideoBitrate")]
        public long? MaxVideoBitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "MaxVideoBitrate", this.MaxVideoBitrate);
        }
    }
}

