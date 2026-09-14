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
        /// Video transcoding template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Custom video transcoding parameter. It takes effect when Definition is set to 0.
        /// This parameter is used in high customization scenarios. It is recommended that you preferentially use Definition to specify transcoding parameters.
        /// </summary>
        [JsonProperty("RawParameter")]
        public RawTranscodeParameter RawParameter{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OverrideParameter")]
        public OverrideTranscodeParameter OverrideParameter{ get; set; }

        /// <summary>
        /// Watermark list. Multiple image or text watermarks up to a maximum of 10 are supported.
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// Mosaic list. A maximum of 10 images is supported.
        /// </summary>
        [JsonProperty("MosaicSet")]
        public MosaicInput[] MosaicSet{ get; set; }

        /// <summary>
        /// Start time offset of the transcoded video, in seconds.
        /// <li>If this parameter is not specified or is set to 0, the transcoded video starts from the start position of the original video;</li>
        /// <li>When the value is greater than 0 (assuming n), it means the transcoded video starts from the nth second of the original video;</li>
        /// <li>When the value is less than 0 (assuming -n), it means the transcoded video starts n seconds before the end of the original video.</li>
        /// </summary>
        [JsonProperty("StartTimeOffset")]
        public float? StartTimeOffset{ get; set; }

        /// <summary>
        /// End time offset of the transcoded video, in seconds.
        /// <li>If not set or set to 0, the transcoded video will last until the end of the original video.</li>
        /// <li>When the value is greater than 0 (assuming n), it means the transcoded video ends at the nth second of the original video.</li>
        /// <li>When the value is less than 0 (assuming -n), it means the transcoded video lasts until n seconds before the end of the original video.</li>
        /// </summary>
        [JsonProperty("EndTimeOffset")]
        public float? EndTimeOffset{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path of the main file after transcoding, which can be a relative or absolute path.
        /// To define the output path, the path must end with `.{format}`. For variable names, please refer to [Filename Variable Explanation](https://www.tencentcloud.com/document/product/862/37039?from_cn_redirect=1).
        /// Relative path example:
        /// <li>Filename_{Variable name}.{format}</li>
        /// <li>Filename.{format}.</li>
        /// Absolute path example:
        /// <li>/Custom path/Filename_{Variable name}.{format}</li>
        /// If left empty, the default relative path is `{inputName}_transcode_{definition}.{format}`.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// Output path for segment files after transcoding (the path of TS files when transcoding to HLS), which can only be a relative path. If left empty, it defaults to `{inputName}_transcode_{definition}_{number}.{format}`.
        /// </summary>
        [JsonProperty("SegmentObjectName")]
        public string SegmentObjectName{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ObjectNumberFormat")]
        public NumberFormat ObjectNumberFormat{ get; set; }

        /// <summary>
        /// 
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

