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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAIRecognitionTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HeadTailConfigure")]
        public HeadTailConfigureInfoForUpdate HeadTailConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentConfigure")]
        public SegmentConfigureInfoForUpdate SegmentConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfoForUpdate FaceConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfoForUpdate OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfoForUpdate OcrWordsConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfoForUpdate AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfoForUpdate AsrWordsConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrTranslateConfigure")]
        public AsrTranslateConfigureInfoForUpdate AsrTranslateConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ObjectConfigure")]
        public ObjectConfigureInfoForUpdate ObjectConfigure{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "HeadTailConfigure.", this.HeadTailConfigure);
            this.SetParamObj(map, prefix + "SegmentConfigure.", this.SegmentConfigure);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrTranslateConfigure.", this.AsrTranslateConfigure);
            this.SetParamObj(map, prefix + "ObjectConfigure.", this.ObjectConfigure);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
        }
    }
}

