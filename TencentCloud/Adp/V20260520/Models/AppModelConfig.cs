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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppModelConfig : AbstractModel
    {
        
        /// <summary>
        /// AI one-click optimization model
        /// </summary>
        [JsonProperty("AiOptimizeModel")]
        public AIOptimizeModel AiOptimizeModel{ get; set; }

        /// <summary>
        /// Real-time file parsing model
        /// </summary>
        [JsonProperty("FileParseModel")]
        public FileParseModel FileParseModel{ get; set; }

        /// <summary>
        /// Generate model configuration
        /// </summary>
        [JsonProperty("GenerateModel")]
        public GenerateModel GenerateModel{ get; set; }

        /// <summary>
        /// Multimodal QA model
        /// </summary>
        [JsonProperty("MultiModalQaModel")]
        public MultiModalQAModel MultiModalQaModel{ get; set; }

        /// <summary>
        /// Multimodal understanding model
        /// </summary>
        [JsonProperty("MultiModalUnderstandingModel")]
        public MultiModalUnderstandingModel MultiModalUnderstandingModel{ get; set; }

        /// <summary>
        /// Prompt rewrite model
        /// </summary>
        [JsonProperty("PromptRewriteModel")]
        public PromptRewriteModel PromptRewriteModel{ get; set; }

        /// <summary>
        /// Thinking model configuration
        /// </summary>
        [JsonProperty("ThinkModel")]
        public ThinkModel ThinkModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AiOptimizeModel.", this.AiOptimizeModel);
            this.SetParamObj(map, prefix + "FileParseModel.", this.FileParseModel);
            this.SetParamObj(map, prefix + "GenerateModel.", this.GenerateModel);
            this.SetParamObj(map, prefix + "MultiModalQaModel.", this.MultiModalQaModel);
            this.SetParamObj(map, prefix + "MultiModalUnderstandingModel.", this.MultiModalUnderstandingModel);
            this.SetParamObj(map, prefix + "PromptRewriteModel.", this.PromptRewriteModel);
            this.SetParamObj(map, prefix + "ThinkModel.", this.ThinkModel);
        }
    }
}

