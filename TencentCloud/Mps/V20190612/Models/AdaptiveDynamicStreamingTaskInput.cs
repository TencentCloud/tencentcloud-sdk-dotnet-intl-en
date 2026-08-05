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
        /// <p>Adaptive bitrate streaming template ID.</p>
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// <p>Watermark list. Up to 10 image or text watermarks are supported.</p>
        /// </summary>
        [JsonProperty("WatermarkSet")]
        public WatermarkInput[] WatermarkSet{ get; set; }

        /// <summary>
        /// <p>Digital watermark parameter.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BlindWatermark")]
        public BlindWatermarkInput BlindWatermark{ get; set; }

        /// <summary>
        /// <p>Target storage for files after adaptive bitrate streaming. If this is not specified, the upper-level OutputStorage value is used.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>Output path for the manifest file after adaptive bitrate streaming, which can be a relative or absolute path.<br>To define the output path, the path must end with <code>.{format}</code>. For variable names, see <a href="https://www.tencentcloud.com/document/product/862/37039?from_cn_redirect=1">Filename Variables</a>.<br>Relative path example:</p><li>Filename_{variable name}.{format}</li><li>Filename.{format}</li>Absolute path example:<li>/custom path/Filename_{variable name}.{format}</li>If this is not specified, the default relative path is {inputName}_adaptiveDynamicStreaming_{definition}.{format}.
        /// </summary>
        [JsonProperty("OutputObjectPath")]
        public string OutputObjectPath{ get; set; }

        /// <summary>
        /// <p>Output path for substream files after adaptive bitrate streaming, which can only be a relative path. If this is not specified, the default relative path is <code>{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}.{format}</code>.</p>
        /// </summary>
        [JsonProperty("SubStreamObjectName")]
        public string SubStreamObjectName{ get; set; }

        /// <summary>
        /// <p>Output path for segment files after adaptive bitrate streaming (HLS only), which can only be a relative path. If this is not specified, the default relative path is <code>{inputName}_adaptiveDynamicStreaming_{definition}_{subStreamNumber}_{segmentNumber}.{format}</code>.</p>
        /// </summary>
        [JsonProperty("SegmentObjectName")]
        public string SegmentObjectName{ get; set; }

        /// <summary>
        /// <p>External subtitle feature. Specifies the subtitle file to be inserted.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AddOnSubtitles")]
        public AddOnSubtitle[] AddOnSubtitles{ get; set; }

        /// <summary>
        /// <p>DRM information.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DrmInfo")]
        public DrmInfo DrmInfo{ get; set; }

        /// <summary>
        /// <p>Adaptive bitrate streaming template type. Valid values:<br>Common: audio and video.<br>PureAudio: audio only.</p>
        /// </summary>
        [JsonProperty("DefinitionType")]
        public string DefinitionType{ get; set; }

        /// <summary>
        /// <p>Hard subtitle (burned-in subtitle) feature. Specifies the subtitle source, font size, location, and other subtitle parameters.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SubtitleTemplate")]
        public SubtitleTemplate SubtitleTemplate{ get; set; }

        /// <summary>
        /// <p>Extended transcoding parameter field.</p>
        /// </summary>
        [JsonProperty("StdExtInfo")]
        public string StdExtInfo{ get; set; }

        /// <summary>
        /// <p>Specifies frames at specified PTS times as keyframes and splits segments. Unit: milliseconds (relative deviation of up to 1 ms is allowed). When both GOP and segment duration are specified, they function together. Note that you need to enable RawPts, keep the frame rate as that of the source, and ensure the specified PTS time corresponds to a frame in the source.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("KeyPTSList")]
        public long?[] KeyPTSList{ get; set; }

        /// <summary>
        /// <p>External audio feature. Specifies the audio files to be inserted.</p>
        /// </summary>
        [JsonProperty("AddOnAudios")]
        public AddOnAudio[] AddOnAudios{ get; set; }

        /// <summary>
        /// <p>When not empty, directly replace the StreamInfos field of the template. The field format is the same as the StreamInfos when creating an adaptive template.</p>
        /// </summary>
        [JsonProperty("StdExtStreamInfos")]
        public AdaptiveStreamTemplate[] StdExtStreamInfos{ get; set; }


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
            this.SetParamArrayObj(map, prefix + "AddOnAudios.", this.AddOnAudios);
            this.SetParamArrayObj(map, prefix + "StdExtStreamInfos.", this.StdExtStreamInfos);
        }
    }
}

