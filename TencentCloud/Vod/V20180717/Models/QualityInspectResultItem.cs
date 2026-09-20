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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QualityInspectResultItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Exception type. Value range:</p><li>Jitter: jitter;</li><li>Blur: blurry;</li><li>LowLighting: low illumination;</li><li>HighLighting: overexposure;</li><li>CrashScreen: screen glitch;</li><li>BlackWhiteEdge: black and white edges;</li><li>SolidColorScreen: solid color screen;</li><li>Noise: noise;</li><li>Mosaic: mosaic;</li><li>QRCode: QR code;</li><li>AppletCode: mini program code;</li><li>BarCode: barcode;</li><li>LowVoice: low voice;</li><li>HighVoice: high voice;</li><li>NoVoice: mute;</li><li>LowEvaluation: no reference scoring below threshold.</li><li> LowColorfulness: color richness info.</li><li> AudioVideoAsync: audio and video synchronization issues.</li><li> AudioSubtitleAsync: audio and subtitle synchronization issues.</li><li> VideoAesthetic: low video aesthetic score.</li><li> AudioDiscontinuity: discontinuous audio.</li><li> AudioVolume: volume information.</li><li> AudioLoudnessJitter: severe volume change.</li><li> BackgroundMusic: background music exists.</li><li> AudioEvaluation: poor bass quality.</li><li> AudioNoise: noise.</li><li> AudioSpeechQuality: low speech definition.</li><li> AudioReverb: high reverberation level.</li><li> AudioHighLoudness: loudness distortion.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>Abnormal fragment list.<br><font color="red">Note:</font> This list can only display up to the first 100 elements. To obtain the complete result, get it from the file corresponding to SegmentSetFileUrl.</p>
        /// </summary>
        [JsonProperty("SegmentSet")]
        public QualityInspectItem[] SegmentSet{ get; set; }

        /// <summary>
        /// <p>URL of the abnormal fragment list file. The file content is in JSON format, and its data structure is consistent with the fields of SegmentSet. (The file will not be retained permanently. It will be deleted after reaching the SegmentSetFileUrlExpireTime time point.)</p>
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// <p>Expiration time of the URL of the exception segment list file, in <a href="https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I">ISO date format</a>.</p>
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

