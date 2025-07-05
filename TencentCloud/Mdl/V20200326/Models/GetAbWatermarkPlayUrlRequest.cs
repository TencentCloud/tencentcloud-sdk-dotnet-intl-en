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

    public class GetAbWatermarkPlayUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Client UUID, 32-bit unsigned integer, [0, 4294967295].
        /// </summary>
        [JsonProperty("Uuid")]
        public ulong? Uuid{ get; set; }

        /// <summary>
        /// Channel ID of Stream Package.
        /// </summary>
        [JsonProperty("StreamPackageChannelId")]
        public string StreamPackageChannelId{ get; set; }

        /// <summary>
        /// Original play URL.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "StreamPackageChannelId", this.StreamPackageChannelId);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

