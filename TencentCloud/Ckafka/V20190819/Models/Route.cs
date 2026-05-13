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
        /// <p>Instance access method 0: PLAINTEXT (plaintext mode, no user information included, supported by older versions and community edition) 1: SASL_PLAINTEXT (plaintext mode, however, login authentication with SASL is performed at data initiation, only supported by community edition) 2: SSL (SSL encrypted communication, no user information included, supported by older versions and community edition) 3: SASL_SSL (SSL encrypted communication, login authentication with SASL is performed at data initiation, only supported by community edition)</p>
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// <p>Route Id</p>
        /// </summary>
        [JsonProperty("RouteId")]
        public long? RouteId{ get; set; }

        /// <summary>
        /// <p>Routing network type (3: vpc routing; 7: Internal support routing; 1: Public network route)</p>
        /// </summary>
        [JsonProperty("VipType")]
        public long? VipType{ get; set; }

        /// <summary>
        /// <p>Virtual IP list</p>
        /// </summary>
        [JsonProperty("VipList")]
        public VipEntity[] VipList{ get; set; }

        /// <summary>
        /// <p>Domain name</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>Domain name port</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DomainPort")]
        public long? DomainPort{ get; set; }

        /// <summary>
        /// <p>Timestamp</p>
        /// </summary>
        [JsonProperty("DeleteTimestamp")]
        public string DeleteTimestamp{ get; set; }

        /// <summary>
        /// <p>Subnet Id</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Subnet")]
        public string Subnet{ get; set; }

        /// <summary>
        /// <p>Virtual IP list (1:1 broker node)</p>
        /// </summary>
        [JsonProperty("BrokerVipList")]
        public VipEntity[] BrokerVipList{ get; set; }

        /// <summary>
        /// <p>VPC Id</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>Remarks</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// <p>Route status. 1: Creating, 2: Successfully created, 3: Creation failed, 4: Deleting, 6: Deletion failed</p>
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

