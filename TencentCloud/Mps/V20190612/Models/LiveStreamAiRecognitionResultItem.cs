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

    public class LiveStreamAiRecognitionResultItem : AbstractModel
    {
        
        /// <summary>
        /// Result type. Valid values:
        /// <li>FaceRecognition: face recognition,</li>
        /// <li>AsrWordsRecognition: speech keyword recognition,</li>
        /// <li>OcrWordsRecognition: text keyword recognition,</li>
        /// <li>AsrFullTextRecognition: full speech recognition,</li>
        /// <li>OcrFullTextRecognition: full text recognition.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Face recognition result, which is valid when `Type` is
        /// `FaceRecognition`.
        /// </summary>
        [JsonProperty("FaceRecognitionResultSet")]
        public LiveStreamFaceRecognitionResult[] FaceRecognitionResultSet{ get; set; }

        /// <summary>
        /// Speech keyword recognition result, which is valid when `Type` is
        /// `AsrWordsRecognition`.
        /// </summary>
        [JsonProperty("AsrWordsRecognitionResultSet")]
        public LiveStreamAsrWordsRecognitionResult[] AsrWordsRecognitionResultSet{ get; set; }

        /// <summary>
        /// Text keyword recognition result, which is valid when `Type` is
        /// `OcrWordsRecognition`.
        /// </summary>
        [JsonProperty("OcrWordsRecognitionResultSet")]
        public LiveStreamOcrWordsRecognitionResult[] OcrWordsRecognitionResultSet{ get; set; }

        /// <summary>
        /// Full speech recognition result, which is valid when `Type` is
        /// `AsrFullTextRecognition`.
        /// </summary>
        [JsonProperty("AsrFullTextRecognitionResultSet")]
        public LiveStreamAsrFullTextRecognitionResult[] AsrFullTextRecognitionResultSet{ get; set; }

        /// <summary>
        /// Full text recognition result, which is valid when `Type` is
        /// `OcrFullTextRecognition`.
        /// </summary>
        [JsonProperty("OcrFullTextRecognitionResultSet")]
        public LiveStreamOcrFullTextRecognitionResult[] OcrFullTextRecognitionResultSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "FaceRecognitionResultSet.", this.FaceRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "AsrWordsRecognitionResultSet.", this.AsrWordsRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "OcrWordsRecognitionResultSet.", this.OcrWordsRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "AsrFullTextRecognitionResultSet.", this.AsrFullTextRecognitionResultSet);
            this.SetParamArrayObj(map, prefix + "OcrFullTextRecognitionResultSet.", this.OcrFullTextRecognitionResultSet);
        }
    }
}

