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
        /// Specifies the identity document type used for authentication. valid values:.  
        /// 
        /// HK (default): hong kong (china) identity card.
        /// 2. ML: malaysian identity card.
        /// Indonesian identity card.
        /// 4. PhilippinesVoteID: specifies the voter card in the philippines.
        /// 5. PhilippinesDrivingLicense: specifies the driving license in philippines.
        /// 6. PhilippinesTinID: specifies the philippines tin id.
        /// 7. PhilippinesSSSID: specifies the SSSID in the philippines.
        /// 8. philippines UMID: specifies the philippines UMID.
        /// 9. MLIDPassport: specifies the passport for hong kong (china), macao (china), and taiwan (china) as well as overseas passports.
        /// ThailandIDCard: specifies the thai identity card.
        /// Mainland id card.
        /// 12. SingaporeIDCard: specifies the Singapore id card.
        /// 13. HMTPermit: specifies the hong kong, macau and taiwan travel permit.
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
        /// Customize which alarm codes to block. If left blank, all alarm codes will be blocked by default.
        /// Optional alarm codes are: -9101 (occlusion or incomplete border), -9102 (photocopying), -9103 (screen capture by camera), -9104 (image editing/PS modification), -9107 (glare/reflection), -9108 (blurriness), -9901 (other alarms).
        /// </summary>
        [JsonProperty("SelectedWarningCodes")]
        public long?[] SelectedWarningCodes{ get; set; }

        /// <summary>
        /// A passthrough field, which is returned together with the verification result and can contain up to 1,024 bits.
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// ENHANCED: enhanced.
        /// BASIC: basic version (default).
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
            this.SetParamArraySimple(map, prefix + "SelectedWarningCodes.", this.SelectedWarningCodes);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "ActionList", this.ActionList);
        }
    }
}

