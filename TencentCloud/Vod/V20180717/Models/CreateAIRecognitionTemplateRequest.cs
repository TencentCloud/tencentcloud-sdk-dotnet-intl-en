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

    public class CreateAIRecognitionTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. Customers who activate VOD services after December 25, 2023 must fill this field with the application ID when accessing resources in on-demand applications (whether default or newly created).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Audio and video content recognition template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio/video content recognition template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Video opening and closing recognition control parameters.
        /// </summary>
        [JsonProperty("HeadTailConfigure")]
        public HeadTailConfigureInfo HeadTailConfigure{ get; set; }

        /// <summary>
        /// Video split recognition control parameters.
        /// </summary>
        [JsonProperty("SegmentConfigure")]
        public SegmentConfigureInfo SegmentConfigure{ get; set; }

        /// <summary>
        /// Face recognition control parameter.
        /// </summary>
        [JsonProperty("FaceConfigure")]
        public FaceConfigureInfo FaceConfigure{ get; set; }

        /// <summary>
        /// Text Full-text Recognition Control Parameters.
        /// </summary>
        [JsonProperty("OcrFullTextConfigure")]
        public OcrFullTextConfigureInfo OcrFullTextConfigure{ get; set; }

        /// <summary>
        /// Text keyword recognition control parameters.
        /// </summary>
        [JsonProperty("OcrWordsConfigure")]
        public OcrWordsConfigureInfo OcrWordsConfigure{ get; set; }

        /// <summary>
        /// Voice full-text recognition control parameters.
        /// <font color=red>Note: This parameter is no longer maintained. Use the AsrTranslateConfigure parameter to trigger voice translation recognition (when DstLanguage is left empty or filled with an empty string, no translation is performed, and the billing item matches that of full speech recognition).</font>
        /// </summary>
        [JsonProperty("AsrFullTextConfigure")]
        public AsrFullTextConfigureInfo AsrFullTextConfigure{ get; set; }

        /// <summary>
        /// Voice keyword recognition control parameters.
        /// </summary>
        [JsonProperty("AsrWordsConfigure")]
        public AsrWordsConfigureInfo AsrWordsConfigure{ get; set; }

        /// <summary>
        /// Voice translation recognition control parameters.
        /// </summary>
        [JsonProperty("AsrTranslateConfigure")]
        public AsrTranslateConfigureInfo AsrTranslateConfigure{ get; set; }

        /// <summary>
        /// Object recognition control parameters.
        /// </summary>
        [JsonProperty("ObjectConfigure")]
        public ObjectConfigureInfo ObjectConfigure{ get; set; }

        /// <summary>
        /// Frame interception interval in seconds. If left empty, the default frame interval is 1 second with a minimum value of 0.5 seconds.
        /// </summary>
        [JsonProperty("ScreenshotInterval")]
        public float? ScreenshotInterval{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
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

