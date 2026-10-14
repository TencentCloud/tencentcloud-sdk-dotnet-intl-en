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

    public class AIDubbingTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>Path of subtitle file extracted from video.</p>
        /// </summary>
        [JsonProperty("OriginSubtitlePath")]
        public string OriginSubtitlePath{ get; set; }

        /// <summary>
        /// <p>Path of a subtitle translation file extracted from a video.</p>
        /// </summary>
        [JsonProperty("TranslateSubtitlePath")]
        public string TranslateSubtitlePath{ get; set; }

        /// <summary>
        /// <p>File URL of the video after voice type cloning</p>
        /// </summary>
        [JsonProperty("VoiceClonedVideo")]
        public string VoiceClonedVideo{ get; set; }

        /// <summary>
        /// <p>File address of the voice type clone annotation</p>
        /// </summary>
        [JsonProperty("VoiceClonedMarkFile")]
        public string VoiceClonedMarkFile{ get; set; }

        /// <summary>
        /// <p>Video output path.</p>
        /// </summary>
        [JsonProperty("VideoPath")]
        public string VideoPath{ get; set; }

        /// <summary>
        /// <p>FileId of the subtitle file extracted from video.</p>
        /// </summary>
        [JsonProperty("OriginSubtitleFileId")]
        public string OriginSubtitleFileId{ get; set; }

        /// <summary>
        /// <p>FileId of a subtitle translation file extracted from a video.</p>
        /// </summary>
        [JsonProperty("TranslateSubtitleFileId")]
        public string TranslateSubtitleFileId{ get; set; }

        /// <summary>
        /// <p>Tag file path.</p>
        /// </summary>
        [JsonProperty("SpeakerPath")]
        public string SpeakerPath{ get; set; }

        /// <summary>
        /// <p>Fileid of the tag file.</p>
        /// </summary>
        [JsonProperty("SpeakerFileId")]
        public string SpeakerFileId{ get; set; }

        /// <summary>
        /// <p>FileId of the video output after removal.</p>
        /// </summary>
        [JsonProperty("EraseVideoFileId")]
        public string EraseVideoFileId{ get; set; }

        /// <summary>
        /// <p>Erase video output path.</p>
        /// </summary>
        [JsonProperty("EraseVideoPath")]
        public string EraseVideoPath{ get; set; }

        /// <summary>
        /// <p>Dubbed audio file path of the translation.</p>
        /// </summary>
        [JsonProperty("DstAudioPath")]
        public string DstAudioPath{ get; set; }

        /// <summary>
        /// <p>FileId of the audio file for the translated dubbing.</p>
        /// </summary>
        [JsonProperty("DstAudioFileId")]
        public string DstAudioFileId{ get; set; }

        /// <summary>
        /// <p>Voice cloning editing information</p><p>Editing information for secondary modifications of voice cloning</p>
        /// </summary>
        [JsonProperty("DubbingEditInfoUrl")]
        public string DubbingEditInfoUrl{ get; set; }

        /// <summary>
        /// <p>Subtitle position after removal. <strong>Note</strong>: only applicable to subtitle extraction when return of subtitle position is enabled.</p>
        /// </summary>
        [JsonProperty("SubtitlePos")]
        public SubtitlePosition SubtitlePos{ get; set; }

        /// <summary>
        /// <p>Storage location of the output file of the AI dubbing task.</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public TaskOutputStorage OutputStorage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OriginSubtitlePath", this.OriginSubtitlePath);
            this.SetParamSimple(map, prefix + "TranslateSubtitlePath", this.TranslateSubtitlePath);
            this.SetParamSimple(map, prefix + "VoiceClonedVideo", this.VoiceClonedVideo);
            this.SetParamSimple(map, prefix + "VoiceClonedMarkFile", this.VoiceClonedMarkFile);
            this.SetParamSimple(map, prefix + "VideoPath", this.VideoPath);
            this.SetParamSimple(map, prefix + "OriginSubtitleFileId", this.OriginSubtitleFileId);
            this.SetParamSimple(map, prefix + "TranslateSubtitleFileId", this.TranslateSubtitleFileId);
            this.SetParamSimple(map, prefix + "SpeakerPath", this.SpeakerPath);
            this.SetParamSimple(map, prefix + "SpeakerFileId", this.SpeakerFileId);
            this.SetParamSimple(map, prefix + "EraseVideoFileId", this.EraseVideoFileId);
            this.SetParamSimple(map, prefix + "EraseVideoPath", this.EraseVideoPath);
            this.SetParamSimple(map, prefix + "DstAudioPath", this.DstAudioPath);
            this.SetParamSimple(map, prefix + "DstAudioFileId", this.DstAudioFileId);
            this.SetParamSimple(map, prefix + "DubbingEditInfoUrl", this.DubbingEditInfoUrl);
            this.SetParamObj(map, prefix + "SubtitlePos.", this.SubtitlePos);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
        }
    }
}

