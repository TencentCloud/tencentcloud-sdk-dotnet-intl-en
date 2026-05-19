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

    public class CreateMPSTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>Video-on-demand (VOD) <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Type of the MPS template to create. Value:</p><li>AIAnalysis: Create an intelligent analysis template.</li><li>SmartSubtitle: Create an intelligent subtitle template.</li><li>SmartErase: Create an intelligent erasure template.</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// <p>MPS template creation parameters. This parameter is used for transparent transmission to the media processing service (MPS) to create user-defined MPS task templates from the VOD side.<br>Currently only supports creating templates of the following task types through this method:</p><ol><li>AI analysis: only supports filling in the content of Name, Comment, ClassificationConfigure, TagConfigure, CoverConfigure, and FrameTagConfigure parameters in the "<a href="https://www.tencentcloud.com/document/api/862/40249?from_cn_redirect=1">create content analysis template</a>" API. Currently only supports configuring the above parameters in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Smart subtitling: only supports filling in the content of Name, Comment, TranslateSwitch, VideoSrcLanguage, SubtitleFormat, SubtitleType, AsrHotWordsConfigure, TranslateDstLanguage, and ProcessType parameters in the "<a href="https://www.tencentcloud.com/document/api/862/117004?from_cn_redirect=1">create intelligent caption template</a>" API. Currently only supports configuring the above parameters in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Intelligent erasure: only supports filling in the content of Name, Comment, EraseType, EraseSubtitleConfig, EraseWatermarkConfig, and ErasePrivacyConfig parameters in the "<a href="https://www.tencentcloud.com/document/api/862/123735?from_cn_redirect=1">create intelligent erasure template</a>" API. Currently only supports configuring the above parameters in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them.</li></ol><p>Currently, only the above parameters can be configured in the template. Other parameters are not required. If other parameters are included, the system will automatically ignore them. The above pass-through parameters are represented in JSON format.</p>
        /// </summary>
        [JsonProperty("MPSCreateTemplateParams")]
        public string MPSCreateTemplateParams{ get; set; }

        /// <summary>
        /// <p>Intelligent analysis template parameter. Valid when MPSCreateTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("AIAnalysisTemplate")]
        public MPSAIAnalysisTemplate AIAnalysisTemplate{ get; set; }

        /// <summary>
        /// <p>Parameter of the intelligent subtitle template. Valid when MPSCreateTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartSubtitleTemplate")]
        public MPSSmartSubtitleTemplate SmartSubtitleTemplate{ get; set; }

        /// <summary>
        /// <p>Intelligent erasure template parameter. Valid when MPSCreateTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartEraseTemplate")]
        public MPSSmartEraseTemplate SmartEraseTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSCreateTemplateParams", this.MPSCreateTemplateParams);
            this.SetParamObj(map, prefix + "AIAnalysisTemplate.", this.AIAnalysisTemplate);
            this.SetParamObj(map, prefix + "SmartSubtitleTemplate.", this.SmartSubtitleTemplate);
            this.SetParamObj(map, prefix + "SmartEraseTemplate.", this.SmartEraseTemplate);
        }
    }
}

