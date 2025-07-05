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

    public class CallDetail : AbstractModel
    {
        
        /// <summary>
        /// Associated ID.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Call time.
        /// </summary>
        [JsonProperty("CallTime")]
        public string CallTime{ get; set; }

        /// <summary>
        /// Total token consumption.
        /// </summary>
        [JsonProperty("TotalTokenUsage")]
        public float? TotalTokenUsage{ get; set; }

        /// <summary>
        /// Token consumption for input.
        /// </summary>
        [JsonProperty("InputTokenUsage")]
        public float? InputTokenUsage{ get; set; }

        /// <summary>
        /// Token consumption for output.
        /// </summary>
        [JsonProperty("OutputTokenUsage")]
        public float? OutputTokenUsage{ get; set; }

        /// <summary>
        /// Number of search service calls.
        /// </summary>
        [JsonProperty("SearchUsage")]
        public ulong? SearchUsage{ get; set; }

        /// <summary>
        /// Model name.
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// Call type.
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// Account.
        /// </summary>
        [JsonProperty("UinAccount")]
        public string UinAccount{ get; set; }

        /// <summary>
        /// Application name.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Total number of consumed pages.
        /// </summary>
        [JsonProperty("PageUsage")]
        public ulong? PageUsage{ get; set; }

        /// <summary>
        /// Filter sub-scenario.
        /// </summary>
        [JsonProperty("SubScene")]
        public string SubScene{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "CallTime", this.CallTime);
            this.SetParamSimple(map, prefix + "TotalTokenUsage", this.TotalTokenUsage);
            this.SetParamSimple(map, prefix + "InputTokenUsage", this.InputTokenUsage);
            this.SetParamSimple(map, prefix + "OutputTokenUsage", this.OutputTokenUsage);
            this.SetParamSimple(map, prefix + "SearchUsage", this.SearchUsage);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "UinAccount", this.UinAccount);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "PageUsage", this.PageUsage);
            this.SetParamSimple(map, prefix + "SubScene", this.SubScene);
        }
    }
}

