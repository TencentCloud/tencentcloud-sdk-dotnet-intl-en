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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplySdkVerificationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// Whether ID card authentication is required. If not, only document OCR will be performed. Currently, authentication is available only when the value of `IdCardType` is `HK`.
        /// </summary>
        [JsonProperty("NeedVerifyIdCard")]
        public bool? NeedVerifyIdCard{ get; set; }

        /// <summary>
        /// The identity document type. Valid values: `HK` (identity card of Hong Kong (China)) (default), `ML` (Malaysian identity card), `IndonesiaIDCard` (Indonesian identity card), `PhilippinesVoteID` (Philippine voters ID card), `PhilippinesDrivingLicense` (Philippine driver's license), `PhilippinesTinID` (Philippine TIN ID card), `PhilippinesSSSID` (Philippine SSS ID card), and `MLIDPassport` (passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions).
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// Whether to forbid the modification of the OCR result by users. Default value: `false` (modification allowed).
        /// </summary>
        [JsonProperty("DisableChangeOcrResult")]
        public bool? DisableChangeOcrResult{ get; set; }

        /// <summary>
        /// Whether to disable the OCR warnings. Default value: `false` (not disable), where OCR warnings are enabled and the OCR result will not be returned if there is a warning. If `NeedVerifyIdCard` is set to `true`, this parameter must also be set to `true`.
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// A passthrough field, which is returned together with the verification result and can contain up to 1,024 bits.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NeedVerifyIdCard", this.NeedVerifyIdCard);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "DisableChangeOcrResult", this.DisableChangeOcrResult);
            this.SetParamSimple(map, prefix + "DisableCheckOcrWarnings", this.DisableCheckOcrWarnings);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
        }
    }
}

