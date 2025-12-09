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

    public class TranscodeTaskInput : AbstractModel
    {
        
        /// <summary>
        /// ID of a video transcoding template.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Custom video transcoding parameter. valid when Definition is set to 0.
        /// This parameter is used in high customization scenarios. it is recommended that you preferentially use Definition to specify transcoding parameters.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawTranscodeParameter RawParameter{ get; set; }

        /// <summary>
        /// Video transcoding custom parameter, which is valid when `Definition` is not 0.
        /// When any parameters in this structure are entered, they will be used to override corresponding parameters in templates.
        /// This parameter is used in highly customized scenarios. We recommend you only use `Definition` to specify the transcoding parameter.
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideTranscodeParameter OverrideParameter{ get; set; }

        /// <summary>
        /// Watermark list. Multiple image or text watermarks up to a maximum of 10 are supported.
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// Digital watermark parameter.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// List of blurs. Up to 10 ones can be supported.
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// Start time offset of a transcoded video, in seconds.
        /// <li>If this parameter is left empty or set to 0, the transcoded video will start at the same time as the original video.</li>
        /// <li>If this parameter is set to a positive number (n for example), the transcoded video will start at the nth second of the original video.</li>
        /// <li>If this parameter is set to a negative number (-n for example), the transcoded video will start at the nth second before the end of the original video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of a transcoded video, in seconds.
        /// <li>If this parameter is left empty or set to 0, the transcoded video will end at the same time as the original video.</li>
        /// <li>If this parameter is set to a positive number (n for example), the transcoded video will end at the nth second of the original video.</li>
        /// <li>If this parameter is set to a negative number (-n for example), the transcoded video will end at the nth second before the end of the original video.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// Target bucket of an output file. If this parameter is left empty, the `OutputStorage` value of the upper folder will be inherited.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path of the main file after transcoding, which can be a relative or absolute path.
        /// If you need to define an output path, the path must end with `.{format}`. For variable names, refer to [Filename Variable](https://intl.cloud.tencent.com/document/product/862/37039?from_cn_redirect=1).Relative path example:
        /// <li>Filename_{Variable name}.{format}.</li>
        /// <li>Filename.{format}.</li>
        /// Absolute path example:
        /// <li>/Custom path/Filename_{Variable name}.{format}.</li>
        /// If left empty, a relative path is used by default: `{inputName}_transcode_{definition}.{format}`.
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
        /// Opening and closing credits parameters
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("HeadTailParameter")]
        public HeadTailParameter HeadTailParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamObj(map, prefix + "RawParameter.", this.RawParameter);
            this.SetParamObj(map, prefix + "OverrideParameter.", this.OverrideParameter);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "BlindWatermark.", this.BlindWatermark);
            this.SetParamArrayObj(map, prefix + "MosaicSet.", this.MosaicSet);
            this.SetParamSimple(map, prefix + "StartTimeOffset", this.StartTimeOffset);
            this.SetParamSimple(map, prefix + "EndTimeOffset", this.EndTimeOffset);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "SegmentObjectName", this.SegmentObjectName);
            this.SetParamObj(map, prefix + "ObjectNumberFormat.", this.ObjectNumberFormat);
            this.SetParamObj(map, prefix + "HeadTailParameter.", this.HeadTailParameter);
        }
    }
}

