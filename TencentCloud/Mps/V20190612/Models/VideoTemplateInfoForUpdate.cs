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

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for video streams. Optional values:
        /// <li>h264: H.264 encoding</li>
        /// <li>h265: H.265 encoding</li>
        /// <li>h266: H.266 encoding</li>
        /// <li>av1: AOMedia Video 1 encoding</li>
        /// <li>vp8: VP8 encoding</li>
        /// <li>vp9: VP9 encoding</li>
        /// <li>mpeg2: MPEG2 encoding</li>
        /// <li>dnxhd: DNxHD encoding</li>
        /// <li>mv-hevc: MV-HEVC encoding</li>
        /// 
        /// Note: AV1 encoding containers currently only support mp4, webm, and mkv.
        /// Note: H.266 encoding containers currently only support mp4, hls, ts, and mov.
        /// Note: VP8 and VP9 encoding containers currently only support webm and mkv.
        /// Note: MPEG2 and DNxHD encoding containers currently only support mxf.
        /// Note: MV-HEVC encoding containers only support mp4, hls, and mov. Among them, the hls format only supports mp4 segmentation format.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate. Value range:
        /// When FpsDenominator is empty, the range is [0, 120], in Hz.
        /// When FpsDenominator is not empty, the Fps/FpsDenominator range is [0, 120].
        /// If the value is 0, the frame rate will be the same as that of the source video.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Bitrate of a video stream, in kbps. Value range: 0 and [128, 100000].If the value is 0, the bitrate of the video will be the same as that of the source video.Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaption. Valid values:
        /// <li>open: Enabled. When resolution adaption is enabled, `Width` indicates the long side of a video, while `Height` indicates the short side.</li>
        /// <li>close: Disabled. When resolution adaption is disabled, `Width` indicates the width of a video, while `Height` indicates the height.</li>
        /// Note: When resolution adaption is enabled, `Width` cannot be smaller than `Height`.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Maximum value of the width (or long side) of a video stream in px. Value range: 0 and [128, 4,096].
        /// <li>If both `Width` and `Height` are 0, the resolution will be the same as that of the source video;</li>
        /// <li>If `Width` is 0, but `Height` is not 0, `Width` will be proportionally scaled;</li>
        /// <li>If `Width` is not 0, but `Height` is 0, `Height` will be proportionally scaled;</li>
        /// <li>If both `Width` and `Height` are not 0, the custom resolution will be used.</li>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of the height (or short side) of a video stream in px. Value range: 0 and [128, 4,096].
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Interval between I-frames (keyframes), which can be customized in frames or seconds. GOP value range: 0 and [1, 100000].
        /// If this parameter is 0, the system will automatically set the GOP length.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// GOP value unit. Optional values: 
        /// frame: indicates frame 
        /// second: indicates second
        /// Default value: frame
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// Filling mode. When the configured aspect ratio parameter for video streams differs from the aspect ratio of the original video, the processing method for transcoding is "filling". Optional filling modes:
        ///  <li>stretch: Each frame is stretched to fill the entire screen, which may cause the transcoded video to be "flattened" or "stretched".</li>
        /// <li>black: The aspect ratio of the video is kept unchanged, and the rest of the edges is filled with black.</li>
        /// <li>white: The aspect ratio of the video is kept unchanged, and the rest of the edges is filled with white.</li>
        /// <li>gauss: The aspect ratio of the video is kept unchanged, and the rest of the edges is filled with a Gaussian blur.</li>
        /// 
        /// <li>smarttailor: Video images are smartly selected to ensure proportional image cropping.</li>
        /// Default value: black.
        /// 
        /// Note: Only stretch and black are supported for adaptive bitrate streaming.
        /// 
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Control factor for constant video bitrate. Value range: [0, 51] and 100.
        /// It is recommended not to specify this parameter if there are no special requirements.
        /// 
        /// Note:
        /// When you need to set it to auto, fill in 100.
        /// If Mode is set to ABR, the Vcrf value does not need to be configured.
        /// If Mode is set to CBR, the Vcrf value does not need to be configured.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// Whether to enable adaptive encoding. Valid values:
        /// <li>0: Disable</li>
        /// <li>1: Enable</li>
        /// Default value: 0. If this parameter is set to `1`, multiple streams with different resolutions and bitrates will be generated automatically. The highest resolution, bitrate, and quality of the streams are determined by the values of `width` and `height`, `Bitrate`, and `Vcrf` in `VideoTemplate` respectively. If these parameters are not set in `VideoTemplate`, the highest resolution generated will be the same as that of the source video, and the highest video quality will be close to VMAF 95. To use this parameter or learn about the billing details of adaptive encoding, please contact your sales rep.
        /// </summary>
        [JsonProperty("ContentAdaptStream")]
        public ulong? ContentAdaptStream{ get; set; }

        /// <summary>
        /// Average segment duration. Value range: (0-10], unit: second
        /// Default value: 10
        /// Note: It is used only in the format of HLS.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("HlsTime")]
        public ulong? HlsTime{ get; set; }

        /// <summary>
        /// HLS segment type. Valid values:
        /// <li>0: HLS+TS segment.</li>
        /// <li>2: HLS+TS byte range.</li>
        /// <li>7: HLS+MP4 segment.</li>
        /// <li>5: HLS+MP4 byte range.</li>
        /// Default value: 0
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentType")]
        public long? SegmentType{ get; set; }

        /// <summary>
        /// Denominator of the frame rate.
        /// Note: The value must be greater than 0.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }

        /// <summary>
        /// 3D video splicing mode, which is only valid for MV-HEVC 3D videos. Valid values:
        /// <li>side_by_side: side-by-side view.</li>
        /// <li>top_bottom: top-bottom view.</li>
        /// Default value: side_by_side.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Stereo3dType")]
        public string Stereo3dType{ get; set; }

        /// <summary>
        /// Profile, suitable for different scenarios. 
        /// baseline: It only supports I/P-frames and non-interlaced scenarios, and is suitable for scenarios such as video calls and mobile videos. 
        /// main: It offers I-frames, P-frames, and B-frames, and supports both interlaced and non-interlaced modes. It is mainly used in mainstream audio and video consumption products such as video players and streaming media transmission devices. 
        /// high: the highest encoding level, with 8x8 prediction added to the main profile and support for custom quantification. It is widely used in scenarios such as Blu-ray storage and HDTV.
        /// default: automatic filling along with the original video
        /// 
        /// This configuration appears only when the encoding standard is set to H264. Default value: default
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("VideoProfile")]
        public string VideoProfile{ get; set; }

        /// <summary>
        /// Encoder level. Default value: auto ("")
        /// If the encoding standard is set to H264, the following options are supported: "", 1, 1.1, 1.2, 1.3, 2, 2.1, 2.2, 3, 3.1, 3.2, 4, 4.1, 4.2, 5, and 5.1. 
        /// If the encoding standard is set to H265, the following options are supported: "", 1, 2, 2.1, 3, 3.1, 4, 4.1, 5, 5.1, 5.2, 6, 6.1, 6.2, and 8.5.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("VideoLevel")]
        public string VideoLevel{ get; set; }

        /// <summary>
        /// Maximum number of consecutive B-frames. The default is auto, and 0 - 16 and -1 are supported.
        /// Note:
        /// 
        /// -1 indicates auto.	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// Bitrate control mode. Optional values: 
        /// VBR: variable bitrate. The output bitrate is adjusted based on the complexity of the video image, ensuring higher image quality. This mode is suitable for storage scenarios as well as applications with high image quality requirements. 
        /// ABR: average bitrate. The average bitrate of the output video is kept stable to the greatest extent, but short-term bitrate fluctuations are allowed. This mode is suitable for scenarios where it is necessary to minimize the overall bitrate while a certain quality is maintained. 
        /// CBR: constant bitrate. The output bitrate remains constant during the video encoding process, regardless of changes in image complexity. This mode is suitable for scenarios with strict network bandwidth requirements, such as live streaming. 
        /// VCRF: constant rate factor. The video quality is controlled by setting a quality factor, achieving constant quality encoding of videos. The bitrate is automatically adjusted based on the complexity of the content. This mode is suitable for scenarios where maintaining a certain quality is desired. 
        /// VBR is selected by default.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Display aspect ratio. Optional values: [1:1, 2:1, default]
        /// Default value: default
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Sar")]
        public string Sar{ get; set; }

        /// <summary>
        /// Adaptive I-frame decision. When it is enabled, Media Processing Service will automatically identify transition points between different scenarios in the video (usually they are visually distinct frames, such as those of switching from one shot to another) and adaptively insert keyframes (I-frames) at these points to improve the random accessibility and encoding efficiency of the video. Optional values: 
        /// 0: Disable the adaptive I-frame decision 
        /// 1: Enable the adaptive I-frame decision 
        /// Default value: 0	
        /// 	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NoScenecut")]
        public long? NoScenecut{ get; set; }

        /// <summary>
        /// Bit: 8/10 is supported. Default value: 8	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("BitDepth")]
        public long? BitDepth{ get; set; }

        /// <summary>
        /// Preservation of original timestamp. Optional values: 
        /// 0: Disabled 
        /// 1: Enabled 
        /// Default value: Disabled	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RawPts")]
        public long? RawPts{ get; set; }

        /// <summary>
        /// Proportional compression bitrate. When it is enabled, the bitrate of the output video will be adjusted according to the proportion. After the compression ratio is entered, the system will automatically calculate the target output bitrate based on the source video bitrate. Compression ratio range: 0-100, optional values: [0-100] and -1 
        /// Note: -1 indicates auto.	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Compress")]
        public long? Compress{ get; set; }

        /// <summary>
        /// Special segment configuration	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SegmentSpecificInfo")]
        public SegmentSpecificInfo SegmentSpecificInfo{ get; set; }

        /// <summary>
        /// Whether to enable scenario-based settings for the template 
        /// 0: disable 
        /// 1: enable 
        ///  
        /// Default value: 0	
        /// 	
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ScenarioBased")]
        public long? ScenarioBased{ get; set; }

        /// <summary>
        /// Video scenario. Optional values: 
        /// normal: General transcoding scenario: General transcoding and compression scenario
        /// pgc: PGC HD TV shows and movies: At the time of compression, focus is placed on the viewing experience of TV shows and movies and ROI encoding is performed according to their characteristics, while high-quality contents of videos and audio are retained. 
        /// materials_video: HD materials: Scenario involving material resources, where requirements for image quality are extremely high and there are many transparent images, with almost no visual loss during compression. 
        /// ugc: UGC content: It is suitable for a wide range of UGC/short video scenarios, with an optimized encoding bitrate for short video characteristics, improved image quality, and enhanced business QOS/QOE metrics. 
        /// e-commerce_video: Fashion show/e-commerce: At the time of compression, emphasis is placed on detail clarity and ROI enhancement, with a particular focus on maintaining the image quality of the face region. 
        /// educational_video: Education: At the time of compression, emphasis is placed on the clarity and readability of text and images to help students better understand the content, ensuring that the teaching content is clearly conveyed.
        /// Default value: normal
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// Transcoding policy. Optional values: 
        /// ultra_compress: Extreme compression: Compared to standard compression, this policy can maximize bitrate compression while ensuring a certain level of image quality, thus greatly saving bandwidth and storage costs. 
        /// standard_compress: Comprehensively optimal: The compression ratio and image quality are balanced, and files are compressed as much as possible without a noticeable reduction in subjective image quality. Only audio and video TSC transcoding fees are charged for this policy. 
        /// high_compress: Bitrate priority: Priority is given to reducing file size, which may result in certain image quality loss. Only audio and video TSC transcoding fees are charged for this policy. 
        /// low_compress: Image quality priority: Priority is given to ensuring image quality, and the size of compressed files may be relatively large. Only audio and video TSC transcoding fees are charged for this policy. 
        /// Default value: standard_compress 
        /// Note: If you need to watch videos on TV, it is recommended no to use the ultra_compress policy. The billing standard for the ultra_compress policy is TSC transcoding + audio and video enhancement - artifacts removal.
        /// Note: This field may return null, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "GopUnit", this.GopUnit);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
            this.SetParamSimple(map, prefix + "Vcrf", this.Vcrf);
            this.SetParamSimple(map, prefix + "ContentAdaptStream", this.ContentAdaptStream);
            this.SetParamSimple(map, prefix + "HlsTime", this.HlsTime);
            this.SetParamSimple(map, prefix + "SegmentType", this.SegmentType);
            this.SetParamSimple(map, prefix + "FpsDenominator", this.FpsDenominator);
            this.SetParamSimple(map, prefix + "Stereo3dType", this.Stereo3dType);
            this.SetParamSimple(map, prefix + "VideoProfile", this.VideoProfile);
            this.SetParamSimple(map, prefix + "VideoLevel", this.VideoLevel);
            this.SetParamSimple(map, prefix + "Bframes", this.Bframes);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Sar", this.Sar);
            this.SetParamSimple(map, prefix + "NoScenecut", this.NoScenecut);
            this.SetParamSimple(map, prefix + "BitDepth", this.BitDepth);
            this.SetParamSimple(map, prefix + "RawPts", this.RawPts);
            this.SetParamSimple(map, prefix + "Compress", this.Compress);
            this.SetParamObj(map, prefix + "SegmentSpecificInfo.", this.SegmentSpecificInfo);
            this.SetParamSimple(map, prefix + "ScenarioBased", this.ScenarioBased);
            this.SetParamSimple(map, prefix + "SceneType", this.SceneType);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
        }
    }
}

