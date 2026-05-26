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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentConfig : AbstractModel
    {
        
        /// <summary>
        /// The robot's UserId is used to enter a room and initiate a task. note that this UserId cannot be duplicated with the host or audience [UserId](https://www.tencentcloud.com/document/product/647/46351?from_cn_redirect=1#UserId) in the current room. if multiple tasks are initiated in a room, the robot's UserId cannot be mutually duplicated. otherwise, the previous task will be interrupted. ensure the robot's UserId is unique in the room.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Signature verification corresponding to the chatbot's UserId, namely, the UserId and UserSig serve as the login password for the chatbot to enter the room. for specific calculation methods, see TRTC solution for calculating.
        /// </summary>
        [JsonProperty("UserSig")]
        public string UserSig{ get; set; }

        /// <summary>
        /// UserId for robot stream pulling. after fill, the robot performs stream pulling and processes in real time.
        /// </summary>
        [JsonProperty("TargetUserId")]
        public string TargetUserId{ get; set; }

        /// <summary>
        /// Exceeding MaxIdleTime in the room with no streaming automatically shuts down the backend task. default value is 60s.
        /// </summary>
        [JsonProperty("MaxIdleTime")]
        public ulong? MaxIdleTime{ get; set; }

        /// <summary>
        /// Robot'S greeting.
        /// </summary>
        [JsonProperty("WelcomeMessage")]
        public string WelcomeMessage{ get; set; }

        /// <summary>
        /// Intelligent interruption mode, defaults to 0. 0 means server-side automatic interruption. 1 means the server does not interrupt, and the client sends an interruption signal to perform interruption.
        /// </summary>
        [JsonProperty("InterruptMode")]
        public ulong? InterruptMode{ get; set; }

        /// <summary>
        /// Used when InterruptMode is 0, in milliseconds, defaults to 500ms. indicates the server will interrupt when it detects continuous voice for InterruptSpeechDuration milliseconds.
        /// </summary>
        [JsonProperty("InterruptSpeechDuration")]
        public ulong? InterruptSpeechDuration{ get; set; }

        /// <summary>
        /// Controls the trigger mode for a new dialogue. default is 0.
        /// -0 means a new dialogue is automatically triggered when the server detects a complete sentence through automatic speech recognition.
        /// -1 indicates the client determines whether to manually send a chat signaling trigger for a new dialogue upon receiving the caption message.
        /// </summary>
        [JsonProperty("TurnDetectionMode")]
        public ulong? TurnDetectionMode{ get; set; }

        /// <summary>
        /// Whether to filter out sentences where the user only says one word. true indicates filtering, false indicates no filtering. default value is true.
        /// </summary>
        [JsonProperty("FilterOneWord")]
        public bool? FilterOneWord{ get; set; }

        /// <summary>
        /// Welcome message priority. valid values: 0 (default), 1 (high priority). high priority messages cannot be interrupted.
        /// </summary>
        [JsonProperty("WelcomeMessagePriority")]
        public ulong? WelcomeMessagePriority{ get; set; }

        /// <summary>
        /// For filtering LLM return content, do not play the content in brackets.
        /// Chinese bracket ().
        /// 2: english parentheses.
        /// 3: chinese square brackets [].
        /// 4: english square brackets [].
        /// 5: english curly braces {}.
        /// Empty by default, means no filtering.
        /// </summary>
        [JsonProperty("FilterBracketsContent")]
        public ulong? FilterBracketsContent{ get; set; }

        /// <summary>
        /// Ambient sound settings.
        /// </summary>
        [JsonProperty("AmbientSound")]
        public AmbientSound AmbientSound{ get; set; }

        /// <summary>
        /// Voiceprint configuration.
        /// </summary>
        [JsonProperty("VoicePrint")]
        public VoicePrint VoicePrint{ get; set; }

        /// <summary>
        /// Semantic sentence segmentation detection.
        /// </summary>
        [JsonProperty("TurnDetection")]
        public TurnDetection TurnDetection{ get; set; }

        /// <summary>
        /// Robot subtitle display mode.
        /// -0 means display as soon as possible without synchronizing with audio playback. at this point, subtitles are fully delivered, and subsequent subtitles will include previous ones.
        /// -1 indicates sentence-level real-time display, which synchronizes with audio playback. only when the current sentence's corresponding audio playback is complete will the next subtitle be delivered. at this point, subtitles are delivered incrementally, and the terminal needs to concatenate the leading and trailing subtitles to form a complete subtitle.
        /// </summary>
        [JsonProperty("SubtitleMode")]
        public ulong? SubtitleMode{ get; set; }

        /// <summary>
        /// Interruption word list. during AI speaking, only speak words in the list to interrupt AI speaking.
        /// Note: interrupt words avoid triggering AI reply.
        /// </summary>
        [JsonProperty("InterruptWordList")]
        public string[] InterruptWordList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "UserSig", this.UserSig);
            this.SetParamSimple(map, prefix + "TargetUserId", this.TargetUserId);
            this.SetParamSimple(map, prefix + "MaxIdleTime", this.MaxIdleTime);
            this.SetParamSimple(map, prefix + "WelcomeMessage", this.WelcomeMessage);
            this.SetParamSimple(map, prefix + "InterruptMode", this.InterruptMode);
            this.SetParamSimple(map, prefix + "InterruptSpeechDuration", this.InterruptSpeechDuration);
            this.SetParamSimple(map, prefix + "TurnDetectionMode", this.TurnDetectionMode);
            this.SetParamSimple(map, prefix + "FilterOneWord", this.FilterOneWord);
            this.SetParamSimple(map, prefix + "WelcomeMessagePriority", this.WelcomeMessagePriority);
            this.SetParamSimple(map, prefix + "FilterBracketsContent", this.FilterBracketsContent);
            this.SetParamObj(map, prefix + "AmbientSound.", this.AmbientSound);
            this.SetParamObj(map, prefix + "VoicePrint.", this.VoicePrint);
            this.SetParamObj(map, prefix + "TurnDetection.", this.TurnDetection);
            this.SetParamSimple(map, prefix + "SubtitleMode", this.SubtitleMode);
            this.SetParamArraySimple(map, prefix + "InterruptWordList.", this.InterruptWordList);
        }
    }
}

