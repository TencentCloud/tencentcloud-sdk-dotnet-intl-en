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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStreamLiveChannelRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel name, limited to lowercase letters, digits, and underscores, length [1, 32], unique in each Region.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Associated media input, limit on the number [1, 5].
        /// </summary>
        [JsonProperty("AttachedInputs")]
        public AttachedInput[] AttachedInputs{ get; set; }

        /// <summary>
        /// Configuration message of the output group for the channel. Limit on the number [1, 10].
        /// </summary>
        [JsonProperty("OutputGroups")]
        public StreamLiveOutputGroupsInfo[] OutputGroups{ get; set; }

        /// <summary>
        /// Audio transcoding template array, with the maximum number of [1, 20].
        /// </summary>
        [JsonProperty("AudioTemplates")]
        public AudioTemplateInfo[] AudioTemplates{ get; set; }

        /// <summary>
        /// Video transcoding template array, with the maximum number of [1, 10].
        /// </summary>
        [JsonProperty("VideoTemplates")]
        public VideoTemplateInfo[] VideoTemplates{ get; set; }

        /// <summary>
        /// Audio and video transcoding template array, with a limit on the number between 1 and 10.
        /// </summary>
        [JsonProperty("AVTemplates")]
        public AVTemplate[] AVTemplates{ get; set; }

        /// <summary>
        /// Subtitle template configuration is only valid for joint transcoding template.
        /// </summary>
        [JsonProperty("CaptionTemplates")]
        public SubtitleConf[] CaptionTemplates{ get; set; }

        /// <summary>
        /// Configuration message of the scheduled task.
        /// </summary>
        [JsonProperty("PlanSettings")]
        public PlanSettings PlanSettings{ get; set; }

        /// <summary>
        /// Callback configuration information.
        /// </summary>
        [JsonProperty("EventNotifySettings")]
        public EventNotifySetting EventNotifySettings{ get; set; }

        /// <summary>
        /// Complement the last video frame settings.
        /// </summary>
        [JsonProperty("InputLossBehavior")]
        public InputLossBehaviorInfo InputLossBehavior{ get; set; }

        /// <summary>
        /// Pipeline configuration.
        /// </summary>
        [JsonProperty("PipelineInputSettings")]
        public PipelineInputSettingsInfo PipelineInputSettings{ get; set; }

        /// <summary>
        /// Input content identification configuration.
        /// </summary>
        [JsonProperty("InputAnalysisSettings")]
        public InputAnalysisInfo InputAnalysisSettings{ get; set; }

        /// <summary>
        /// Console tag list
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// chart template
        /// </summary>
        [JsonProperty("FrameCaptureTemplates")]
        public FrameCaptureTemplate[] FrameCaptureTemplates{ get; set; }

        /// <summary>
        /// Common configuration.
        /// </summary>
        [JsonProperty("GeneralSettings")]
        public GeneralSetting GeneralSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "AttachedInputs.", this.AttachedInputs);
            this.SetParamArrayObj(map, prefix + "OutputGroups.", this.OutputGroups);
            this.SetParamArrayObj(map, prefix + "AudioTemplates.", this.AudioTemplates);
            this.SetParamArrayObj(map, prefix + "VideoTemplates.", this.VideoTemplates);
            this.SetParamArrayObj(map, prefix + "AVTemplates.", this.AVTemplates);
            this.SetParamArrayObj(map, prefix + "CaptionTemplates.", this.CaptionTemplates);
            this.SetParamObj(map, prefix + "PlanSettings.", this.PlanSettings);
            this.SetParamObj(map, prefix + "EventNotifySettings.", this.EventNotifySettings);
            this.SetParamObj(map, prefix + "InputLossBehavior.", this.InputLossBehavior);
            this.SetParamObj(map, prefix + "PipelineInputSettings.", this.PipelineInputSettings);
            this.SetParamObj(map, prefix + "InputAnalysisSettings.", this.InputAnalysisSettings);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "FrameCaptureTemplates.", this.FrameCaptureTemplates);
            this.SetParamObj(map, prefix + "GeneralSettings.", this.GeneralSettings);
        }
    }
}

