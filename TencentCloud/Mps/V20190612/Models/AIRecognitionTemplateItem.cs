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

    public class AIRecognitionTemplateItem : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a video content recognition template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Name of a video content recognition template.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of a video content recognition template.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Face recognition control parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfo FaceConfigure{ get; set; }

        /// <summary>
        /// Full text recognition control parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfo OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// Text keyword recognition control parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfo OcrWordsConfigure{ get; set; }

        /// <summary>
        /// Full speech recognition control parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfo AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// Speech keyword recognition control parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfo AsrWordsConfigure{ get; set; }

        /// <summary>
        /// Voice translation control parameters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TranslateConfigure")]
        public TranslateConfigureInfo TranslateConfigure{ get; set; }

        /// <summary>
        /// Creation time of a template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of a template in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// The template type. Valid values:
        /// * Preset
        /// * Custom
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
            this.SetParamObj(map, prefix + "TranslateConfigure.", this.TranslateConfigure);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

