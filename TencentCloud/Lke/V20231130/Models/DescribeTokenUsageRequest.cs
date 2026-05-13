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

    public class DescribeTokenUsageRequest : AbstractModel
    {
        
        /// <summary>
        /// Root account of Tencent Cloud.
        /// </summary>
        [JsonProperty("UinAccount")]
        public string[] UinAccount{ get; set; }

        /// <summary>
        /// Log in to user's root account (required in the integrator mode).
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// Login to user's sub-account (required in integrator mode).
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// Sub-business types of Tencent Cloud Agent Development Platform/ADP: FileParse (document parsing), embedding, Rewrite (multi-round rewriting), Concurrency, KnowledgeSummary (knowledge summary), KnowledgeQA (knowledge Q&A), KnowledgeCapacity (knowledge base capacity), SearchEngine (search engine).
        /// </summary>
        [JsonProperty("SubBizType")]
        public string SubBizType{ get; set; }

        /// <summary>
        /// Model identifier.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Start timestamp, in seconds (default value: 0).
        /// </summary>
        [JsonProperty("StartTime")]
        [System.Obsolete]
        public string StartTime{ get; set; }

        /// <summary>
        /// End timestamp, in seconds (default value: 0, must be greater than the start timestamp).
        /// </summary>
        [JsonProperty("EndTime")]
        [System.Obsolete]
        public string EndTime{ get; set; }

        /// <summary>
        /// Application ID list.
        /// </summary>
        [JsonProperty("AppBizIds")]
        public string[] AppBizIds{ get; set; }

        /// <summary>
        /// Filter sub-scenario (used in document parsing scenario).
        /// </summary>
        [JsonProperty("SubScenes")]
        public string[] SubScenes{ get; set; }

        /// <summary>
        /// Application Type (knowledge_qa: Knowledge Q&A Application Management, shared_knowledge: Shared Knowledge Base)
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// Space ID, used to limit the query scope. If left blank, data of all spaces will be returned.
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// Start time. Unix timestamp in seconds, empty by default.
        /// </summary>
        [JsonProperty("StatStartTime")]
        public long? StatStartTime{ get; set; }

        /// <summary>
        /// End time. Unix timestamp in seconds, empty by default.
        /// </summary>
        [JsonProperty("StatEndTime")]
        public long? StatEndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "UinAccount.", this.UinAccount);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamSimple(map, prefix + "SubBizType", this.SubBizType);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "AppBizIds.", this.AppBizIds);
            this.SetParamArraySimple(map, prefix + "SubScenes.", this.SubScenes);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "StatStartTime", this.StatStartTime);
            this.SetParamSimple(map, prefix + "StatEndTime", this.StatEndTime);
        }
    }
}

