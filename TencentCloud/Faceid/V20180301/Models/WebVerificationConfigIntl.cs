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

    public class WebVerificationConfigIntl : AbstractModel
    {
        
        /// <summary>
        /// <p>Whether to skip the start verification webpage when starting verification. If true, directly enter the verification process. Default false. If the degradation policy is triggered, this configuration will not take effect.</p>
        /// </summary>
        [JsonProperty("AutoSkipStartPage")]
        public bool? AutoSkipStartPage{ get; set; }

        /// <summary>
        /// <p>Whether to skip the result display page and automatically jump to RedirectURL when verification is successful. Default false.</p>
        /// </summary>
        [JsonProperty("AutoSkip")]
        public bool? AutoSkip{ get; set; }

        /// <summary>
        /// <p>Detection mode. Parameter values are as follows:<br>1: OCR+liveness detection+face comparison;<br>2: liveness detection+face comparison;<br>3: liveness detection;<br>4: OCR;<br>Default value is 2.</p>
        /// </summary>
        [JsonProperty("CheckMode")]
        public long? CheckMode{ get; set; }

        /// <summary>
        /// <p>Identity document type used for authentication. Currently supported:<br>1.HKIDCard: Hong Kong (China) identity card<br>2.MLIDCard: Malaysian identity card<br>3.IndonesiaIDCard: Indonesian Identity Card<br>4.PhilippinesVoteID: Philippines voter card<br>5.PhilippinesDrivingLicense: Philippines driving license<br>6.PhilippinesTinID: Philippines TinID<br>7.PhilippinesSSSID: Philippines SSSID<br>8.PhilippinesUMID: Philippines UMID<br>9.InternationalIDPassport: Passport for Hong Kong (China), Macao (China), and Taiwan (China) as well as overseas passport<br>10.ThailandIDCard: Thai Identity Card<br>11.SingaporeIDCard: Singapore ID card<br>12.MainlandIDCard: Mainland ID card</p>
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }

        /// <summary>
        /// <p>Want to close document alarm, false by default (enable alarm detection). When enabled, the identity verification process will intercept based on the document alarm status. If you need to use document anti-counterfeiting functionality, <a href="https://www.tencentcloud.com/zh/contact-us">contact us</a>.</p>
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// <p>Security level of authentication:<br>1: Silent liveness;<br>2: Action liveness;<br>3: Light liveness;<br>4: Action + light liveness;<br>Default value is 3.</p>
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public long? SecurityLevel{ get; set; }

        /// <summary>
        /// <p>Whether to skip the privacy agreement webpage, default false. When SkipPrivacyPolicy is false, the privacy agreement webpage will show and the privacy agreement must be checked. When SkipPrivacyPolicy is true, the privacy agreement webpage will be skipped to directly enter the Live Face Process without the need to check the privacy agreement webpage.</p>
        /// </summary>
        [JsonProperty("SkipPrivacyPolicy")]
        public bool? SkipPrivacyPolicy{ get; set; }

        /// <summary>
        /// <p>Default false. When false, show the original document image. When true, show the split document image.</p>
        /// </summary>
        [JsonProperty("IdCardCutReturn")]
        public bool? IdCardCutReturn{ get; set; }

        /// <summary>
        /// <p>Frontend theme color in base 16 RGB format. Defaults to "#2d72f1". Uses default values if the format is incorrect.</p>
        /// </summary>
        [JsonProperty("ThemeColor")]
        public string ThemeColor{ get; set; }

        /// <summary>
        /// <p>Internationalized language, defaults to en (English). Currently supported:<br>th: Thai;<br>en: English;<br>zh-cn: Simplified Chinese;<br>zh-tc: Traditional Chinese;<br>id: Indonesia;</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Automatic downgrade mode. Parameter values as follows:<br>1: Downgrade to silent liveness mode.<br>2: Disable downgrade mode.<br>Default value: 1.</p>
        /// </summary>
        [JsonProperty("AutoDowngrade")]
        public long? AutoDowngrade{ get; set; }

        /// <summary>
        /// <p>Control the action sequence. Action types are as follows:<br>"blink"<br>"mouth"<br>"nod"<br>"shake"<br>Choose 1-2 actions from the four.<br>Single action example: "blink"<br>Multi-action example: "blink,mouth".<br>Default value: blink<br>Input this parameter only when SecurityLevel is 2, 4, or 5 for different action types to take effect; otherwise, an API error occurs.</p>
        /// </summary>
        [JsonProperty("ActionList")]
        public string ActionList{ get; set; }

        /// <summary>
        /// <p>Maximum liveness verification attempts. Value ranges from 1 to 99. Default value is 99.</p>
        /// </summary>
        [JsonProperty("LivenessRetryLimit")]
        public long? LivenessRetryLimit{ get; set; }

        /// <summary>
        /// <p>Control the liveness detection timeout period in seconds. The value ranges from 0 to 600. Default: 45 seconds.</p>
        /// </summary>
        [JsonProperty("LivenessTimeout")]
        public ulong? LivenessTimeout{ get; set; }

        /// <summary>
        /// <p>Select OCR alarms that require attention. When an OCR alarm is generated, the identity verification process will be interrupted. The default value is empty, indicating all alarms are monitored. This feature requires the parameter DisableCheckOcrWarnings=false. If the alarm is disabled, this parameter will not be effective.</p><p>Alarm code list and definitions:<br>-9101 Incomplete border alarm<br>-9102 Photocopies alarm<br>-9103 Alarm for rephotographing<br>-9104 ps alarm<br>-9107 Reflective alarm<br>-9108 Blurry alarm<br>-9109 Alarm not enabled</p>
        /// </summary>
        [JsonProperty("SelectedWarningCodes")]
        public string SelectedWarningCodes{ get; set; }

        /// <summary>
        /// <p>Whether to allow expired identity documents to enter the liveness detection process. This parameter is valid only when the document type is Hong Kong identity card (HKID).<br>true (default value): Allow expired Hong Kong identity card to enter the liveness detection process.<br>false: Reject expired Hong Kong identity card, not accessible to the liveness detection process.</p>
        /// </summary>
        [JsonProperty("AllowExpiredDocument")]
        public bool? AllowExpiredDocument{ get; set; }

        /// <summary>
        /// <p>Service version, including basic version (BASIC) and PLUS version (PLUS).</p><p>Enumeration value:</p><ul><li>BASIC: Basic version</li><li>PLUS: PLUS version</li></ul><p>Default value: BASIC.</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }


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
            this.SetParamSimple(map, prefix + "LivenessRetryLimit", this.LivenessRetryLimit);
            this.SetParamSimple(map, prefix + "LivenessTimeout", this.LivenessTimeout);
            this.SetParamSimple(map, prefix + "SelectedWarningCodes", this.SelectedWarningCodes);
            this.SetParamSimple(map, prefix + "AllowExpiredDocument", this.AllowExpiredDocument);
            this.SetParamSimple(map, prefix + "Version", this.Version);
        }
    }
}

