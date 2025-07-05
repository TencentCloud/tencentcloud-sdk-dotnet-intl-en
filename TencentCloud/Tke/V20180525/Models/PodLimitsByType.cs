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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PodLimitsByType : AbstractModel
    {
        
        /// <summary>
        /// The number of Pods supported by a TKE shared ENI in non-static IP address mode
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TKERouteENINonStaticIP")]
        public long? TKERouteENINonStaticIP{ get; set; }

        /// <summary>
        /// The number of Pods supported by a TKE shared ENI in static IP address mode
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TKERouteENIStaticIP")]
        public long? TKERouteENIStaticIP{ get; set; }

        /// <summary>
        /// The number of Pods supported by TKE independent ENI mode
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TKEDirectENI")]
        public long? TKEDirectENI{ get; set; }

        /// <summary>
        /// Number of Pods supported by TKE relay network card mode
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TKESubENI")]
        public long? TKESubENI{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TKERouteENINonStaticIP", this.TKERouteENINonStaticIP);
            this.SetParamSimple(map, prefix + "TKERouteENIStaticIP", this.TKERouteENIStaticIP);
            this.SetParamSimple(map, prefix + "TKEDirectENI", this.TKEDirectENI);
            this.SetParamSimple(map, prefix + "TKESubENI", this.TKESubENI);
        }
    }
}

