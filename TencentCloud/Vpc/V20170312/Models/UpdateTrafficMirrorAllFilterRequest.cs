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

    public class UpdateTrafficMirrorAllFilterRequest : AbstractModel
    {
        
        /// <summary>
        /// Traffic mirroring instance ID.
        /// </summary>
        [JsonProperty("TrafficMirrorId")]
        public string TrafficMirrorId{ get; set; }

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
        /// NAT gateway instance to be filtered by traffic mirroring.
        /// </summary>
        [JsonProperty("NatId")]
        public string NatId{ get; set; }

        /// <summary>
        /// Five tuple rule to be filtered by traffic mirroring.
        /// </summary>
        [JsonProperty("CollectorNormalFilters")]
        public TrafficMirrorFilter[] CollectorNormalFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrafficMirrorId", this.TrafficMirrorId);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamArraySimple(map, prefix + "CollectorSrcs.", this.CollectorSrcs);
            this.SetParamSimple(map, prefix + "NatId", this.NatId);
            this.SetParamArrayObj(map, prefix + "CollectorNormalFilters.", this.CollectorNormalFilters);
        }
    }
}

