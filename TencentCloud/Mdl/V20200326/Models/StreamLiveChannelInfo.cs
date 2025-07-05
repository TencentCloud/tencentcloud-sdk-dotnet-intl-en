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

    public class StreamLiveChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// Channel ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Channel status
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// Information of attached inputs
        /// </summary>
        [JsonProperty("AttachedInputs")]
        public AttachedInput[] AttachedInputs{ get; set; }

        /// <summary>
        /// Information of output groups
        /// </summary>
        [JsonProperty("OutputGroups")]
        public StreamLiveOutputGroupsInfo[] OutputGroups{ get; set; }

        /// <summary>
        /// Channel name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Audio transcoding templates
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AudioTemplates")]
        public AudioTemplateInfo[] AudioTemplates{ get; set; }

        /// <summary>
        /// Video transcoding templates
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("VideoTemplates")]
        public VideoTemplateInfo[] VideoTemplates{ get; set; }

        /// <summary>
        /// Audio/Video transcoding templates
        /// Note: this field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AVTemplates")]
        public AVTemplate[] AVTemplates{ get; set; }

        /// <summary>
        /// Caption templates.
        /// </summary>
        [JsonProperty("CaptionTemplates")]
        public SubtitleConf[] CaptionTemplates{ get; set; }

        /// <summary>
        /// Event settings
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PlanSettings")]
        public PlanSettings PlanSettings{ get; set; }

        /// <summary>
        /// The callback settings.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("EventNotifySettings")]
        public EventNotifySetting EventNotifySettings{ get; set; }

        /// <summary>
        /// Supplement the last video frame configuration settings.
        /// </summary>
        [JsonProperty("InputLossBehavior")]
        public InputLossBehaviorInfo InputLossBehavior{ get; set; }

        /// <summary>
        /// Pipeline configuration.
        /// </summary>
        [JsonProperty("PipelineInputSettings")]
        public PipelineInputSettingsInfo PipelineInputSettings{ get; set; }

        /// <summary>
        /// Recognition configuration for input content.
        /// </summary>
        [JsonProperty("InputAnalysisSettings")]
        public InputAnalysisInfo InputAnalysisSettings{ get; set; }

        /// <summary>
        /// Console tag list.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Frame capture templates.
        /// </summary>
        [JsonProperty("FrameCaptureTemplates")]
        public FrameCaptureTemplate[] FrameCaptureTemplates{ get; set; }

        /// <summary>
        /// General settings.
        /// </summary>
        [JsonProperty("GeneralSettings")]
        public GeneralSetting GeneralSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "AttachedInputs.", this.AttachedInputs);
            this.SetParamArrayObj(map, prefix + "OutputGroups.", this.OutputGroups);
            this.SetParamSimple(map, prefix + "Name", this.Name);
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

