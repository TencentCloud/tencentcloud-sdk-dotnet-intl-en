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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartEraseTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Smart erasing template id.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawSmartEraseParameter RawParameter{ get; set; }

        /// <summary>
        /// Custom parameters for smart erasing. When the value of Definition is not 0, this parameter is valid. When certain erasing parameters in this structure are specified, the specified parameters will be used to overwrite those in the smart erasing template. This parameter is used in highly customized scenarios. It is recommended to use only Definition to specify smart erasing parameters.
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideEraseParameter OverrideParameter{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path of the file, which can be a relative or absolute path.
        /// To define the output path, the path must end with `.{format}`. For variable names, please refer to the Filename Variable Explanation (https://www.tencentcloud.com/document/product/862/37039?from_cn_redirect=1).
        /// Relative path example:
        /// <li>Filename_{Variable name}.{format}</li>
        /// <li>Filename.{format}</li>
        /// Absolute path example:
        /// <li>/Custom path/Filename_{Variable name}.{format}</li>
        /// 
        /// **Note**: Currently does not support the `BatchProcessMedia` API.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
        }
    }
}

