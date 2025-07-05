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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Base64EncodedTriggerRule : AbstractModel
    {
        
        /// <summary>
        /// Header for triggering encoding. Valid values are `Accept` and `Content_Type`, corresponding to the `Accept` and `Content-Type` headers in the data stream request, respectively.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Array of header values that can trigger the encoding. Each element in the array can be up to 40 characters, including digits, letters, and special characters (`.`, `+`, `*`, `-`, `/`, and `_`). 
        /// 
        /// For example, [
        ///     "application/x-vpeg005",
        ///     "application/xhtml+xml",
        ///     "application/vnd.ms-project",
        ///     "application/vnd.rn-rn_music_package"
        /// ] are valid.
        /// </summary>
        [JsonProperty("Value")]
        public string[] Value{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "Value.", this.Value);
        }
    }
}

