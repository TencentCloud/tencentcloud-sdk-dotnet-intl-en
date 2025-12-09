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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpcEndpointInfo : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VpcEndpoint")]
        public string VpcEndpoint{ get; set; }

        /// <summary>
        /// Access point status. valid values: OFF, ON, CREATING, DELETING.
        /// </summary>
        [JsonProperty("VpcDataStreamEndpointStatus")]
        public string VpcDataStreamEndpointStatus{ get; set; }

        /// <summary>
        /// Encrypted TLS data stream access point.
        /// </summary>
        [JsonProperty("VpcTlsEndpoint")]
        public string VpcTlsEndpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcEndpoint", this.VpcEndpoint);
            this.SetParamSimple(map, prefix + "VpcDataStreamEndpointStatus", this.VpcDataStreamEndpointStatus);
            this.SetParamSimple(map, prefix + "VpcTlsEndpoint", this.VpcTlsEndpoint);
        }
    }
}

