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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaConfig : AbstractModel
    {
        
        /// <summary>
        /// Welcome words, within 200 characters.
        /// </summary>
        [JsonProperty("Greeting")]
        public string Greeting{ get; set; }

        /// <summary>
        /// Character description, within 4,000 characters. By filling out the description, set the #Character Name, #Style Characteristics, and reachable #Intent of the application. It is recommended to fill in according to the following template, with custom intents no more than 5. 
        /// #Character Name:
        /// #Style Characteristics:
        /// #Output Requirements:
        /// #Ability Limitations:
        /// The following user intents can be reached.
        /// ##Intent Name:
        /// ##Intent Description:
        /// ##Intent Example:
        /// ##Intent Implementation:
        /// </summary>
        [JsonProperty("RoleDescription")]
        public string RoleDescription{ get; set; }

        /// <summary>
        /// Generative model configuration.
        /// </summary>
        [JsonProperty("Model")]
        public AppModel Model{ get; set; }

        /// <summary>
        /// Knowledge search configuration.
        /// </summary>
        [JsonProperty("Search")]
        public KnowledgeQaSearch[] Search{ get; set; }

        /// <summary>
        /// Knowledge management output configuration.
        /// </summary>
        [JsonProperty("Output")]
        public KnowledgeQaOutput Output{ get; set; }

        /// <summary>
        /// Workflow configuration.
        /// </summary>
        [JsonProperty("Workflow")]
        public KnowledgeWorkflow Workflow{ get; set; }

        /// <summary>
        /// Retrieval range.
        /// </summary>
        [JsonProperty("SearchRange")]
        public SearchRange SearchRange{ get; set; }

        /// <summary>
        /// Application modes: standard, agent, single_workflow.
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// Retrieve a policy.
        /// </summary>
        [JsonProperty("SearchStrategy")]
        public SearchStrategy SearchStrategy{ get; set; }

        /// <summary>
        /// Single workflow ID, which is entered when Pattern is single_workflow.
        /// </summary>
        [JsonProperty("SingleWorkflow")]
        public KnowledgeQaSingleWorkflow SingleWorkflow{ get; set; }

        /// <summary>
        /// Application associated plug-in.
        /// </summary>
        [JsonProperty("Plugins")]
        public KnowledgeQaPlugin[] Plugins{ get; set; }

        /// <summary>
        /// Thinking model configuration.
        /// </summary>
        [JsonProperty("ThoughtModel")]
        public AppModel ThoughtModel{ get; set; }

        /// <summary>
        /// Priority of intent achievement methods.
        /// </summary>
        [JsonProperty("IntentAchievements")]
        public IntentAchievement[] IntentAchievements{ get; set; }

        /// <summary>
        /// Whether to enable Image-Text Search.
        /// </summary>
        [JsonProperty("ImageTextRetrieval")]
        public bool? ImageTextRetrieval{ get; set; }

        /// <summary>
        /// Configure voice call parameters.
        /// </summary>
        [JsonProperty("AiCall")]
        public AICallConfig AiCall{ get; set; }

        /// <summary>
        /// Session content moderation switch. Note: 1. This feature is enabled by default if no value is input. 2. Tencent Cloud provides a content pre-filtering feature to help filter high-risk or illegal content. If you do not use our filtering feature, you can disable it here. We hereby remind you that you are responsible for ensuring that your content complies with platform policies and laws and regulations, and that you should fulfill your content moderation obligations.
        /// </summary>
        [JsonProperty("EnableAudit")]
        public bool? EnableAudit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Greeting", this.Greeting);
            this.SetParamSimple(map, prefix + "RoleDescription", this.RoleDescription);
            this.SetParamObj(map, prefix + "Model.", this.Model);
            this.SetParamArrayObj(map, prefix + "Search.", this.Search);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "Workflow.", this.Workflow);
            this.SetParamObj(map, prefix + "SearchRange.", this.SearchRange);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamObj(map, prefix + "SearchStrategy.", this.SearchStrategy);
            this.SetParamObj(map, prefix + "SingleWorkflow.", this.SingleWorkflow);
            this.SetParamArrayObj(map, prefix + "Plugins.", this.Plugins);
            this.SetParamObj(map, prefix + "ThoughtModel.", this.ThoughtModel);
            this.SetParamArrayObj(map, prefix + "IntentAchievements.", this.IntentAchievements);
            this.SetParamSimple(map, prefix + "ImageTextRetrieval", this.ImageTextRetrieval);
            this.SetParamObj(map, prefix + "AiCall.", this.AiCall);
            this.SetParamSimple(map, prefix + "EnableAudit", this.EnableAudit);
        }
    }
}

