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

    public class Route : AbstractModel
    {
        
        /// <summary>
        /// Instance connection method
        /// 0: PLAINTEXT (plaintext method, which does not carry user information and is supported for legacy versions and Community Edition)
        /// 1: SASL_PLAINTEXT (plaintext method, which authenticates the login through SASL before data start and is supported only for Community Edition)
        /// 2: SSL (SSL-encrypted communication, which does not carry user information and is supported for legacy versions and Community Edition)
        /// 3: SASL_SSL (SSL-encrypted communication, which authenticates the login through SASL before data start and is supported only for Community Edition)
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// Route ID
        /// </summary>
        [JsonProperty("RouteId")]
        public long? RouteId{ get; set; }

        /// <summary>
        /// VIP network type (1: Public network TGW; 2: Classic network; 3: VPC; 4: Supporting network (IDC environment); 5: SSL public network access; 6: BM VPC; 7: Supporting network (CVM environment)).
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// Virtual IP list
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// Domain name
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Domain name port
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DomainPort")]
        public long? DomainPort{ get; set; }

        /// <summary>
        /// Timestamp
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeleteTimestamp")]
        public string DeleteTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "VipType", this.VipType);
            this.SetParamArrayObj(map, prefix + "VipList.", this.VipList);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "DomainPort", this.DomainPort);
            this.SetParamSimple(map, prefix + "DeleteTimestamp", this.DeleteTimestamp);
        }
    }
}

