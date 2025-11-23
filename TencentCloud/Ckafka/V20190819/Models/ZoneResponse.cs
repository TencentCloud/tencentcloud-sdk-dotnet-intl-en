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
        /// <P>Specifies the zone list.</p>.
        /// </summary>
        [JsonProperty("ZoneList")]
        public ZoneInfo[] ZoneList{ get; set; }

        /// <summary>
        /// <P>Maximum number of instances that can be purchased.</p>.
        /// </summary>
        [JsonProperty("MaxBuyInstanceNum")]
        public long? MaxBuyInstanceNum{ get; set; }

        /// <summary>
        /// <p>Maximum purchase bandwidth in Mb/s.</p>.
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// <P>Unit price for postpayment.</p>.
        /// </summary>
        [JsonProperty("UnitPrice")]
        public Price UnitPrice{ get; set; }

        /// <summary>
        /// <P>Message unit price for postpayment.</p>.
        /// </summary>
        [JsonProperty("MessagePrice")]
        public Price MessagePrice{ get; set; }

        /// <summary>
        /// <P>User-Exclusive cluster information.</p>.
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// <P>Specifies the standard version configuration to purchase.</p>.
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// <P>Specifies the purchase of standard version s2 configuration.</p>.
        /// </summary>
        [JsonProperty("StandardS2")]
        public string StandardS2{ get; set; }

        /// <summary>
        /// <P>Specifies the configuration for purchasing professional edition.</p>.
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// <P>Purchase physical dedicated edition configuration.</p>.
        /// </summary>
        [JsonProperty("Physical")]
        public string Physical{ get; set; }

        /// <summary>
        /// <p>Specifies the public network bandwidth. valid values: 3Mbps to 999Mbps. only supported in pro edition. abandoned, meaningless.</p>.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public string PublicNetwork{ get; set; }

        /// <summary>
        /// <P>Public network bandwidth configuration.</p>.
        /// </summary>
        [JsonProperty("PublicNetworkLimit")]
        public string PublicNetworkLimit{ get; set; }

        /// <summary>
        /// <p>Request Id.</p>.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// <P>Specifies the pagination offset.</p>.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <P>Specifies the pagination limit.</p>.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <P>Specifies whether the tag is mandatory.</p>.
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

