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

    public class QualityControlItemConfig : AbstractModel
    {
        
        /// <summary>
        /// Quality control item name. The quality control item values are as follows:
        /// <li>LowEvaluation: No reference score.</li>
        /// <li>Mosaic: Mosaic detection.</li>
        /// <li>CrashScreen: Screen crash detection.</li>
        /// <li>Blur: Blur detection.</li>
        /// <li>BlackWhiteEdge: Black and white edge detection.</li>
        /// <li>SolidColorScreen: Solid color screen detection.</li>
        /// <li>LowLighting: Low lighting.</li>
        /// <li>HighLighting: Overexposure.</li>
        /// <li>NoVoice: Silence detection.</li>
        /// <li>LowVoice: Low voice detection.</li>
        /// <li>HighVoice: High voice detection.</li>
        /// <li>Jitter: Jitter detection.</li>
        /// <li>Noise: Noise detection.</li>
        /// <li>QRCode: QR code detection.</li>
        /// <li>BarCode: Barcode detection.</li>
        /// <li>AppletCode: Applet code detection.</li>
        /// <li>VideoResolutionChanged: The video resolution changed.</li>
        /// <li>AudioSampleRateChanged: The audio sampling rate changed.</li>
        /// <li>AudioChannelsChanged: The audio channel count changed.</li>
        /// <li>ParameterSetsChanged: The stream parameter set information changed.</li>
        /// <li>DarOrSarInvalid: Abnormal video aspect ratio.</li>
        /// <li>TimestampFallback: DTS timestamp fallback.</li>
        /// <li>DtsJitter: Excessive DTS jitter.</li>
        /// <li>PtsJitter: Excessive PTS jitter.</li>
        /// <li>AACDurationDeviation: Unreasonable AAC frame timestamp interval.</li>
        /// <li>AudioDroppingFrames: Audio frame loss.</li>
        /// <li>VideoDroppingFrames: Video frame loss.</li>
        /// <li>AVTimestampInterleave: Unreasonable audio and video interleaving.</li>
        /// <li>PtsLessThanDts: The PTS of media streams is less than DTS.</li>
        /// <li>ReceiveFpsJitter: Excessive jitter of the frame rate received by the network.</li>
        /// <li>ReceiveFpsTooSmall: Too low video frame rate received by the network.</li>
        /// <li>FpsJitter: Excessive stream frame rate jitter calculated through PTS.</li>
        /// <li>StreamOpenFailed: Stream opening failed.</li>
        /// <li>StreamEnd: The stream ended.</li>
        /// <li>StreamParseFailed: Stream parsing failed.</li>
        /// <li>VideoFirstFrameNotIdr: The first frame is not an IDR frame.</li>
        /// <li>StreamNALUError: NALU start code error.</li>
        /// <li>TsStreamNoAud: The H26x stream of MPEGTS lacks AUD NALU.</li>
        /// <li>AudioStreamLack: No audio stream.</li>
        /// <li>VideoStreamLack: No video stream.</li>
        /// <li>LackAudioRecover: Lack of audio stream recovery.</li>
        /// <li>LackVideoRecover: Lack of video stream recovery.</li>
        /// <li>VideoBitrateOutofRange: Out-of-range video stream bitrate (kbps).</li>
        /// <li>AudioBitrateOutofRange: Out-of-range audio stream bitrate (kbps).</li>
        /// <li>VideoDecodeFailed: Video decoding error.</li>
        /// <li>AudioDecodeFailed: Audio decoding error.</li>
        /// <li>AudioOutOfPhase: Opposite phase in Dual-channel audio.</li>
        /// <li>VideoDuplicatedFrame: Duplicate frames in the video stream.</li>
        /// <li>AudioDuplicatedFrame: Duplicate frames in the audio stream.</li>
        /// <li>VideoRotation: Video image rotation.</li>
        /// <li>TsMultiPrograms: The MPEG2-TS stream has multiple programs.</li>
        /// <li>Mp4InvalidCodecFourcc: The codec fourcc in MP4 does not meet Apple HLS requirements.</li>
        /// <li>HLSBadM3u8Format: Invalid m3u8 file.</li>
        /// <li>HLSInvalidMasterM3u8: Invalid main m3u8 file.</li>
        /// <li>HLSInvalidMediaM3u8: Invalid media m3u8 file.</li>
        /// <li>HLSMasterM3u8Recommended: The main m3u8 file lacks parameters recommended by the standard.</li>
        /// <li>HLSMediaM3u8Recommended: The media m3u8 file lacks parameters recommended by the standard.</li>
        /// <li>HLSMediaM3u8DiscontinuityExist: EXT-X-DISCONTINUITY exists in the media m3u8 file.</li>
        /// <li>HLSMediaSegmentsStreamNumChange: The number of streams in the segment has changed.</li>
        /// <li>HLSMediaSegmentsPTSJitterDeviation: PTS jitter between segments without EXT-X-DISCONTINUITY.</li>
        /// <li>HLSMediaSegmentsDTSJitterDeviation: DTS jitter between segments without EXT-X-DISCONTINUITY.</li>
        /// <li>TimecodeTrackExist: TMCD track in MP4.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Capability configuration switch. Valid values:
        /// <li>ON: enabled;</li>
        /// <li>OFF: disabled.</li>
        /// 
        /// Default value: ON.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Sampling method, Valid value:
        /// - Time: sampling based on time interval.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Sampling")]
        public string Sampling{ get; set; }

        /// <summary>
        /// Sampling interval time, in ms.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IntervalTime")]
        public ulong? IntervalTime{ get; set; }

        /// <summary>
        /// Duration of abnormality, in ms.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Threshold of a detection item. Different detection items have different thresholds.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Threshold")]
        public string Threshold{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Sampling", this.Sampling);
            this.SetParamSimple(map, prefix + "IntervalTime", this.IntervalTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
        }
    }
}

