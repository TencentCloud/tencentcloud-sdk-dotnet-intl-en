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

    public class SmartSubtitlesTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Smart subtitle template ID.	
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// User extension field, which does not need to be filled in for general scenarios.
        /// </summary>
        [JsonProperty("UserExtPara")]
        public string UserExtPara{ get; set; }

        /// <summary>
        /// Custom smart subtitle parameter. It takes effect when Definition is set to 0. This parameter is used in high customization scenarios. It is recommended that you preferentially use Definition to specify smart subtitle parameters.	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawSmartSubtitleParameter RawParameter{ get; set; }

        /// <summary>
        /// Bucket that stores the output file. If it is left unspecified, the storage location in InputInfo will be inherited.
        /// **Note**: This parameter is required when InputInfo.Type is set to URL.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path of the generated subtitle file, which can be a relative or absolute path.
        /// To define the output path, end the path with .{format}. For variable names, see the description of file name variables at https://www.tencentcloud.comom/document/product/862/37039.?from_cn_redirect=1
        /// 
        /// Relative path example:
        ///  - File name_{variable name}.{format}.
        ///  - File name.{format}.
        /// 
        /// Absolute path example:
        ///  -/Custom path/File name_{variable name}.{format}.
        /// 
        /// If this field is left unspecified, the default value is the relative path in the following format: {inputName}_smartsubtitle_{definition}.{format}.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "UserExtPara", this.UserExtPara);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
        }
    }
}

