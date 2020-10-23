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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkAcl : AbstractModel
    {
        
        /// <summary>
        /// `ID` of the `VPC` instance.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// `ID` of the network ACL instance.
        /// </summary>
        [JsonProperty("NetworkAclId")]
        public string NetworkAclId{ get; set; }

        /// <summary>
        /// Name of the network ACL. The maximum length is 60 bytes.
        /// </summary>
        [JsonProperty("NetworkAclName")]
        public string NetworkAclName{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Array of subnets associated with the network ACL.
        /// </summary>
        [JsonProperty("SubnetSet")]
        public Subnet[] SubnetSet{ get; set; }

        /// <summary>
        /// Inbound rules of the network ACL.
        /// </summary>
        [JsonProperty("IngressEntries")]
        public NetworkAclEntry[] IngressEntries{ get; set; }

        /// <summary>
        /// Outbound rules of the network ACL.
        /// </summary>
        [JsonProperty("EgressEntries")]
        public NetworkAclEntry[] EgressEntries{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NetworkAclId", this.NetworkAclId);
            this.SetParamSimple(map, prefix + "NetworkAclName", this.NetworkAclName);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "SubnetSet.", this.SubnetSet);
            this.SetParamArrayObj(map, prefix + "IngressEntries.", this.IngressEntries);
            this.SetParamArrayObj(map, prefix + "EgressEntries.", this.EgressEntries);
        }
    }
}

