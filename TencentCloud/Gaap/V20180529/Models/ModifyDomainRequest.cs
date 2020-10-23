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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Layer-7 listener ID
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// Original domain name information
        /// </summary>
        [JsonProperty("OldDomain")]
        public string OldDomain{ get; set; }

        /// <summary>
        /// New domain name information
        /// </summary>
        [JsonProperty("NewDomain")]
        public string NewDomain{ get; set; }

        /// <summary>
        /// Server SSL certificate ID. It's only applicable to the connections of version 3.0:
        /// If this field is not passed in, the original certificate will be used;
        /// If this field is passed in, and CertificateId=default, the listener certificate will be used;
        /// For other cases, the certificate specified by CertificateId will be used.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Client CA certificate ID. It's only applicable to the connections of version 3.0:
        /// If this field is not passed in, the original certificate will be used;
        /// If this field is passed in, and ClientCertificateId=default, the listener certificate will be used;
        /// For other cases, the certificate specified by ClientCertificateId will be used.
        /// </summary>
        [JsonProperty("ClientCertificateId")]
        public string ClientCertificateId{ get; set; }

        /// <summary>
        /// Client CA certificate ID. It is only applicable to connections on version 3.0, where:
        /// If this field and `ClientCertificateId` are not included, the original certificate will be used;
        /// If this field is included, and ClientCertificateId=default, then the listener certificate will be used;
        /// In other cases, the certificate specified by `ClientCertificateId` or `PolyClientCertificateIds` will be used.
        /// </summary>
        [JsonProperty("PolyClientCertificateIds")]
        public string[] PolyClientCertificateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "OldDomain", this.OldDomain);
            this.SetParamSimple(map, prefix + "NewDomain", this.NewDomain);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ClientCertificateId", this.ClientCertificateId);
            this.SetParamArraySimple(map, prefix + "PolyClientCertificateIds.", this.PolyClientCertificateIds);
        }
    }
}

