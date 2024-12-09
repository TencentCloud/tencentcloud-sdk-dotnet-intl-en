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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AVTemplate : AbstractModel
    {
        
        /// <summary>
        /// Name of an audio/video transcoding template, which can contain 1-20 case-sensitive letters and digits
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether video is needed. `0`: not needed; `1`: needed
        /// </summary>
        [JsonProperty("NeedVideo")]
        public ulong? NeedVideo{ get; set; }

        /// <summary>
        /// Video codec. Valid values: `H264`, `H265`. If this parameter is left empty, the original video codec will be used.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video width. Value range: (0, 3000]. The value must be an integer multiple of 4. If this parameter is left empty, the original video width will be used.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Video height. Value range: (0, 3000]. The value must be an integer multiple of 4. If this parameter is left empty, the original video height will be used.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Video frame rate. Value range: [1, 240]. If this parameter is left empty, the original frame rate will be used.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Whether to enable top speed codec transcoding. Valid values: `CLOSE` (disable), `OPEN` (enable). Default value: `CLOSE`
        /// </summary>
        [JsonProperty("TopSpeed")]
        public string TopSpeed{ get; set; }

        /// <summary>
        /// Compression ratio for top speed codec transcoding. Value range: [0, 50]. The lower the compression ratio, the higher the image quality.
        /// </summary>
        [JsonProperty("BitrateCompressionRatio")]
        public ulong? BitrateCompressionRatio{ get; set; }

        /// <summary>
        /// Whether audio is needed. `0`: not needed; `1`: needed
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// Audio encoding format, only `AAC` and `PASSTHROUGH` are available, with `AAC` as the default.
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Audio bitrate. If this parameter is left empty, the original bitrate will be used.
        /// Valid values: `6000`, `7000`, `8000`, `10000`, `12000`, `14000`, `16000`, `20000`, `24000`, `28000`, `32000`, `40000`, `48000`, `56000`, `64000`, `80000`, `96000`, `112000`, `128000`, `160000`, `192000`, `224000`, `256000`, `288000`, `320000`, `384000`, `448000`, `512000`, `576000`, `640000`, `768000`, `896000`, `1024000`
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Video bitrate. Value range: [50000, 40000000]. The value must be an integer multiple of 1000. If this parameter is left empty, the original bitrate will be used.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Bitrate control mode. Valid values: `CBR`, `ABR` (default), `VBR`.
        /// </summary>
        [JsonProperty("RateControlMode")]
        public string RateControlMode{ get; set; }

        /// <summary>
        /// Watermark ID
        /// </summary>
        [JsonProperty("WatermarkId")]
        public string WatermarkId{ get; set; }

        /// <summary>
        /// Whether to convert audio to text. `0` (default): No; `1`: Yes.
        /// </summary>
        [JsonProperty("SmartSubtitles")]
        public ulong? SmartSubtitles{ get; set; }

        /// <summary>
        /// The subtitle settings. Currently, the following subtitles are supported:
        /// `eng2eng`: English speech to English text.
        /// `eng2chs`: English speech to Chinese text. 
        /// `eng2chseng`: English speech to English and Chinese text. 
        /// `chs2chs`: Chinese speech to Chinese text.   
        /// `chs2eng`: Chinese speech to English text. 
        /// `chs2chseng`: Chinese speech to Chinese and English text.
        /// </summary>
        [JsonProperty("SubtitleConfiguration")]
        public string SubtitleConfiguration{ get; set; }

        /// <summary>
        /// Whether to enable the face blur function, 1 is on, 0 is off, and the default is 0.
        /// </summary>
        [JsonProperty("FaceBlurringEnabled")]
        public ulong? FaceBlurringEnabled{ get; set; }

        /// <summary>
        /// Only AttachedInputs.AudioSelectors.Name can be selected. The following types need to be filled in: 'RTP_PUSH', 'SRT_PUSH', 'UDP_PUSH', 'RTP-FEC_PUSH'.
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public string AudioSelectorName{ get; set; }

        /// <summary>
        /// Audio transcoding special configuration information.
        /// </summary>
        [JsonProperty("AudioNormalization")]
        public AudioNormalizationSettings AudioNormalization{ get; set; }

        /// <summary>
        /// Audio sampling rate, unit HZ.
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// This field indicates how to specify the output video frame rate. If FOLLOW_SOURCE is selected, the output video frame rate will be set equal to the input video frame rate of the first input. If SPECIFIED_FRACTION is selected, the output video frame rate is determined by the fraction (frame rate numerator and frame rate denominator). If SPECIFIED_HZ is selected, the frame rate of the output video is determined by the HZ you enter.
        /// </summary>
        [JsonProperty("FrameRateType")]
        public string FrameRateType{ get; set; }

        /// <summary>
        /// Valid when the FrameRateType type you select is SPECIFIED_FRACTION, the output frame rate numerator setting.
        /// </summary>
        [JsonProperty("FrameRateNumerator")]
        public ulong? FrameRateNumerator{ get; set; }

        /// <summary>
        /// Valid when the FrameRateType type you select is SPECIFIED_FRACTION, the output frame rate denominator setting.
        /// </summary>
        [JsonProperty("FrameRateDenominator")]
        public ulong? FrameRateDenominator{ get; set; }

        /// <summary>
        /// The number of B frames can be selected from 1 to 3.
        /// </summary>
        [JsonProperty("BFramesNum")]
        public ulong? BFramesNum{ get; set; }

        /// <summary>
        /// The number of reference frames can be selected from 1 to 16.
        /// </summary>
        [JsonProperty("RefFramesNum")]
        public ulong? RefFramesNum{ get; set; }

        /// <summary>
        /// Additional video bitrate configuration.
        /// </summary>
        [JsonProperty("AdditionalRateSettings")]
        public AdditionalRateSetting AdditionalRateSettings{ get; set; }

        /// <summary>
        /// Video encoding configuration.
        /// </summary>
        [JsonProperty("VideoCodecDetails")]
        public VideoCodecDetail VideoCodecDetails{ get; set; }

        /// <summary>
        /// Audio encoding configuration.
        /// </summary>
        [JsonProperty("AudioCodecDetails")]
        public AudioCodecDetail AudioCodecDetails{ get; set; }

        /// <summary>
        /// Whether to enable multiple audio tracks 0: Not required 1: Required Default value 0.
        /// </summary>
        [JsonProperty("MultiAudioTrackEnabled")]
        public ulong? MultiAudioTrackEnabled{ get; set; }

        /// <summary>
        /// Quantity limit 0-20 Valid when MultiAudioTrackEnabled is turned on.
        /// </summary>
        [JsonProperty("AudioTracks")]
        public AudioTrackInfo[] AudioTracks{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoEnhanceEnabled")]
        public ulong? VideoEnhanceEnabled{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("VideoEnhanceSettings")]
        public VideoEnhanceSetting[] VideoEnhanceSettings{ get; set; }

        /// <summary>
        /// Key frame interval, 300-10000, optional.
        /// </summary>
        [JsonProperty("GopSize")]
        public long? GopSize{ get; set; }

        /// <summary>
        /// Keyframe units, only support MILLISECONDS (milliseconds).
        /// </summary>
        [JsonProperty("GopSizeUnits")]
        public string GopSizeUnits{ get; set; }

        /// <summary>
        /// Color space setting.
        /// </summary>
        [JsonProperty("ColorSpaceSettings")]
        public ColorSpaceSetting ColorSpaceSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "TopSpeed", this.TopSpeed);
            this.SetParamSimple(map, prefix + "BitrateCompressionRatio", this.BitrateCompressionRatio);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "RateControlMode", this.RateControlMode);
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
            this.SetParamSimple(map, prefix + "SmartSubtitles", this.SmartSubtitles);
            this.SetParamSimple(map, prefix + "SubtitleConfiguration", this.SubtitleConfiguration);
            this.SetParamSimple(map, prefix + "FaceBlurringEnabled", this.FaceBlurringEnabled);
            this.SetParamSimple(map, prefix + "AudioSelectorName", this.AudioSelectorName);
            this.SetParamObj(map, prefix + "AudioNormalization.", this.AudioNormalization);
            this.SetParamSimple(map, prefix + "AudioSampleRate", this.AudioSampleRate);
            this.SetParamSimple(map, prefix + "FrameRateType", this.FrameRateType);
            this.SetParamSimple(map, prefix + "FrameRateNumerator", this.FrameRateNumerator);
            this.SetParamSimple(map, prefix + "FrameRateDenominator", this.FrameRateDenominator);
            this.SetParamSimple(map, prefix + "BFramesNum", this.BFramesNum);
            this.SetParamSimple(map, prefix + "RefFramesNum", this.RefFramesNum);
            this.SetParamObj(map, prefix + "AdditionalRateSettings.", this.AdditionalRateSettings);
            this.SetParamObj(map, prefix + "VideoCodecDetails.", this.VideoCodecDetails);
            this.SetParamObj(map, prefix + "AudioCodecDetails.", this.AudioCodecDetails);
            this.SetParamSimple(map, prefix + "MultiAudioTrackEnabled", this.MultiAudioTrackEnabled);
            this.SetParamArrayObj(map, prefix + "AudioTracks.", this.AudioTracks);
            this.SetParamSimple(map, prefix + "VideoEnhanceEnabled", this.VideoEnhanceEnabled);
            this.SetParamArrayObj(map, prefix + "VideoEnhanceSettings.", this.VideoEnhanceSettings);
            this.SetParamSimple(map, prefix + "GopSize", this.GopSize);
            this.SetParamSimple(map, prefix + "GopSizeUnits", this.GopSizeUnits);
            this.SetParamObj(map, prefix + "ColorSpaceSettings.", this.ColorSpaceSettings);
        }
    }
}

