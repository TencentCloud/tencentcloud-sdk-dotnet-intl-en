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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Browser : AbstractModel
    {
        
        /// <summary>
        /// <p>The user agent of the browser that interacts with the website</p>
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// <p>The language(s) that the client prefers</p><p>Parameter format: Complies with the ISO 3166 standard</p>
        /// </summary>
        [JsonProperty("AcceptLanguage")]
        public string AcceptLanguage{ get; set; }

        /// <summary>
        /// <p>The language(s) intended for the audience</p><p>Parameter format: Compliant with ISO 3166 standard</p>
        /// </summary>
        [JsonProperty("ContentLanguage")]
        public string ContentLanguage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "AcceptLanguage", this.AcceptLanguage);
            this.SetParamSimple(map, prefix + "ContentLanguage", this.ContentLanguage);
        }
    }
}

