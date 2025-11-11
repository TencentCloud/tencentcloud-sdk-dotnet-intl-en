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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneResponse : AbstractModel
    {
        
        /// <summary>
        /// Zone list
        /// </summary>
        [JsonProperty("ZoneList")]
        public ZoneInfo[] ZoneList{ get; set; }

        /// <summary>
        /// Maximum number of instances to be purchased
        /// </summary>
        [JsonProperty("MaxBuyInstanceNum")]
        public long? MaxBuyInstanceNum{ get; set; }

        /// <summary>
        /// Maximum bandwidth in MB/S
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// Pay-as-you-go unit price
        /// </summary>
        [JsonProperty("UnitPrice")]
        public Price UnitPrice{ get; set; }

        /// <summary>
        /// Pay-as-you-go unit message price
        /// </summary>
        [JsonProperty("MessagePrice")]
        public Price MessagePrice{ get; set; }

        /// <summary>
        /// Specifies the user-exclusive cluster info.
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// Purchase the standard version configuration.
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// Purchase the standard version S2 configuration.
        /// </summary>
        [JsonProperty("StandardS2")]
        public string StandardS2{ get; set; }

        /// <summary>
        /// Specifies the configuration for purchasing the professional edition.
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// Purchase physical dedicated edition configuration.
        /// </summary>
        [JsonProperty("Physical")]
        public string Physical{ get; set; }

        /// <summary>
        /// Public network bandwidth. minimum 3 Mbps. maximum 999 Mbps. only the pro edition supports filling in. abandoned, meaningless.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public string PublicNetwork{ get; set; }

        /// <summary>
        /// Configures the public network bandwidth.
        /// </summary>
        [JsonProperty("PublicNetworkLimit")]
        public string PublicNetworkLimit{ get; set; }

        /// <summary>
        /// Request ID.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// Pagination Offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Pagination Limit
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Mandatory. input tag.
        /// </summary>
        [JsonProperty("ForceCheckTag")]
        public bool? ForceCheckTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "MaxBuyInstanceNum", this.MaxBuyInstanceNum);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamObj(map, prefix + "UnitPrice.", this.UnitPrice);
            this.SetParamObj(map, prefix + "MessagePrice.", this.MessagePrice);
            this.SetParamArrayObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "Standard", this.Standard);
            this.SetParamSimple(map, prefix + "StandardS2", this.StandardS2);
            this.SetParamSimple(map, prefix + "Profession", this.Profession);
            this.SetParamSimple(map, prefix + "Physical", this.Physical);
            this.SetParamSimple(map, prefix + "PublicNetwork", this.PublicNetwork);
            this.SetParamSimple(map, prefix + "PublicNetworkLimit", this.PublicNetworkLimit);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ForceCheckTag", this.ForceCheckTag);
        }
    }
}

