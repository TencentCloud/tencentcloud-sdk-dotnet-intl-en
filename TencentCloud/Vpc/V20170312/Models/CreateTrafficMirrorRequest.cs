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

    public class CreateTrafficMirrorRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Traffic mirroring name.
        /// </summary>
        [JsonProperty("TrafficMirrorName")]
        public string TrafficMirrorName{ get; set; }

        /// <summary>
        /// Traffic mirroring description.
        /// </summary>
        [JsonProperty("TrafficMirrorDescribe")]
        public string TrafficMirrorDescribe{ get; set; }

        /// <summary>
        /// Traffic mirroring status. Valid values: RUNNING/STOPED (VPC) and RUNNING (public IP address). It is required when VPC traffic mirroring is collected.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Traffic mirroring collection direction. Valid values: EGRESS/INGRESS/ALL (VPC) and ALL (public IP address).
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Traffic mirroring collection object.
        /// </summary>
        [JsonProperty("CollectorSrcs")]
        public string[] CollectorSrcs{ get; set; }

        /// <summary>
        /// NAT gateway instance filtered by traffic mirroring.
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// Five tuple rule to be filtered.
        /// </summary>
        [JsonProperty("CollectorNormalFilters")]
        public TrafficMirrorFilter[] CollectorNormalFilters{ get; set; }

        /// <summary>
        /// Traffic mirroring destination address.
        /// </summary>
        [JsonProperty("CollectorTarget")]
        public TrafficMirrorTarget CollectorTarget{ get; set; }

        /// <summary>
        /// Subnet ID of the sender of the traffic mirroring collection traffic.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Created traffic mirroring type. Valid values: VPC and PUBLICIP. Default value: VPC.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Specifies the list of bound tags. For example, [{"Key": "city", "Value": "shanghai"}].
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TrafficMirrorName", this.TrafficMirrorName);
            this.SetParamSimple(map, prefix + "TrafficMirrorDescribe", this.TrafficMirrorDescribe);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArraySimple(map, prefix + "CollectorSrcs.", this.CollectorSrcs);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamArrayObj(map, prefix + "CollectorNormalFilters.", this.CollectorNormalFilters);
            this.SetParamObj(map, prefix + "CollectorTarget.", this.CollectorTarget);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

