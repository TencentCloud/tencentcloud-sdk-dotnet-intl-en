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

namespace TencentCloud.Car.V20220110.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationProjectRequest : AbstractModel
    {
        
        /// <summary>
        /// Project ID returned by cloud.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// Project name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Concurrency type required for project operation.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Whether to Enable Pre-launch.
        /// </summary>
        [JsonProperty("IsPreload")]
        public bool? IsPreload{ get; set; }

        /// <summary>
        /// Application startup parameters.
        /// </summary>
        [JsonProperty("ApplicationParams")]
        public string ApplicationParams{ get; set; }

        /// <summary>
        /// Cloud application project description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Resolution, in the format of widthxheight, such as 1920x1080.
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Frame rate.
        /// </summary>
        [JsonProperty("FPS")]
        public long? FPS{ get; set; }

        /// <summary>
        /// Waiting time for application pre-launch.
        /// </summary>
        [JsonProperty("PreloadDuration")]
        public string PreloadDuration{ get; set; }

        /// <summary>
        /// Waiting time for reconnection.
        /// </summary>
        [JsonProperty("ReconnectTimeout")]
        public string ReconnectTimeout{ get; set; }

        /// <summary>
        /// Minimum bitrate, in Mbps.
        /// </summary>
        [JsonProperty("MinBitrate")]
        public long? MinBitrate{ get; set; }

        /// <summary>
        /// Maximum bitrate, in Mbps.
        /// </summary>
        [JsonProperty("MaxBitrate")]
        public long? MaxBitrate{ get; set; }

        /// <summary>
        /// Upstream audio options.DisableMixIntoStreamPush: not mixing upstream audio in streaming.
        /// </summary>
        [JsonProperty("UpstreamAudioOption")]
        public string UpstreamAudioOption{ get; set; }

        /// <summary>
        /// Video encoding configuration.
        /// </summary>
        [JsonProperty("VideoEncodeConfig")]
        public VideoEncodeConfig VideoEncodeConfig{ get; set; }

        /// <summary>
        /// Upper limit of the XR application resolution.If the project concurrency type is L or L2, the upper limit is 5000; if the project concurrency type is XL2, the upper limit is 6000.
        /// </summary>
        [JsonProperty("XRMaxWidth")]
        public ulong? XRMaxWidth{ get; set; }

        /// <summary>
        /// ID of the background image COS file.
        /// </summary>
        [JsonProperty("BackgroundImageCOSFileId")]
        public string BackgroundImageCOSFileId{ get; set; }

        /// <summary>
        /// Disabled code list.
        /// </summary>
        [JsonProperty("DisableVideoCodecs")]
        public string[] DisableVideoCodecs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsPreload", this.IsPreload);
            this.SetParamSimple(map, prefix + "ApplicationParams", this.ApplicationParams);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "FPS", this.FPS);
            this.SetParamSimple(map, prefix + "PreloadDuration", this.PreloadDuration);
            this.SetParamSimple(map, prefix + "ReconnectTimeout", this.ReconnectTimeout);
            this.SetParamSimple(map, prefix + "MinBitrate", this.MinBitrate);
            this.SetParamSimple(map, prefix + "MaxBitrate", this.MaxBitrate);
            this.SetParamSimple(map, prefix + "UpstreamAudioOption", this.UpstreamAudioOption);
            this.SetParamObj(map, prefix + "VideoEncodeConfig.", this.VideoEncodeConfig);
            this.SetParamSimple(map, prefix + "XRMaxWidth", this.XRMaxWidth);
            this.SetParamSimple(map, prefix + "BackgroundImageCOSFileId", this.BackgroundImageCOSFileId);
            this.SetParamArraySimple(map, prefix + "DisableVideoCodecs.", this.DisableVideoCodecs);
        }
    }
}

