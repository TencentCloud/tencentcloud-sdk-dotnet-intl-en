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
        /// Smart erasure template id.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Intelligent erasure custom parameter. valid when Definition is 0. this parameter is used for highly custom scenarios. we recommend you prioritize using Definition to specify intelligent erasure parameters.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawSmartEraseParameter RawParameter{ get; set; }

        /// <summary>
        /// Specifies the target storage for files. if left blank, it inherits the upper-level OutputStorage value.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path of the file, which can be a relative or absolute path.
        /// Specifies the output path must end with `.{format}`. variable names, please refer to [filename variable explanation](https://www.tencentcloud.com/document/product/1041/33495?has_map=1).
        /// **Relative path example**:
        /// <Li>Filename_{Variable name}.{format}</li>
        /// <li>Filename.{format}</li>
        /// 
        /// **Absolute path example**:
        /// <Li>/Custom path/filename_{variable name}.{format}</li>
        /// 
        /// **Note**: currently does not support the `BatchProcessMedia` api.
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
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
        }
    }
}

