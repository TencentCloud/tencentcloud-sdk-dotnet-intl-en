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

    public class SmartEraseSubtitleConfig : AbstractModel
    {
        
        /// <summary>
        /// Specifies the subtitle erasure method.
        /// **Automatic erasing:** automatically identifies subtitle text content in videos through AI models and performs seamless erasure to generate new videos. frame interference and unique subtitle styles may cause certain missed or incorrect erasures, which can be handled through specified area erasure.
        /// When using automatic erasure, if AutoAreas is not specified, the default region (lower middle of the frame) will be erased automatically. if AutoAreas is specified, it will change to erase the designated area.
        /// **Specified area erasing:** if your subtitle position is fixed, directly specify the erasure area to decrease the chance of removal omission to the maximum extent.
        /// When your choice is specified area erasure, please import at least one designated region in CustomAreas.
        /// -Automated removal.
        /// - specifies the custom specified area erasure.
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// Subtitle erasure model.
        /// **Standard version (recommend):** if your subtitle style is standard, normally recommend choose this version for better effectiveness with seamless detail.
        /// **Regional version:** if your subtitles have special styles such as italics, shadows, or motion effects, we recommend choosing the regional version for larger removal area, though the detail effect is not as good as the standard version.
        /// -Specifies the standard model.
        /// -area. specifies the regional model.
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// Whether OCR subtitle extraction is enabled. default value: OFF.
        /// Supports enabling OCR subtitle extraction only when SubtitleEraseMethod is set to auto. when enabled, it identifies the longest and most stable text area within the region as the subtitle area, then performs text extraction and removal.
        /// -ON: enable.
        /// -OFF. specifies the disabled state.
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// Subtitle language, for OCR guidance, default value zh_en. this parameter is valid only when OcrSwitch is ON.
        /// -Chinese and english.
        /// -multi other.
        /// Other supported languages:.
        /// Chinese, english, japanese, korean, spanish, french, german, portuguese, vietnamese, malay, russian, italian, dutch, swedish, finnish, danish, norwegian, hungarian, thai, hindi, arabic, indian-bengali, indian-gujarati, indian-kannada, indian-malayalam, indian-tamil, indian-telugu, slovenian, polish, catalan, bosnian, czech, estonian, croatian, punjabi, marathi, azerbaijani, indonesian, luxembourgish, lithuanian, latvian, maltese, slovak, turkish, kazakh, greek, irish, belarusian, khmer, tagalog, pashto, persian, tajik.
        /// 
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// Specifies the subtitle file format. default value: vtt. this parameter is valid only when OcrSwitch is set to ON.
        /// -srt format.
        /// -vtt: WebVTT format.
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// Specifies whether to enable subtitle translation. default value: OFF. this parameter is valid only when OcrSwitch is set to ON.
        /// -ON: enable.
        /// -OFF. specifies the disabled state.
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// Subtitle target language. default value: en. this parameter is valid only when TransSwitch is set to ON.
        /// Supported languages:.
        /// Simplified chinese.
        /// Specifies the language. valid values: en (english).
        /// Ja: japanese.
        /// Ko: korean.
        /// Fr: french.
        /// es: spanish.
        /// It: italian.
        /// de: german.
        /// tr: turkish.
        /// Ru: russian.
        /// pt: portuguese.
        /// Vi: vietnamese.
        /// id: indonesian.
        /// ms: malay.
        /// Th: thai.
        /// Ar: arabic.
        /// hi: Hindi
        /// </summary>
        [JsonProperty("TransDstLang")]
        public string TransDstLang{ get; set; }

        /// <summary>
        /// Specifies automatic removal of a custom region.
        /// Specifies the use of an AI model to automatically detect and erase existing targets in the specified region.
        /// Note that this parameter will not take effect when the removal method is custom. for template modification, input [] to clean up the region. the template region information remains unchanged if not imported.
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// Specifies erasure of a custom region.
        /// Detects and directly performs removal within a specified time range for the selected region.
        /// Note: when modifying the template, pass [] to clear the region. the template region information remains unchanged if not passed.
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

