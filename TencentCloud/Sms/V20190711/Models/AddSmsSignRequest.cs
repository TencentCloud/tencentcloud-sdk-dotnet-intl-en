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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddSmsSignRequest : AbstractModel
    {
        
        /// <summary>
        /// Signature name.
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// Signature type. Each of these types is followed by their `DocumentType` (identity document type) option:
        /// 0: company (0, 1, 2, 3).
        /// 1: app (0, 1, 2, 3, 4).
        /// 2: website (0, 1, 2, 3, 5).
        /// 3: WeChat Official Account or WeChat Mini Program (0, 1, 2, 3, 6).
        /// 4: trademark (7).
        /// 5: governmental/public institution or others (2, 3).
        /// Note: the identity document type must be selected according to the correspondence; otherwise, the review will fail.
        /// </summary>
        [JsonProperty("SignType")]
        public ulong? SignType{ get; set; }

        /// <summary>
        /// Identity document type:
        /// 0: 3-in-1 license.
        /// 1: business license.
        /// 2: organization code certificate.
        /// 3: certificate of unified social credit code.
        /// 4: screenshot of application backend management (for personal app).
        /// 5: screenshot of website ICP filing backend (for personal website).
        /// 6: screenshot of WeChat Mini Program settings page (for personal WeChat Mini Program).
        /// 7: trademark registration certificate.
        /// </summary>
        [JsonProperty("DocumentType")]
        public ulong? DocumentType{ get; set; }

        /// <summary>
        /// Whether it is Global SMS:
        /// 0: Mainland China SMS.
        /// 1: Global SMS.
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// Signature use:
        /// 0: for self-use.
        /// 1: for others.
        /// </summary>
        [JsonProperty("UsedMethod")]
        public ulong? UsedMethod{ get; set; }

        /// <summary>
        /// You should Base64-encode the image of the identity document corresponding to the signature first, remove the prefix `data:image/jpeg;base64,` from the resulted string, and then use it as the value of this parameter.
        /// </summary>
        [JsonProperty("ProofImage")]
        public string ProofImage{ get; set; }

        /// <summary>
        /// Authorization letter, which should be submitted if `UsedMethod` is for others.
        /// You should Base64-encode the image first, remove the prefix `data:image/jpeg;base64,` from the resulted string, and then use it as the value of this parameter.
        /// Note: this field will take effect only when `UsedMethod` is 1 (for others).
        /// </summary>
        [JsonProperty("CommissionImage")]
        public string CommissionImage{ get; set; }

        /// <summary>
        /// Signature application remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "UsedMethod", this.UsedMethod);
            this.SetParamSimple(map, prefix + "ProofImage", this.ProofImage);
            this.SetParamSimple(map, prefix + "CommissionImage", this.CommissionImage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

