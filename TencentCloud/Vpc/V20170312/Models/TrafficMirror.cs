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

    public class TrafficMirror : AbstractModel
    {
        
        /// <summary>
        /// VPC instance ID.
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Traffic mirroring instance.
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

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
        /// Traffic mirroring status.
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Traffic mirroring collection direction.
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// Traffic mirroring collection object.
        /// </summary>
        [JsonProperty("CollectorSrcs")]
        public string[] CollectorSrcs{ get; set; }

        /// <summary>
        /// NAT gateway instance ID filtered by traffic mirroring.
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// Five tuple rule filtered by traffic mirroring.
        /// </summary>
        [JsonProperty("CollectorNormalFilters")]
        public TrafficMirrorFilter[] CollectorNormalFilters{ get; set; }

        /// <summary>
        /// Traffic mirroring receiving target.
        /// </summary>
        [JsonProperty("CollectorTarget")]
        public TrafficMirrorTarget CollectorTarget{ get; set; }

        /// <summary>
        /// Traffic mirroring creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Traffic mirroring type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Traffic mirroring subnet ID.
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Resource information of the traffic mirroring receiving target, returned when the receiving target is ENI or CLB.
        /// </summary>
        [JsonProperty("TargetInfo")]
        public TrafficMirrorTargetResourceInfo[] TargetInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "TrafficMirrorName", this.TrafficMirrorName);
            this.SetParamSimple(map, prefix + "TrafficMirrorDescribe", this.TrafficMirrorDescribe);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArraySimple(map, prefix + "CollectorSrcs.", this.CollectorSrcs);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamArrayObj(map, prefix + "CollectorNormalFilters.", this.CollectorNormalFilters);
            this.SetParamObj(map, prefix + "CollectorTarget.", this.CollectorTarget);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamArrayObj(map, prefix + "TargetInfo.", this.TargetInfo);
        }
    }
}

