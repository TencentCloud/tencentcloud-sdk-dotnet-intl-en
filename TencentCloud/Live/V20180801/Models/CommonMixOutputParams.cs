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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CommonMixOutputParams : AbstractModel
    {
        
        /// <summary>
        /// Output stream name.
        /// </summary>
        [JsonProperty("OutputStreamName")]
        public string OutputStreamName{ get; set; }

        /// <summary>
        /// Output stream type. Valid values: [0,1].
        /// If this parameter is left empty, 0 will be used by default.
        /// If the output stream is a stream in the input stream list, enter 0.
        /// If you want the stream mix result to be a new stream, enter 1.
        /// If this value is 1, `output_stream_id` cannot appear in `input_stram_list`, and there cannot be a stream with the same ID on the LVB backend.
        /// </summary>
        [JsonProperty("OutputStreamType")]
        public long? OutputStreamType{ get; set; }

        /// <summary>
        /// Output stream bitrate. Value range: [1,50000].
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputStreamBitRate")]
        public long? OutputStreamBitRate{ get; set; }

        /// <summary>
        /// Output stream GOP size. Value range: [1,10].
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputStreamGop")]
        public long? OutputStreamGop{ get; set; }

        /// <summary>
        /// Output stream frame rate. Value range: [1,60].
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputStreamFrameRate")]
        public long? OutputStreamFrameRate{ get; set; }

        /// <summary>
        /// Output stream audio bitrate. Value range: [1,500]
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputAudioBitRate")]
        public long? OutputAudioBitRate{ get; set; }

        /// <summary>
        /// Output stream audio sample rate. Valid values: [96000, 88200, 64000, 48000, 44100, 32000,24000, 22050, 16000, 12000, 11025, 8000].
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputAudioSampleRate")]
        public long? OutputAudioSampleRate{ get; set; }

        /// <summary>
        /// Output stream audio sound channel. Valid values: [1,2].
        /// If this parameter is left empty, the system will automatically determine.
        /// </summary>
        [JsonProperty("OutputAudioChannels")]
        public long? OutputAudioChannels{ get; set; }

        /// <summary>
        /// SEI information in output stream. If there are no special needs, leave it empty.
        /// </summary>
        [JsonProperty("MixSei")]
        public string MixSei{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputStreamName", this.OutputStreamName);
            this.SetParamSimple(map, prefix + "OutputStreamType", this.OutputStreamType);
            this.SetParamSimple(map, prefix + "OutputStreamBitRate", this.OutputStreamBitRate);
            this.SetParamSimple(map, prefix + "OutputStreamGop", this.OutputStreamGop);
            this.SetParamSimple(map, prefix + "OutputStreamFrameRate", this.OutputStreamFrameRate);
            this.SetParamSimple(map, prefix + "OutputAudioBitRate", this.OutputAudioBitRate);
            this.SetParamSimple(map, prefix + "OutputAudioSampleRate", this.OutputAudioSampleRate);
            this.SetParamSimple(map, prefix + "OutputAudioChannels", this.OutputAudioChannels);
            this.SetParamSimple(map, prefix + "MixSei", this.MixSei);
        }
    }
}

