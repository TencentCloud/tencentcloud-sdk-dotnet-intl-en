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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindSharedCNAMERequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID of the acceleration domain name.	
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Binding type. Valid values:
        /// <li>bind: bind;</li>
        /// <li>unbind: Unbind.</li>
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }

        /// <summary>
        /// Binding relationship between the domain name and shared CNAME.
        /// </summary>
        [JsonProperty("BindSharedCNAMEMaps")]
        public BindSharedCNAMEMap[] BindSharedCNAMEMaps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamArrayObj(map, prefix + "BindSharedCNAMEMaps.", this.BindSharedCNAMEMaps);
        }
    }
}

