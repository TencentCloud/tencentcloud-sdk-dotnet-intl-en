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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SignResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Signature verification status. 1 indicates that the signature verification is passed.</p>
        /// </summary>
        [JsonProperty("VerifyStatus")]
        public long? VerifyStatus{ get; set; }

        /// <summary>
        /// <p>Signer name</p>
        /// </summary>
        [JsonProperty("SignerName")]
        public string SignerName{ get; set; }

        /// <summary>
        /// <p>Signature algorithm, such as SHA256withRSA</p>
        /// </summary>
        [JsonProperty("SignAlgorithm")]
        public string SignAlgorithm{ get; set; }

        /// <summary>
        /// <p>Signature time (Unix timestamp in milliseconds)</p>
        /// </summary>
        [JsonProperty("SignTime")]
        public long? SignTime{ get; set; }

        /// <summary>
        /// <p>Signature verification information</p>
        /// </summary>
        [JsonProperty("CertSn")]
        public string CertSn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerifyStatus", this.VerifyStatus);
            this.SetParamSimple(map, prefix + "SignerName", this.SignerName);
            this.SetParamSimple(map, prefix + "SignAlgorithm", this.SignAlgorithm);
            this.SetParamSimple(map, prefix + "SignTime", this.SignTime);
            this.SetParamSimple(map, prefix + "CertSn", this.CertSn);
        }
    }
}

