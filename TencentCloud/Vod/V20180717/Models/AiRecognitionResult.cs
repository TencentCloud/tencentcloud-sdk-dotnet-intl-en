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
        /// Task type. Valid values:
        /// <li>FaceRecognition: face recognition.</li>
        /// <li>AsrWordsRecognition: speech keyword recognition.</li>
        /// <li>OcrWordsRecognition: text keyword recognition.</li>
        /// <li>AsrFullTextRecognition: full speech recognition.</li>
        /// <li>AsrTranslateRecognition: Speech translation recognition,</li>
        /// <li>OcrFullTextRecognition: full text recognition.</li>
        /// <li>HeadTailRecognition: Video start and end recognition,</li>
        /// <li>ObjectRecognition: Object recognition.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Video opening and closing credits recognition result when Type is
        /// HeadTailRecognition.
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiRecognitionTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// Video splitting recognition result, which is valid when Type is
        /// Valid at SegmentRecognition.
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiRecognitionTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// Face recognition result, which is valid when Type is 
        /// FaceRecognition.
        /// </summary>
        [JsonProperty("FaceTask")]
        public AiRecognitionTaskFaceResult FaceTask{ get; set; }

        /// <summary>
        /// Speech keyword recognition result when Type is
        /// Valid at AsrWordsRecognition.
        /// </summary>
        [JsonProperty("AsrWordsTask")]
        public AiRecognitionTaskAsrWordsResult AsrWordsTask{ get; set; }

        /// <summary>
        /// Full speech recognition result. When Type is
        /// Set to AsrFullTextRecognition, this parameter takes effect.
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public AiRecognitionTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// Voice translation result. Valid when Type is AsrTranslateRecognition.
        /// </summary>
        [JsonProperty("AsrTranslateTask")]
        public AiRecognitionTaskAsrTranslateResult AsrTranslateTask{ get; set; }

        /// <summary>
        /// Text keyword recognition result when Type is
        /// Valid at OcrWordsRecognition.
        /// </summary>
        [JsonProperty("OcrWordsTask")]
        public AiRecognitionTaskOcrWordsResult OcrWordsTask{ get; set; }

        /// <summary>
        /// Full text recognition result. When Type is
        /// OcrFullTextRecognition.
        /// </summary>
        [JsonProperty("OcrFullTextTask")]
        public AiRecognitionTaskOcrFullTextResult OcrFullTextTask{ get; set; }

        /// <summary>
        /// Object recognition result, which is valid when Type is
        /// Valid at ObjectRecognition.
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

