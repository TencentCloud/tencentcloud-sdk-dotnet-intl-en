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

namespace TencentCloud.Vm.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageResultsResultDetail : AbstractModel
    {
        
        /// <summary>
        /// This field is used to return the task name in the `TaskInput` parameter passed in when the video moderation API is called for easier task identification and management.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// This field is used to return the OCR result of an image. OCR can recognize text of **up to 5,000 bytes**.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Text")]
        public string Text{ get; set; }

        /// <summary>
        /// This field is used to return the detailed position information of the image moderation sub-result, such as coordinates, size, and rotation angle. For the detailed returned content, see the description of the `ImageResultsResultDetailLocation` data structure.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Location")]
        public ImageResultsResultDetailLocation Location{ get; set; }

        /// <summary>
        /// This field is used to return the maliciousness tag in the detection result.<br>Returned values: **Normal**: normal; **Porn**: pornographic; **Abuse**: abusive; **Ad**: advertising; **Custom**: custom type of non-compliant content and other offensive, unsafe, or inappropriate types of content.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// This field is **valid only when `Label` is `Custom` (custom keyword)**. It is used to return the ID of the custom library for easier custom library management and configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LibId")]
        public string LibId{ get; set; }

        /// <summary>
        /// This field is **valid only when `Label` is `Custom` (custom keyword)**. It is used to return the name of the custom library for easier custom library management and configuration.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LibName")]
        public string LibName{ get; set; }

        /// <summary>
        /// This field is used to return the keyword information hit by the detected text and indicate the specific cause of text non-compliance (such as *Friend me*). This parameter may have multiple returned values representing multiple hit keywords. If the returned value is empty, but `Score` is not empty, the maliciousness tag (Label) that corresponds to the recognition result derives from the returned value determined by the semantic model.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// This field is used to return the operation suggestion. When you get the determination result, the returned value indicates the suggested operation.<br>
        /// Returned values: **Block**, **Review**, **Pass**.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// This field is used to return the confidence under the current tag. Value range: 0 (**the lowest confidence**)–100 (**the highest confidence**), where a higher value indicates that the text is more likely to fall into the category of the current returned tag; for example, *Porn 99* indicates that the text is highly likely to be pornographic.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// This field is used to return the detection result for a subtag under the maliciousness tag, such as *Porn-SexBehavior*.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubLabelCode")]
        public string SubLabelCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Text", this.Text);
            this.SetParamObj(map, prefix + "Location.", this.Location);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "LibId", this.LibId);
            this.SetParamSimple(map, prefix + "LibName", this.LibName);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "SubLabelCode", this.SubLabelCode);
        }
    }
}

