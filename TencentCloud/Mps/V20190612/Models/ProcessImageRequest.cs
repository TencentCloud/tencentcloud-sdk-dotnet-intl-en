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

    public class ProcessImageRequest : AbstractModel
    {
        
        /// <summary>
        /// File input information for image processing.
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// Target storage for image processing output files. If left blank, it inherits the storage location in InputInfo.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output file path for image processing. If left blank, it is the directory of the file in InputInfo. If it is a directory, such as `/image/201907/`, it means inheriting the original filename and outputting to this directory.
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }

        /// <summary>
        /// Output path, which can be a relative or an absolute path.
        /// The path must end with `.{format}`. For details, please refer to the [Filename Variable](https://www.tencentcloud.comom/document/product/862/37039?from_cn_redirect=1).
        /// **Relative path example:**
        /// <Li>`Filename_{Variablename}.{format}`.</li>
        /// <Li>`Filename.{format}`.</li>
        /// 
        /// **Absolute path example:**
        /// <Li>`/Path/Filename_{Variablename}.{format}`.</li>
        /// 
        /// If not filled in, default relative path: `{inputName}.{format}`.
        /// </summary>
        [JsonProperty("OutputPath")]
        public string OutputPath{ get; set; }

        /// <summary>
        /// Image processing parameter.
        /// </summary>
        [JsonProperty("ImageTask")]
        public ImageTaskInput ImageTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
            this.SetParamSimple(map, prefix + "OutputPath", this.OutputPath);
            this.SetParamObj(map, prefix + "ImageTask.", this.ImageTask);
        }
    }
}

