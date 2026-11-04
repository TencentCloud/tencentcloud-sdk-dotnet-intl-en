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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentPluginCredentialConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Plugin authentication value source</p><p>Enumeration values:</p><ul><li>0: Unspecified</li><li>1: Use the default authentication value of the plug-in. Only APIKey/AccessKey is supported.</li><li>2: Refer to a credential</li><li>3: Refer to a variable</li></ul>
        /// </summary>
        [JsonProperty("AuthValueSource")]
        public long? AuthValueSource{ get; set; }

        /// <summary>
        /// <p>Credential ID</p><p>Input parameter limit: required when AuthValueSource=2</p>
        /// </summary>
        [JsonProperty("CredentialId")]
        public string CredentialId{ get; set; }

        /// <summary>
        /// <p>Parameter configuration</p>
        /// </summary>
        [JsonProperty("ParamList")]
        public AgentPluginCredentialParam[] ParamList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AuthValueSource", this.AuthValueSource);
            this.SetParamSimple(map, prefix + "CredentialId", this.CredentialId);
            this.SetParamArrayObj(map, prefix + "ParamList.", this.ParamList);
        }
    }
}

