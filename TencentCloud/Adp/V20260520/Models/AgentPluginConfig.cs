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

    public class AgentPluginConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>plugin_id</p>
        /// </summary>
        [JsonProperty("PluginId")]
        public string PluginId{ get; set; }

        /// <summary>
        /// <p>Plug-in Header parameter</p>
        /// </summary>
        [JsonProperty("HeaderParameterList")]
        public AgentPluginParameter[] HeaderParameterList{ get; set; }

        /// <summary>
        /// <p>Plug-in Query parameter</p>
        /// </summary>
        [JsonProperty("QueryParameterList")]
        public AgentPluginParameter[] QueryParameterList{ get; set; }

        /// <summary>
        /// <p>Whether to use CAM one-click authorization. This parameter is valid only when auth_type=2</p>
        /// </summary>
        [JsonProperty("EnableCamRoleAuth")]
        public bool? EnableCamRoleAuth{ get; set; }

        /// <summary>
        /// <p>Authorization type</p><p>Enumeration values:</p><ul><li>0: No authentication</li><li>1: API Key</li><li>2: CAM authorization</li><li>3: OAuth2.0 authorization</li></ul>
        /// </summary>
        [JsonProperty("AuthType")]
        public long? AuthType{ get; set; }

        /// <summary>
        /// <p>OAuth authorization and consent mode; 0 - developer authorization; 1 - user authorization (valid only when auth_type=3)</p>
        /// </summary>
        [JsonProperty("OAuthConsent")]
        public long? OAuthConsent{ get; set; }

        /// <summary>
        /// <p>Credential configuration</p>
        /// </summary>
        [JsonProperty("CredentialConfig")]
        public AgentPluginCredentialConfig CredentialConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PluginId", this.PluginId);
            this.SetParamArrayObj(map, prefix + "HeaderParameterList.", this.HeaderParameterList);
            this.SetParamArrayObj(map, prefix + "QueryParameterList.", this.QueryParameterList);
            this.SetParamSimple(map, prefix + "EnableCamRoleAuth", this.EnableCamRoleAuth);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamSimple(map, prefix + "OAuthConsent", this.OAuthConsent);
            this.SetParamObj(map, prefix + "CredentialConfig.", this.CredentialConfig);
        }
    }
}

