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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApplySdkVerificationTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// The verification mode. Valid values:
        /// 1: OCR + liveness detection + face comparison
        /// 2: Liveness detection + face comparison
        /// 3: Liveness detection
        /// Default value: 1
        /// </summary>
        [JsonProperty("CheckMode")]
        public long? CheckMode{ get; set; }

        /// <summary>
        /// The security level of the verification. Valid values:
        /// 1: Video-based liveness detection
        /// 2: Motion-based liveness detection
        /// 3: Reflection-based liveness detection
        /// 4: Motion- and reflection-based liveness detection
        /// Default value: 4
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public long? SecurityLevel{ get; set; }

        /// <summary>
        /// Card Types Supported for Authentication: Currently supported types are as follows:
        /// 1.HK (Default): Hong Kong (China) Identity Card
        /// 2.ML: Malaysia Identity Card
        /// 3.IndonesiaIDCard: Indonesia Identity Card
        /// 4.PhilippinesVoteID: Philippines Voter ID
        /// 5.PhilippinesDrivingLicense: Philippines Driving License
        /// 6.PhilippinesTinID: Philippines Tin ID
        /// 7.PhilippinesSSSID: Philippines SSS ID
        /// 8.PhilippinesUMID: Philippines UMID
        /// 9.MLIDPassport: Passports of Hong Kong, Macao, Taiwan Regions (China) and Foreign Countries
        /// 10.ThailandIDCard: Thailand Identity Card
        /// 11.MainlandIDCard: Mainland China Identity Card
        /// 12.SingaporeIDCard: Singapore Identity Card
        /// 13.HMTPermit: Exit-Entry Permit for Travel to and from Hong Kong, Macao and Taiwan (China)
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// The Base64-encoded value of the photo to compare, which is required only when `CheckMode` is set to `2`.
        /// </summary>
        [JsonProperty("CompareImage")]
        public string CompareImage{ get; set; }

        /// <summary>
        /// Whether ID card authentication is required. If not, only document OCR will be performed. Currently, authentication is available only when the value of `IdCardType` is `HK`.
        /// </summary>
        [JsonProperty("NeedVerifyIdCard")]
        [System.Obsolete]
        public bool? NeedVerifyIdCard{ get; set; }

        /// <summary>
        /// Whether to forbid the modification of the OCR result by users. Default value: `false` (modification allowed). (Currently, this parameter is not applied.)
        /// </summary>
        [JsonProperty("DisableChangeOcrResult")]
        public bool? DisableChangeOcrResult{ get; set; }

        /// <summary>
        /// Whether to disable the OCR warnings. Default value: `false` (not disable), where OCR warnings are enabled and the OCR result will not be returned if there is a warning.
        /// This feature applies only to Hong Kong (China) identity cards, Malaysian identity cards, and passports.
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// A passthrough field, which is returned together with the verification result and can contain up to 1,024 bits.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// ENHANCED: Enhanced Version, BASIC: Basic Version (Default)
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// This interface is used to control th action sequences.
        /// Action types are as follows:
        /// "blink"
        /// "mouth"
        /// "nod"
        /// "shake"
        /// You can choose 1-2 actions out of the four.
        /// Single action example: "blink"
        /// Multiple action example: "blink,mouth"
        /// The default value is blink. The different action types passed in this parameter take effect only when the SecurityLevel is 2 or 4; otherwise, the interface reports an error.
        /// </summary>
        [JsonProperty("ActionList")]
        public string ActionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
            this.SetParamSimple(map, prefix + "SecurityLevel", this.SecurityLevel);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "CompareImage", this.CompareImage);
            this.SetParamSimple(map, prefix + "NeedVerifyIdCard", this.NeedVerifyIdCard);
            this.SetParamSimple(map, prefix + "DisableChangeOcrResult", this.DisableChangeOcrResult);
            this.SetParamSimple(map, prefix + "DisableCheckOcrWarnings", this.DisableCheckOcrWarnings);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "ActionList", this.ActionList);
        }
    }
}

