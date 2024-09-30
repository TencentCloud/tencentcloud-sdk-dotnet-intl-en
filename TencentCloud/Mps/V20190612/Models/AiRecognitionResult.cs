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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiRecognitionResult : AbstractModel
    {
        
        /// <summary>
        /// The task type. Valid values:
        /// <li>FaceRecognition: Face recognition</li>
        /// <li>AsrWordsRecognition: Speech keyword recognition</li>
        /// <li>OcrWordsRecognition: Text keyword recognition</li>
        /// <li>AsrFullTextRecognition: Full speech recognition</li>
        /// <li>OcrFullTextRecognition: Full text recognition</li>
        /// <li>TransTextRecognition: Speech translation</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Face recognition result, which is valid when `Type` is 
        ///  `FaceRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FaceTask")]
        public AiRecognitionTaskFaceResult FaceTask{ get; set; }

        /// <summary>
        /// Speech keyword recognition result, which is valid when `Type` is
        ///  `AsrWordsRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrWordsTask")]
        public AiRecognitionTaskAsrWordsResult AsrWordsTask{ get; set; }

        /// <summary>
        /// Full speech recognition result, which is valid when `Type` is
        ///  `AsrFullTextRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public AiRecognitionTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// Text keyword recognition result, which is valid when `Type` is
        ///  `OcrWordsRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrWordsTask")]
        public AiRecognitionTaskOcrWordsResult OcrWordsTask{ get; set; }

        /// <summary>
        /// Full text recognition result, which is valid when `Type` is
        ///  `OcrFullTextRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcrFullTextTask")]
        public AiRecognitionTaskOcrFullTextResult OcrFullTextTask{ get; set; }

        /// <summary>
        /// The translation result. This parameter is valid only if `Type` is
        ///  `TransTextRecognition`.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TransTextTask")]
        public AiRecognitionTaskTransTextResult TransTextTask{ get; set; }

        /// <summary>
        /// Object recognition result, which is valid when Type is
        /// 
        /// ObjectRecognition.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectTask")]
        public AiRecognitionTaskObjectResult ObjectTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "FaceTask.", this.FaceTask);
            this.SetParamObj(map, prefix + "AsrWordsTask.", this.AsrWordsTask);
            this.SetParamObj(map, prefix + "AsrFullTextTask.", this.AsrFullTextTask);
            this.SetParamObj(map, prefix + "OcrWordsTask.", this.OcrWordsTask);
            this.SetParamObj(map, prefix + "OcrFullTextTask.", this.OcrFullTextTask);
            this.SetParamObj(map, prefix + "TransTextTask.", this.TransTextTask);
            this.SetParamObj(map, prefix + "ObjectTask.", this.ObjectTask);
        }
    }
}

