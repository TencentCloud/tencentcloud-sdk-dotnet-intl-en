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

    public class ApplyOcrTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// Country code. ISO 3166-1 Alpha-3 country/region code standard.
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// Supported countries/regions and document types:
        /// 
        /// Mainland China: ID_CARD, PERMIT
        /// Hong Kong: ID_CARD
        /// Macao: ID_CARD
        /// Hong Kong/Macao/Taiwan: MAINLAND_PERMIT, HMT_RESIDENT_PERMIT
        /// Thailand: ID_CARD, THA_PINK_CARD
        /// Indonesia: ID_CARD
        /// Malaysia: ID_CARD
        /// Singapore: ID_CARD
        /// Philippines: PHL_UMID, PHL_VOTE_ID, PHL_TIN_ID, PHL_SSS_ID, DRIVING_LICENSE
        /// Any country/region: PASSPORT
        /// </summary>
        [JsonProperty("CardType")]
        public string CardType{ get; set; }

        /// <summary>
        /// SDK-generated device-related encryption configuration information.
        /// </summary>
        [JsonProperty("EncryptedConfig")]
        public string EncryptedConfig{ get; set; }

        /// <summary>
        /// <p>Whether to extract the portrait image from the document. false by default</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("ReturnHeadImage")]
        public bool? ReturnHeadImage{ get; set; }

        /// <summary>
        /// <p>Maximum number of token retries</p><p>Value range: [1, 5]</p><p>Default value: 3</p>
        /// </summary>
        [JsonProperty("RetryLimit")]
        public long? RetryLimit{ get; set; }

        /// <summary>
        /// <p>SDK capture mode</p><p>Enumeration values:</p><ul><li>OCR_DETECT_MANUAL: Photo recognition mode. The system performs recognition after you tap to take a photo.</li><li>OCR_DETECT_AUTO_MANUAL: Automatic recognition mode. The system recognizes automatically, and you can switch to photo recognition after a recognition timeout.</li><li>OCR_DETECT_AUTO: Pure automatic recognition mode. The system recognizes automatically, and you cannot switch to photo recognition after a recognition timeout.</li><li>OCR_DETECT_AUTO_MULTI: Pure automatic recognition mode (multiple images). The system turns on the flash and automatically collects multiple document photos.</li></ul><p>Default value: OCR_DETECT_AUTO_MANUAL</p>
        /// </summary>
        [JsonProperty("OcrModeType")]
        public string OcrModeType{ get; set; }

        /// <summary>
        /// <p>Whether to allow uploading gallery images for recognition.</p><p>Default value: true</p>
        /// </summary>
        [JsonProperty("AllowUploadPhoto")]
        public bool? AllowUploadPhoto{ get; set; }

        /// <summary>
        /// <p>Whether to enable ID card photo cropping (remove extra edges outside the document and automatically correct the shooting angle). It is false by default and only applicable to Mainland ID cards.</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("CropIdCard")]
        public bool? CropIdCard{ get; set; }

        /// <summary>
        /// <p>SDK-supported recognition version mode</p><p>Enumeration values:</p><ul><li>BASIC: Basic version</li><li>ENHANCED: Enhanced version</li></ul><p>Default value: BASIC</p>
        /// </summary>
        [JsonProperty("SdkVersion")]
        public string SdkVersion{ get; set; }

        /// <summary>
        /// OCR automatic capture mode timeout (ms).
        /// Value range: [5000, 180000].
        /// Default value: 20000.
        /// If the value is below 5000, it is set to 5000; if above 180000, it is set to 180000.
        /// </summary>
        [JsonProperty("OcrAutoDetectTimeout")]
        public long? OcrAutoDetectTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "CardType", this.CardType);
            this.SetParamSimple(map, prefix + "EncryptedConfig", this.EncryptedConfig);
            this.SetParamSimple(map, prefix + "ReturnHeadImage", this.ReturnHeadImage);
            this.SetParamSimple(map, prefix + "RetryLimit", this.RetryLimit);
            this.SetParamSimple(map, prefix + "OcrModeType", this.OcrModeType);
            this.SetParamSimple(map, prefix + "AllowUploadPhoto", this.AllowUploadPhoto);
            this.SetParamSimple(map, prefix + "CropIdCard", this.CropIdCard);
            this.SetParamSimple(map, prefix + "SdkVersion", this.SdkVersion);
            this.SetParamSimple(map, prefix + "OcrAutoDetectTimeout", this.OcrAutoDetectTimeout);
        }
    }
}

