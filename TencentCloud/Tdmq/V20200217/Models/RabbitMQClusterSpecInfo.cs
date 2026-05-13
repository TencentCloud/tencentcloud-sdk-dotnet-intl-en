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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MaxStorage")]
        public ulong? MaxStorage{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("PublicNetworkTps")]
        public ulong? PublicNetworkTps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "MaxStorage", this.MaxStorage);
            this.SetParamSimple(map, prefix + "PublicNetworkTps", this.PublicNetworkTps);
        }
    }
}

