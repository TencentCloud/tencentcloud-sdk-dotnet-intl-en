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
        /// When automatic erasing is used, if AutoAreas is not specified, the default area (lower middle part of the image) will be erased automatically. If AutoAreas is specified, the specified area will be erased automatically.
        /// **Specified area erasing:** If the subtitle position is relatively fixed, you are recommended to specify the erasing area directly to minimize missed erasing.
        /// When you choose specified area erasing, specify at least one area for CustomAreas.
        /// - auto: automatic erasing.
        /// - custom: specified area erasing.
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// Subtitle erasing model.
        /// **Standard edition (recommended):** For standard subtitle styles, you are recommended to select this edition to ensure better traceless effects in the details.
        /// **Area edition:** If the subtitles have special styles, such as calligraphy, shadow, or motion effects, you are recommended to select this edition to ensure a larger erasing area. However, the erasing effect in the details is not as good as the standard edition.
        /// - standard: standard edition.
        /// - area: area edition.
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// Whether to enable OCR subtitle extraction. The default value is OFF.
        /// OCR subtitle extraction is supported if and only if SubtitleEraseMethod is set to auto. When OCR subtitle extraction is enabled, it identifies the text region that appears most persistently and stably within the automatic erasing area as the subtitle area. The text within the subtitle area is extracted and erased.
        /// - ON: enabled.
        /// -OFF: disabled.
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// Subtitle language, which is used to guide OCR recognition. The default value is zh_en. This parameter is valid only when OcrSwitch is set to ON.
        /// - zh_en: Chinese and English.
        /// - multi: others.
        /// The following are other languages supported for recognition:
        /// Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, Thai, Hindi, Arabic, India-Bengali, India-Gujarati, India-Kannada, India-Malayalam, India-Tamil, India-Telugu, Slovenian, Polish, Catalan, Bosnian, Czech, Estonian, Croatian, Punjabi, Marathi, Azerbaijani, Indonesian, Luxembourgish, Lithuanian, Latvian, Maltese, Slovak, Turkish, Kazakh, Greek, Irish, Belarusian, Khmer, Tagalog, Pashto, Persian, and Tajik.
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// Subtitle file format. The default value is vtt. This parameter is valid only when OcrSwitch is set to ON.
        /// - srt: SRT format.
        /// - vtt: WebVTT format.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Whether to enable subtitle translation. The default value is OFF. This parameter is valid only when OcrSwitch is set to ON.
        /// - ON: enabled.
        /// - OFF: disabled.
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// Target language for Subtitle translation. The default value is en. This parameter is valid only when TransSwitch is set to ON.
        /// Currently, the following languages are supported:
        /// zh: Simplified Chinese.
        /// en: English.
        /// ja: Japanese.
        /// ko: Korean.
        /// fr: French.
        /// es: Spanish.
        /// it: Italian.
        /// de: German.
        /// tr: Turkish.
        /// ru: Russian.
        /// pt: Portuguese.
        /// vi: Vietnamese.
        /// id: Indonesian.
        /// ms: Malay.
        /// th: Thai.
        /// ar: Arabic.
        /// hi: Hindi.
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
        /// Custom area for specified area erasing.
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

