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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAIRecognitionTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Name of a video content recognition template. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of a video content recognition template. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Face recognition control parameter.
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfo FaceConfigure{ get; set; }

        /// <summary>
        /// Full text recognition control parameter.
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfo OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// Text keyword recognition control parameter.
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfo OcrWordsConfigure{ get; set; }

        /// <summary>
        /// Full speech recognition control parameter.
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfo AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// Speech keyword recognition control parameter.
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfo AsrWordsConfigure{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
        }
    }
}

