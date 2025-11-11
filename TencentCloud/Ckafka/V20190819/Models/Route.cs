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
        /// Specifies the network type of the route (3: vpc routing; 7: internal support route; 1: public network route).
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
        /// Timestamp.
        /// </summary>
        [JsonProperty("DeleteTimestamp")]
        public string DeleteTimestamp{ get; set; }

        /// <summary>
        /// Specifies the subnet Id.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Subnet")]
        public string Subnet{ get; set; }

        /// <summary>
        /// Virtual IP list (1:1 broker node).
        /// </summary>
        [JsonProperty("BrokerVipList")]
        public VipEntity[] BrokerVipList{ get; set; }

        /// <summary>
        /// VPC Id. specifies the Id of the vpc.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Remarks
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// Route status. 1: creating, 2: creation succeeded, 3: creation failed, 4: deleting, 6: deletion failed.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }


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
            this.SetParamSimple(map, prefix + "Subnet", this.Subnet);
            this.SetParamArrayObj(map, prefix + "BrokerVipList.", this.BrokerVipList);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

