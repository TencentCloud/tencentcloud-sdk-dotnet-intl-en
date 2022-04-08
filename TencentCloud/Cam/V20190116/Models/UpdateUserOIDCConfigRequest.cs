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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateUserOIDCConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// OpenID Connect IdP URL.
        /// It corresponds to the value of the `issuer` field in the `Openid-configuration` provided by the enterprise IdP.
        /// </summary>
        [JsonProperty("IdentityUrl")]
        public string IdentityUrl{ get; set; }

        /// <summary>
        /// Signature public key, which is used to verify the OpenID Connect IdP's ID token and must be Base64-encoded. For the security of your account, we recommend you rotate it regularly.
        /// </summary>
        [JsonProperty("IdentityKey")]
        public string IdentityKey{ get; set; }

        /// <summary>
        /// Client ID registered with the OpenID Connect IdP.
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// OpenID Connect IdP authorization endpoint. It corresponds to the value of the `authorization_endpoint` field in the `Openid-configuration` provided by the enterprise IdP.
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public string AuthorizationEndpoint{ get; set; }

        /// <summary>
        /// Authorization response type, which is always `id_token`.
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// Authorization response mode. Valid values: form_post (recommended); fragment.
        /// </summary>
        [JsonProperty("ResponseMode")]
        public string ResponseMode{ get; set; }

        /// <summary>
        /// Mapping field name. It indicates which field in the `id_token` of the IdP is mapped to the username of a sub-user. It is usually the `sub` or `name` field
        /// </summary>
        [JsonProperty("MappingFiled")]
        public string MappingFiled{ get; set; }

        /// <summary>
        /// Authorization information scope. Valid values: openid (default); email; profile.
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdentityUrl", this.IdentityUrl);
            this.SetParamSimple(map, prefix + "IdentityKey", this.IdentityKey);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "AuthorizationEndpoint", this.AuthorizationEndpoint);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseMode", this.ResponseMode);
            this.SetParamSimple(map, prefix + "MappingFiled", this.MappingFiled);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

