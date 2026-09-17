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

    public class AiRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiRecognitionTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiRecognitionTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("FaceTask")]
        public AiRecognitionTaskFaceResult FaceTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrWordsTask")]
        public AiRecognitionTaskAsrWordsResult AsrWordsTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public AiRecognitionTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AsrTranslateTask")]
        public AiRecognitionTaskAsrTranslateResult AsrTranslateTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OcrWordsTask")]
        public AiRecognitionTaskOcrWordsResult OcrWordsTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OcrFullTextTask")]
        public AiRecognitionTaskOcrFullTextResult OcrFullTextTask{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ObjectTask")]
        public AiRecognitionTaskObjectResult ObjectTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "HeadTailTask.", this.HeadTailTask);
            this.SetParamObj(map, prefix + "SegmentTask.", this.SegmentTask);
            this.SetParamObj(map, prefix + "FaceTask.", this.FaceTask);
            this.SetParamObj(map, prefix + "AsrWordsTask.", this.AsrWordsTask);
            this.SetParamObj(map, prefix + "AsrFullTextTask.", this.AsrFullTextTask);
            this.SetParamObj(map, prefix + "AsrTranslateTask.", this.AsrTranslateTask);
            this.SetParamObj(map, prefix + "OcrWordsTask.", this.OcrWordsTask);
            this.SetParamObj(map, prefix + "OcrFullTextTask.", this.OcrFullTextTask);
            this.SetParamObj(map, prefix + "ObjectTask.", this.ObjectTask);
        }
    }
}

