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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PublishLayerVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// Layer name, which can contain 1–64 English letters, digits, hyphens, and underscores, must begin with a letter, and cannot end with a hyphen or underscore
        /// </summary>
        [JsonProperty("LayerName")]
        public string LayerName{ get; set; }

        /// <summary>
        /// Runtimes compatible with layer. Multiple choices are allowed. The valid values of this parameter correspond to the valid values of the `Runtime` of the function.
        /// </summary>
        [JsonProperty("CompatibleRuntimes")]
        public string[] CompatibleRuntimes{ get; set; }

        /// <summary>
        /// Layer file source or content
        /// </summary>
        [JsonProperty("Content")]
        public Code Content{ get; set; }

        /// <summary>
        /// Layer version description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Software license of layer
        /// </summary>
        [JsonProperty("LicenseInfo")]
        public string LicenseInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LayerName", this.LayerName);
            this.SetParamArraySimple(map, prefix + "CompatibleRuntimes.", this.CompatibleRuntimes);
            this.SetParamObj(map, prefix + "Content.", this.Content);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LicenseInfo", this.LicenseInfo);
        }
    }
}

