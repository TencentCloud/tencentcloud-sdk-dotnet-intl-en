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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCloudNativeAPIGatewayCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// gateway ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Certificate ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Certificate name, will already be deprecated
        /// </summary>
        [JsonProperty("Name")]
        [System.Obsolete]
        public string Name{ get; set; }

        /// <summary>
        /// Certificate private key. Required when CertSource is native.
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// Certificate in pem format. Required when CertSource is native.
        /// </summary>
        [JsonProperty("Crt")]
        public string Crt{ get; set; }

        /// <summary>
        /// Bound domain names will already be deprecated
        /// </summary>
        [JsonProperty("BindDomains")]
        [System.Obsolete]
        public string[] BindDomains{ get; set; }

        /// <summary>
        /// ssl platform cert Id. Required when CertSource is ssl.
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// Certificate source
        /// -ssl (Platform Cert), default value
        /// -native (kong custom certificate) 
        /// </summary>
        [JsonProperty("CertSource")]
        public string CertSource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Crt", this.Crt);
            this.SetParamArraySimple(map, prefix + "BindDomains.", this.BindDomains);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertSource", this.CertSource);
        }
    }
}

