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

    public class DrmStreamingsInfo : AbstractModel
    {
        
        /// <summary>
        /// ID of the adaptive bitrate streaming template whose protection type is SimpleAES.
        /// </summary>
        [JsonProperty("SimpleAesDefinition")]
        public ulong? SimpleAesDefinition{ get; set; }

        /// <summary>
        /// The ID of the adaptive bitrate streaming template that encrypts the streams by Widewine.
        /// </summary>
        [JsonProperty("WidevineDefinition")]
        public ulong? WidevineDefinition{ get; set; }

        /// <summary>
        /// The ID of the adaptive bitrate streaming template that encrypts the streams by FairPlay.
        /// </summary>
        [JsonProperty("FairPlayDefinition")]
        public ulong? FairPlayDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SimpleAesDefinition", this.SimpleAesDefinition);
            this.SetParamSimple(map, prefix + "WidevineDefinition", this.WidevineDefinition);
            this.SetParamSimple(map, prefix + "FairPlayDefinition", this.FairPlayDefinition);
        }
    }
}

