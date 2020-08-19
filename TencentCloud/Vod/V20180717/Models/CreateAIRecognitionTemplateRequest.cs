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

    public class CreateAIRecognitionTemplateRequest : AbstractModel
    {
        
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
        public HeadTailConfigureInfo HeadTailConfigure{ get; set; }

        /// <summary>
        /// Control parameter of video splitting recognition.
        /// </summary>
        [JsonProperty("SegmentConfigure")]
        public SegmentConfigureInfo SegmentConfigure{ get; set; }

        /// <summary>
        /// Control parameter of face recognition.
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfo FaceConfigure{ get; set; }

        /// <summary>
        /// Control parameter of full text recognition.
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfo OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// Control parameter of text keyword recognition.
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfo OcrWordsConfigure{ get; set; }

        /// <summary>
        /// Control parameter of full speech recognition.
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfo AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// Control parameter of speech keyword recognition.
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfo AsrWordsConfigure{ get; set; }

        /// <summary>
        /// Control parameter of object recognition.
        /// </summary>
        [JsonProperty("ObjectConfigure")]
        public ObjectConfigureInfo ObjectConfigure{ get; set; }

        /// <summary>
        /// Frame capturing interval in seconds. If this parameter is left empty, 1 second will be used by default. Minimum value: 0.5 seconds.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }

        /// <summary>
        /// [Subapplication](https://intl.cloud.tencent.com/document/product/266/14574?from_cn_redirect=1) ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this field; otherwise, leave it empty.
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamObj(map, prefix + "HeadTailConfigure.", this.HeadTailConfigure);
            this.SetParamObj(map, prefix + "SegmentConfigure.", this.SegmentConfigure);
            this.SetParamObj(map, prefix + "FaceConfigure.", this.FaceConfigure);
            this.SetParamObj(map, prefix + "OcrFullTextConfigure.", this.OcrFullTextConfigure);
            this.SetParamObj(map, prefix + "OcrWordsConfigure.", this.OcrWordsConfigure);
            this.SetParamObj(map, prefix + "AsrFullTextConfigure.", this.AsrFullTextConfigure);
            this.SetParamObj(map, prefix + "AsrWordsConfigure.", this.AsrWordsConfigure);
            this.SetParamObj(map, prefix + "ObjectConfigure.", this.ObjectConfigure);
            this.SetParamSimple(map, prefix + "ScreenshotInterval", this.ScreenshotInterval);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

