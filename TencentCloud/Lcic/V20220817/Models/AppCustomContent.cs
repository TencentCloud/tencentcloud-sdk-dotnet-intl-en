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

namespace TencentCloud.Lcic.V20220817.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppCustomContent : AbstractModel
    {
        
        /// <summary>
        /// Multiple scenarios can be set for an application.
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// Logo URL
        /// </summary>
        [JsonProperty("LogoUrl")]
        public string LogoUrl{ get; set; }

        /// <summary>
        /// Homepage URL, which can be used for redirection
        /// </summary>
        [JsonProperty("HomeUrl")]
        public string HomeUrl{ get; set; }

        /// <summary>
        /// Custom JS URL
        /// </summary>
        [JsonProperty("JsUrl")]
        public string JsUrl{ get; set; }

        /// <summary>
        /// Custom CSS URL
        /// </summary>
        [JsonProperty("CssUrl")]
        public string CssUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "LogoUrl", this.LogoUrl);
            this.SetParamSimple(map, prefix + "HomeUrl", this.HomeUrl);
            this.SetParamSimple(map, prefix + "JsUrl", this.JsUrl);
            this.SetParamSimple(map, prefix + "CssUrl", this.CssUrl);
        }
    }
}

