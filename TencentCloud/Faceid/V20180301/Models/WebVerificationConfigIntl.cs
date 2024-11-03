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

    public class WebVerificationConfigIntl : AbstractModel
    {
        
        /// <summary>
        /// When starting verification, whether to skip the starting verification page. If true, enter the verification process directly. The default is false. This configuration will not take effect if the downgrade policy is triggered.
        /// </summary>
        [JsonProperty("AutoSkipStartPage")]
        public bool? AutoSkipStartPage{ get; set; }

        /// <summary>
        /// When the verification passed, whether to skip the result page and automatically jump to RedirectURL. The default value is false.
        /// Example value: false
        /// </summary>
        [JsonProperty("AutoSkip")]
        public bool? AutoSkip{ get; set; }

        /// <summary>
        /// Detection mode, parameter values are as follows:
        /// 1: OCR+living detection & face comparison;
        /// 2: Living detection & face comparison;
        /// 3: Living detection;
        /// The default value is 2.
        /// Example value: 3
        /// </summary>
        [JsonProperty("CheckMode")]
        public long? CheckMode{ get; set; }

        /// <summary>
        /// The type of lisence used for verification. The following types are supported.
        /// 1.HKIDCard: Hong Kong (China) ID card
        /// 2.MLIDCard: Malaysia ID card
        /// 3.IndonesiaIDCard: Indonesia ID card
        /// 4.PhilippinesVoteID: Philippines VoteID card
        /// 5.PhilippinesDrivingLicense: Philippines driving license
        /// 6.PhilippinesTinID: Philippines TinID card
        /// 7.PhilippinesSSSID: Philippines SSSID card
        /// 8.PhilippinesUMID: Philippines UMID card
        /// 9.InternationalIDPassport: ID cards of Hong Kong, Macao and Taiwan (China), and international passport.
        /// 10.IndonesiaDrivingLicense:Indonesia driving license
        /// 11.ThailandIDCard: Thailand ID card
        /// 12.ThailandDrivingLicense: Thailand driving license
        /// 13.MLDrivingLicense: Malaysia driving license
        /// 14.SingaporeIDCard: Singapore ID card
        /// 15.SingaporeDrivingLicense: Singapore driving license
        /// 16.JapanIDCard: Japan ID card
        /// 17.JapanDrivingLicense: Japan driving license
        /// 18.PhilippinesIDCard: Philippines ID card
        /// 19.MainlandIDCard: Mainland ID card
        /// 20.MacaoIDCard: Macao ID card
        /// Example: HKIDCard
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }

        /// <summary>
        /// Whether to turn off document alarms, the default is false (the alarm detection function is turned on). When enabled, the identity authentication process will be intercepted based on the alarm status of the certificate. If you need to use the document authentication function, please contact us.
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// Liveness security level: 1:Silent mode;2:Action mode;3:Lighting mode;4:Action+Lighting mode;5:Action+Lighting(High security) mode; default value is 3
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public long? SecurityLevel{ get; set; }

        /// <summary>
        /// Whether to skip the agreement page, the default is false. When SkipPrivacyPolicy is false, the agreement page will be displayed and the privacy agreement needs to be checked; when SkipPrivacyPolicy is true, the agreement page will be skipped and the liveness process will be entered directly without checking the privacy agreement page.
        /// </summary>
        [JsonProperty("SkipPrivacyPolicy")]
        public bool? SkipPrivacyPolicy{ get; set; }

        /// <summary>
        /// The default value is false. If it is false, the original ID image will be displayed. If it is true, the cut ID image will be displayed.
        /// </summary>
        [JsonProperty("IdCardCutReturn")]
        public bool? IdCardCutReturn{ get; set; }

        /// <summary>
        /// Front-end theme color, in the format of RGB hexadecimal color code. The default value is "#2d72+1". If the format is incorrect, the default value color will be used.
        /// </summary>
        [JsonProperty("ThemeColor")]
        public string ThemeColor{ get; set; }

        /// <summary>
        /// International language, the default value is en (English). Currently supported: th: Thai; en: English; zh-cn: Simplified Chinese; zh-tc: Tradionnal Chinese; id: Bahasa Indonesia.
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// Automatic downgrade mode, with the following parameter values: 1: Downgrade to silent live mode; 2: Disable downgrade mode. The default value is 1.
        /// </summary>
        [JsonProperty("AutoDowngrade")]
        public long? AutoDowngrade{ get; set; }

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
        /// The default value is blink. The different action types passed in this parameter take effect only when the SecurityLevel is 2, 4, or 5; otherwise, the interface reports an error.
        /// </summary>
        [JsonProperty("ActionList")]
        public string ActionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSkipStartPage", this.AutoSkipStartPage);
            this.SetParamSimple(map, prefix + "AutoSkip", this.AutoSkip);
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
            this.SetParamSimple(map, prefix + "IDCardType", this.IDCardType);
            this.SetParamSimple(map, prefix + "DisableCheckOcrWarnings", this.DisableCheckOcrWarnings);
            this.SetParamSimple(map, prefix + "SecurityLevel", this.SecurityLevel);
            this.SetParamSimple(map, prefix + "SkipPrivacyPolicy", this.SkipPrivacyPolicy);
            this.SetParamSimple(map, prefix + "IdCardCutReturn", this.IdCardCutReturn);
            this.SetParamSimple(map, prefix + "ThemeColor", this.ThemeColor);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "AutoDowngrade", this.AutoDowngrade);
            this.SetParamSimple(map, prefix + "ActionList", this.ActionList);
        }
    }
}

