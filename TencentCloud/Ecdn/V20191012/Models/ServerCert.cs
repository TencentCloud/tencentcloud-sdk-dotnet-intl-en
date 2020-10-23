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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerCert : AbstractModel
    {
        
        /// <summary>
        /// Server certificate ID, which is required if the certificate is a Tencent Cloud-hosted certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// Server certificate name, which is required if the certificate is a Tencent Cloud-hosted certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// Server certificate information, which is required when uploading your own certificate and must contain complete certificate chain information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Certificate")]
        public string Certificate{ get; set; }

        /// <summary>
        /// Server key information, which is required when uploading your own certificate.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// Certificate expiration time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Certificate issuance time.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// Certificate remarks.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "Certificate", this.Certificate);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

