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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SessionIdAffinityConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Transmission location of the session ID parameter. If left empty, it defaults to Header.</p><p>Enumeration values:</p><ul><li>Header: Pass the parameter in the request header.</li></ul><p>Default value: Header.</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>Request header name for transmitting the session ID. Required when Source is Header.<br>If left empty, it defaults to EO-Infer-Session-Id.</p><p>Input limits: 1-64 characters in length. Only letters, digits, and hyphens are supported.</p><p>Default value: EO-Infer-Session-Id.</p>
        /// </summary>
        [JsonProperty("HeaderName")]
        public string HeaderName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "HeaderName", this.HeaderName);
        }
    }
}

