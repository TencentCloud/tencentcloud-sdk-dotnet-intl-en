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

    public class AdaptiveDynamicStreamingTaskInput : AbstractModel
    {
        
        /// <summary>
        /// Adaptive dynamic streaming template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

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
        /// Target storage for files after adaptive dynamic streaming. If left blank, it inherits the upper-level OutputStorage value.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// Output path for the manifest file after adaptive dynamic streaming. It can be either a relative path or an absolute path.
        /// If you need to define an output path, the path must end with `.{format}`. Refer to [Filename Variable Description](https://intl.cloud.tencent.com/document/product/862/37039?from_cn_redirect=1) for variable names.
        /// Example of relative path:
        /// <li>filename_{variable name}.{format}</li>
        /// <li>filename.{format}</li>
        /// Example of absolute path:
        /// <li>/custom path/filename_{variable name}.{format}</li>
        /// If not filled in, it is a relative path by default: {inputName}_adaptiveDynamicStreaming_{definition}.{format}.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// After adaptive dynamic streaming, the output path of substream files can only be a relative path. If not filled in, it is a relative path by default: `{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}.{format}`.
        /// </summary>
        [JsonProperty("SubStreamObjectName")]
        public string SubStreamObjectName{ get; set; }

        /// <summary>
        /// After adaptive dynamic streaming (for HLS only), the output path of segment files can only be a relative path. If not filled in, it is a relative path by default: `{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}_{segmentNumber}.{format}`.
        /// </summary>
        [JsonProperty("SegmentObjectName")]
        public string SegmentObjectName{ get; set; }

        /// <summary>
        /// External subtitle feature specifies the subtitle file to be inserted.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AddOnSubtitles")]
        public AddOnSubtitle[] AddOnSubtitles{ get; set; }

        /// <summary>
        /// Specifies the Drm information.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DrmInfo")]
        public DrmInfo DrmInfo{ get; set; }

        /// <summary>
        /// Adaptive transcoding template type.
        /// Common: audio/video type.
        /// PureAudio: audio-only.
        /// </summary>
        [JsonProperty("DefinitionType")]
        public string DefinitionType{ get; set; }

        /// <summary>
        /// Hard subtitle (suppression subtitle) feature, specify subtitles source, font size, position and other subtitle parameters.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SubtitleTemplate")]
        public SubtitleTemplate SubtitleTemplate{ get; set; }

        /// <summary>
        /// Transcoding parameter extension field.
        /// </summary>
        [JsonProperty("StdExtInfo")]
        public string StdExtInfo{ get; set; }

        /// <summary>
        /// Specifies the frame at the given pts time as a key frame and segments it. unit: milliseconds (relative deviation <=1ms is allowed). when gop and segment duration are specified simultaneously, they function together. note: enable RawPts, keep the frame rate as source, and ensure the passed-in pts time corresponds to a frame in the source.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyPTSList")]
        public long?[] KeyPTSList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamArrayObj(map, prefix + "WatermarkSet.", this.WatermarkSet);
            this.SetParamObj(map, prefix + "BlindWatermark.", this.BlindWatermark);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamSimple(map, prefix + "OutputObjectPath", this.OutputObjectPath);
            this.SetParamSimple(map, prefix + "SubStreamObjectName", this.SubStreamObjectName);
            this.SetParamSimple(map, prefix + "SegmentObjectName", this.SegmentObjectName);
            this.SetParamArrayObj(map, prefix + "AddOnSubtitles.", this.AddOnSubtitles);
            this.SetParamObj(map, prefix + "DrmInfo.", this.DrmInfo);
            this.SetParamSimple(map, prefix + "DefinitionType", this.DefinitionType);
            this.SetParamObj(map, prefix + "SubtitleTemplate.", this.SubtitleTemplate);
            this.SetParamSimple(map, prefix + "StdExtInfo", this.StdExtInfo);
            this.SetParamArraySimple(map, prefix + "KeyPTSList.", this.KeyPTSList);
        }
    }
}

