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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetExternalSAMLIdentityProviderRequest : AbstractModel
    {
        
        /// <summary>
        /// Space ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// IdP metadata document (Base64 encoded). Provided by an IdP that supports the SAML 2.0 protocol.
        /// </summary>
        [JsonProperty("EncodedMetadataDocument")]
        public string EncodedMetadataDocument{ get; set; }

        /// <summary>
        /// SSO enabling status. Valid values: Enabled, Disabled (default).
        /// </summary>
        [JsonProperty("SSOStatus")]
        public string SSOStatus{ get; set; }

        /// <summary>
        /// IdP identifier.
        /// </summary>
        [JsonProperty("EntityId")]
        public string EntityId{ get; set; }

        /// <summary>
        /// IdP login URL.
        /// </summary>
        [JsonProperty("LoginUrl")]
        public string LoginUrl{ get; set; }

        /// <summary>
        /// X509 certificate in PEM format. If this parameter is specified, all existing certificates will be replaced.
        /// </summary>
        [JsonProperty("X509Certificate")]
        public string X509Certificate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "EncodedMetadataDocument", this.EncodedMetadataDocument);
            this.SetParamSimple(map, prefix + "SSOStatus", this.SSOStatus);
            this.SetParamSimple(map, prefix + "EntityId", this.EntityId);
            this.SetParamSimple(map, prefix + "LoginUrl", this.LoginUrl);
            this.SetParamSimple(map, prefix + "X509Certificate", this.X509Certificate);
        }
    }
}
