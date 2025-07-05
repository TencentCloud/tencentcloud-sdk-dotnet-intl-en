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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelInfo : AbstractModel
    {
        
        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Model description.
        /// </summary>
        [JsonProperty("ModelDesc")]
        public string ModelDesc{ get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Resource status, 1: available; 2: exhausted.
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public ulong? ResourceStatus{ get; set; }

        /// <summary>
        /// Character limit of prompt content.
        /// </summary>
        [JsonProperty("PromptWordsLimit")]
        public string PromptWordsLimit{ get; set; }

        /// <summary>
        /// By controlling the diversity of content generation through core sampling, a higher Top P value will lead to more diverse content generation.
        /// </summary>
        [JsonProperty("TopP")]
        public ModelParameter TopP{ get; set; }

        /// <summary>
        /// Temperature control randomness.
        /// </summary>
        [JsonProperty("Temperature")]
        public ModelParameter Temperature{ get; set; }

        /// <summary>
        /// Maximum quantity of tokens that can be generated.
        /// </summary>
        [JsonProperty("MaxTokens")]
        public ModelParameter MaxTokens{ get; set; }

        /// <summary>
        /// Model source, Hunyuan: Tencent Hunyuan; Industry: Tencent Cloud industry large model; Experience: new model experience.
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// Model icon.
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }

        /// <summary>
        /// Whether it is free.
        /// </summary>
        [JsonProperty("IsFree")]
        public bool? IsFree{ get; set; }

        /// <summary>
        /// Maximum characters input in the model dialog box.
        /// </summary>
        [JsonProperty("InputLenLimit")]
        public ulong? InputLenLimit{ get; set; }

        /// <summary>
        /// Workflow support levels:
        /// 0 - Not supported by the model;
        /// 1 - Supported by the model;
        /// 2 - Poorly supported by the model.
        /// </summary>
        [JsonProperty("SupportWorkflowStatus")]
        public ulong? SupportWorkflowStatus{ get; set; }

        /// <summary>
        /// Model categories:
        /// Generate: Generative model
        /// Thought: Thinking model
        /// </summary>
        [JsonProperty("ModelCategory")]
        public string ModelCategory{ get; set; }

        /// <summary>
        /// Whether it is the default model.
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// Maximum characters of role prompt words.
        /// </summary>
        [JsonProperty("RoleLenLimit")]
        public ulong? RoleLenLimit{ get; set; }

        /// <summary>
        /// Whether it is an exclusive concurrency model.
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// The model supports intelligent call effects.
        /// </summary>
        [JsonProperty("SupportAiCallStatus")]
        public ulong? SupportAiCallStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelDesc", this.ModelDesc);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "PromptWordsLimit", this.PromptWordsLimit);
            this.SetParamObj(map, prefix + "TopP.", this.TopP);
            this.SetParamObj(map, prefix + "Temperature.", this.Temperature);
            this.SetParamObj(map, prefix + "MaxTokens.", this.MaxTokens);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
            this.SetParamSimple(map, prefix + "IsFree", this.IsFree);
            this.SetParamSimple(map, prefix + "InputLenLimit", this.InputLenLimit);
            this.SetParamSimple(map, prefix + "SupportWorkflowStatus", this.SupportWorkflowStatus);
            this.SetParamSimple(map, prefix + "ModelCategory", this.ModelCategory);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "RoleLenLimit", this.RoleLenLimit);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "SupportAiCallStatus", this.SupportAiCallStatus);
        }
    }
}

