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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioCodecDetail : AbstractModel
    {
        
        /// <summary>
        /// Channel configuration, optional values: MONO (mono), STEREO (two-channel), 5.1 (surround).
        /// </summary>
        [JsonProperty("ChannelMode")]
        public string ChannelMode{ get; set; }

        /// <summary>
        /// Level in aac case, optional values: "LC" "HE-AAC" "HE-AACV2".
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMode", this.ChannelMode);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
        }
    }
}

