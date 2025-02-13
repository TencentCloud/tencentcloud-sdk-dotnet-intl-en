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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AICallExtractConfigElement : AbstractModel
    {
        
        /// <summary>
        /// Configuration item type, including.
        /// Text.
        /// Selector option.
        /// Boolean value.
        /// Number.
        /// </summary>
        [JsonProperty("InfoType")]
        public string InfoType{ get; set; }

        /// <summary>
        /// Configuration item name, duplicat.
        /// </summary>
        [JsonProperty("InfoName")]
        public string InfoName{ get; set; }

        /// <summary>
        /// Specific content of the configuration item.
        /// </summary>
        [JsonProperty("InfoContent")]
        public string InfoContent{ get; set; }

        /// <summary>
        /// Example of extracted content from the configuration item.
        /// </summary>
        [JsonProperty("Examples")]
        public string[] Examples{ get; set; }

        /// <summary>
        /// When infotype is selector, this field needs to be configured.
        /// </summary>
        [JsonProperty("Choices")]
        public string[] Choices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InfoType", this.InfoType);
            this.SetParamSimple(map, prefix + "InfoName", this.InfoName);
            this.SetParamSimple(map, prefix + "InfoContent", this.InfoContent);
            this.SetParamArraySimple(map, prefix + "Examples.", this.Examples);
            this.SetParamArraySimple(map, prefix + "Choices.", this.Choices);
        }
    }
}

