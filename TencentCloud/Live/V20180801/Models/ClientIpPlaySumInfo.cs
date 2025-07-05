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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientIpPlaySumInfo : AbstractModel
    {
        
        /// <summary>
        /// Client IP in dotted-decimal notation.
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// District where the client is located.
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// Total traffic.
        /// </summary>
        [JsonProperty("TotalFlux")]
        public float? TotalFlux{ get; set; }

        /// <summary>
        /// Total number of requests.
        /// </summary>
        [JsonProperty("TotalRequest")]
        public ulong? TotalRequest{ get; set; }

        /// <summary>
        /// Total number of failed requests.
        /// </summary>
        [JsonProperty("TotalFailedRequest")]
        public ulong? TotalFailedRequest{ get; set; }

        /// <summary>
        /// Country/region where the client is located.
        /// </summary>
        [JsonProperty("CountryArea")]
        public string CountryArea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "TotalFlux", this.TotalFlux);
            this.SetParamSimple(map, prefix + "TotalRequest", this.TotalRequest);
            this.SetParamSimple(map, prefix + "TotalFailedRequest", this.TotalFailedRequest);
            this.SetParamSimple(map, prefix + "CountryArea", this.CountryArea);
        }
    }
}

