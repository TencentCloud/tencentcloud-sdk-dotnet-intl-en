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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateSmartEraseSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// Subtitle erasing method.
        /// **Automatic erasing:** Video subtitles are automatically recognized using an AI model and are erased without traces to generate a new video. However, missed or incorrect erasing may occur due to image interference and special subtitle styles. In this case, you can specify the erasing area.
        /// When using automatic erasing, if AutoAreas is not specified, the default area (lower middle part of the image) will be erased automatically. If AutoAreas is specified, the specified area will be erased automatically.
        /// **Specified area erasing:** If the subtitle position is relatively fixed, you are recommended to specify the erasing area directly to minimize missed erasing.
        /// When you choose specified area erasing, specify at least one area for CustomAreas.
        /// -auto erasing
        /// - custom: specified area erasing.
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// Subtitle erasing model.
        /// **Standard edition (recommended):** For standard subtitle styles, it is usually recommended to select this version for better traceless effects in the details.
        /// **Area edition:** If the subtitles have special styles, such as calligraphy, shadow, or motion effects, you are recommended to select this edition to ensure a larger erasing area. However, the erasing effect in the details is not as good as the standard edition.
        /// - standard: standard edition.
        /// - area: area edition.
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// Whether to enable OCR subtitle extraction. The default value is OFF.
        /// OCR subtitle extraction is supported only when SubtitleEraseMethod is set to auto. Once enabled, it identifies the text region that appears longest and most stably within the automated erasing area as the subtitle area. The text in the subtitle area is extracted and erased.
        /// -ON
        /// -OFF: disabled.
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// Subtitle language, used for guiding OCR recognition, default value zh_en; this parameter is valid only when OcrSwitch is "ON".
        /// - zh_en: Chinese and English
        /// - multi: others
        /// The following are other languages supported for recognition:
        /// Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, Thai, Hindi, Arabic, Indian Bengali, Indian Gujarati, Indian Kannada, Indian Malayalam, Indian Tamil, Indian Telugu, Slovenian, Polish, Catalonia, Bosnia, Czech, Estonian, Croatian, Punjabi, Marathi, Azerbaijan, Indonesian, Luxembourg, Lithuanian, Latvian, Malta, Slovak, Turkish, Kazakh, Greek, Irish, Belarus, Khmer, Tagalog, Pashto, Persian, Tajikistan
        /// 
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// Subtitle file format, default value vtt; this parameter is valid only when OcrSwitch is "ON".
        /// - srt: SRT format
        /// - vtt: WebVTT format.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Whether to enable subtitle translation, default value is OFF. This parameter is valid only when OcrSwitch is "ON".
        /// -ON
        /// -OFF: disabled.
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// Subtitle target language, default value en; this parameter is valid only when TransSwitch is "ON".
        /// Supported languages:
        /// zh: Simplified Chinese
        /// en: English
        /// ja: Japanese
        /// ko: Korean
        /// fr: French
        /// es: Spanish
        /// it: Italian
        /// de: German
        /// tr: Turkish
        /// ru: Russian
        /// pt: Portuguese
        /// vi: Vietnamese
        /// id: Indonesian
        /// ms: Malay
        /// th: Thai
        /// ar: Arabic
        /// hi: Hindi
        /// </summary>
        [JsonProperty("TransDstLang")]
        public string TransDstLang{ get; set; }

        /// <summary>
        /// Custom area for automatic erasing.
        /// For the specified area, AI models are used to automatically detect and erase the target objects.
        /// Note: When the erasing method is set to custom, this parameter is invalid. When a template is modified, input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// Specify the custom region for erasing.
        /// For the specified area, erase the target objects directly without detection and recognition within a selected time period.
        /// Note: When a template is modified, input [] for the erasing area; if this parameter is unspecified, the template area information will remain unchanged.
        /// </summary>
        [JsonProperty("CustomAreas")]
        public EraseTimeArea[] CustomAreas{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubtitleEraseMethod", this.SubtitleEraseMethod);
            this.SetParamSimple(map, prefix + "SubtitleModel", this.SubtitleModel);
            this.SetParamSimple(map, prefix + "OcrSwitch", this.OcrSwitch);
            this.SetParamSimple(map, prefix + "SubtitleLang", this.SubtitleLang);
            this.SetParamSimple(map, prefix + "SubtitleFormat", this.SubtitleFormat);
            this.SetParamSimple(map, prefix + "TransSwitch", this.TransSwitch);
            this.SetParamSimple(map, prefix + "TransDstLang", this.TransDstLang);
            this.SetParamArrayObj(map, prefix + "AutoAreas.", this.AutoAreas);
            this.SetParamArrayObj(map, prefix + "CustomAreas.", this.CustomAreas);
        }
    }
}

