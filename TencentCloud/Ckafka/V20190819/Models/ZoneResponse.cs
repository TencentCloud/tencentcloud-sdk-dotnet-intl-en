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
        /// Cluster information dedicated to a user
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public ClusterInfo[] ClusterInfo{ get; set; }

        /// <summary>
        /// Purchase of Standard Edition configurations
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Standard")]
        public string Standard{ get; set; }

        /// <summary>
        /// Purchase of Standard S2 Edition configurations
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StandardS2")]
        public string StandardS2{ get; set; }

        /// <summary>
        /// Purchase of Pro Edition configurations
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Profession")]
        public string Profession{ get; set; }

        /// <summary>
        /// Purchase of Physical Dedicated Edition configurations
        /// Note: `null` may be returned for this field, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Physical")]
        public string Physical{ get; set; }

        /// <summary>
        /// Public network bandwidth.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicNetwork")]
        public string PublicNetwork{ get; set; }

        /// <summary>
        /// Public network bandwidth configuration.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PublicNetworkLimit")]
        public string PublicNetworkLimit{ get; set; }


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
        }
    }
}

