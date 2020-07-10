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

    public class DescribeLiveDomainPlayInfoListResponse : AbstractModel
    {
        
        /// <summary>
        /// Data time in the format of yyyy-mm-dd HH:MM:SS.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Real-time total bandwidth.
        /// </summary>
        [JsonProperty("TotalBandwidth")]
        public float? TotalBandwidth{ get; set; }

        /// <summary>
        /// Real-time total traffic.
        /// </summary>
        [JsonProperty("TotalFlux")]
        public float? TotalFlux{ get; set; }

        /// <summary>
        /// TotalRequest.
        /// </summary>
        [JsonProperty("TotalRequest")]
        public ulong? TotalRequest{ get; set; }

        /// <summary>
        /// Real-time total number of connections.
        /// </summary>
        [JsonProperty("TotalOnline")]
        public ulong? TotalOnline{ get; set; }

        /// <summary>
        /// Data by region name.
        /// </summary>
        [JsonProperty("DomainInfoList")]
        public DomainInfoList[] DomainInfoList{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TotalBandwidth", this.TotalBandwidth);
            this.SetParamSimple(map, prefix + "TotalFlux", this.TotalFlux);
            this.SetParamSimple(map, prefix + "TotalRequest", this.TotalRequest);
            this.SetParamSimple(map, prefix + "TotalOnline", this.TotalOnline);
            this.SetParamArrayObj(map, prefix + "DomainInfoList.", this.DomainInfoList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

