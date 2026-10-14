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
        /// <p>Subtitle erasure method.<br><strong>Automatic erasing:</strong> Video subtitles are automatically recognized using an AI model and are erased without traces to generate a new video. However, missed or incorrect erasing may occur due to image interference and special subtitle styles. In this case, you can specify the erasing area.<br>When using automatic erasing, if you do not specify AutoAreas, the default region (lower middle part of the frame) will be erased automatically. If AutoAreas is specified, the designated region will be erased instead.<br><strong>Specified area erasure:</strong> If your subtitle position is fixed, it is recommended to directly specify the erasure area to minimize missed erasures.<br>When choosing specified area erasure, please input at least one designated region in CustomAreas.</p><ul><li>auto: Automatic erasing</li><li>custom: Specified area erasure</li></ul>
        /// </summary>
        [JsonProperty("SubtitleEraseMethod")]
        public string SubtitleEraseMethod{ get; set; }

        /// <summary>
        /// <p>Subtitle erasure model.<br><strong>Standard version (recommended):</strong> If your subtitles have a standard style, it is usually recommended to select this version for better effectiveness in seamless detail removal.<br><strong>Area edition:</strong> If the subtitles have special styles, such as calligraphy, shadow, or motion effects, you are recommended to select this edition to ensure a larger erasing area. However, the erasing effect in the details is not as good as the standard edition.</p><ul><li>standard Standard model</li><li>area Regional model</li></ul>
        /// </summary>
        [JsonProperty("SubtitleModel")]
        public string SubtitleModel{ get; set; }

        /// <summary>
        /// <p>Whether OCR subtitle extraction is enabled. The default value is OFF.<br>OCR subtitle extraction is supported if and only if SubtitleEraseMethod is set to auto. When enabled, it identifies the text region that appears most persistently and stably within the automatic erasing area as the subtitle area. The text within the subtitle area is extracted and erased.</p><ul><li>ON Enable</li><li>OFF Disable</li></ul>
        /// </summary>
        [JsonProperty("OcrSwitch")]
        public string OcrSwitch{ get; set; }

        /// <summary>
        /// <p>Subtitle language, used to guide OCR recognition, default value is zh_en. This parameter is valid only when OcrSwitch is "ON".</p><ul><li>zh_en Chinese and English</li><li>multi other<br>The following languages are supported for recognition:<br>Chinese, English, Japanese, Korean, Spanish, French, German, Portuguese, Vietnamese, Malay, Russian, Italian, Dutch, Swedish, Finnish, Danish, Norwegian, Hungarian, Thai, Hindi, Arabic, Bengali, Gujarati, Kannada, Malayalam, Tamil, Telugu, Slovenian, Polish, Catalan, Bosnia, Czech, Estonian, Croatian, Punjabi, Marathi, Azerbaijan, Indonesian, Luxembourg, Lithuanian, Latvian, Malta, Slovak, Turkish, Kazakh, Greek, Irish, Belarus, Khmer, Tagalog, Pashto, Persian, Tajikistan</li></ul>
        /// </summary>
        [JsonProperty("SubtitleLang")]
        public string SubtitleLang{ get; set; }

        /// <summary>
        /// <p>Subtitle file format. Default value is vtt. This parameter is valid only when OcrSwitch takes value "ON".</p><ul><li>srt srt format</li><li>vtt WebVTT format</li><li>When SubtitleEmbedId is filled, it can take value empty string, which means no subtitle file is output.</li></ul>
        /// </summary>
        [JsonProperty("SubtitleFormat")]
        public string SubtitleFormat{ get; set; }

        /// <summary>
        /// <p>Whether to enable subtitle translation. The default value is OFF. This parameter is valid only when OcrSwitch is set to "ON".</p><ul><li>ON: Enable</li><li>OFF: Disable</li></ul>
        /// </summary>
        [JsonProperty("TransSwitch")]
        public string TransSwitch{ get; set; }

        /// <summary>
        /// <p>The target language for subtitle translation defaults to en. This parameter is valid only when TransSwitch is set to "ON".<br>The following languages are currently supported:<br>zh: Simplified Chinese<br>en: English<br>ja: Japanese<br>ko: Korean<br>fr: French<br>es: Spanish<br>it: Italian<br>de: German<br>tr: Turkish<br>ru: Russian<br>pt: Portuguese<br>vi: Vietnamese<br>id: Indonesian<br>ms: Malay<br>th: Thai<br>ar: Arabic<br>hi: Hindi</p>
        /// </summary>
        [JsonProperty("TransDstLang")]
        public string TransDstLang{ get; set; }

        /// <summary>
        /// <p>Automatically erase custom regions.<br>For selected regions, use the AI model to automatically detect and erase existing targets.<br>Note: When the erase method is set to custom, this parameter will not take effect. To modify the template, input [] for region cleanup. If not provided, the template region information remains unchanged.</p>
        /// </summary>
        [JsonProperty("AutoAreas")]
        public EraseArea[] AutoAreas{ get; set; }

        /// <summary>
        /// <p>Designate the removal of custom regions.<br>For specified regions, directly perform erasure without detection and recognition within a selected time range.<br>Note: When modifying the template, import [] to clear regions. The template region information remains unchanged if not imported.</p>
        /// </summary>
        [JsonProperty("CustomAreas")]
        public EraseTimeArea[] CustomAreas{ get; set; }

        /// <summary>
        /// <p>Subtitle suppression template id. Only allowed to fill in when OCR translation is enabled.</p>
        /// </summary>
        [JsonProperty("SubtitleEmbedId")]
        public ulong? SubtitleEmbedId{ get; set; }

        /// <summary>
        /// <p>Suppression configuration, enabled by default, compresses subtitles back to their original position. It can be filled only when OCR translation is turned on. A value of 0 indicates disabled suppression.</p>
        /// </summary>
        [JsonProperty("UseOriginalPos")]
        public long? UseOriginalPos{ get; set; }

        /// <summary>
        /// <p>Suppression configuration, enabled by default. After being turned on, the original subtitle font size is used. It can only be filled when OCR translation is enabled. Setting it to 0 means non-use of the original font size.</p>
        /// </summary>
        [JsonProperty("UseOriginalSize")]
        public long? UseOriginalSize{ get; set; }


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
            this.SetParamSimple(map, prefix + "SubtitleEmbedId", this.SubtitleEmbedId);
            this.SetParamSimple(map, prefix + "UseOriginalPos", this.UseOriginalPos);
            this.SetParamSimple(map, prefix + "UseOriginalSize", this.UseOriginalSize);
        }
    }
}

