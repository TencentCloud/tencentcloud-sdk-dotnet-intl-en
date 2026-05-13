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

    public class InstanceVersion : AbstractModel
    {
        
        /// <summary>
        /// <p>ckafka cluster instance version</p>
        /// </summary>
        [JsonProperty("KafkaVersion")]
        public string KafkaVersion{ get; set; }

        /// <summary>
        /// <p>broker version info</p>
        /// </summary>
        [JsonProperty("CurBrokerVersion")]
        public string CurBrokerVersion{ get; set; }

        /// <summary>
        /// <p>latest version info</p>
        /// </summary>
        [JsonProperty("LatestBrokerVersion")]
        public LatestBrokerVersion[] LatestBrokerVersion{ get; set; }

        /// <summary>
        /// <p>Permission for cross-major version kernel upgrade</p>
        /// </summary>
        [JsonProperty("AllowUpgradeHighVersion")]
        public bool? AllowUpgradeHighVersion{ get; set; }

        /// <summary>
        /// <p>Permission for major version upgrade</p>
        /// </summary>
        [JsonProperty("HighVersionSet")]
        public string[] HighVersionSet{ get; set; }

        /// <summary>
        /// <p>Permission to configure auto deletion of consumer group for minor version number</p>
        /// </summary>
        [JsonProperty("AllowAutoDeleteTimestamp")]
        public bool? AllowAutoDeleteTimestamp{ get; set; }

        /// <summary>
        /// <p>Allow the modification of transaction ID expiration time configuration</p>
        /// </summary>
        [JsonProperty("AllowModifyTxnIdExpiration")]
        public bool? AllowModifyTxnIdExpiration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KafkaVersion", this.KafkaVersion);
            this.SetParamSimple(map, prefix + "CurBrokerVersion", this.CurBrokerVersion);
            this.SetParamArrayObj(map, prefix + "LatestBrokerVersion.", this.LatestBrokerVersion);
            this.SetParamSimple(map, prefix + "AllowUpgradeHighVersion", this.AllowUpgradeHighVersion);
            this.SetParamArraySimple(map, prefix + "HighVersionSet.", this.HighVersionSet);
            this.SetParamSimple(map, prefix + "AllowAutoDeleteTimestamp", this.AllowAutoDeleteTimestamp);
            this.SetParamSimple(map, prefix + "AllowModifyTxnIdExpiration", this.AllowModifyTxnIdExpiration);
        }
    }
}

