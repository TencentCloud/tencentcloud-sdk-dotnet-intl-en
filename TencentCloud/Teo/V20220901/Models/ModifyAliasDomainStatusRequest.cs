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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAliasDomainStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Status of the alias domain name. Values:
        /// <li>`false`: Enable the alias domain name.</li>
        /// <li>`true`: Disable the alias domain name.</li>
        /// </summary>
        [JsonProperty("Paused")]
        public bool? Paused{ get; set; }

        /// <summary>
        /// The alias domain name you want to modify its status. If it is left empty, the modify operation is not performed.
        /// </summary>
        [JsonProperty("AliasNames")]
        public string[] AliasNames{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Paused", this.Paused);
            this.SetParamArraySimple(map, prefix + "AliasNames.", this.AliasNames);
        }
    }
}

