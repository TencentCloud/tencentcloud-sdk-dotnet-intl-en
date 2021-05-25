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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IKEOptionsSpecification : AbstractModel
    {
        
        /// <summary>
        /// Encryption algorithm. Valid values: `3DES-CBC`, `AES-CBC-128`, `AES-CBS-192`, `AES-CBC-256`, `DES-CBC`, and `SM4`; default value: `3DES-CBC`.
        /// </summary>
        [JsonProperty("PropoEncryAlgorithm")]
        public string PropoEncryAlgorithm{ get; set; }

        /// <summary>
        /// Authentication algorithm. Valid values: `MD5`, `SHA1` and `SHA-256`; default value: `MD5`.
        /// </summary>
        [JsonProperty("PropoAuthenAlgorithm")]
        public string PropoAuthenAlgorithm{ get; set; }

        /// <summary>
        /// Negotiation mode. Available values: 'AGGRESSIVE' and 'MAIN'. Default is MAIN.
        /// </summary>
        [JsonProperty("ExchangeMode")]
        public string ExchangeMode{ get; set; }

        /// <summary>
        /// Type of local identity. Available values: 'ADDRESS' and 'FQDN'. Default is ADDRESS.
        /// </summary>
        [JsonProperty("LocalIdentity")]
        public string LocalIdentity{ get; set; }

        /// <summary>
        /// Type of remote identity. Available values: 'ADDRESS' and 'FQDN'. Default is ADDRESS.
        /// </summary>
        [JsonProperty("RemoteIdentity")]
        public string RemoteIdentity{ get; set; }

        /// <summary>
        /// Local identity. When ADDRESS is selected for LocalIdentity, LocalAddress is required. The default LocalAddress is the public IP of the VPN gateway.
        /// </summary>
        [JsonProperty("LocalAddress")]
        public string LocalAddress{ get; set; }

        /// <summary>
        /// Remote identity. When ADDRESS is selected for RemoteIdentity, RemoteAddress is required.
        /// </summary>
        [JsonProperty("RemoteAddress")]
        public string RemoteAddress{ get; set; }

        /// <summary>
        /// Local identity. When FQDN is selected for LocalIdentity, LocalFqdnName is required.
        /// </summary>
        [JsonProperty("LocalFqdnName")]
        public string LocalFqdnName{ get; set; }

        /// <summary>
        /// Remote identity. When FQDN is selected for RemoteIdentity, RemoteFqdnName is required.
        /// </summary>
        [JsonProperty("RemoteFqdnName")]
        public string RemoteFqdnName{ get; set; }

        /// <summary>
        /// DH group. Specify the DH group used for exchanging the key via IKE. Available values: 'GROUP1', 'GROUP2', 'GROUP5', 'GROUP14', and 'GROUP24'.
        /// </summary>
        [JsonProperty("DhGroupName")]
        public string DhGroupName{ get; set; }

        /// <summary>
        /// IKE SA lifetime (in sec). Value range: 60-604800
        /// </summary>
        [JsonProperty("IKESaLifetimeSeconds")]
        public ulong? IKESaLifetimeSeconds{ get; set; }

        /// <summary>
        /// IKE version
        /// </summary>
        [JsonProperty("IKEVersion")]
        public string IKEVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PropoEncryAlgorithm", this.PropoEncryAlgorithm);
            this.SetParamSimple(map, prefix + "PropoAuthenAlgorithm", this.PropoAuthenAlgorithm);
            this.SetParamSimple(map, prefix + "ExchangeMode", this.ExchangeMode);
            this.SetParamSimple(map, prefix + "LocalIdentity", this.LocalIdentity);
            this.SetParamSimple(map, prefix + "RemoteIdentity", this.RemoteIdentity);
            this.SetParamSimple(map, prefix + "LocalAddress", this.LocalAddress);
            this.SetParamSimple(map, prefix + "RemoteAddress", this.RemoteAddress);
            this.SetParamSimple(map, prefix + "LocalFqdnName", this.LocalFqdnName);
            this.SetParamSimple(map, prefix + "RemoteFqdnName", this.RemoteFqdnName);
            this.SetParamSimple(map, prefix + "DhGroupName", this.DhGroupName);
            this.SetParamSimple(map, prefix + "IKESaLifetimeSeconds", this.IKESaLifetimeSeconds);
            this.SetParamSimple(map, prefix + "IKEVersion", this.IKEVersion);
        }
    }
}

