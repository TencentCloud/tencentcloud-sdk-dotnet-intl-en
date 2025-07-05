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

namespace TencentCloud.Mdc.V20200828.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOutputRTMPSettings : AbstractModel
    {
        
        /// <summary>
        /// The relay destination addresses. One or two addresses are allowed.
        /// </summary>
        [JsonProperty("Destinations")]
        public CreateOutputRtmpSettingsDestinations[] Destinations{ get; set; }

        /// <summary>
        /// The RTMP chunk size. Value range: [4096, 40960].
        /// </summary>
        [JsonProperty("ChunkSize")]
        public long? ChunkSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Destinations.", this.Destinations);
            this.SetParamSimple(map, prefix + "ChunkSize", this.ChunkSize);
        }
    }
}

