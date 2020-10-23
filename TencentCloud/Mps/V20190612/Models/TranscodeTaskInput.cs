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

    public class TranscodeTaskInput : AbstractModel
    {
        
        /// <summary>
        /// ID of a video transcoding template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Custom video transcoding parameter, which is valid if `Definition` is 0.
        /// This parameter is used in highly customized scenarios. We recommend you use `Definition` to specify the transcoding parameter preferably.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawTranscodeParameter RawParameter{ get; set; }

        /// <summary>
        /// List of up to 10 image or text watermarks.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// List of blurs. Up to 10 ones can be supported.
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// Target bucket of an output file. If this parameter is left empty, the `OutputStorage` value of the upper folder will be inherited.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Path to a primary output file, which can be a relative path or an absolute path. If this parameter is left empty, the following relative path will be used by default: `{inputName}_transcode_{definition}.{format}`.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// Path to an output file part (the path to ts during transcoding to HLS), which can only be a relative path. If this parameter is left empty, the following relative path will be used by default: `{inputName}_transcode_{definition}_{number}.{format}`.
        /// </summary>
        [JsonProperty("SegmentObjectName")]
        public string SegmentObjectName{ get; set; }

        /// <summary>
        /// Rule of the `{number}` variable in the output path after transcoding.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ObjectNumberFormat")]
        public NumberFormat ObjectNumberFormat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamArrayObj(map, prefix + "MosaicSet.", this.MosaicSet);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "SegmentObjectName", this.SegmentObjectName);
            this.SetParamObj(map, prefix + "ObjectNumberFormat.", this.ObjectNumberFormat);
        }
    }
}

