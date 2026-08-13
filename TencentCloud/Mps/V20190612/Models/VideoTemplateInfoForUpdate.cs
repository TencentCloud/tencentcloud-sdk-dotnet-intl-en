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

    public class VideoTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Encoding format for video streams. Optional values:
        /// <li>h264: H.264 encoding.</li>
        /// <li>h265: H.265 encoding.</li>
        /// <li>h266: H.266 encoding.</li>
        /// <li>av1: AOMedia Video 1 encoding</li>
        /// <li>vp8: VP8 encoding.</li>
        /// <li>vp9: VP9 encoding.</li>
        /// <li>mpeg2: MPEG2 encoding.</li>
        /// <li>dnxhd: DNxHD encoding.</li>
        /// <li>mv-hevc: MV-HEVC encoding.</li>
        /// 
        /// Note: The av1 encoding container currently only supports mp4, webm, and mkv.
        /// Note: H.266 encoding containers only support mp4, hls, ts, and mov.
        /// Note: VP8 and VP9 encoding containers currently only support webm and mkv.
        /// Note: MPEG2 and dnxhd encoding containers currently only support mxf.
        /// Note: The MV-HEVC codec currently only supports mp4, hls, and mov. Among them, the HLS format only supports the MP4 segmented format and requires the input source to be a panoramic video (with multiple views).
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Video frame rate. Value range:
        /// When FpsDenominator is empty, the range is [0, 120], in Hz.
        /// When FpsDenominator is not empty, the Fps/FpsDenominator range is [0, 120].
        /// If the value is 0, the frame rate will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Bitrate of video stream, value ranges from 0 to [128, 100000], measurement unit: kbps.
        /// If the value is 0, the bitrate of the video will be the same as that of the source video.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Resolution adaptation, available values:
        /// <li>open: Turn on. At this point, Width represents the long side of the video, and Height indicates the short side of the video;</li>
        /// <li>close: Close. At this point, Width represents the video width, and Height indicates the video height.</li>
        /// Note: In self-adaptation mode, Width cannot be less than Height.
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// Maximum value of the video stream width (or long edge) in px. Value range: 0 and [128, 4096].
        /// <li>If both Width and Height are 0, the resolution is the same as the source.</li>
        /// <li>If Width is 0 but Height is not 0, the width will be proportionally scaled.</li>
        /// <li>If Width is not 0 but Height is 0, the height will be proportionally scaled.</li>
        /// <li>If both Width and Height are not 0, the resolution is as specified by the user.</li>
        /// Note: If Codec is set to MV-HEVC, the maximum value can be 7680.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Maximum value of video stream height (or short side). Value ranges from 0 to [128, 4096]. Measurement unit: px.
        /// Note: If Codec is set to MV-HEVC, the maximum value can be 7680.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Interval between I-frames, customizable by frame or second. GOP length value ranges from 0 to [1, 100000].
        /// When set to 0, the system will automatically set the gop length.
        /// </summary>
        [JsonProperty("Gop")]
        public ulong? Gop{ get; set; }

        /// <summary>
        /// Gop value unit, value range: 
        /// frame: indicates frame 
        /// second: indicates second
        /// Default value: frame
        /// </summary>
        [JsonProperty("GopUnit")]
        public string GopUnit{ get; set; }

        /// <summary>
        /// Filling method, when video stream configuration width and height parameters are inconsistent with the aspect ratio of the original video, the processing method for transcoding is "padding". Optional filling mode:
        /// <li> stretch: Stretch, stretch each frame to fill the entire screen, possibly causing the transcoded video to be "squashed" or "stretched";</li>
        /// <li>black: Keep black, maintain video aspect ratio, edges filled with black.</li>
        /// <li>White: Leave blank, maintain video aspect ratio, edge remainder filled with white.</li>
        /// <li>gauss: Gaussian blur, maintain video aspect ratio, Gaussian blur filling for the rest of the edges.</li>
        /// <li>smarttailor: intelligent cropping. It smartly selects video images to ensure proportional image cropping.</li>
        /// Default value: black.
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }

        /// <summary>
        /// Control factor for constant video bitrate. Value range: [0, 51]. If this parameter is not specified, it means "auto". If there are no special requirements, it is advisable not to specify this parameter.
        /// When the Mode parameter is set to VBR, if the Vcrf value is configured at the same time, MPS processes video in VBR mode with consideration of both Vcrf and Bitrate parameter settings to balance video quality, bitrate, transcoding efficiency, and file size.
        /// When the Mode parameter is set to CRF, the Bitrate setting will become invalid, and encoding is performed based on the Vcrf value.
        /// When the Mode parameter is set to ABR or CBR, the Vcrf value requires no configuration.
        /// Note: When you need to set it to auto, fill in 100.
        /// </summary>
        [JsonProperty("Vcrf")]
        public ulong? Vcrf{ get; set; }

        /// <summary>
        /// Adaptive coding. Available values:
        /// <li>0: Not enabled</li>
        /// <li>1: Turn on</li>
        /// Default value: 0. When this parameter is enabled, multiple streams with different resolutions and bitrates will be self-adaptively generated. Among them, the width and height in VideoTemplate are the maximum resolution among the multiple streams, the bitrate in VideoTemplate is the highest bitrate among the multiple streams, and the vcrf in VideoTemplate is the highest quality among the multiple streams. When resolution, bitrate, and vcrf are not set, the highest resolution generated by the ContentAdaptStream parameter is the resolution of the video source, and the video quality is close to vmaf95. To enable this parameter or learn about billing details, contact your Tencent Cloud business.
        /// </summary>
        [JsonProperty("ContentAdaptStream")]
        public ulong? ContentAdaptStream{ get; set; }

        /// <summary>
        /// Average shard duration. Value range: (0-10], unit: second
        /// Default value: 10
        /// Note: It is used only in the HLS format.
        /// </summary>
        [JsonProperty("HlsTime")]
        public ulong? HlsTime{ get; set; }

        /// <summary>
        /// hls fragment type, available values:
        /// <li>0: HLS+TS segment.</li>
        /// <li>2:HLS+TS byte range</li>
        /// <li>7: HLS+MP4 segment.</li>
        /// <li>5:HLS+MP4 byte range</li>
        /// Default value: 0
        /// Note: This field is used for ordinary/TSC transcoding settings and does not take effect for adaptive bitrate streams. If needed, you can use the outer field to configure the shard type for adaptive bitrate streams.
        /// </summary>
        [JsonProperty("SegmentType")]
        public long? SegmentType{ get; set; }

        /// <summary>
        /// Denominator of the frame rate
        /// Note: The value must be greater than 0.
        /// </summary>
        [JsonProperty("FpsDenominator")]
        public long? FpsDenominator{ get; set; }

        /// <summary>
        /// 3D video splicing mode, only mv-hevc, takes effect for 3D video, available values:
        /// <li>side_by_side: side-by-side layout of the original video content.</li>
        /// <li>top_bottom: top-bottom layout arrangement of the original video content.</li>
        /// Billing is based on the segmented resolution dimension to report usage amount and cost.
        /// Default value: side_by_side
        /// </summary>
        [JsonProperty("Stereo3dType")]
        public string Stereo3dType{ get; set; }

        /// <summary>
        /// Profile, suitable for different scenarios. 
        /// baseline: It only supports I/P-frames and non-interlaced scenarios, and is suitable for scenarios such as video calls and mobile videos. 
        /// Mainstream Profile, providing I-frames, P-frames, and B-frames, and supporting both interlaced and non-interlaced modes. It is primarily used in mainstream audio and video consumption products such as video players and streaming media transmission devices. 
        /// high: The highest encoding level, adding 8X8 prediction to the Main Profile and supporting custom quantification. Widely used in Blu-ray storage and HDTV scenarios.
        /// default: automatic filling along with the original video
        /// 
        /// This configuration appears only when the encoding standard is set to H264. Default: default
        /// </summary>
        [JsonProperty("VideoProfile")]
        public string VideoProfile{ get; set; }

        /// <summary>
        /// Encoder level. Default value: auto ("")
        /// If the encoding standard is set to H264, the following options are supported: "", 1, 1.1, -1.2, 1.3, 2, 2.1, 2.2, 3, 3.1, 3.2, 4, 4.1, 4.2, 5, and 5.1. 
        /// If the encoding standard is set to H265, the following options are supported: "", 1, 2, 2.1, 3, 3.1, 4, 4.1, -5, 5.1, 5.2, 6, 6.1, 6.2, and 8.5.
        /// </summary>
        [JsonProperty("VideoLevel")]
        public string VideoLevel{ get; set; }

        /// <summary>
        /// Maximum number of consecutive B-frames. The default is auto, and 0 - 16 and -1 are supported.
        /// Note:
        /// -1 indicates auto.	
        /// </summary>
        [JsonProperty("Bframes")]
        public long? Bframes{ get; set; }

        /// <summary>
        /// Bitrate control mode. Optional values: 
        /// VBR (Variable Bit Rate): Dynamic bitrate adjusts the output bitrate based on the complexity of the video image to ensure higher image quality. It is suitable for storage scenarios and applications with high image quality requirements. 
        /// ABR (Average Bit Rate): Average bitrate. It aims to keep the average bitrate of the output video stable as much as possible, but allows short-term bitrate fluctuation. It is suitable for scenarios where you need to minimize overall bitrate while maintaining a certain image quality. 
        /// CBR (Constant Bit Rate): Constant bit rate. In video encoding, it maintains a constant output bitrate regardless of image complexity changes. It is suitable for scenarios with strict network bandwidth requirements, such as live streaming. 
        /// VCRF (Constant Rate Factor): Constant quality factor. It controls video quality by setting a quality factor to achieve constant quality encoding of videos. Bitrate adjustment based on content complexity. Suitable for scenarios where maintaining a certain quality is desired. 
        /// VBR is selected by default.
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// Display aspect ratio. Optional values: [1:1, 2:1, default]
        /// Default value: default
        /// </summary>
        [JsonProperty("Sar")]
        public string Sar{ get; set; }

        /// <summary>
        /// Adaptive I-frame decision. When enabled, Media Processing Service automatically identifies transition points between different scenarios in the video (usually visually distinct frames, such as those of switching from one shot to another) and adaptively inserts keyframes (I-frames) at these points to improve the video's random accessibility and encoding efficiency. Optional values: 
        /// 0: Disable adaptive I-frame decision 
        /// 1: Enable the adaptive I-frame decision 
        /// Default value: 0	
        /// </summary>
        [JsonProperty("NoScenecut")]
        public long? NoScenecut{ get; set; }

        /// <summary>
        /// Bit: 8/10 is supported. Default value: -	
        /// </summary>
        [JsonProperty("BitDepth")]
        public long? BitDepth{ get; set; }

        /// <summary>
        /// Preserve original timestamp. Optional values: 
        /// 0: Disabled 
        /// 1: Enabled 
        /// Default value: Disabled	
        /// </summary>
        [JsonProperty("RawPts")]
        public long? RawPts{ get; set; }

        /// <summary>
        /// Proportional compression bitrate. When enabled, the output video's bitrate is adjusted according to the specified ratio. After the compression ratio is entered, the system automatically calculates the target output bitrate based on the video source bitrate. Compression ratio range: 0-100, optional values: [0-100] and -1. 
        /// Note: -1 indicates auto.	
        /// </summary>
        [JsonProperty("Compress")]
        public long? Compress{ get; set; }

        /// <summary>
        /// Segment Duration at Startup
        /// </summary>
        [JsonProperty("SegmentSpecificInfo")]
        public SegmentSpecificInfo SegmentSpecificInfo{ get; set; }

        /// <summary>
        /// Whether to enable scenario-based settings for the template 
        /// 0: disable 
        /// 1: enable 
        /// Default value: 0	
        /// Note: SceneType and CompressType field values are effective only when this field value is 1.
        /// </summary>
        [JsonProperty("ScenarioBased")]
        public long? ScenarioBased{ get; set; }

        /// <summary>
        /// Video scenario. Optional values: 
        /// normal: General transcoding scenario: General transcoding and compression scenario. pgc: PGC HD TV shows and movies: At the time of compression, focus is placed on the viewing experience of TV shows and movies and ROI encoding is performed according to their characteristics, while high-quality contents of videos and audio are retained. 
        /// materials_video: HD materials: Scenario involving material resources, where requirements for image quality are extremely high and there are many transparent images, with almost no visual loss during compression. 
        /// ugc: UGC content: Suitable for a wide range of UGC/short video scenarios, with optimized encoding bitrate for short video characteristics, image quality improvement, and enhanced business QOS/QOE metrics. 
        /// e-commerce_video: Fashion show/e-commerce: During compression, emphasis is placed on detail clarity and ROI enhancement, with a particular focus on maintaining the image quality of the face region. 
        /// educational_video: Education: Compression emphasizes clarity and readability of text and images to help students better understand content and ensure clear conveyance of teaching content.
        /// Default value: normal.
        /// Note: To use this value, ScenarioBased must be 1, otherwise it does not take effect.
        /// </summary>
        [JsonProperty("SceneType")]
        public string SceneType{ get; set; }

        /// <summary>
        /// Transcoding policy. Optional values: 
        /// ultra_compress: Extreme compression: Compared to standard compression, this policy can maximize bitrate compression while ensuring a certain level of image quality, thus greatly saving bandwidth and storage costs. 
        /// standard_compress: Comprehensively optimal: The compression ratio and image quality are balanced, and files are compressed as much as possible without a noticeable reduction in subjective image quality. Only audio and video TSC transcoding fees are charged for the policy. 
        /// high_compress: Bitrate priority: Priority is given to reducing file size, which may result in certain image quality loss. Only audio and video TSC transcoding fees are charged for this policy. 
        /// low_compress: Image quality priority: Priority is given to ensuring image quality, and the size of the compressed file may be relatively large. Only audio and video Top Speed Codec transcoding fees are charged for this policy. 
        /// Default value: standard_compress. 
        /// Note: To watch videos on TV, the ultra_compress policy is not recommended. The billing standard for the ultra_compress policy is TSC transcoding + audio/video enhancement - artifacts removal.
        /// Note: To use this value, ScenarioBased must be 1, otherwise it does not take effect.
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

