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

    public class AIDubbingTaskInput : AbstractModel
    {
        
        /// <summary>
        /// <p>AI Dubbing template id.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <p>Custom AI dubbing parameter. It takes effect when Definition is set to 0. This parameter is used in highly customized scenarios. We recommend that you use Definition to specify dubbing parameters.</p>
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawAIDubbingParameter RawParameter{ get; set; }

        /// <summary>
        /// <p>AI Dubbing custom parameters. Valid when Definition is not filled with 0. When some dubbing parameters in this structure are filled in, the filled parameters will be used to override the parameters in the AI Dubbing template. This parameter is used for highly customized scenarios. We recommend you use only Definition to specify dubbing parameters.</p>
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideAIDubbingParameter OverrideParameter{ get; set; }

        /// <summary>
        /// <p>Target storage for the file. If this is not specified, it inherits the value from the upper-level OutputStorage.</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>External source subtitle file information.</p>
        /// </summary>
        [JsonProperty("SrcSubtitleInfo")]
        public MediaInputInfo SrcSubtitleInfo{ get; set; }

        /// <summary>
        /// <p>External subtitle file information, translated subtitles.</p>
        /// </summary>
        [JsonProperty("DstSubtitleInfos")]
        public DstSubtitleInput[] DstSubtitleInfos{ get; set; }

        /// <summary>
        /// <p>Output path of the file, which can be a relative or absolute path.<br>To define the output path, the path must end with <code>.{format}</code>. For variable names, see <a href="https://www.tencentcloud.com/document/product/862/37039?from_cn_redirect=1">File Name Variable Description</a>.<br>Relative path example:</p><li>File name_{variable name}.{format}</li><li>File name.{format}</li>Absolute path example:<li>/custom path/file name_{variable name}.{format}</li><p><strong>Note</strong>: The <code>BatchProcessMedia</code> API is currently not supported.</p>
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// <p>Additional parameters for AI Dubbing, serialized json string.</p>
        /// </summary>
        [JsonProperty("ExtendedParameter")]
        public string ExtendedParameter{ get; set; }

        /// <summary>
        /// <p>ID of the associated drama series.<br>Note: This value takes effect when dubbing mode is intelligent dubbing by role.</p>
        /// </summary>
        [JsonProperty("DramaId")]
        public string DramaId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamObj(map, prefix + "SrcSubtitleInfo.", this.SrcSubtitleInfo);
            this.SetParamArrayObj(map, prefix + "DstSubtitleInfos.", this.DstSubtitleInfos);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "ExtendedParameter", this.ExtendedParameter);
            this.SetParamSimple(map, prefix + "DramaId", this.DramaId);
        }
    }
}

