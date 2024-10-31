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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAIRecognitionTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of video content recognition template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Video content recognition template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Description of video content recognition template. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Control parameter of video opening and ending credits recognition.
        /// </summary>
        [JsonProperty("HeadTailConfigure")]
        public HeadTailConfigureInfoForUpdate HeadTailConfigure{ get; set; }

        /// <summary>
        /// Control parameter of video splitting recognition.
        /// </summary>
        [JsonProperty("SegmentConfigure")]
        public SegmentConfigureInfoForUpdate SegmentConfigure{ get; set; }

        /// <summary>
        /// Control parameter of face recognition.
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfoForUpdate FaceConfigure{ get; set; }

        /// <summary>
        /// Control parameter of full text recognition.
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfoForUpdate OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// Control parameter of text keyword recognition.
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfoForUpdate OcrWordsConfigure{ get; set; }

        /// <summary>
        /// Control parameter of full speech recognition.
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfoForUpdate AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// Control parameter of speech keyword recognition.
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfoForUpdate AsrWordsConfigure{ get; set; }

        /// <summary>
        /// Control parameter of voice translation.
        /// </summary>
        [JsonProperty("AsrTranslateConfigure")]
        public AsrTranslateConfigureInfoForUpdate AsrTranslateConfigure{ get; set; }

        /// <summary>
        /// Control parameter of object recognition.
        /// </summary>
        [JsonProperty("ObjectConfigure")]
        public ObjectConfigureInfoForUpdate ObjectConfigure{ get; set; }

        /// <summary>
        /// Frame capturing interval in seconds. Minimum value: 0.5 seconds.
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

