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

namespace TencentCloud.Gme.V20180711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAppRequest : AbstractModel
    {
        
        /// <summary>
        /// Application name
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// Tencent Cloud project ID. Default value: 0, which means that the default project is used.
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// List of engines to be supported.
        /// Valid values: `android`, `ios`, `unity`, `cocos`, `unreal`, `windows`. All values are selected by default.
        /// </summary>
        [JsonProperty("EngineList")]
        public string[] EngineList{ get; set; }

        /// <summary>
        /// List of regions.
        /// Valid values: `mainland` (Chinese mainland), `hmt` (Hong Kong, Macao and Taiwan (China)), `sea` (Southeast Asia), `na` (North America), `eu` (Europe), `jpkr` (Japan, Korea and Asia Pacific), `sa` (South America), `oc` (Oceania), `me` (Middle East). All values are selected by default.
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// Configuration information of Voice Chat
        /// </summary>
        [JsonProperty("RealtimeSpeechConf")]
        public RealtimeSpeechConf RealtimeSpeechConf{ get; set; }

        /// <summary>
        /// Configuration information of Voice Messaging
        /// </summary>
        [JsonProperty("VoiceMessageConf")]
        public VoiceMessageConf VoiceMessageConf{ get; set; }

        /// <summary>
        /// Configuration information of Voice Analysis Service
        /// </summary>
        [JsonProperty("VoiceFilterConf")]
        public VoiceFilterConf VoiceFilterConf{ get; set; }

        /// <summary>
        /// Configuration information of Speech-to-Text
        /// </summary>
        [JsonProperty("AsrConf")]
        public AsrConf AsrConf{ get; set; }

        /// <summary>
        /// List of tags to be added
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "EngineList.", this.EngineList);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamObj(map, prefix + "RealtimeSpeechConf.", this.RealtimeSpeechConf);
            this.SetParamObj(map, prefix + "VoiceMessageConf.", this.VoiceMessageConf);
            this.SetParamObj(map, prefix + "VoiceFilterConf.", this.VoiceFilterConf);
            this.SetParamObj(map, prefix + "AsrConf.", this.AsrConf);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

