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

    public class LibResult : AbstractModel
    {
        
        /// <summary>
        /// This field indicates the scenario recognition result of the model. Default value: Similar.
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// This field is used to return the operation suggestion. When you get the determination result, the returned value indicates the operation suggested by the system. We recommend you handle different types of violations and suggestions according to your business needs. <br>Returned values: **Block**, **Review**, **Pass**.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// This field is used to return the maliciousness tag in the detection result.<br>Returned values: **Normal**: normal; **Porn**: pornographic; **Abuse**: abusive; **Ad**: advertising; **Custom**: custom type of non-compliant content and other offensive, unsafe, or inappropriate types of content.
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// This field is used to return the detection result for a subtag under the maliciousness tag, such as *Porn-SexBehavior*.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// This field is used to return the recognition score of the image search model. Value range: **0–100**. It indicates the score for the similarity between the moderated image **and the samples in the library**. A higher score indicates that the content is more likely to hit a sample in the library of similar images.
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// This field is used to return the detailed result of the comparison with the blocklist/allowlist, such as number, library name, and maliciousness tag. For more information on the returned value, see the description of the [LibDetail](https://intl.cloud.tencent.com/document/product/1125/53274?from_cn_redirect=1#LibDetail) data structure.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Details")]
        public LibDetail[] Details{ get; set; }


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
        }
    }
}

