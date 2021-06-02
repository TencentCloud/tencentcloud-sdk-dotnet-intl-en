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

namespace TencentCloud.Sms.V20210111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySmsSignRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the signature to be modified.
        /// </summary>
        [JsonProperty("SignId")]
        public ulong? SignId{ get; set; }

        /// <summary>
        /// Signature name.
        /// </summary>
        [JsonProperty("SignName")]
        public string SignName{ get; set; }

        /// <summary>
        /// Signature type. Each of these types is followed by their `DocumentType` (identity certificate type) option:
        /// 0: company. Valid values of `DocumentType` include 0, 1, 2, and 3.
        /// 1: app. Valid values of `DocumentType` include 0, 1, 2, 3, and 4.
        /// 2: website. Valid values of `DocumentType` include 0, 1, 2, 3, and 5.
        /// 3: WeChat Official Account or WeChat Mini Program. Valid values of `DocumentType` include 0, 1, 2, 3, and 6.
        /// 4: trademark. Valid values of `DocumentType` include 7.
        /// 5: government/public institution/other. Valid values of `DocumentType` include 2 and 3.
        /// Note: the identity certificate type must be selected according to the correspondence; otherwise, the review will fail.
        /// </summary>
        [JsonProperty("SignType")]
        public ulong? SignType{ get; set; }

        /// <summary>
        /// Identity certificate type:
        /// 0: three-in-one.
        /// 1: business license.
        /// 2: organization code certificate.
        /// 3: social credit code certificate.
        /// 4: screenshot of application backend management (for personal app).
        /// 5: screenshot of website ICP filing backend (for personal website).
        /// 6: screenshot of WeChat Mini Program settings page (for personal WeChat Mini Program).
        /// 7: trademark registration certificate.
        /// Note: the corresponding `DocumentType` must be selected according to `SignType`.
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
        /// Signature purpose:
        /// 0: for personal use.
        /// 1: for others.
        /// </summary>
        [JsonProperty("SignPurpose")]
        public ulong? SignPurpose{ get; set; }

        /// <summary>
        /// You should Base64-encode the image of the identity certificate corresponding to the signature first, remove the prefix `data:image/jpeg;base64,` from the resulted string, and then use it as the value of this parameter.
        /// </summary>
        [JsonProperty("ProofImage")]
        public string ProofImage{ get; set; }

        /// <summary>
        /// Power of attorney, which should be submitted if `SignPurpose` is for use by others.
        /// You should Base64-encode the image first, remove the prefix `data:image/jpeg;base64,` from the resulted string, and then use it as the value of this parameter.
        /// Note: this field will take effect only when `SignPurpose` is 1 (for user by others).
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
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "SignName", this.SignName);
            this.SetParamSimple(map, prefix + "SignType", this.SignType);
            this.SetParamSimple(map, prefix + "DocumentType", this.DocumentType);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "SignPurpose", this.SignPurpose);
            this.SetParamSimple(map, prefix + "ProofImage", this.ProofImage);
            this.SetParamSimple(map, prefix + "CommissionImage", this.CommissionImage);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

