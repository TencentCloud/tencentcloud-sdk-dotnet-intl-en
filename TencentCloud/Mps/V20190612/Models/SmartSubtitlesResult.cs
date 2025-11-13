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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmartSubtitlesResult : AbstractModel
    {
        
        /// <summary>
        /// Task type. Valid values:
        /// - AsrFullTextRecognition: full speech recognition.
        /// - TransTextRecognition: speech translation.
        /// - PureSubtitleTrans: pure subtitle translation.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Full speech recognition result. When Type is
        ///  set to AsrFullTextRecognition, this parameter takes effect.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AsrFullTextTask")]
        public SmartSubtitleTaskAsrFullTextResult AsrFullTextTask{ get; set; }

        /// <summary>
        /// Translation result. When Type is
        /// 
        ///  set to TransTextRecognition, this parameter takes effect.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("TransTextTask")]
        public SmartSubtitleTaskTransTextResult TransTextTask{ get; set; }

        /// <summary>
        /// The translation result of the pure subtitle file is returned when the translation type is PureSubtitleTrans.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PureSubtitleTransTask")]
        public PureSubtitleTransResult PureSubtitleTransTask{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "AsrFullTextTask.", this.AsrFullTextTask);
            this.SetParamObj(map, prefix + "TransTextTask.", this.TransTextTask);
            this.SetParamObj(map, prefix + "PureSubtitleTransTask.", this.PureSubtitleTransTask);
        }
    }
}

