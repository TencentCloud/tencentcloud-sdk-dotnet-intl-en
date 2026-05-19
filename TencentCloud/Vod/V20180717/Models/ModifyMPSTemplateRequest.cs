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

    public class ModifyMPSTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><b>VOD <a href="/document/product/266/14574?from_cn_redirect=1">application</a> ID.</b></p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>Type of the MPS template that needs to be modified.</p><p>Enumeration value:</p><ul><li>AIAnalysis: Intelligent analysis template</li><li>SmartSubtitle: Intelligent subtitle template</li><li>SmartErase: Intelligent erasure template</li></ul>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// <p>MPS modifies template parameters. This parameter is used for passing through to the media processing service (MPS) to modify user-defined MPS task templates from the VOD side.<br> Currently only support modifying templates of the following task types in this way:</p><ol><li>Audio and video enhancement: Only support filling in the content of Name, Comment, RemoveVideo, RemoveAudio, VideoTemplate, AudioTemplate, and EnhanceConfig parameters in the "<a href="https://www.tencentcloud.com/document/api/862/37578?from_cn_redirect=1">modify transcoding template</a>" interface. Currently only support configuring the above parameters in the template, other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>AI analysis: Only support filling in the content of Name, Comment, ClassificationConfigure, TagConfigure, CoverConfigure, and FrameTagConfigure parameters in the "<a href="https://www.tencentcloud.com/document/api/862/40246?from_cn_redirect=1">modify content analysis template</a>" interface. Currently only support configuring the above parameters in the template, other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Intelligent caption: Only support filling in the content of Name, Comment, TranslateSwitch, VideoSrcLanguage, SubtitleFormat, SubtitleType, AsrHotWordsConfigure, TranslateDstLanguage, and ProcessType parameters in the "<a href="https://www.tencentcloud.com/document/api/862/117001?from_cn_redirect=1">modify intelligent caption template</a>" interface. Currently only support configuring the above parameters in the template, other parameters are not required. If other parameters are included, the system will automatically ignore them.</li><li>Intelligent erasure: Only support filling in the content of Name, Comment, EraseType, EraseSubtitleConfig, EraseWatermarkConfig, and ErasePrivacyConfig parameters in the "<a href="https://www.tencentcloud.com/document/api/862/123732?from_cn_redirect=1">modify intelligent erasure template</a>" interface. Currently only support configuring the above parameters in the template, other parameters are not required. If other parameters are included, the system will automatically ignore them.</li></ol>
        /// </summary>
        [JsonProperty("MPSModifyTemplateParams")]
        public string MPSModifyTemplateParams{ get; set; }

        /// <summary>
        /// <p>Intelligent analysis template parameter. Valid when MPSModifyTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("AIAnalysisTemplate")]
        public MPSAIAnalysisTemplateForUpdate AIAnalysisTemplate{ get; set; }

        /// <summary>
        /// <p>Intelligent subtitle template parameter. Valid when MPSModifyTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartSubtitleTemplate")]
        public MPSSmartSubtitleTemplateForUpdate SmartSubtitleTemplate{ get; set; }

        /// <summary>
        /// <p>Intelligent erasure template parameter. Valid when MPSModifyTemplateParams is empty.</p>
        /// </summary>
        [JsonProperty("SmartEraseTemplate")]
        public MPSSmartEraseTemplateForUpdate SmartEraseTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSModifyTemplateParams", this.MPSModifyTemplateParams);
            this.SetParamObj(map, prefix + "AIAnalysisTemplate.", this.AIAnalysisTemplate);
            this.SetParamObj(map, prefix + "SmartSubtitleTemplate.", this.SmartSubtitleTemplate);
            this.SetParamObj(map, prefix + "SmartEraseTemplate.", this.SmartEraseTemplate);
        }
    }
}

