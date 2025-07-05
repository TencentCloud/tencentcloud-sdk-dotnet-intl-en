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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FunctionInfo : AbstractModel
    {
        
        /// <summary>
        /// Function namespace
        /// </summary>
        [JsonProperty("FunctionNamespace")]
        public string FunctionNamespace{ get; set; }

        /// <summary>
        /// Function name
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// Function version name or alias
        /// </summary>
        [JsonProperty("FunctionQualifier")]
        public string FunctionQualifier{ get; set; }

        /// <summary>
        /// Function qualifier type. Values: `VERSION`, `ALIAS`.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FunctionQualifierType")]
        public string FunctionQualifierType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionNamespace", this.FunctionNamespace);
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "FunctionQualifier", this.FunctionQualifier);
            this.SetParamSimple(map, prefix + "FunctionQualifierType", this.FunctionQualifierType);
        }
    }
}

