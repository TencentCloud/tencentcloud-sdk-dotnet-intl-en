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

    public class AppInfo : AbstractModel
    {
        
        /// <summary>
        /// Application type; knowledge_qa - knowledge Q&A management; summary - knowledge summary; classifys - knowledge label extraction.
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// Application type description.
        /// </summary>
        [JsonProperty("AppTypeDesc")]
        public string AppTypeDesc{ get; set; }

        /// <summary>
        /// Application ID.
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Application avatar.
        /// </summary>
        [JsonProperty("Avatar")]
        public string Avatar{ get; set; }

        /// <summary>
        /// Application description.
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// Application status. 1: offline; 2: running; 3: disabled.
        /// </summary>
        [JsonProperty("AppStatus")]
        public ulong? AppStatus{ get; set; }

        /// <summary>
        /// Status description.
        /// </summary>
        [JsonProperty("AppStatusDesc")]
        public string AppStatusDesc{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Last modifier.
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Alias of the generative model.
        /// </summary>
        [JsonProperty("ModelAliasName")]
        public string ModelAliasName{ get; set; }

        /// <summary>
        /// Application mode: standard; agent; single_workflow.
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// Alias of the thought model.
        /// </summary>
        [JsonProperty("ThoughtModelAliasName")]
        public string ThoughtModelAliasName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "AppTypeDesc", this.AppTypeDesc);
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Avatar", this.Avatar);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "AppStatus", this.AppStatus);
            this.SetParamSimple(map, prefix + "AppStatusDesc", this.AppStatusDesc);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelAliasName", this.ModelAliasName);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "ThoughtModelAliasName", this.ThoughtModelAliasName);
        }
    }
}

