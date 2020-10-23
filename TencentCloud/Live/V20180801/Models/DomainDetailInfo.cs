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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// In or outside Mainland China:
        /// Mainland: data in Mainland China.
        /// Oversea: data outside Mainland China.
        /// </summary>
        [JsonProperty("MainlandOrOversea")]
        public string MainlandOrOversea{ get; set; }

        /// <summary>
        /// Bandwidth in Mbps.
        /// </summary>
        [JsonProperty("Bandwidth")]
        public float? Bandwidth{ get; set; }

        /// <summary>
        /// Traffic in MB.
        /// </summary>
        [JsonProperty("Flux")]
        public float? Flux{ get; set; }

        /// <summary>
        /// Number of viewers.
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// Number of requests.
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MainlandOrOversea", this.MainlandOrOversea);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "Request", this.Request);
        }
    }
}

