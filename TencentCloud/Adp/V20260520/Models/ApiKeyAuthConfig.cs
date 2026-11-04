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

    public class ApiKeyAuthConfig : AbstractModel
    {
        
        /// <summary>
        /// Key position. HEADER/QUERY
        /// 
        /// Enumeration values:
        /// | uint | Description |
        /// | --- | --- |
        /// Header authentication
        /// | 1 | Query authentication |
        /// </summary>
        [JsonProperty("KeyLocation")]
        public long? KeyLocation{ get; set; }

        /// <summary>
        /// Key parameter name
        /// </summary>
        [JsonProperty("KeyParamName")]
        public string KeyParamName{ get; set; }

        /// <summary>
        /// Key parameter value
        /// </summary>
        [JsonProperty("KeyParamValue")]
        public string KeyParamValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyLocation", this.KeyLocation);
            this.SetParamSimple(map, prefix + "KeyParamName", this.KeyParamName);
            this.SetParamSimple(map, prefix + "KeyParamValue", this.KeyParamValue);
        }
    }
}

