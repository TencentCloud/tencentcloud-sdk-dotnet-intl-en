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

    public class DescribeUserOIDCConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// IdP type. 12: user OIDC IdP
        /// </summary>
        [JsonProperty("ProviderType")]
        public ulong? ProviderType{ get; set; }

        /// <summary>
        /// IdP URL
        /// </summary>
        [JsonProperty("IdentityUrl")]
        public string IdentityUrl{ get; set; }

        /// <summary>
        /// Signature public key
        /// </summary>
        [JsonProperty("IdentityKey")]
        public string IdentityKey{ get; set; }

        /// <summary>
        /// Client ID
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Status. 0: not set; 2: disabled; 11: enabled.
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Authorization endpoint
        /// </summary>
        [JsonProperty("AuthorizationEndpoint")]
        public string AuthorizationEndpoint{ get; set; }

        /// <summary>
        /// Authorization scope
        /// </summary>
        [JsonProperty("Scope")]
        public string[] Scope{ get; set; }

        /// <summary>
        /// Authorization response type
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// Authorization response mode
        /// </summary>
        [JsonProperty("ResponseMode")]
        public string ResponseMode{ get; set; }

        /// <summary>
        /// Mapping field name
        /// </summary>
        [JsonProperty("MappingFiled")]
        public string MappingFiled{ get; set; }

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProviderType", this.ProviderType);
            this.SetParamSimple(map, prefix + "IdentityUrl", this.IdentityUrl);
            this.SetParamSimple(map, prefix + "IdentityKey", this.IdentityKey);
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AuthorizationEndpoint", this.AuthorizationEndpoint);
            this.SetParamArraySimple(map, prefix + "Scope.", this.Scope);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "ResponseMode", this.ResponseMode);
            this.SetParamSimple(map, prefix + "MappingFiled", this.MappingFiled);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

