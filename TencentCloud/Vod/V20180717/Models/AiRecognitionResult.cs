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
        /// <li>FaceRecognition: face recognition,</li>
        /// <li>AsrWordsRecognition: speech keyword recognition,</li>
        /// <li>OcrWordsRecognition: text keyword recognition,</li>
        /// <li>AsrFullTextRecognition: full speech recognition,</li>
        /// <li>AsrTranslateRecognition: voice translation recognition,</li>
        /// <li>OcrFullTextRecognition: full text recognition,</li>
        /// <li>HeadTailRecognition: video opening and ending credits recognition,</li>
        /// <li>ObjectRecognition: object recognition.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Video opening and ending credits recognition result, which is valid when `Type` is
        ///  `HeadTailRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HeadTailTask")]
        public AiRecognitionTaskHeadTailResult HeadTailTask{ get; set; }

        /// <summary>
        /// Video splitting recognition result, which is valid when `Type` is
        ///  `SegmentRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentTask")]
        public AiRecognitionTaskSegmentResult SegmentTask{ get; set; }

        /// <summary>
        /// Face recognition result, which is valid when `Type` is 
        ///  `FaceRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceTask")]
        public AiRecognitionTaskFaceResult FaceTask{ get; set; }

        /// <summary>
        /// Speech keyword recognition result, which is valid when `Type` is
        ///  `AsrWordsRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrWordsTask")]
        public AiRecognitionTaskAsrWordsResult AsrWordsTask{ get; set; }

        /// <summary>
        /// Full speech recognition result, which is valid when `Type` is
        ///  `AsrFullTextRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public AiRecognitionTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// Voice translation result, valid when Type is AsrTranslateRecognition.
        /// </summary>
        [JsonProperty("AsrTranslateTask")]
        public AiRecognitionTaskAsrTranslateResult AsrTranslateTask{ get; set; }

        /// <summary>
        /// Text keyword recognition result, which is valid when `Type` is
        ///  `OcrWordsRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrWordsTask")]
        public AiRecognitionTaskOcrWordsResult OcrWordsTask{ get; set; }

        /// <summary>
        /// Full text recognition result, which is valid when `Type` is
        ///  `OcrFullTextRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrFullTextTask")]
        public AiRecognitionTaskOcrFullTextResult OcrFullTextTask{ get; set; }

        /// <summary>
        /// Object recognition result, which is valid when `Type` is
        ///  `ObjectRecognition`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
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

