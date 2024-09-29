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
        /// The identity document type. Valid values: 
        /// 1. HK (default): Identity card of Hong Kong (China)
        /// 2. ML: Malaysian identity card
        /// 3. IndonesiaIDCard: Indonesian identity card
        /// 4. PhilippinesVoteID: Philippine voters ID card
        /// 5. PhilippinesDrivingLicense: Philippine driver's license
        /// 6. PhilippinesTinID: Philippine TIN ID card
        /// 7. PhilippinesSSSID: Philippine SSS ID card
        /// 8. PhilippinesUMID: Philippine UMID card
        /// 9. MLIDPassport: Passport issued in Hong Kong/Macao/Taiwan (China) or other countries/regions
        /// 10..MacaoIDCard: Macao ID Card
        /// 11.ThailandIDCard: Thailand ID Card
        /// 12.MainlandIDCard: Mainland ID Card
        /// 13.SingaporeIDCard: Singapore ID Card
        /// 14.JapanIDCard: Japan ID Card
        /// 15.MLDrivingLicense: Malaysian Driving License
        /// 16.IndonesiaDrivingLicense: Indonesia Driving License
        /// 17.ThailandDrivingLicense: Thailand Driving License
        /// 18.SingaporeDrivingLicense: Singapore Driving License
        /// 19.JapanDrivingLicense: Japan Driving License
        /// 20.TaiWanIDCard:Taiwan ID Card
        /// 21.HMTPermit: exit/entry permit (card) for traveling to and from Hong Kong, Macao, or Taiwan
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
        }
    }
}

