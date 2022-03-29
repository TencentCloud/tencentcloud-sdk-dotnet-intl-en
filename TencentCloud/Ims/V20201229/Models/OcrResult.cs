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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OcrResult : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the recognition scenario. Default value: OCR (image OCR).
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// This field is used to return the operation suggestion for the maliciousness tag with the highest priority. When you get the determination result, the returned value indicates the operation suggested by the system. We recommend you handle different types of violations and suggestions according to your business needs. <br>Returned values: **Block**, **Review**, **Pass**.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// This field is used to return the maliciousness tag with the highest priority in the OCR detection result, which represents the moderation result suggested by the model. We recommend you handle different types of violations and suggestions according to your business needs. <br>Returned values: **Normal**: normal; **Porn**: pornographic; **Abuse**: abusive; **Ad**: advertising; **Custom**: custom type of non-compliant content and other offensive, unsafe, or inappropriate types of content.
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// This field is used to return the detection result for a subtag under the current tag (Label), such as *Porn-SexBehavior*.
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// This field is used to return the confidence under the current tag (Label). Value range: 0 (**the lowest confidence**)–100 (**the highest confidence**), where a higher value indicates that the text is more likely to fall into the category of the current returned tag; for example, *Porn 99* indicates that the text is highly likely to be pornographic, while *Porn 0* indicates that the text is not pornographic.
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// This field is used to return the details of the OCR recognition result, such as text content, tag, and recognition frame position.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Details")]
        public OcrTextDetail[] Details{ get; set; }

        /// <summary>
        /// This field is used to return the text information recognized by OCR.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamSimple(map, prefix + "Text", this.Text);
        }
    }
}

