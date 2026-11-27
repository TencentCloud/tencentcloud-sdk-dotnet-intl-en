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
        /// <p>Indicates whether to skip the start verification page when starting verification. If set to true, the verification process starts directly. The default value is false. If a fallback policy is triggered, this configuration does not take effect.</p>
        /// </summary>
        [JsonProperty("AutoSkipStartPage")]
        public bool? AutoSkipStartPage{ get; set; }

        /// <summary>
        /// <p>Indicates whether to skip the result display page and automatically redirect to RedirectURL when verification succeeds. The default value is false.</p>
        /// </summary>
        [JsonProperty("AutoSkip")]
        public bool? AutoSkip{ get; set; }

        /// <summary>
        /// <p>Detection mode. Valid values: <br>1: OCR + liveness detection + face comparison; <br>2: Liveness detection + face comparison; <br>3: Liveness detection; <br>4: OCR. <br>The default value is 2.</p>
        /// </summary>
        [JsonProperty("CheckMode")]
        public long? CheckMode{ get; set; }

        /// <summary>
        /// <p>The type of card used for authentication. Currently supported types: <br>1. HKIDCard: Hong Kong (China) ID card <br>2. MLIDCard: Malaysian ID card <br>3. IndonesiaIDCard: Indonesian ID card <br>4. PhilippinesVoteID: Philippine voter's card <br>5. PhilippinesDrivingLicense: Philippine driving license <br>6. PhilippinesTinID: Philippine TIN ID <br>7. PhilippinesSSSID: Philippine SSS ID <br>8. PhilippinesUMID: Philippine UMID <br>9. InternationalIDPassport: Passports from Hong Kong/Macao/Taiwan (China) and overseas <br>10. ThailandIDCard: Thai ID card <br>11. SingaporeIDCard: Singaporean ID card <br>12. MainlandIDCard: Mainland ID card</p>
        /// </summary>
        [JsonProperty("IDCardType")]
        public string IDCardType{ get; set; }

        /// <summary>
        /// <p>Indicates whether to disable document alerts. The default value is false, which means the alert detection feature is enabled. When enabled, the identity authentication process will be blocked based on document alerts. If you need to use the document authentication feature, please <a href="https://www.tencentcloud.com/zh/contact-us">contact us</a>.</p>
        /// </summary>
        [JsonProperty("DisableCheckOcrWarnings")]
        public bool? DisableCheckOcrWarnings{ get; set; }

        /// <summary>
        /// <p>Security level of authentication: <br>1: Silent liveness; <br>2: Motion liveness; <br>3: Light liveness; <br>4: Motion + light liveness; <br>The default value is 3.</p>
        /// </summary>
        [JsonProperty("SecurityLevel")]
        public long? SecurityLevel{ get; set; }

        /// <summary>
        /// <p>Indicates whether to skip the agreement page. The default value is false. When SkipPrivacyPolicy is false, the agreement page is displayed and the privacy agreement must be selected. When SkipPrivacyPolicy is true, the agreement page is skipped and the liveness process starts directly without selecting the privacy agreement.</p>
        /// </summary>
        [JsonProperty("SkipPrivacyPolicy")]
        public bool? SkipPrivacyPolicy{ get; set; }

        /// <summary>
        /// <p>The default value is false. When set to false, the original document image is displayed. When set to true, the cropped document image is displayed.</p>
        /// </summary>
        [JsonProperty("IdCardCutReturn")]
        public bool? IdCardCutReturn{ get; set; }

        /// <summary>
        /// <p>Frontend theme color, in the format of an RGB hexadecimal color code. The default value is "#2d72f1". If the format is incorrect, the default color is used.</p>
        /// </summary>
        [JsonProperty("ThemeColor")]
        public string ThemeColor{ get; set; }

        /// <summary>
        /// <p>Internationalization language. The default value is en (English). Currently supported languages: <br>th: Thai; <br>en: English; <br>zh-cn: Simplified Chinese; <br>zh-tc: Traditional Chinese; <br>id: Indonesian.</p>
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// <p>Automatic fallback mode. Valid values: <br>1: Fall back to silent liveness mode; <br>2: Disable fallback mode. <br>The default value is 1.</p>
        /// </summary>
        [JsonProperty("AutoDowngrade")]
        public long? AutoDowngrade{ get; set; }

        /// <summary>
        /// <p>Controls the action sequence. The action types are as follows: <br>"blink" <br>"mouth" <br>"nod" <br>"shake" <br>You can select 1 to 2 actions from the four. <br>Single action example: "blink" <br>Multiple actions example: "blink,mouth". <br>The default value is blink. <br>This parameter takes effect only when SecurityLevel is 2, 4, or 5. Otherwise, an error is reported.</p>
        /// </summary>
        [JsonProperty("ActionList")]
        public string ActionList{ get; set; }

        /// <summary>
        /// <p>Maximum number of liveness verification attempts. The valid range is 1–99. The default value is 99.</p>
        /// </summary>
        [JsonProperty("LivenessRetryLimit")]
        public long? LivenessRetryLimit{ get; set; }

        /// <summary>
        /// <p>Controls the liveness detection timeout in seconds. The valid range is (0, 600]. The default value is 45 seconds.</p>
        /// </summary>
        [JsonProperty("LivenessTimeout")]
        public ulong? LivenessTimeout{ get; set; }

        /// <summary>
        /// <p>Selects the OCR alerts to pay attention to. When a selected OCR alert occurs, the identity authentication process is interrupted. The default value is empty, indicating that all alerts are selected. This feature requires the parameter DisableCheckOcrWarnings=false. If alerts are disabled, this parameter does not take effect.</p><p>List of alert codes and their meanings: <br>-9101 Incomplete border alert <br>-9102 Photocopy alert <br>-9103 Recapture alert <br>-9104 Photoshop alert <br>-9107 Reflection alert <br>-9108 Blur alert <br>-9109 Alert not enabled</p>
        /// </summary>
        [JsonProperty("SelectedWarningCodes")]
        public string SelectedWarningCodes{ get; set; }

        /// <summary>
        /// <p>Indicates whether expired identity documents are allowed to enter the liveness detection process. This parameter takes effect only when the document type is Hong Kong (China) identity card (HKID). <br>true (default): Expired Hong Kong (China) identity cards are allowed to enter the liveness detection process. <br>false: Expired Hong Kong (China) identity cards are rejected and cannot enter the liveness detection process.</p>
        /// </summary>
        [JsonProperty("AllowExpiredDocument")]
        public bool? AllowExpiredDocument{ get; set; }

        /// <summary>
        /// <p>Service edition, including the basic edition (BASIC) and the PLUS edition (PLUS).</p><p>Valid values:</p><ul><li>BASIC: Basic edition</li><li>PLUS: PLUS edition</li></ul><p>Default value: BASIC</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>When <code>CheckMode = 1</code>, this parameter defines the waiting policy for the OCR recognition result.</p><p>Valid values:</p><ul><li>required: Wait until the OCR verification result is confirmed before proceeding to liveness detection.</li><li>skip: Proceed to liveness detection directly after the document photo is submitted.</li></ul><p>Default value: required</p>
        /// </summary>
        [JsonProperty("OcrWaitPolicy")]
        public string OcrWaitPolicy{ get; set; }

        /// <summary>
        /// <p>Verification status callback URL. After this URL is configured, the service actively pushes notifications to this URL when the process ends. Leave it empty to disable the callback capability. As callbacks cannot be guaranteed to be 100% reliable, it is recommended to use them together with a polling mechanism to ensure that the final status is obtained.</p>
        /// </summary>
        [JsonProperty("WebhookUrl")]
        public string WebhookUrl{ get; set; }


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
            this.SetParamSimple(map, prefix + "OcrWaitPolicy", this.OcrWaitPolicy);
            this.SetParamSimple(map, prefix + "WebhookUrl", this.WebhookUrl);
        }
    }
}

