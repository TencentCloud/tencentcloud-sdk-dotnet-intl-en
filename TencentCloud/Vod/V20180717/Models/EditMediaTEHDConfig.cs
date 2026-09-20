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

    public class EditMediaTEHDConfig : AbstractModel
    {
        
        /// <summary>
        /// Top speed Codec type. Available values: <li>TEHD-100 means top speed Codec-100;</li> <li>OFF means disabling top speed Codec.</li> If not specified, OFF is used.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Maximum video bitrate. Valid when Type is specified as top speed Codec.
        /// Leave it empty or set it to 0 to let VOD set the bitrate cap automatically.
        /// </summary>
        [JsonProperty("MaxVideoBitrate")]
        public ulong? MaxVideoBitrate{ get; set; }


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

