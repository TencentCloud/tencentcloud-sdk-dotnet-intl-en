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
        /// Tencent Cloud project ID. Default value: 0, which means that the default project is used
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// List of engines to be supported. Valid values: android, ios, unity, cocos, unreal, windows. All values are selected by default.
        /// </summary>
        [JsonProperty("EngineList")]
        public string[] EngineList{ get; set; }

        /// <summary>
        /// List of service regions. Valid values: mainland (Mainland China), sa (South America), eu (Europe), oc (Australia), me (Middle East). All values are selected by default.
        /// </summary>
        [JsonProperty("RegionList")]
        public string[] RegionList{ get; set; }

        /// <summary>
        /// Configuration information of voice chat
        /// </summary>
        [JsonProperty("RealtimeSpeechConf")]
        public RealtimeSpeechConf RealtimeSpeechConf{ get; set; }

        /// <summary>
        /// Configuration information of voice messaging and speech-to-text
        /// </summary>
        [JsonProperty("VoiceMessageConf")]
        public VoiceMessageConf VoiceMessageConf{ get; set; }

        /// <summary>
        /// Configuration information of phrase analysis
        /// </summary>
        [JsonProperty("VoiceFilterConf")]
        public VoiceFilterConf VoiceFilterConf{ get; set; }

        /// <summary>
        /// List of tags to be added
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "EngineList.", this.EngineList);
            this.SetParamArraySimple(map, prefix + "RegionList.", this.RegionList);
            this.SetParamObj(map, prefix + "RealtimeSpeechConf.", this.RealtimeSpeechConf);
            this.SetParamObj(map, prefix + "VoiceMessageConf.", this.VoiceMessageConf);
            this.SetParamObj(map, prefix + "VoiceFilterConf.", this.VoiceFilterConf);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

