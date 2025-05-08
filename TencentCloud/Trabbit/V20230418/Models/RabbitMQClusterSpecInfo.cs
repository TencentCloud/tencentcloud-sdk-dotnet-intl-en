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

namespace TencentCloud.Trabbit.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RabbitMQClusterSpecInfo : AbstractModel
    {
        
        /// <summary>
        /// Specifies the cluster specification name.
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// Max tps.
        /// </summary>
        [JsonProperty("MaxTps")]
        public ulong? MaxTps{ get; set; }

        /// <summary>
        /// Maximum number of queues.
        /// </summary>
        [JsonProperty("MaxQueueNum")]
        public ulong? MaxQueueNum{ get; set; }

        /// <summary>
        /// Maximum number of exchanges.
        /// </summary>
        [JsonProperty("MaxExchangeNum")]
        public ulong? MaxExchangeNum{ get; set; }

        /// <summary>
        /// Maximum number of vhosts.
        /// </summary>
        [JsonProperty("MaxVhostNum")]
        public ulong? MaxVhostNum{ get; set; }

        /// <summary>
        /// Maximum number of connections.
        /// </summary>
        [JsonProperty("MaxConnNum")]
        public ulong? MaxConnNum{ get; set; }

        /// <summary>
        /// Maximum number of users.
        /// </summary>
        [JsonProperty("MaxUserNum")]
        public ulong? MaxUserNum{ get; set; }

        /// <summary>
        /// Peak bandwidth. abandoned.
        /// </summary>
        [JsonProperty("MaxBandWidth")]
        public ulong? MaxBandWidth{ get; set; }

        /// <summary>
        /// Public network bandwidth. abandoned.
        /// </summary>
        [JsonProperty("PublicNetworkTps")]
        public ulong? PublicNetworkTps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "MaxTps", this.MaxTps);
            this.SetParamSimple(map, prefix + "MaxQueueNum", this.MaxQueueNum);
            this.SetParamSimple(map, prefix + "MaxExchangeNum", this.MaxExchangeNum);
            this.SetParamSimple(map, prefix + "MaxVhostNum", this.MaxVhostNum);
            this.SetParamSimple(map, prefix + "MaxConnNum", this.MaxConnNum);
            this.SetParamSimple(map, prefix + "MaxUserNum", this.MaxUserNum);
            this.SetParamSimple(map, prefix + "MaxBandWidth", this.MaxBandWidth);
            this.SetParamSimple(map, prefix + "PublicNetworkTps", this.PublicNetworkTps);
        }
    }
}

