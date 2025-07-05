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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkAclQuintupleEntry : AbstractModel
    {
        
        /// <summary>
        /// Protocol. Valid values: `TCP`, `UDP`, `ICMP`, `ALL`.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Source port. Valid values: all, single port, range. When `Protocol` is `ALL` or `ICMP`, `Port` cannot be specified.
        /// </summary>
        [JsonProperty("SourcePort")]
        public string SourcePort{ get; set; }

        /// <summary>
        /// Source CIDR block.
        /// </summary>
        [JsonProperty("SourceCidr")]
        public string SourceCidr{ get; set; }

        /// <summary>
        /// Destination port. Valid values: all, single port, range. When `Protocol` is `ALL` or `ICMP`, `Port` cannot be specified.
        /// </summary>
        [JsonProperty("DestinationPort")]
        public string DestinationPort{ get; set; }

        /// <summary>
        /// Destination CIDR block.
        /// </summary>
        [JsonProperty("DestinationCidr")]
        public string DestinationCidr{ get; set; }

        /// <summary>
        /// Action. Valid values: `ACCEPT` and `DROP`.
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Unique ID of a network ACL entry.
        /// </summary>
        [JsonProperty("NetworkAclQuintupleEntryId")]
        public string NetworkAclQuintupleEntryId{ get; set; }

        /// <summary>
        /// Priority. `1` refers to the highest priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Creation time. It’s returned by `DescribeNetworkAclQuintupleEntries`.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Direction of the rule. It’s returned by `DescribeNetworkAclQuintupleEntries`. Valid values: `INGRESS` and `EGRESS`.
        /// </summary>
        [JsonProperty("NetworkAclDirection")]
        public string NetworkAclDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourcePort", this.SourcePort);
            this.SetParamSimple(map, prefix + "SourceCidr", this.SourceCidr);
            this.SetParamSimple(map, prefix + "DestinationPort", this.DestinationPort);
            this.SetParamSimple(map, prefix + "DestinationCidr", this.DestinationCidr);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "NetworkAclQuintupleEntryId", this.NetworkAclQuintupleEntryId);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NetworkAclDirection", this.NetworkAclDirection);
        }
    }
}

