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

    public class ClientAttestationRules : AbstractModel
    {
        
        /// <summary>
        /// List of client authentication. When using ModifySecurityPolicy to modify Web protection configuration: <li> If the Rules parameter in SecurityPolicy.BotManagement.ClientAttestationRules is not specified, or the Rules parameter length is zero: clear all client authentication rule configurations.</li> <li> If the ClientAttestationRules parameter value is not specified in the SecurityPolicy.BotManagement parameter: keep the existing client authentication rule configuration without modification.</li>
        /// </summary>
        [JsonProperty("Rules")]
        public ClientAttestationRule[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

