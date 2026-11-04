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

    public class AppConfig : AbstractModel
    {
        
        /// <summary>
        /// Trial configuration
        /// </summary>
        [JsonProperty("Experience")]
        public AppExperienceConfig Experience{ get; set; }

        /// <summary>
        /// Welcome message configuration
        /// </summary>
        [JsonProperty("Greeting")]
        public AppGreetingConfig Greeting{ get; set; }

        /// <summary>
        /// Memory configuration
        /// </summary>
        [JsonProperty("Memory")]
        public AppMemoryConfig Memory{ get; set; }

        /// <summary>
        /// Mode-related configuration
        /// </summary>
        [JsonProperty("Mode")]
        public AppModeConfig Mode{ get; set; }

        /// <summary>
        /// Model configuration
        /// </summary>
        [JsonProperty("Model")]
        public AppModelConfig Model{ get; set; }

        /// <summary>
        /// Online search configuration
        /// </summary>
        [JsonProperty("WebSearch")]
        public AppWebSearchConfig WebSearch{ get; set; }

        /// <summary>
        /// Workflow configuration
        /// </summary>
        [JsonProperty("Workflow")]
        public AppWorkflowConfig Workflow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Experience.", this.Experience);
            this.SetParamObj(map, prefix + "Greeting.", this.Greeting);
            this.SetParamObj(map, prefix + "Memory.", this.Memory);
            this.SetParamObj(map, prefix + "Mode.", this.Mode);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamObj(map, prefix + "WebSearch.", this.WebSearch);
            this.SetParamObj(map, prefix + "Workflow.", this.Workflow);
        }
    }
}

