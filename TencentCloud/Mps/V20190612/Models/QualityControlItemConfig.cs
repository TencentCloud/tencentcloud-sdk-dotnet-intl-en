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

    public class QualityControlItemConfig : AbstractModel
    {
        
        /// <summary>
        /// Quality inspection item name. valid values:.
        /// <li>LowEvaluation: specifies the no-reference MOS score of the video.</li>.
        /// <li>AudioEvaluation: specifies the no-reference MOS score of the audio.</li>.
        /// <Li>Mosaic: mosaic detection.</li>.
        /// <Li>CrashScreen: specifies screen glitch detection.</li>.
        /// <Li>Blur: specifies blur detection.</li>.
        /// <Li>Jitter: jitter detection.</li>.
        /// <Li>Noise: noise detection.</li>.
        /// <Li>QRCode: qr code detection.</li>.
        /// <Li>BarCode: specifies barcode detection.</li>.
        /// <Li>AppletCode: specifies mini program code detection.</li>.
        /// <Li>BlackWhiteEdge: specifies black and white edge detection.</li>.
        /// <Li>SolidColorScreen: specifies solid color screen detection.</li>.
        /// <Li>LowLighting: specifies low light.</li>.
        /// <Li>HighLighting: overexposure.</li>.
        /// <Li>NoVoice: specifies silence detection.</li>.
        /// <Li>LowVoice: specifies bass detection.</li>.
        /// <Li>HighVoice: explosion noise detection.</li>.
        /// <Li>AudioNoise: specifies audio noise detection.</li>.
        /// <Li>VideoResolutionChanged: specifies the video resolution change.</li>.
        /// <Li>AudioSampleRateChanged: specifies the audio sample rate change.</li>.
        /// <Li>AudioChannelsChanged: indicates the audio channel quantity change.</li>.
        /// <Li>ParameterSetsChanged: indicates the stream parameter set information has changed.</li>.
        /// <Li>DarOrSarInvalid: indicates an abnormal video aspect ratio.</li>.
        /// <li>TimestampFallback: specifies DTS timestamp rollback.</li>.
        /// <li>DtsJitter: specifies excessive DTS jitter.</li>.
        /// <li>PtsJitter: indicates excessive PTS jitter.</li>.
        /// <Li>AACDurationDeviation: specifies an improper aac frame timestamp interval.</li>.
        /// <Li>AudioDroppingFrames: indicates audio frame dropping.</li>.
        /// <Li>VideoDroppingFrames: specifies video frame dropping.</li>.
        /// <Li>AVTimestampInterleave: improper audio-video interleaving.</li>.
        /// <Li>PtsLessThanDts: specifies that the pts of the media stream is less than the dts.</li>.
        /// <Li>ReceiveFpsJitter: specifies excessive jitter in the network received frame rate.</li>.
        /// <Li>ReceiveFpsTooSmall: indicates the network received video frame rate is too low.</li>.
        /// <li>FpsJitter: specifies excessive jitter in the stream frame rate calculated via PTS.</li>.
        /// <Li>StreamOpenFailed: indicates the stream open failure.</li>.
        /// <Li>StreamEnd: specifies the stream end.</li>.
        /// <Li>StreamParseFailed: specifies the stream parsing failure.</li>.
        /// <li>VideoFirstFrameNotIdr: first frame not an IDR frame.</li>.
        /// <Li>StreamNALUError: indicates an nalu start code error.</li>.
        /// <li>TsStreamNoAud: specifies whether the mpegts H26x stream misses AUD NALU.</li>.
        /// <Li>AudioStreamLack: no audio stream.</li>.
        /// <Li>VideoStreamLack: no video stream.</li>.
        /// <Li>LackAudioRecover: specifies missing audio stream recovery.</li>.
        /// <Li>LackVideoRecover: missing video stream recovery.</li>.
        /// <Li>VideoBitrateOutofRange: video stream bitrate (kbps) out of range.</li>.
        /// <Li>AudioBitrateOutofRange: audio stream bitrate (kbps) out of range.</li>.
        /// <Li>VideoDecodeFailed: indicates a video decoding error.</li>.
        /// <Li>AudioDecodeFailed: audio decoding error.</li>.
        /// <Li>AudioOutOfPhase: specifies opposite phase in dual-channel audio.</li>.
        /// <Li>VideoDuplicatedFrame: indicates duplicate frames in video streams.</li>.
        /// <Li>AudioDuplicatedFrame: indicates duplicate frames in audio streams.</li>.
        /// <Li>VideoRotation: specifies video rotation.</li>.
        /// <li>TsMultiPrograms: specifies multiple programs in MPEG2-TS streams.</li>.
        /// <li>Mp4InvalidCodecFourcc: specifies the codec fourcc in Mp4 does not meet Apple HLS requirements.</li>.
        /// <Li>HLSBadM3u8Format: invalid m3u8 file.</li>.
        /// <Li>HLSInvalidMasterM3u8: invalid main m3u8 file.</li>.
        /// <Li>HLSInvalidMediaM3u8: invalid media m3u8 file.</li>.
        /// <Li>HLSMasterM3u8Recommended: parameters recommended by standards missing in main m3u8.</li>.
        /// <Li>HLSMediaM3u8Recommended: parameters recommended by standards missing in media m3u8.</li>.
        /// <li>HLSMediaM3u8DiscontinuityExist: indicates the existence of EXT-X-DISCONTINUITY in media m3u8.</li>.
        /// <Li>HLSMediaSegmentsStreamNumChange: indicates the number of streams in segments changes.</li>.
        /// <li>HLSMediaSegmentsPTSJitterDeviation: indicates PTS jumps between segments without EXT-X-DISCONTINUITY.</li>.
        /// <li>HLSMediaSegmentsDTSJitterDeviation: indicates DTS jumps between segments without EXT-X-DISCONTINUITY.</li>.
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

