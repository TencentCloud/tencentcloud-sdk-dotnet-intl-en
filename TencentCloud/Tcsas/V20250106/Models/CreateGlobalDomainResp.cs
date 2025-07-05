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

    public class CreateGlobalDomainResp : AbstractModel
    {
        
        /// <summary>
        /// Result
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Result")]
        public bool? Result{ get; set; }

        /// <summary>
        /// List of duplicate domain names
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RepeatUrls")]
        public string[] RepeatUrls{ get; set; }

        /// <summary>
        /// List of allowed domain names
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExistsWhiteUrls")]
        public string[] ExistsWhiteUrls{ get; set; }

        /// <summary>
        /// List of blocked domain names
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExistsBlackUrls")]
        public string[] ExistsBlackUrls{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamArraySimple(map, prefix + "RepeatUrls.", this.RepeatUrls);
            this.SetParamArraySimple(map, prefix + "ExistsWhiteUrls.", this.ExistsWhiteUrls);
            this.SetParamArraySimple(map, prefix + "ExistsBlackUrls.", this.ExistsBlackUrls);
        }
    }
}

