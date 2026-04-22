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

namespace TencentCloud.Tcsas.V20250106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApplicationMNPListRequest : AbstractModel
    {
        
        /// <summary>
        /// Page offset
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results per page
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Platform ID
        /// </summary>
        [JsonProperty("PlatformId")]
        public string PlatformId{ get; set; }

        /// <summary>
        /// Superapp ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// Online status. 0 All (default); 1 Available; 2 In canary release
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// Engine type. 0 Mini program; 1 Mini game
        /// </summary>
        [JsonProperty("EngineTypeList")]
        public long?[] EngineTypeList{ get; set; }

        /// <summary>
        /// Secondary category name
        /// </summary>
        [JsonProperty("SubCategory")]
        public string SubCategory{ get; set; }

        /// <summary>
        /// Primary category name
        /// </summary>
        [JsonProperty("PrimaryCategory")]
        public string PrimaryCategory{ get; set; }

        /// <summary>
        /// Keywords
        /// </summary>
        [JsonProperty("Keyword")]
        public string Keyword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "PlatformId", this.PlatformId);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamArraySimple(map, prefix + "EngineTypeList.", this.EngineTypeList);
            this.SetParamSimple(map, prefix + "SubCategory", this.SubCategory);
            this.SetParamSimple(map, prefix + "PrimaryCategory", this.PrimaryCategory);
            this.SetParamSimple(map, prefix + "Keyword", this.Keyword);
        }
    }
}

