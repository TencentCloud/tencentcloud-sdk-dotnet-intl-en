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

    public class MPSTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// File type result in the task return result. For example, in intelligent removal, the erased video file will be stored in the media asset, and FileId will be provided in this field. The Url of the subtitle file extracted from the video will be provided in this field.
        /// </summary>
        [JsonProperty("OutputFiles")]
        public MPSOutputFile[] OutputFiles{ get; set; }

        /// <summary>
        /// Result returned by the task. This field corresponds to the Output result in the MPS task response, returned in JSON format.
        /// The output result structures of different MPS tasks are different. For the specific return content, see the MPS task output struct.
        /// [Intelligent Categorization Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskClassificationOutput)
        /// [Intelligent Cover Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskCoverOutput)
        /// [Intelligent Tag Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskTagOutput)
        /// [Intelligent frame tagging classification result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskFrameTagOutput)
        /// [Intelligent Highlight Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskHighlightOutput)
        /// [Video Splitting Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskSegmentOutput)
        /// [Intelligent opening and ending content result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskHeadTailOutput)
        /// [Intelligent Summary Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskDescriptionOutput)
        /// [Horizontal-to-Vertical Video Transformation Result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskHorizontalToVerticalOutput)
        /// [Intelligent dubbing result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskDubbingOutput)
        /// [Intelligent video understanding result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#AiAnalysisTaskVideoComprehensionOutput)
        /// [Smart subtitle full speech recognition result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#SmartSubtitleTaskAsrFullTextResultOutput)
        /// [Intelligent caption translation result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#SmartSubtitleTaskTransTextResultOutput)
        /// [Translation result of pure subtitle file in smart subtitling](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#PureSubtitleTransResultOutput)
        /// [Smart subtitle text extraction subtitle result](https://www.tencentcloud.com/document/product/862/37615?from_cn_redirect=1#SmartSubtitleTaskTextResultOutput)
        /// 
        /// </summary>
        [JsonProperty("OutputText")]
        public string OutputText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "OutputFiles.", this.OutputFiles);
            this.SetParamSimple(map, prefix + "OutputText", this.OutputText);
        }
    }
}

